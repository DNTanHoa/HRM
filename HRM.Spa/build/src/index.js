import * as React from "react";
import * as ReactDOM from "react-dom";

import "core-js/fn/array/find-index";
import "core-js/fn/array/find"

import { App } from "app-player-react";
import { patchAppConfig } from "xaf-app-module";

import modules from "./modules";
import * as serviceWorker from './serviceWorker';

import * as urlJson from './url.json';

// Uncomment and grab value for update app-configs.json
//import * as mainDemo from "./configs/app";
//var mainDemoJson = JSON.stringify(mainDemo.mainDemoConfigs);

function appConfigSource(device) {
    let host = window.location.origin;
    let applicationUrl = urlJson.applicationUrl

    let publicUrl = process.env.PUBLIC_URL;
    if (publicUrl) {
        host = publicUrl;
    }

    if (!process.env.NODE_ENV || process.env.NODE_ENV === 'development') {
        host = applicationUrl.substring(0, applicationUrl.length - 1);
    }

    let appConfigUrl = host + "/metadata/appconfig?url=" + host + "&device=" + device;
    if(window.location.search){
        appConfigUrl += '&' + window.location.search.substring(1, window.location.search.length);
    }
    return fetch(appConfigUrl).then((response) => {
        return new Promise((resolve, reject) => {
            response.json().then((result) => {
                resolve(result); 
            })
	    .catch(() => {
                reject(response.statusText);
            });
	});
   }).then((appConfig) => {
        let result = undefined;
        let errorMessage = appConfig.Message;
        if(errorMessage !== undefined) {
           throw new Error(errorMessage);
        } else {
            result = patchAppConfig(device, appConfig[device], host + '/');
        }
        return result;
    }).catch((errorMessage) => {
        throw new Error(errorMessage);
    });
}

ReactDOM.render(
    <App appConfigSource={appConfigSource} modules={modules} onLoaded={window.completeProgress} />,
    document.getElementById("root")
);
// If you want your app to work offline and load faster, you can change

// unregister() to register() below. Note this comes with some pitfalls.

// Learn more about service workers: https://bit.ly/CRA-PWA

serviceWorker.unregister(); 

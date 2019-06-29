using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Spa;
using DevExpress.ExpressApp.Spa.AspNetCore;
using DevExpress.ExpressApp.Spa.AspNetCore.Mvc;
using DevExpress.Persistent.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace HRM.Spa {
    public class Startup {
        public Startup(IConfiguration configuration) {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
		    services.AddXaf<HRMSpaApplication>();
			services.AddSingleton<XpoDataStoreProviderService>();
            services.AddResponseCompression();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseDetailedExceptionHandler(options => {
                options.ShowUserFriendlyExceptionsOnly = !env.IsDevelopment();
            });
            app.UseDefaultFiles();
            app.UseResponseCompression();
            app.UseStaticFiles();

            app.UseXaf();
        }
    }
}

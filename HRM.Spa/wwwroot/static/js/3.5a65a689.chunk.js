(window.webpackJsonp=window.webpackJsonp||[]).push([[3],{523:function(t,e,i){"use strict";var n=i(5),o=i(615),s=i(12),a=i(57),r=i(38),p=i(11),l=i(24),u=i(73).focused,c=i(8).each,h=i(4).isDefined,d=i(6).extend,_=i(24).getPublicElement,f=i(47),m=i(192),g=i(292).getDefaultAlignment,y=i(616).default,v=i(71),b=i(20),S=i(291),C=i(53),w=i(197),O=i(286),D=S.inherit({_supportedKeys:function(){var t=function(t){return!!this.option("opened")&&(t.preventDefault(),!0)};return d({},this.callBase(),{tab:function(t){if(this.option("opened"))if("instantly"!==this.option("applyValueMode")){var e=t.shiftKey?this._getLastPopupElement():this._getFirstPopupElement();e&&s.trigger(e,"focus"),t.preventDefault()}else this.close()},escape:function(t){this.option("opened")&&t.preventDefault(),this.close()},upArrow:function(t){return t.preventDefault(),t.stopPropagation(),!t.altKey||(this.close(),!1)},downArrow:function(t){return t.preventDefault(),t.stopPropagation(),!t.altKey||(this._validatedOpening(),!1)},enter:function(t){return this.option("opened")&&(t.preventDefault(),this._valueChangeEventHandler(t)),!0},home:t,end:t})},_getDefaultButtons:function(){return this.callBase().concat([{name:"dropDown",Ctor:y}])},_getDefaultOptions:function(){return d(this.callBase(),{value:null,onOpened:null,onClosed:null,opened:!1,acceptCustomValue:!0,applyValueMode:"instantly",deferRendering:!0,activeStateEnabled:!0,dropDownButtonTemplate:"dropDownButton",fieldTemplate:null,contentTemplate:null,openOnFieldClick:!1,showDropDownButton:!0,buttons:void 0,dropDownOptions:{},popupPosition:this._getDefaultPopupPosition(),onPopupInitialized:null,applyButtonText:v.format("OK"),cancelButtonText:v.format("Cancel"),buttonsLocation:"default",showPopupTitle:!1})},_getDefaultPopupPosition:function(){var t=g(this.option("rtlEnabled"));return{offset:{h:0,v:-1},my:t+" top",at:t+" bottom",collision:"flip flip"}},_defaultOptionsRules:function(){return this.callBase().concat([{device:function(t){return"generic"===t.platform},options:{popupPosition:{offset:{v:0}}}}])},_inputWrapper:function(){return this.$element().find(".dx-dropdowneditor-input-wrapper")},_init:function(){this.callBase(),this._initVisibilityActions(),this._initPopupInitializedAction(),this._initInnerOptionCache("dropDownOptions")},_initVisibilityActions:function(){this._openAction=this._createActionByOption("onOpened",{excludeValidators:["disabled","readOnly"]}),this._closeAction=this._createActionByOption("onClosed",{excludeValidators:["disabled","readOnly"]})},_initPopupInitializedAction:function(){this._popupInitializedAction=this._createActionByOption("onPopupInitialized",{excludeValidators:["disabled","readOnly"]})},_initMarkup:function(){this.callBase(),this.$element().addClass("dx-dropdowneditor"),this.setAria("role","combobox")},_render:function(){this.callBase(),this._renderOpenHandler(),this._renderOpenedState()},_renderContentImpl:function(){this.option("deferRendering")||this._createPopup()},_renderInput:function(){this.callBase(),this.$element().wrapInner(n("<div>").addClass("dx-dropdowneditor-input-wrapper")),this._$container=this.$element().children().eq(0),this.setAria({haspopup:"true",autocomplete:"list"})},_readOnlyPropValue:function(){return!this.option("acceptCustomValue")||this.callBase()},_cleanFocusState:function(){this.callBase(),this.option("fieldTemplate")&&s.off(this._input(),"focusin focusout beforeactivate")},_getFieldTemplate:function(){return this.option("fieldTemplate")&&this._getTemplateByOption("fieldTemplate")},_renderField:function(){var t=this._getFieldTemplate();t&&this._renderTemplatedField(t,this._fieldRenderData())},_renderPlaceholder:function(){!!this._getFieldTemplate()||this.callBase()},_renderValue:function(){this.callBase().always(this._renderField.bind(this))},_renderTemplatedField:function(t,e){var i=this,o=u(this._input()),a=this._$container;this._disposeKeyboardProcessor();var r=this._$beforeButtonsContainer&&this._$beforeButtonsContainer[0].parentNode,p=this._$afterButtonsContainer&&this._$afterButtonsContainer[0].parentNode;r&&r.removeChild(this._$beforeButtonsContainer[0]),p&&p.removeChild(this._$afterButtonsContainer[0]),a.empty();var c=n("<div>").addClass("dx-dropdowneditor-field-template-wrapper").appendTo(a);t.render({model:e,container:l.getPublicElement(c),onRendered:function(){if(!i._input().length)throw f.Error("E1010");i._refreshEvents(),i._refreshValueChangeEvent(),i._renderFocusState(),o&&s.trigger(i._input(),"focus")}}),a.prepend(this._$beforeButtonsContainer),a.append(this._$afterButtonsContainer)},_fieldRenderData:function(){return this.option("value")},_initTemplates:function(){this.callBase(),this._defaultTemplates.dropDownButton=new w(function(t){var e=n("<div>").addClass("dx-dropdowneditor-icon");n(t.container).append(e)},this)},_renderOpenHandler:function(){var t=this._inputWrapper(),e=b.addNamespace(C.name,this.NAME),i=this.option("openOnFieldClick");s.off(t,e),s.on(t,e,this._getInputClickHandler(i)),this.$element().toggleClass("dx-dropdowneditor-field-clickable",i),i&&(this._openOnFieldClickAction=this._createAction(this._openHandler.bind(this)))},_getInputClickHandler:function(t){var e=this;return t?function(t){e._executeOpenAction(t)}:function(t){e._focusInput()}},_openHandler:function(){this._toggleOpenState()},_executeOpenAction:function(t){this._openOnFieldClickAction({event:t})},_keyboardEventBindingTarget:function(){return this._input()},_focusInput:function(){return!this.option("disabled")&&(this.option("focusStateEnabled")&&!u(this._input())&&s.trigger(this._input(),"focus"),!0)},_toggleOpenState:function(t){this._focusInput()&&(this.option("readOnly")||(t=arguments.length?t:!this.option("opened"),this.option("opened",t)))},_renderOpenedState:function(){var t=this.option("opened");t&&this._createPopup(),this.$element().toggleClass("dx-dropdowneditor-active",t),this._setPopupOption("visible",t),this.setAria({expanded:t,owns:t?this._popupContentId:void 0})},_createPopup:function(){this._$popup||(this._$popup=n("<div>").addClass("dx-dropdowneditor-overlay").addClass(this.option("customOverlayCssClass")).appendTo(this.$element()),this._renderPopup(),this._renderPopupContent())},_renderPopup:function(){this._popup=this._createComponent(this._$popup,O,d(this._popupConfig(),this._getInnerOptionsCache("dropDownOptions"))),this._popup.on({showing:this._popupShowingHandler.bind(this),shown:this._popupShownHandler.bind(this),hiding:this._popupHidingHandler.bind(this),hidden:this._popupHiddenHandler.bind(this)}),this._popup.option("onContentReady",this._contentReadyHandler.bind(this)),this._contentReadyHandler(),this._popupContentId="dx-"+new a,this.setAria("id",this._popupContentId,this._popup.$content()),this._bindInnerWidgetOptions(this._popup,"dropDownOptions")},_contentReadyHandler:p.noop,_popupConfig:function(){return{onInitialized:this._popupInitializedHandler(),position:d(this.option("popupPosition"),{of:this.$element()}),showTitle:this.option("showPopupTitle"),width:"auto",height:"auto",shading:!1,closeOnTargetScroll:!0,closeOnOutsideClick:this._closeOutsideDropDownHandler.bind(this),animation:{show:{type:"fade",duration:0,from:0,to:1},hide:{type:"fade",duration:400,from:1,to:0}},deferRendering:!1,focusStateEnabled:!1,showCloseButton:!1,toolbarItems:this._getPopupToolbarItems(),onPositioned:this._popupPositionedHandler.bind(this),fullScreen:!1}},_popupInitializedHandler:function(){if(this.option("onPopupInitialized"))return function(t){this._popupInitializedAction({popup:t.component})}.bind(this)},_popupPositionedHandler:function(t){t.position&&this._popup.overlayContent().toggleClass("dx-dropdowneditor-overlay-flipped",t.position.v.flip)},_popupShowingHandler:p.noop,_popupHidingHandler:function(){this.option("opened",!1)},_popupShownHandler:function(){this._openAction(),this._$validationMessage&&this._$validationMessage.dxOverlay("option","position",this._getValidationMessagePosition())},_popupHiddenHandler:function(){this._closeAction(),this._$validationMessage&&this._$validationMessage.dxOverlay("option","position",this._getValidationMessagePosition())},_getValidationMessagePosition:function(){var t="below";if(this._popup&&this._popup.option("visible")){var e=m.setup(this.$element()).top,i=m.setup(this._popup.$content()).top;t=e+this.option("popupPosition").offset.v>i?"below":"above"}return this.callBase(t)},_renderPopupContent:function(){var t=this._getTemplateByOption("contentTemplate");if(t&&this.option("contentTemplate")){var e=this._popup.$content(),i={value:this._fieldRenderData(),component:this};e.empty(),t.render({container:l.getPublicElement(e),model:i})}},_closeOutsideDropDownHandler:function(t){var e=t.target,i=n(e),o=this.getButton("dropDown"),s=o&&o.$element(),a=!!i.closest(this.$element()).length,r=!!i.closest(s).length;return!a&&!r},_clean:function(){delete this._openOnFieldClickAction,this._$popup&&(this._$popup.remove(),delete this._$popup,delete this._popup),this.callBase()},_setPopupOption:function(t,e){this._setWidgetOption("_popup",arguments)},_validatedOpening:function(){this.option("readOnly")||this._toggleOpenState(!0)},_getPopupToolbarItems:function(){return"useButtons"===this.option("applyValueMode")?this._popupToolbarItemsConfig():[]},_getFirstPopupElement:function(){return this._popup._wrapper().find(".dx-popup-done.dx-button")},_getLastPopupElement:function(){return this._popup._wrapper().find(".dx-popup-cancel.dx-button")},_popupElementTabHandler:function(t){var e=n(t.currentTarget);(t.shiftKey&&e.is(this._getFirstPopupElement())||!t.shiftKey&&e.is(this._getLastPopupElement()))&&(s.trigger(this._input(),"focus"),t.preventDefault())},_popupElementEscHandler:function(){s.trigger(this._input(),"focus"),this.close()},_popupButtonInitializedHandler:function(t){t.component.registerKeyHandler("tab",this._popupElementTabHandler.bind(this)),t.component.registerKeyHandler("escape",this._popupElementEscHandler.bind(this))},_popupToolbarItemsConfig:function(){var t=[{shortcut:"done",options:{onClick:this._applyButtonHandler.bind(this),text:this.option("applyButtonText"),onInitialized:this._popupButtonInitializedHandler.bind(this)}},{shortcut:"cancel",options:{onClick:this._cancelButtonHandler.bind(this),text:this.option("cancelButtonText"),onInitialized:this._popupButtonInitializedHandler.bind(this)}}];return this._applyButtonsLocation(t)},_applyButtonsLocation:function(t){var e=this.option("buttonsLocation"),i=t;if("default"!==e){var n=p.splitPair(e);c(i,function(t,e){d(e,{toolbar:n[0],location:n[1]})})}return i},_applyButtonHandler:function(){this.close(),this.option("focusStateEnabled")&&this.focus()},_cancelButtonHandler:function(){this.close(),this.option("focusStateEnabled")&&this.focus()},_updatePopupWidth:p.noop,_popupOptionChanged:function(t){var e=this._getOptionsFromContainer(t);this._setPopupOption(e),-1!==Object.keys(e).indexOf("width")&&void 0===e.width&&this._updatePopupWidth()},_optionChanged:function(t){switch(t.name){case"opened":this._renderOpenedState();break;case"onOpened":case"onClosed":this._initVisibilityActions();break;case"onPopupInitialized":this._initPopupInitializedAction();break;case"fieldTemplate":h(t.value)?this._renderField():this._invalidate();break;case"contentTemplate":case"acceptCustomValue":case"openOnFieldClick":this._invalidate();break;case"dropDownButtonTemplate":case"showDropDownButton":this._updateButtons(["dropDown"]);break;case"dropDownOptions":this._popupOptionChanged(t),this._cacheInnerOptions("dropDownOptions",t.value);break;case"popupPosition":case"deferRendering":break;case"applyValueMode":case"applyButtonText":case"cancelButtonText":case"buttonsLocation":this._setPopupOption("toolbarItems",this._getPopupToolbarItems());break;case"showPopupTitle":this._setPopupOption("showTitle",t.value);break;default:this.callBase(t)}},open:function(){this.option("opened",!0)},close:function(){this.option("opened",!1)},field:function(){return _(this._input())},content:function(){return this._popup?this._popup.content():null}}).include(o);r("dxDropDownEditor",D),t.exports=D,t.exports.default=t.exports},555:function(t,e,i){"use strict";var n="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},o=i(5),s=i(14).getWindow(),a=i(12),r=i(57),p=i(38),l=i(11),u=i(4),c=i(6).extend,h=i(23).inArray,d=i(523),_=i(489),f=i(47),m=i(20),g=i(22),y=i(617),v=i(71),b=i(293),S=i(18).Deferred,C=i(657).default,w=["startswith","contains","endwith","notcontains"],O=d.inherit({_supportedKeys:function(){var t=this.callBase();return c({},t,{tab:function(e){if(this._allowSelectItemByTab()){this._saveValueChangeEvent(e);var i=o(this._list.option("focusedElement"));i.length&&this._setSelectedElement(i)}t.tab.apply(this,arguments)},space:l.noop,home:l.noop,end:l.noop})},_allowSelectItemByTab:function(){return this.option("opened")&&"instantly"===this.option("applyValueMode")},_setSelectedElement:function(t){var e=this._valueGetter(this._list._getItemData(t));this._setValue(e)},_setValue:function(t){this.option("value",t)},_getDefaultOptions:function(){return c(this.callBase(),c(y._dataExpressionDefaultOptions(),{displayValue:void 0,searchEnabled:!1,searchMode:"contains",searchTimeout:500,minSearchLength:0,searchExpr:null,valueChangeEvent:"input change keyup",selectedItem:null,noDataText:v.format("dxCollectionWidget-noDataText"),onSelectionChanged:null,onItemClick:l.noop,showDataBeforeSearch:!1,grouped:!1,groupTemplate:"group",popupPosition:{my:"left top",at:"left bottom",offset:{h:0,v:0},collision:"flip"},popupWidthExtension:0}))},_defaultOptionsRules:function(){return this.callBase().concat([{device:function(t){return"win"===t.platform&&t.version&&8===t.version[0]},options:{popupPosition:{offset:{v:-6}}}},{device:{platform:"ios"},options:{popupPosition:{offset:{v:-1}}}},{device:{platform:"generic"},options:{buttonsLocation:"bottom center"}}])},_setOptionsByReference:function(){this.callBase(),c(this._optionsByReference,{value:!0,selectedItem:!0,displayValue:!0})},_init:function(){this.callBase(),this._initDataExpressions(),this._initActions(),this._setListDataSource(),this._validateSearchMode(),this._clearSelectedItem(),this._initItems()},_initItems:function(){var t=this.option().items;t&&!t.length&&this._dataSource&&(this.option().items=this._dataSource.items())},_initActions:function(){this._initContentReadyAction(),this._initSelectionChangedAction(),this._initItemClickAction()},_initContentReadyAction:function(){this._contentReadyAction=this._createActionByOption("onContentReady",{excludeValidators:["disabled","readOnly"]})},_initSelectionChangedAction:function(){this._selectionChangedAction=this._createActionByOption("onSelectionChanged",{excludeValidators:["disabled","readOnly"]})},_initItemClickAction:function(){this._itemClickAction=this._createActionByOption("onItemClick")},_initTemplates:function(){this.callBase(),this._defaultTemplates.item=new b("item",this)},_saveFocusOnWidget:function(t){this._list&&this._list.initialOption("focusStateEnabled")&&this._focusInput()},_createPopup:function(){this.callBase(),this._popup._wrapper().addClass(this._popupWrapperClass());var t=this._popup.$content();a.off(t,"mouseup"),a.on(t,"mouseup",this._saveFocusOnWidget.bind(this))},_popupWrapperClass:function(){return"dx-dropdownlist-popup-wrapper"},_renderInputValue:function(){var t=this._getCurrentValue();return this._loadInputValue(t,this._setSelectedItem.bind(this)).always(this.callBase.bind(this,t))},_loadInputValue:function(t,e){return this._loadItem(t).always(e)},_loadItem:function(t,e){var i,o;return e&&"object"!==("undefined"===typeof t?"undefined":n(t))&&(e.itemByValue||(e.itemByValue={},(i=this._getPlainItems()).forEach(function(t){e.itemByValue[this._valueGetter(t)]=t},this)),o=e.itemByValue[t]),o||(i=this._getPlainItems(),o=l.grep(i,function(e){return this._isValueEquals(this._valueGetter(e),t)}.bind(this))[0]),void 0!==o?(new S).resolve(o).promise():this._loadValue(t)},_getPlainItems:function(t){var e=[];t=t||this.option("items")||[];for(var i=0;i<t.length;i++)t[i]&&t[i].items?e=e.concat(t[i].items):e.push(t[i]);return e},_setSelectedItem:function(t){var e=this._displayValue(t);this.option("selectedItem",l.ensureDefined(t,null)),this.option("displayValue",e)},_displayValue:function(t){return this._displayGetter(t)},_refreshSelected:function(){var t={};this._listItemElements().each(function(e,i){var n=o(i),s=this._valueGetter(n.data("dxListItemData"));this._isSelectedValue(s,t)?this._list.selectItem(n):this._list.unselectItem(n)}.bind(this))},_popupShownHandler:function(){this.callBase(),this._setFocusPolicy()},_setFocusPolicy:function(){this.option("focusStateEnabled")&&this._list&&this._list.option("focusedElement",null)},_isSelectedValue:function(t){return this._isValueEquals(t,this.option("value"))},_validateSearchMode:function(){var t=this.option("searchMode"),e=t.toLowerCase();if(h(e,w)<0)throw f.Error("E1019",t)},_clearSelectedItem:function(){this.option("selectedItem",null)},_processDataSourceChanging:function(){this._setListDataSource(),this._renderInputValue().fail(function(){this._isCustomValueAllowed()||this._clearSelectedItem()}.bind(this))},_isCustomValueAllowed:function(){return this.option("displayCustomValue")},reset:function(){this.callBase(),this._clearFilter(),this._clearSelectedItem()},_listItemElements:function(){return this._$list?this._$list.find(".dx-list-item"):o()},_popupConfig:function(){var t=this;return c(this.callBase(),{templatesRenderAsynchronously:!1,width:this.option("width"),onShowing:function(){t.$element().addClass("dx-skip-gesture-event")},onHidden:function(){t.$element().removeClass("dx-skip-gesture-event")},height:"auto",autoResizeEnabled:!1,maxHeight:this._getMaxHeight.bind(this)})},_renderPopupContent:function(){this._renderList()},_attachChildKeyboardEvents:function(){this._childKeyboardProcessor=this._keyboardProcessor.attachChildProcessor(),this._setListOption("_keyboardProcessor",this._childKeyboardProcessor)},_fireContentReadyAction:l.noop,_setAriaTargetForList:function(){this._list._getAriaTarget=this._getAriaTarget.bind(this),this._list.setAria("role","combobox")},_renderList:function(){this._listId="dx-"+(new r)._value;var t=this._$list=o("<div>").attr("id",this._listId).appendTo(this._popup.$content());this._list=this._createComponent(t,_,this._listConfig()),this._refreshList(),this._setAriaTargetForList(),this._renderPreventBlur(this._$list)},_renderPreventBlur:function(t){var e=m.addNamespace("mousedown","dxDropDownList");a.off(t,e),a.on(t,e,function(t){t.preventDefault()}.bind(this))},_renderOpenedState:function(){this.callBase();var t=this.option("opened")||void 0;this.setAria({activedescendant:t&&this._list.getFocusedItemId(),owns:t&&this._listId})},_refreshList:function(){this._list&&this._shouldRefreshDataSource()&&this._setListDataSource()},_shouldRefreshDataSource:function(){return!!this._list.option("dataSource")!==this._needPassDataSourceToList()},_isDesktopDevice:function(){return"desktop"===g.real().deviceType},_listConfig:function(){return{selectionMode:"single",_templates:this.option("_templates"),templateProvider:this.option("templateProvider"),noDataText:this.option("noDataText"),grouped:this.option("grouped"),onContentReady:this._listContentReadyHandler.bind(this),itemTemplate:this.option("itemTemplate"),indicateLoading:!1,keyExpr:this._getCollectionKeyExpr(),displayExpr:this._displayGetterExpr(),groupTemplate:this.option("groupTemplate"),tabIndex:null,onItemClick:this._listItemClickAction.bind(this),dataSource:this._getDataSource(),_keyboardProcessor:this._childKeyboardProcessor,hoverStateEnabled:!!this._isDesktopDevice()&&this.option("hoverStateEnabled"),focusStateEnabled:!!this._isDesktopDevice()&&this.option("focusStateEnabled")}},_getDataSource:function(){return this._needPassDataSourceToList()?this._dataSource:null},_dataSourceOptions:function(){return{paginate:!1}},_getGroupedOption:function(){return this.option("grouped")},_dataSourceFromUrlLoadMode:function(){return"raw"},_listContentReadyHandler:function(){this._list=this._list||this._$list.dxList("instance"),this.option("deferRendering")||this._refreshSelected(),this._dimensionChanged(),this._contentReadyAction()},_setListOption:function(t,e){this._setWidgetOption("_list",arguments)},_listItemClickAction:function(t){this._listItemClickHandler(t),this._itemClickAction(t)},_listItemClickHandler:l.noop,_setListDataSource:function(){this._list&&(this._setListOption("dataSource",this._getDataSource()),this._needPassDataSourceToList()||this._setListOption("items",[]))},_needPassDataSourceToList:function(){return this.option("showDataBeforeSearch")||this._isMinSearchLengthExceeded()},_isMinSearchLengthExceeded:function(){return this._searchValue().toString().length>=this.option("minSearchLength")},_searchValue:function(){return this._input().val()||""},_getSearchEvent:function(){return m.addNamespace("input",this.NAME+"Search")},_getSetFocusPolicyEvent:function(){return m.addNamespace("input",this.NAME+"FocusPolicy")},_renderEvents:function(){this.callBase(),a.on(this._input(),this._getSetFocusPolicyEvent(),this._setFocusPolicy.bind(this)),this._shouldRenderSearchEvent()&&a.on(this._input(),this._getSearchEvent(),this._searchHandler.bind(this))},_shouldRenderSearchEvent:function(){return this.option("searchEnabled")},_refreshEvents:function(){a.off(this._input(),this._getSearchEvent()),a.off(this._input(),this._getSetFocusPolicyEvent()),this.callBase()},_searchHandler:function(){if(this._isMinSearchLengthExceeded()){var t=this.option("searchTimeout");t?(this._clearSearchTimer(),this._searchTimer=setTimeout(this._searchDataSource.bind(this),t)):this._searchDataSource()}else this._searchCanceled()},_searchCanceled:function(){this._clearSearchTimer(),this._needPassDataSourceToList()&&this._filterDataSource(null),this._refreshList()},_searchDataSource:function(){this._filterDataSource(this._searchValue())},_filterDataSource:function(t){this._clearSearchTimer();var e=this._dataSource;return e.searchExpr(this.option("searchExpr")||this._displayGetterExpr()),e.searchOperation(this.option("searchMode")),e.searchValue(t),e.load().done(this._dataSourceFiltered.bind(this,t))},_clearFilter:function(){var t=this._dataSource;t&&t.searchValue()&&t.searchValue(null)},_dataSourceFiltered:function(){this._refreshList(),this._refreshPopupVisibility()},_shouldOpenPopup:function(){return this._hasItemsToShow()},_refreshPopupVisibility:function(){if(!this.option("readOnly")&&this._searchValue()){var t=this._shouldOpenPopup();t&&!this._isFocused()||(this.option("opened",t),t&&this._dimensionChanged())}},_dataSourceChangedHandler:function(t){0===this._dataSource.pageIndex()?this.option().items=t:this.option().items=this.option().items.concat(t)},_hasItemsToShow:function(){var t=(this._dataSource&&this._dataSource.items()||[]).length;return!(!this._needPassDataSourceToList()||!t)},_clearSearchTimer:function(){clearTimeout(this._searchTimer),delete this._searchTimer},_popupShowingHandler:function(){this._dimensionChanged()},_dimensionChanged:function(){this._popup&&this._updatePopupDimensions()},_updatePopupDimensions:function(){this._updatePopupWidth(),this._updatePopupHeight()},_updatePopupWidth:function(){this._setPopupOption("width",this.$element().outerWidth()+this.option("popupWidthExtension"))},_needPopupRepaint:function(){if(!this._dataSource)return!1;var t=this._dataSource.pageIndex(),e=u.isDefined(this._pageIndex)&&t<=this._pageIndex;return this._pageIndex=t,e},_updatePopupHeight:function(){this._needPopupRepaint()&&this._popup.repaint(),this._list&&this._list.updateDimensions()},_getMaxHeight:function(){var t=this.$element(),e=t.offset(),i=o(s).height(),n=Math.max(e.top,i-e.top-t.outerHeight());return Math.min(.5*i,n)},_clean:function(){this._list&&delete this._list,this.callBase()},_dispose:function(){this._clearSearchTimer(),this.callBase()},_setCollectionWidgetOption:function(){this._setListOption.apply(this,arguments)},_optionChanged:function(t){switch(this._dataExpressionOptionChanged(t),t.name){case"hoverStateEnabled":case"focusStateEnabled":this._isDesktopDevice()&&this._setListOption(t.name,t.value),this.callBase(t);break;case"items":this.option("dataSource")||this._processDataSourceChanging();break;case"dataSource":this._processDataSourceChanging();break;case"valueExpr":this._renderValue(),this._setListOption("keyExpr",this._getCollectionKeyExpr());break;case"displayExpr":this._renderValue(),this._setListOption("displayExpr",this._displayGetterExpr());break;case"searchMode":this._validateSearchMode();break;case"minSearchLength":this._refreshList();break;case"searchEnabled":case"showDataBeforeSearch":case"searchExpr":this._invalidate();break;case"onContentReady":this._initContentReadyAction();break;case"onSelectionChanged":this._initSelectionChangedAction();break;case"onItemClick":this._initItemClickAction();break;case"grouped":case"groupTemplate":case"noDataText":this._setListOption(t.name);break;case"displayValue":this.option("text",t.value);break;case"itemTemplate":case"searchTimeout":case"popupWidthExtension":break;case"selectedItem":this._selectionChangedAction({selectedItem:t.value});break;default:this.callBase(t)}}}).include(y,C);p("dxDropDownList",O),t.exports=O},615:function(t,e,i){"use strict";t.exports={_waitAsyncTemplates:function(t){if(this._options.templatesRenderAsynchronously){this._asyncTemplatesTimers=this._asyncTemplatesTimers||[];var e=setTimeout(function(){t.call(this),clearTimeout(e)}.bind(this));this._asyncTemplatesTimers.push(e)}else t.call(this)},_cleanAsyncTemplatesTimer:function(){for(var t=this._asyncTemplatesTimers||[],e=0;e<t.length;e++)clearTimeout(t[e]);delete this._asyncTemplatesTimers}}},616:function(t,e,i){"use strict";Object.defineProperty(e,"__esModule",{value:!0});var n=function(){function t(t,e){for(var i=0;i<e.length;i++){var n=e[i];n.enumerable=n.enumerable||!1,n.configurable=!0,"value"in n&&(n.writable=!0),Object.defineProperty(t,n.key,n)}}return function(e,i,n){return i&&t(e.prototype,i),n&&t(e,n),e}}(),o=function t(e,i,n){null===e&&(e=Function.prototype);var o=Object.getOwnPropertyDescriptor(e,i);if(void 0===o){var s=Object.getPrototypeOf(e);return null===s?void 0:t(s,i,n)}if("value"in o)return o.value;var a=o.get;return void 0!==a?a.call(n):void 0},s=l(i(5)),a=l(i(12)),r=l(i(204)),p=l(i(158));function l(t){return t&&t.__esModule?t:{default:t}}var u=function(t){function e(){return function(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}(this,e),function(t,e){if(!t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return!e||"object"!==typeof e&&"function"!==typeof e?t:e}(this,(e.__proto__||Object.getPrototypeOf(e)).apply(this,arguments))}return function(t,e){if("function"!==typeof e&&null!==e)throw new TypeError("Super expression must either be null or a function, not "+typeof e);t.prototype=Object.create(e&&e.prototype,{constructor:{value:t,enumerable:!1,writable:!0,configurable:!0}}),e&&(Object.setPrototypeOf?Object.setPrototypeOf(t,e):t.__proto__=e)}(e,r.default),n(e,[{key:"_attachEvents",value:function(t){var e=this.editor;t.option("onClick",function(t){!e.option("openOnFieldClick")&&e._openHandler(t)}),a.default.on(t.$element(),"mousedown",function(t){t.preventDefault()})}},{key:"_create",value:function(){var t=this.editor,e=(0,s.default)("<div>"),i=this._getOptions();this._addToContainer(e);var n=t._createComponent(e,p.default,i);return this._legacyRender(t.$element(),e,i.visible),{$element:e,instance:n}}},{key:"_getOptions",value:function(){var t=this.editor,e=this._isVisible();return{focusStateEnabled:!1,hoverStateEnabled:!1,activeStateEnabled:!1,useInkRipple:!1,disabled:t.option("readOnly"),visible:e,template:t._getTemplateByOption("dropDownButtonTemplate")}}},{key:"_isVisible",value:function(){var t=this.editor;return o(e.prototype.__proto__||Object.getPrototypeOf(e.prototype),"_isVisible",this).call(this)&&t.option("showDropDownButton")}},{key:"_legacyRender",value:function(t,e,i){t.toggleClass("dx-dropdowneditor-button-visible",i),e&&(e.removeClass("dx-button"),e.addClass("dx-dropdowneditor-button"))}},{key:"update",value:function(){if(o(e.prototype.__proto__||Object.getPrototypeOf(e.prototype),"update",this).call(this)){var t=this.editor,i=this.instance,n=t.$element(),s=this._getOptions();i&&i.option(s),this._legacyRender(n,i&&i.$element(),s.visible)}}}]),e}();e.default=u},617:function(t,e,i){"use strict";var n="function"===typeof Symbol&&"symbol"===typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"===typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},o=i(194),s=i(42),a=i(11),r=i(4),p=i(6).extend,l=i(298),u=i(119),c=i(75),h=i(18).Deferred,d=p({},l,{_dataExpressionDefaultOptions:function(){return{items:[],dataSource:null,itemTemplate:"item",value:null,valueExpr:"this",displayExpr:void 0}},_initDataExpressions:function(){this._compileValueGetter(),this._compileDisplayGetter(),this._initDynamicTemplates(),this._initDataSource(),this._itemsToDataSource()},_itemsToDataSource:function(){this.option("dataSource")||(this._dataSource=new u.DataSource({store:new c(this.option("items")),pageSize:0}))},_compileDisplayGetter:function(){this._displayGetter=s.compileGetter(this._displayGetterExpr())},_displayGetterExpr:function(){return this.option("displayExpr")},_compileValueGetter:function(){this._valueGetter=s.compileGetter(this._valueGetterExpr())},_valueGetterExpr:function(){return this.option("valueExpr")||"this"},_loadValue:function(t){var e=new h;return t=this._unwrappedValue(t),r.isDefined(t)?(this._loadSingle(this._valueGetterExpr(),t).done(function(i){this._isValueEquals(this._valueGetter(i),t)?e.resolve(i):e.reject()}.bind(this)).fail(function(){e.reject()}),e.promise()):e.reject().promise()},_getCurrentValue:function(){return this.option("value")},_unwrappedValue:function(t){return(t=r.isDefined(t)?t:this._getCurrentValue())&&this._dataSource&&"this"===this._valueGetterExpr()&&(t=this._getItemKey(t)),o.unwrap(t)},_getItemKey:function(t){var e=this._dataSource.key();if(Array.isArray(e)){for(var i={},o=0,s=e.length;o<s;o++)i[e[o]]=t[e[o]];return i}return e&&"object"===("undefined"===typeof t?"undefined":n(t))&&(t=t[e]),t},_isValueEquals:function(t,e){var i=this._dataSource&&this._dataSource.key(),n=r.isDefined,o=this._compareValues(t,e);return!o&&i&&n(t)&&n(e)&&(o=Array.isArray(i)?this._compareByCompositeKey(t,e,i):this._compareByKey(t,e,i)),o},_compareByCompositeKey:function(t,e,i){var n=r.isObject;if(!n(t)||!n(e))return!1;for(var o=0,s=i.length;o<s;o++)if(t[i[o]]!==e[i[o]])return!1;return!0},_compareByKey:function(t,e,i){var n=a.ensureDefined,s=o.unwrap,r=n(s(t[i]),t),p=n(s(e[i]),e);return this._compareValues(r,p)},_compareValues:function(t,e){return s.toComparable(t,!0)===s.toComparable(e,!0)},_initDynamicTemplates:a.noop,_setCollectionWidgetItemTemplate:function(){this._initDynamicTemplates(),this._setCollectionWidgetOption("itemTemplate",this.option("itemTemplate"))},_getCollectionKeyExpr:function(){var t=this.option("valueExpr");return r.isString(t)&&"this"!==t||r.isFunction(t)?t:null},_dataExpressionOptionChanged:function(t){switch(t.name){case"items":this._itemsToDataSource(),this._setCollectionWidgetOption("items");break;case"dataSource":this._initDataSource();break;case"itemTemplate":this._setCollectionWidgetItemTemplate();break;case"valueExpr":this._compileValueGetter();break;case"displayExpr":this._compileDisplayGetter(),this._initDynamicTemplates(),this._setCollectionWidgetOption("displayExpr")}}});t.exports=d}}]);
//# sourceMappingURL=3.5a65a689.chunk.js.map
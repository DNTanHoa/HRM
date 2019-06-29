(window.webpackJsonp=window.webpackJsonp||[]).push([[31],{1020:function(e,t,n){"use strict";Object.defineProperty(t,"__esModule",{value:!0}),function(e){for(var n in e)t.hasOwnProperty(n)||(t[n]=e[n])}(n(729));var i=n(729);t.default=i.default},729:function(e,t,n){"use strict";var i=this&&this.__extends||function(){var e=function(t,n){return(e=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(e,t){e.__proto__=t}||function(e,t){for(var n in t)t.hasOwnProperty(n)&&(e[n]=t[n])})(t,n)};return function(t,n){function i(){this.constructor=t}e(t,n),t.prototype=null===n?Object.create(n):(i.prototype=n.prototype,new i)}}();Object.defineProperty(t,"__esModule",{value:!0});var o=n(995),s=n(3),p=function(e){function t(){var t=null!==e&&e.apply(this,arguments)||this;return t._WidgetClass=o.default,t._defaults={defaultValue:"value"},t}return i(t,e),Object.defineProperty(t.prototype,"instance",{get:function(){return this._instance},enumerable:!0,configurable:!0}),t}(n(98).Component);t.TextArea=p,p.propTypes={accessKey:s.PropTypes.string,activeStateEnabled:s.PropTypes.bool,autoResizeEnabled:s.PropTypes.bool,disabled:s.PropTypes.bool,elementAttr:s.PropTypes.object,focusStateEnabled:s.PropTypes.bool,height:s.PropTypes.oneOfType([s.PropTypes.func,s.PropTypes.number,s.PropTypes.string]),hint:s.PropTypes.string,hoverStateEnabled:s.PropTypes.bool,inputAttr:s.PropTypes.object,isValid:s.PropTypes.bool,maxHeight:s.PropTypes.oneOfType([s.PropTypes.number,s.PropTypes.string]),maxLength:s.PropTypes.oneOfType([s.PropTypes.number,s.PropTypes.string]),minHeight:s.PropTypes.oneOfType([s.PropTypes.number,s.PropTypes.string]),name:s.PropTypes.string,onChange:s.PropTypes.func,onContentReady:s.PropTypes.func,onCopy:s.PropTypes.func,onCut:s.PropTypes.func,onDisposing:s.PropTypes.func,onEnterKey:s.PropTypes.func,onFocusIn:s.PropTypes.func,onFocusOut:s.PropTypes.func,onInitialized:s.PropTypes.func,onInput:s.PropTypes.func,onKeyDown:s.PropTypes.func,onKeyPress:s.PropTypes.func,onKeyUp:s.PropTypes.func,onOptionChanged:s.PropTypes.func,onPaste:s.PropTypes.func,onValueChanged:s.PropTypes.func,placeholder:s.PropTypes.string,readOnly:s.PropTypes.bool,rtlEnabled:s.PropTypes.bool,spellcheck:s.PropTypes.bool,stylingMode:s.PropTypes.oneOf(["outlined","underlined","filled"]),tabIndex:s.PropTypes.number,text:s.PropTypes.string,validationError:s.PropTypes.object,validationMessageMode:s.PropTypes.oneOf(["always","auto"]),value:s.PropTypes.string,valueChangeEvent:s.PropTypes.string,visible:s.PropTypes.bool,width:s.PropTypes.oneOfType([s.PropTypes.func,s.PropTypes.number,s.PropTypes.string])},t.default=p},995:function(e,t,n){"use strict";var i=n(5),o=n(12),s=n(11).noop,p=n(38),r=n(6).extend,a=n(20),u=n(45),h=n(291),l=h.inherit({_getDefaultOptions:function(){return r(this.callBase(),{spellcheck:!0,minHeight:void 0,maxHeight:void 0,autoResizeEnabled:!1})},_initMarkup:function(){this.$element().addClass("dx-textarea"),this.callBase(),this.setAria("multiline","true")},_renderContentImpl:function(){this._updateInputHeight(),this.callBase()},_renderInput:function(){this.callBase(),this._renderScrollHandler()},_createInput:function(){var e=i("<textarea>");return this._applyInputAttributes(e,this.option("inputAttr")),this._updateInputAutoResizeAppearance(e),e},_applyInputAttributes:function(e,t){e.attr(t).addClass("dx-texteditor-input")},_renderScrollHandler:function(){var e=this._input(),t=0;o.on(e,a.addNamespace(u.down,this.NAME),function(e){t=a.eventData(e).y}),o.on(e,a.addNamespace(u.move,this.NAME),function(n){var i=e.scrollTop(),o=e.prop("scrollHeight")-e.prop("clientHeight")-i;if(0!==i||0!==o){var s=a.eventData(n).y;(0===i&&t>=s||0===o&&t<=s||i>0&&o>0)&&(n.isScrollingEvent=!0,n.stopPropagation()),t=s}})},_renderDimensions:function(){var e=this.$element(),t=e.get(0),n=this._getOptionValue("width",t),i=this._getOptionValue("height",t),o=this.option("minHeight"),s=this.option("maxHeight");e.css({minHeight:void 0!==o?o:"",maxHeight:void 0!==s?s:"",width:n,height:i})},_resetDimensions:function(){this.$element().css({height:"",minHeight:"",maxHeight:""})},_renderEvents:function(){this.option("autoResizeEnabled")&&o.on(this._input(),a.addNamespace("input paste",this.NAME),this._updateInputHeight.bind(this)),this.callBase()},_refreshEvents:function(){o.off(this._input(),a.addNamespace("input paste",this.NAME)),this.callBase()},_updateInputHeight:function(){var e=this._input();if(this.option("autoResizeEnabled")&&void 0===this.option("height")){this._resetDimensions(),e.css("height",0);var t=this._$element.outerHeight()-e.outerHeight();this._renderDimensions();var n=this.option("minHeight"),i=this.option("maxHeight"),o=e[0].scrollHeight;void 0!==n&&(o=Math.max(o,n-t)),void 0!==i&&(o=Math.min(o,i-t)),e.css("height",o)}else e.css("height","")},_renderInputType:s,_visibilityChanged:function(e){e&&this._updateInputHeight()},_updateInputAutoResizeAppearance:function(e){e&&e.toggleClass("dx-texteditor-input-auto-resize",this.option("autoResizeEnabled"))},_optionChanged:function(e){switch(e.name){case"autoResizeEnabled":this._updateInputAutoResizeAppearance(this._input()),this._refreshEvents(),this._updateInputHeight();break;case"value":case"height":this.callBase(e),this._updateInputHeight();break;case"minHeight":case"maxHeight":this._renderDimensions(),this._updateInputHeight();break;case"visible":this.callBase(e),e.value&&this._updateInputHeight();break;default:this.callBase(e)}}});p("dxTextArea",l),e.exports=l,e.exports.default=e.exports}}]);
//# sourceMappingURL=31.7fca6a7c.chunk.js.map
﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\User\Login.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/Login.cshtml")]
    public partial class _Areas_Admin_Views_User_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\Login.cshtml"
  
    Layout = null;
    ViewBag.Title = "登录";

    var set = NewLife.Cube.Setting.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->\r\n\r\n    <title>");

            
            #line 16 "..\..\Areas\Admin\Views\User\Login.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 16 "..\..\Areas\Admin\Views\User\Login.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 466), Tuple.Create("\"", 486)
, Tuple.Create(Tuple.Create("", 473), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 473), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- 基本样式 -->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 562), Tuple.Create("\"", 610)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 569), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <!-- 自定义样式-->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 661), Tuple.Create("\"", 686)
, Tuple.Create(Tuple.Create("", 668), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Cube.css")
, 668), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <!-- 仅用于过渡期兼容-->\r\n    <style>\r\n        .login-logo {\r\n            width:" +
" 130px;\r\n            font-size: 130px;\r\n            color: #4CA6FF;\r\n           " +
" margin-top: 50px;\r\n        }\r\n\r\n        .cube-login {\r\n            background: " +
"#fff;\r\n            padding-bottom: 40px;\r\n            border-radius: 15px;\r\n    " +
"        text-align: center;\r\n        }\r\n\r\n            .cube-login .heading {\r\n  " +
"              display: block;\r\n                font-size: 24px;\r\n               " +
" font-weight: 700;\r\n                padding: 5px 0;\r\n                margin-bott" +
"om: 20px;\r\n            }\r\n\r\n            .cube-login .form-group {\r\n             " +
"   padding: 0 40px;\r\n                margin: 0 0 25px 0;\r\n                positi" +
"on: relative;\r\n                display: block;\r\n            }\r\n\r\n            .cu" +
"be-login .form-control {\r\n                border-radius: 20px;\r\n                " +
"box-shadow: none;\r\n                padding: 0 20px 0 45px;\r\n                heig" +
"ht: 40px;\r\n                transition: all 0.3s ease 0s;\r\n            }\r\n\r\n     " +
"           .cube-login .form-control:focus {\r\n                    background: #e" +
"0e0e0;\r\n                    box-shadow: none;\r\n                    outline: 0 no" +
"ne;\r\n                }\r\n\r\n            .cube-login .form-group i {\r\n             " +
"   position: absolute;\r\n                top: 12px;\r\n                left: 60px;\r" +
"\n                font-size: 17px;\r\n                color: #c8c8c8;\r\n            " +
"    transition: all 0.5s ease 0s;\r\n            }\r\n\r\n            .cube-login .for" +
"m-group a {\r\n                position: absolute;\r\n                top: 12px;\r\n  " +
"              right: 0px;\r\n                font-size: 17px;\r\n                col" +
"or: #c8c8c8;\r\n                transition: all 0.5s ease 0s;\r\n                col" +
"or: #4CA6FF;\r\n            }\r\n\r\n            .cube-login .form-control:focus + i {" +
"\r\n                color: #00b4ef;\r\n            }\r\n\r\n            .cube-login .fa-" +
"question-circle {\r\n                display: inline-block;\r\n                posit" +
"ion: absolute;\r\n                top: 12px;\r\n                right: 60px;\r\n      " +
"          font-size: 20px;\r\n                color: #808080;\r\n                tra" +
"nsition: all 0.5s ease 0s;\r\n            }\r\n\r\n                .cube-login .fa-que" +
"stion-circle:hover {\r\n                    color: #000;\r\n                }\r\n\r\n   " +
"         .cube-login .main-checkbox {\r\n                float: left;\r\n           " +
"     width: 20px;\r\n                height: 20px;\r\n                background: #1" +
"1a3fc;\r\n                border-radius: 50%;\r\n                position: relative;" +
"\r\n                margin: 5px 0 0 5px;\r\n                border: 1px solid #11a3f" +
"c;\r\n            }\r\n\r\n                .cube-login .main-checkbox label {\r\n       " +
"             width: 20px;\r\n                    height: 20px;\r\n                  " +
"  position: absolute;\r\n                    top: 0;\r\n                    left: 0;" +
"\r\n                    cursor: pointer;\r\n                }\r\n\r\n                   " +
" .cube-login .main-checkbox label:after {\r\n                        content: \"\";\r" +
"\n                        width: 10px;\r\n                        height: 5px;\r\n   " +
"                     position: absolute;\r\n                        top: 5px;\r\n   " +
"                     left: 4px;\r\n                        border: 3px solid #fff;" +
"\r\n                        border-top: none;\r\n                        border-righ" +
"t: none;\r\n                        background: transparent;\r\n                    " +
"    opacity: 0;\r\n                        -webkit-transform: rotate(-45deg);\r\n   " +
"                     transform: rotate(-45deg);\r\n                    }\r\n\r\n      " +
"          .cube-login .main-checkbox input[type=checkbox] {\r\n                   " +
" visibility: hidden;\r\n                }\r\n\r\n                    .cube-login .main" +
"-checkbox input[type=checkbox]:checked + label:after {\r\n                        " +
"opacity: 1;\r\n                    }\r\n\r\n            .cube-login .text {\r\n         " +
"       float: left;\r\n                margin-left: 7px;\r\n                line-hei" +
"ght: 20px;\r\n                padding-top: 5px;\r\n                text-transform: c" +
"apitalize;\r\n            }\r\n\r\n            .cube-login .btn {\r\n                flo" +
"at: right;\r\n                font-size: 14px;\r\n                color: #fff;\r\n    " +
"            background: #00b4ef;\r\n                border-radius: 30px;\r\n        " +
"        padding: 8px 50px;\r\n                border: none;\r\n                text-" +
"transform: capitalize;\r\n                transition: all 0.5s ease 0s;\r\n         " +
"   }\r\n\r\n        .ui.divider {\r\n            margin: 1rem 0rem;\r\n            line-" +
"height: 1;\r\n            height: 0em;\r\n            font-weight: bold;\r\n          " +
"  text-transform: uppercase;\r\n            letter-spacing: 0.05em;\r\n            c" +
"olor: rgba(0, 0, 0, 0.85);\r\n            -webkit-user-select: none;\r\n            " +
"-moz-user-select: none;\r\n            -ms-user-select: none;\r\n            user-se" +
"lect: none;\r\n            -webkit-tap-highlight-color: rgba(0, 0, 0, 0)\r\n        " +
"}\r\n\r\n        .ui.horizontal.divider {\r\n            display: table;\r\n            " +
"white-space: nowrap;\r\n            height: auto;\r\n            line-height: 1;\r\n  " +
"          text-align: center\r\n        }\r\n\r\n            .ui.horizontal.divider:be" +
"fore,\r\n            .ui.horizontal.divider:after {\r\n                content: \'\';\r" +
"\n                display: table-cell;\r\n                position: relative;\r\n    " +
"            top: 50%;\r\n                width: 50%;\r\n                background-r" +
"epeat: no-repeat\r\n            }\r\n\r\n            .ui.horizontal.divider:before {\r\n" +
"                background-position: right 1em top 50%;\r\n            }\r\n\r\n      " +
"      .ui.horizontal.divider:after {\r\n                background-position: left " +
"1em top 50%\r\n            }\r\n\r\n        .ui.divider > .icon {\r\n            margin:" +
" 0rem;\r\n            font-size: 1rem;\r\n            height: 1em;\r\n            vert" +
"ical-align: middle\r\n        }\r\n\r\n        .ui.divider {\r\n            font-size: 1" +
"rem\r\n        }\r\n\r\n        .ui.horizontal.divider:before,\r\n        .ui.horizontal" +
".divider:after {\r\n            background-image: url(\"data:image/png;base64,iVBOR" +
"w0KGgoAAAANSUhEUgAABaAAAAACCAYAAACuTHuKAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlY" +
"WR5ccllPAAAAyFpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZ" +
"D0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6b" +
"WV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuNS1jMDE0IDc5LjE1MTQ4MSwgMjAxMy8wMy8xM" +
"y0xMjowOToxNSAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xO" +
"Tk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sb" +
"nM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zL" +
"mFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwL" +
"zEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENDI" +
"ChXaW5kb3dzKSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo1OThBRDY4OUNDMTYxMUU0OUE3NUVGO" +
"EJDMzMzMjE2NyIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDo1OThBRDY4QUNDMTYxMUU0OUE3NUVGO" +
"EJDMzMzMjE2NyI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjU5O" +
"EFENjg3Q0MxNjExRTQ5QTc1RUY4QkMzMzMyMTY3IiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjU5O" +
"EFENjg4Q0MxNjExRTQ5QTc1RUY4QkMzMzMyMTY3Ii8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSR" +
"EY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+VU513gAAADVJREFUeNrs0DENACAQBDBIW" +
"LGBJQby/mUcJn5sJXQmOQMAAAAAAJqt+2prAAAAAACg2xdgANk6BEVuJgyMAAAAAElFTkSuQmCC\");\r\n" +
"        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <!--布局容器-->\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-6 col-md-offset-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"tab-content\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 233 "..\..\Areas\Admin\Views\User\Login.cshtml"
               Write(Html.Partial("_Login_Login"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 234 "..\..\Areas\Admin\Views\User\Login.cshtml"
               Write(Html.Partial("_Login_Forgot"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 235 "..\..\Areas\Admin\Views\User\Login.cshtml"
               Write(Html.Partial("_Login_Register"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 236 "..\..\Areas\Admin\Views\User\Login.cshtml"
               Write(Html.Partial("_Login_Login3"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-" +
"- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 8637), Tuple.Create("\"", 8675)
, Tuple.Create(Tuple.Create("", 8643), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 8643), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 8699), Tuple.Create("\"", 8744)
, Tuple.Create(Tuple.Create("", 8705), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 8705), false)
);

WriteLiteral(@"></script>
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src=""https://cdn.bootcss.com/html5shiv/3.7.3/html5shiv.min.js""></script>
      <script src=""https://cdn.bootcss.com/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->

</body>
");

            
            #line 251 "..\..\Areas\Admin\Views\User\Login.cshtml"
Write(Html.Partial("_Footer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</html>");

        }
    }
}
#pragma warning restore 1591

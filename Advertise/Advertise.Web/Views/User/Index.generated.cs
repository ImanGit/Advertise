﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    using Advertise.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/Index.cshtml")]
    public partial class _Views_User_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_User_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\User\Index.cshtml"
  
    ViewBag.Title = "Index";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Index</h2>\r\n\r\n<button");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" id=\"yy\"");

WriteLiteral(">ایمان</button>\r\n\r\n\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-7\"");

WriteLiteral(">\r\n        <h1>\r\n            Title Title\r\n        </h1>\r\n        Text Text Text T" +
"ext Text Text Text Text Text Text Text Text Text Text Text Text\r\n    </div>\r\n   " +
" <div");

WriteLiteral(" class=\"col-md-5\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"glyphicon glyphicon-exclamation-sign\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Error:</span>\r\n            Enter a valid email address\r\n        </div>\r\n\r\n      " +
"  <span");

WriteLiteral(" class=\"glyphicon glyphicon-exclamation-sign alert-success\"");

WriteLiteral(" ></span>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $(""#yy"").click(function (e) {
                e.preventDefault(); //می‌خواهیم لینک به صورت معمول عمل نکند
                $.bootstrapModalConfirm({
                                    caption: 'تائید عملیات',
                                    body: 'آیا عملیات درخواستی اجرا شود؟',
                                    onConfirm: function () {
                                        alert('در حال انجام عملیات');
                                    },
                                    confirmText: 'تائید',
                                    closeText: 'انصراف'
                });
            });
        });
    </script>
");

});

        }
    }
}
#pragma warning restore 1591

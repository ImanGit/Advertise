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
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class _SampleTemplate_cshtml : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden
        #line 3 "..\..\SampleTemplate.cshtml"
            
    public string Message { get; set; }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\nHello ");

            
            #line 7 "..\..\SampleTemplate.cshtml"
 Write(Message);

            
            #line default
            #line hidden
WriteLiteral("!\r\n");

        }
    }
}
#pragma warning restore 1591

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
    
    #line 6 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/VisitStat/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_VisitStat__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.VisitStat>>
    {
        public _Areas_Admin_Views_VisitStat__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var set = ViewBag.PageSetting as PageSetting;

    var level = (XCode.Statistics.StatLevels)page["Level"].ToInt();

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 24 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 833), Tuple.Create("\"", 872)
            
            #line 25 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 840), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 840), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 925), Tuple.Create("\"", 966)
            
            #line 26 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 932), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Time"))
            
            #line default
            #line hidden
, 932), false)
);

WriteLiteral(">时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1019), Tuple.Create("\"", 1060)
            
            #line 27 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1026), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Page"))
            
            #line default
            #line hidden
, 1026), false)
);

WriteLiteral(">页面</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1113), Tuple.Create("\"", 1155)
            
            #line 28 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1120), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Title"))
            
            #line default
            #line hidden
, 1120), false)
);

WriteLiteral(">标题</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1208), Tuple.Create("\"", 1250)
            
            #line 29 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1215), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 1215), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1303), Tuple.Create("\"", 1345)
            
            #line 30 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1310), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Users"))
            
            #line default
            #line hidden
, 1310), false)
);

WriteLiteral(">用户</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1398), Tuple.Create("\"", 1438)
            
            #line 31 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1405), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("IPs"))
            
            #line default
            #line hidden
, 1405), false)
);

WriteLiteral(">IP</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1491), Tuple.Create("\"", 1533)
            
            #line 32 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1498), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Error"))
            
            #line default
            #line hidden
, 1498), false)
);

WriteLiteral(">错误</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1586), Tuple.Create("\"", 1627)
            
            #line 33 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1593), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Cost"))
            
            #line default
            #line hidden
, 1593), false)
);

WriteLiteral(">平均耗时</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1682), Tuple.Create("\"", 1726)
            
            #line 34 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("MaxCost"))
            
            #line default
            #line hidden
, 1689), false)
);

WriteLiteral(">最大耗时</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1781), Tuple.Create("\"", 1828)
            
            #line 35 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1788), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1788), false)
);

WriteLiteral(">创建时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1883), Tuple.Create("\"", 1930)
            
            #line 36 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1890), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1890), false)
);

WriteLiteral(">更新时间</a></th>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 40 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 44 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
         foreach (var entity in Model)
        {
            var st = new VisitStatModel
            {
                Level = level,
                Time = entity.Time
            };

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 52 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2514), Tuple.Create("\"", 2532)
            
            #line 54 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2522), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2522), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 55 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 56 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                   Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 57 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(st);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 58 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Page);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 59 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 61 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Users.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 62 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.IPs.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 63 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Error.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 64 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Cost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 65 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.MaxCost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td>");

            
            #line 66 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 67 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 68 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 73 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 75 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 76 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
         if (page.State is VisitStat)
        {
            var entity = page.State as VisitStat;

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 80 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 80 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td></td>\r\n");

            
            #line 83 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">总计</td>\r\n                <td></td>\r\n                <td></td>\r\n                <" +
"td></td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 88 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 89 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Users.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 90 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.IPs.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 91 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Error.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 92 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Cost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 93 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.MaxCost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td>");

            
            #line 94 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 95 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 96 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 96 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td></td>\r\n");

            
            #line 99 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 101 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Four\WMS_MVC\WMS_MVC\WMS_MVC\Views\Inventoryrecord\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692f963bf9f2ae26d64ef3548177c7a465c13127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventoryrecord_Show), @"mvc.1.0.view", @"/Views/Inventoryrecord/Show.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Four\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Four\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692f963bf9f2ae26d64ef3548177c7a465c13127", @"/Views/Inventoryrecord/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2675e3018d93bc97dc009e4184a70cdd1dc5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventoryrecord_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692f963bf9f2ae26d64ef3548177c7a465c131273228", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Majestic Admin</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""../../vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""../../vendors/base/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <link rel=""stylesheet"" href=""../../css/style.css"">
    <!-- endinject -->
    <link rel=""shortcut icon"" href=""../../images/favicon.png"" />
    <script src=""D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\wwwroot\lib\jquery\dist\jquery.js""></script>
    <link href=""D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\wwwroot\lib\bootstrap\dist\css\bootstrap.css"" rel=""stylesheet"" />
    <script>
        var pageSize = 6;
        var currentPage = 1;
        var totalPage = 1;

        $(function () {
            Sho");
                WriteLiteral(@"w(1);
        })

        function Show(page) {
            var obj = {};
            obj.currentPage = page;
            obj.pageSize = pageSize;


            $.ajax({
                url: 'http://localhost:63209/api/Inventoryrecord/InventoryrecordShow',
                type: 'get',
                dataType: 'json',
                contentType: 'application/json',
                data: { time1: $(""#Texttime1"").val(), time2: $(""#Textrime2"").val(), CurrentPage: page, },
                crossDomain: true,
                success: function (d) {
                    $(""#TotalCount"").text(d.totalCount)
                    $(""#TotalPage"").text(d.totalPage)
                    $(""#CurrentPage"").text(d.currentPage)
                    //最大页
                    totalPage = d.totalPage;
                    //当前页
                    currentPage = d.currentPage;

                    $(""#td"").empty();
                    $(d.inventoryrecords).each(function () {
                        var list ");
                WriteLiteral(@"= '<tr>'
                            + '<td>' + this.inventoryrecordId + '</td>'
                            + '<td>' + this.stockInDetailId + '</td>'
                            + '<td>' + this.qty + '</td>'
                            + '<td>' + this.isDel + '</td>'
                            + '<td>' + this.remark + '</td>'
                            + '<td>' + this.createBy + '</td>'
                            + '<td>' + this.createDate + '</td>'
                            + '<td>' + this.modifiedBy + '</td>'
                            + '<td>' + this.modifiedDate + '</td>'
                        '</tr>'
                        $(""#td"").append(list);
                    })

                }

            })
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692f963bf9f2ae26d64ef3548177c7a465c131277127", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <!-- partial:../../partials/_navbar.html -->
        <nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""navbar-brand-wrapper d-flex justify-content-center"">
                <div class=""navbar-brand-inner-wrapper d-flex justify-content-between align-items-center w-100"">
                    <a class=""navbar-brand brand-logo"" href=""../../index.html""><img src=""../../images/logo.svg"" alt=""logo"" /></a>
                    <a class=""navbar-brand brand-logo-mini"" href=""../../index.html""><img src=""../../images/logo-mini.svg"" alt=""logo"" /></a>
                    <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                        <span class=""mdi mdi-sort-variant""></span>
                    </button>
                </div>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
                <ul class=""nav");
                WriteLiteral(@"bar-nav mr-lg-4 w-100"">
                    <li class=""nav-item nav-search d-none d-lg-block w-100"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""search"">
                                    <i class=""mdi mdi-magnify""></i>
                                </span>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search now"" aria-label=""search"" aria-describedby=""search"">
                        </div>
                    </li>
                </ul>
                <ul class=""navbar-nav navbar-nav-right"">
                    <li class=""nav-item dropdown mr-1"">
                        <a class=""nav-link count-indicator dropdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-message-text mx-0""><");
                WriteLiteral(@"/i>
                            <span class=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""messageDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Messages</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""../../images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        David Grey
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        The meeting is cancelled
                                   ");
                WriteLiteral(@" </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""../../images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Tim Cook
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        New product launch
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <img src=""..");
                WriteLiteral(@"/../images/faces/face3.jpg"" alt=""image"" class=""profile-pic"">
                                </div>
                                <div class=""item-content flex-grow"">
                                    <h6 class=""ellipsis font-weight-normal"">
                                        Johnson
                                    </h6>
                                    <p class=""font-weight-light small-text text-muted mb-0"">
                                        Upcoming board meeting
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item dropdown mr-4"">
                        <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center notification-dropdown"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-bell mx-0""></i>
                      ");
                WriteLiteral(@"      <span class=""count""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""notificationDropdown"">
                            <p class=""mb-0 font-weight-normal float-left dropdown-header"">Notifications</p>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-success"">
                                        <i class=""mdi mdi-information mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Application Error</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        Just now
                                    </p>
                              ");
                WriteLiteral(@"  </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-warning"">
                                        <i class=""mdi mdi-settings mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">Settings</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        Private message
                                    </p>
                                </div>
                            </a>
                            <a class=""dropdown-item"">
                                <div class=""item-thumbnail"">
                                    <div class=""item-icon bg-info"">
                                 ");
                WriteLiteral(@"       <i class=""mdi mdi-account-box mx-0""></i>
                                    </div>
                                </div>
                                <div class=""item-content"">
                                    <h6 class=""font-weight-normal"">New user registration</h6>
                                    <p class=""font-weight-light small-text mb-0 text-muted"">
                                        2 days ago
                                    </p>
                                </div>
                            </a>
                        </div>
                    </li>
                    <li class=""nav-item nav-profile dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"" id=""profileDropdown"">
                            <img src=""../../images/faces/face5.jpg"" alt=""profile"" />
                            <span class=""nav-profile-name"">Louis Barnett</span>
                        </a>
                        <div class=""dro");
                WriteLiteral(@"pdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDropdown"">
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-settings text-primary""></i>
                                Settings
                            </a>
                            <a class=""dropdown-item"">
                                <i class=""mdi mdi-logout text-primary""></i>
                                Logout
                            </a>
                        </div>
                    </li>
                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>
        <!-- partial -->
        <div class=""container-fluid page-body-wrapper"">
            <!-- partial:../../partials/_sidebar.html -->
            <nav class=""sidebar sidebar-offca");
                WriteLiteral(@"nvas"" id=""sidebar"">
                <ul class=""nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../index.html"">
                            <i class=""mdi mdi-home menu-icon""></i>
                            <span class=""menu-title"">Dashboard</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" data-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                            <i class=""mdi mdi-circle-outline menu-icon""></i>
                            <span class=""menu-title"">UI Elements</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""ui-basic"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Button");
                WriteLiteral(@"s</a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""Delivery.html"">发货记录</a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""Inventoryrecord.html"">库存记录</a></li>

                                <li class=""nav-item""> <a class=""nav-link"" href=""Inventorymove.html"">库存移动</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../pages/forms/basic_elements.html"">
                            <i class=""mdi mdi-view-headline menu-icon""></i>
                            <span class=""menu-title"">Form elements</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../pages/charts/chartjs.html"">
                            <i class=""mdi mdi-chart-pie menu-icon""></i>
                            <s");
                WriteLiteral(@"pan class=""menu-title"">Charts</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                            <i class=""mdi mdi-grid-large menu-icon""></i>
                            <span class=""menu-title"">Tables</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../pages/icons/mdi.html"">
                            <i class=""mdi mdi-emoticon menu-icon""></i>
                            <span class=""menu-title"">Icons</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" data-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                            <i class=""mdi mdi-account menu-icon""></i>
                            <span class=");
                WriteLiteral(@"""menu-title"">User Pages</span>
                            <i class=""menu-arrow""></i>
                        </a>
                        <div class=""collapse"" id=""auth"">
                            <ul class=""nav flex-column sub-menu"">
                                <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/login.html""> Login </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/login-2.html""> Login 2 </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/register.html""> Register </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/register-2.html""> Register 2 </a></li>
                                <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/lock-screen.html""> Lockscreen </a></li>
                            </ul>
                        </div>
                    </li>
      ");
                WriteLiteral(@"              <li class=""nav-item"">
                        <a class=""nav-link"" href=""../../documentation/documentation.html"">
                            <i class=""mdi mdi-file-document-box-outline menu-icon""></i>
                            <span class=""menu-title"">Documentation</span>
                        </a>
                    </li>
                </ul>
            </nav>
            <!-- partial -->
            <div class=""main-panel"">
                <div class=""content-wrapper"">
                    <table class=""table table-hover"">
                        <tr>
                            <td>日期范围</td>
                            <td><input id=""Texttime1"" type=""text"" /></td>
                            <td><input id=""Textrime2"" type=""text"" /></td>


                            <td><input id=""Button1"" type=""button"" value=""查询"" class=""btn btn-info"" onclick=""Show(1)"" /></td>
                        </tr>
                    </table>
                    <table class=""table"">
     ");
                WriteLiteral(@"                   <thead>
                            <tr>
                                <th>库存记录号</th>
                                <th>库存详情号</th>
                                <th>数量</th>
                                <th>是否删除</th>
                                <th>备注</th>
                                <th>创建者</th>
                                <th>创建时间</th>
                                <th>修改者</th>
                                <th>修改时间</th>
                            </tr>
                        </thead>
                        <tbody id=""td""></tbody>
                    </table>
                    <table class=""table"">
                        <tr>
                            <td style=""text-align: center; vertical-align: middle; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">总记录数<span id=""TotalCount""></span>条</td>
                            <td style=""text-align: center; vertical-align: middle; color: black; font-family: STXingkai;");
                WriteLiteral(@" font-weight: bolder; font-size: larger"">总共<span id=""TotalPage""></span>页</td>
                            <td style=""text-align: center; vertical-align: middle; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">当前第<span id=""CurrentPage""></span>页</td>
                            <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
                                <input id=""Button1"" type=""button"" value=""首页"" onclick=""Show(1)"" class=""btn btn-primary"" />
                            </td>
                            <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
                                <input type=""button"" value=""<"" onclick=""Show(currentPage - 1)"" class=""btn btn-primary"" />
                            </td>
                            <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
          ");
                WriteLiteral(@"                      <input type=""button"" value="">"" onclick=""Show(currentPage + 1)"" class=""btn btn-primary"" />
                            </td>
                            <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
                                <input type=""button"" value=""尾页"" onclick=""Show(totalPage)"" class=""btn btn-primary"" />
                            </td>
                        </tr>
                    </table>


                </div>
                <!-- content-wrapper ends -->
                <!-- partial:../../partials/_footer.html -->
                <footer class=""footer"">
                    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                        <span class=""text-muted text-center text-sm-left d-block d-sm-inline-block"">Copyright © 2018 <a href=""https://www.urbanui.com/"" target=""_blank"">Urbanui</a>. All rights reserved.</span>
                        <span class=""flo");
                WriteLiteral(@"at-none float-sm-right d-block mt-1 mt-sm-0 text-center"">Hand-crafted & made with <i class=""mdi mdi-heart text-danger""></i></span>
                    </div>
                </footer>
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""../../vendors/base/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugin js for this page-->
    <!-- End plugin js for this page-->
    <!-- inject:js -->
    <script src=""../../js/off-canvas.js""></script>
    <script src=""../../js/hoverable-collapse.js""></script>
    <script src=""../../js/template.js""></script>
    <!-- endinject -->
    <!-- Custom js for this page-->
    <!-- End custom js for this page-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

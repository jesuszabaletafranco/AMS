#pragma checksum "C:\Users\FELIX\source\repos\AMS\AMS\Views\Auditoria\GestionJuridica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d121adf2906601b4f6a45213267b4947a12be4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auditoria_GestionJuridica), @"mvc.1.0.view", @"/Views/Auditoria/GestionJuridica.cshtml")]
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
#line 1 "C:\Users\FELIX\source\repos\AMS\AMS\Views\_ViewImports.cshtml"
using AMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FELIX\source\repos\AMS\AMS\Views\_ViewImports.cshtml"
using AMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d121adf2906601b4f6a45213267b4947a12be4d2", @"/Views/Auditoria/GestionJuridica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cea8c9a7a39c059a3c8516ab26e1dbc95d2b05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Auditoria_GestionJuridica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FELIX\source\repos\AMS\AMS\Views\Auditoria\GestionJuridica.cshtml"
  
    ViewData["Title"] = "Gestión Juridica";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .padding-0 {\r\n        padding-right: 1px;\r\n        padding-left: 1px;\r\n    }\r\n</style>\r\n\r\n<div class=\"row row-cards\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d121adf2906601b4f6a45213267b4947a12be4d24556", async() => {
                WriteLiteral(@"
        <div class=""card-header"">
            <h4 class=""card-title"">Gestion Juridica</h4>
        </div>

        <div class=""card-footer text-end"">
            <div class=""d-flex"">
                <a href=""#"" class=""btn btn-link"">Cancelar</a>
                <button type=""submit"" class=""btn btn-primary ms-auto"">Guardar</button>
            </div>
        </div>

        <div class=""card-body"">

            <div class=""row no-gutters"">

                <div class=""col-md-3 padding-0"">
                    <label class=""form-label"">Numero Radicado</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Numero Radicado"">
                </div>

                <div class=""col-md-3 padding-0"">
                    <label class=""form-label"">Numero Factura</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Numero factura"">
                </div>

                <div class=""col-md-3 ");
                WriteLiteral(@"padding-0"">
                    <label class=""form-label"">Tipo Presentacion</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Tipo Presentacion"">
                </div>

                <div class=""col-md-3 padding-0"">
                    <label class=""form-label"">TipoRadicacion</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Tipo Radicacion"">
                </div>

            </div>

            <div class=""row no-gutters"">

                <div class=""col-md-4 padding-0"">
                    <label class=""form-label"">Fecha</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Fecha Radicacion"">
                </div>

                <div class=""col-md-4 padding-0"">
                    <label class=""form-label"">Usuario</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeho");
                WriteLiteral(@"lder=""Usuario"">
                </div>

                <div class=""col-md-4"">
                    <label class=""form-label padding-0"">Registro</label>
                    <input type=""text"" class=""form-control"" name=""example-text-input"" placeholder=""Fecha Registro"">
                </div>


            </div>

            <div class=""row g-2 align-items-center"">
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                    <a href=""#"" class=""btn btn-primary w-100"" data-bs-toggle=""modal"" data-bs-target=""#modal-datos-reclamante"">
                        Datos Reclamante
                    </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                    <a href=""#"" class=""btn btn-secondary w-100"" data-bs-toggle=""modal"" data-bs-target=""#modal-datos-victima"">
                        Datos Victima
                    </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"" data-bs-tog");
                WriteLiteral(@"gle=""modal"" data-bs-target=""#modal-datos-evento"">
                    <a href=""#"" class=""btn btn-success w-100"">
                        Datos Evento
                    </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                    <a href=""#"" class=""btn btn-warning w-100"" data-bs-toggle=""modal"" data-bs-target=""#modal-datos-vehiculo"">
                        Datos Vehiculo
                    </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                    <a href=""#"" class=""btn btn-danger w-100"" data-bs-toggle=""modal"" data-bs-target=""#modal-datos-propietario"">
                        Datos propietario
                    </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                    <a href=""#"" class=""btn btn-info w-100"" data-bs-toggle=""modal"" data-bs-target=""#modal-datos-conductor"">
                        Datos Conductor
                  ");
                WriteLiteral(@"  </a>
                </div>
                <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"" data-bs-toggle=""modal"" data-bs-target=""#modal-visualizador-pdf"">
                    <a href=""#"" class=""btn btn-dark w-100"">
                        Visualizar Fisico
                    </a>
                </div>
            </div>

            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Datos Detalles a Liquidar</h3>
                </div>
                <div class=""row g-2 align-items-center"">

                    <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                        <a href=""#"" class=""btn btn-primary w-100"">
                            Items recobrados
                        </a>
                    </div>

                    <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                        <a href=""#"" class=""btn btn-primary w-100"">
                            Glosas Aplicadas
                     ");
                WriteLiteral(@"   </a>
                    </div>

                    <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                        <a href=""#"" class=""btn btn-primary w-100"">
                            Alertas
                        </a>
                    </div>

                    <div class=""col-6 col-sm-4 col-md-2 col-xl py-3"">
                        <a href=""#"" class=""btn btn-primary w-100"">
                            Manual de Glosas
                        </a>
                    </div>

                </div>

                <div class=""table-responsive"">
                    <table class=""table card-table table-vcenter text-nowrap datatable"">
                        <thead>
                            <tr>
                                <th>Codigo</th>
                                <th>Concepto</th>
                                <th>Fecha</th>
                                <th>cantidad Cobrada</th>
                                <th>Valor Unitario</th>
         ");
                WriteLiteral(@"                       <th>Total Cobrado</th>
                                <th>Cantidad Aprobada</th>
                                <th>Valor Unitario</th>
                                <th>Total Aprobado</th>
                                <th>Glosas Aplicadas</th>
                                <th>estado</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                        </tbody>
                 ");
                WriteLiteral("   </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>

<!-- Datos reclamante -->
<div class=""modal modal-blur fade"" id=""modal-datos-reclamante"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Datos Reclamante</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-5"">
                        <label class=""form-label"">Tipo Documento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-7"">
                        <label class=""form-label"">Numero Documento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
         ");
            WriteLiteral(@"       </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-4"">
                        <label class=""form-label"">Codigo Habilitacion</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-8"">
                        <label class=""form-label"">Razon Social</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-8"">
                        <label class=""form-label"">Direccion</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Telefono</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

   ");
            WriteLiteral(@"             <div class=""row mb-3 align-items-end"">
                    <div class=""col"">
                        <label class=""form-label"">Departamento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col"">
                        <label class=""form-label"">Municipio</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>

<!-- Datos victima -->
<div class=""modal modal-blur fade"" id=""modal-datos-victima"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=");
            WriteLiteral(@"""modal-title"">Datos Victima</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Primer Apellido</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo Apellido</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Primer nombre</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo nombre</label>
        ");
            WriteLiteral(@"                <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Tipo Documento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Numero dDocumento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Sexo</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Fecha Nacimiento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
         ");
            WriteLiteral(@"       </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-8"">
                        <label class=""form-label"">Direccion</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Telefono</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col"">
                        <label class=""form-label"">Departamento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col"">
                        <label class=""form-label"">Municipio</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <");
            WriteLiteral(@"div class=""row mb-3 align-items-end"">
                    <div class=""col-4"">
                        <label class=""form-label"">Zona residencia</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-8"">
                        <label class=""form-label"">Condicion Victima</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>


<!-- Datos Evento -->
<div class=""modal modal-blur fade"" id=""modal-datos-evento"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-t");
            WriteLiteral(@"itle"">Datos Evento</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div>
                    <label class=""form-label"">Descripcion del Evento</label>
                    <textarea class=""form-control""></textarea>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-8"">
                        <label class=""form-label"">Direccion Evento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Fecha Evento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-5"">
                        <label clas");
            WriteLiteral(@"s=""form-label"">Departamento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Municipio</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Zona</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>

<!-- Datos Vehiculo -->
<div class=""modal modal-blur fade"" id=""modal-datos-vehiculo"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-conten");
            WriteLiteral(@"t"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Datos Vehiculo</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-4"">
                        <label class=""form-label"">Placa</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Marca</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Esrado Aseguramiento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 alig");
            WriteLiteral(@"n-items-end"">
                    <div class=""col-4"">
                        <label class=""form-label"">Tipo vehiculo</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Codigo Aseguradora</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Poliza Soat</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-4"">
                        <label class=""form-label"">Inicio Poliza</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=");
            WriteLiteral(@"""form-label"">Fin Poliza</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Int. Autoridad</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>

<!-- Datos propietario -->
<div class=""modal modal-blur fade"" id=""modal-datos-propietario"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Datos Propietario</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal");
            WriteLiteral(@""" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Primer Apellido</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo Apellido</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Primer nombre</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo nombre</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>
");
            WriteLiteral(@"
                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Tipo Documento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Numero dDocumento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Sexo</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Fecha Nacimiento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-8"">");
            WriteLiteral(@"
                        <label class=""form-label"">Direccion</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Telefono</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col"">
                        <label class=""form-label"">Departamento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col"">
                        <label class=""form-label"">Municipio</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dis");
            WriteLiteral(@"miss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>


<!-- Datos Conductor -->
<div class=""modal modal-blur fade"" id=""modal-datos-conductor"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Datos Conductor</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Primer Apellido</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo Apellido</label>
                      ");
            WriteLiteral(@"  <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Primer nombre</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Segundo nombre</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-3"">
                        <label class=""form-label"">Tipo Documento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Numero dDocumento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

              ");
            WriteLiteral(@"      <div class=""col-3"">
                        <label class=""form-label"">Sexo</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-3"">
                        <label class=""form-label"">Fecha Nacimiento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col-8"">
                        <label class=""form-label"">Direccion</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col-4"">
                        <label class=""form-label"">Telefono</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

                <div class=""row mb-3 align-items-end"">
                    <div class=""col"">
      ");
            WriteLiteral(@"                  <label class=""form-label"">Departamento</label>
                        <input type=""text"" class=""form-control"" />
                    </div>

                    <div class=""col"">
                        <label class=""form-label"">Municipio</label>
                        <input type=""text"" class=""form-control"" />
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>

<!-- Visor PDF-->
<div class=""modal modal-blur fade"" id=""modal-visualizador-pdf"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-full-width modal-fullscreen modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Visualizador de Fisicos</h5>
                <button type=""b");
            WriteLiteral(@"utton"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                Visualizador PDF
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn me-auto"" data-bs-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>");
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

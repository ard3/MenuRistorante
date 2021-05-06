#pragma checksum "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc004f04a5ab83fdd2b0ea271f792422385d0c80"
// <auto-generated/>
#pragma warning disable 1591
namespace MenuRistorante.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using MenuRistorante;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\_Imports.razor"
using MenuRistorante.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gestionepiatti")]
    public partial class GestionePiatti : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>GestionePiatti</h1>\r\n<br>\r\n");
#nullable restore
#line 5 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
 if (nuovoPiatto == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                              (e => AggiungiPiatto())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Aggiungi Piatto");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, @"<thead>
            <tr>
                <th>Numero del Piatto</th>
                <th>Nome del piatto</th>
                <th>Tipo del Piatto</th>
                <th>Allergeni Contenuti</th>
                <th>Stagione del Piatto</th>
                <th>Prezzo del Piatto</th>
                <th>Descizione</th>
                <th width=""1%"">Modifica Piatto</th>
                <th width=""1%"">Cancella Piatto</th>
            </tr>
        </thead>
");
#nullable restore
#line 24 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
         foreach (MenuRistorante.Data.PiattiRistorante singoloPiatto in dbPiatti.TabellaPiatti)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.IdPiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.NomePiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.TipoPiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 30 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.AllergeniContenuti

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 31 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.StagionePiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 32 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.PrezzoPiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 33 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
             singoloPiatto.DescizionePiatto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                      (e => ModificaPiatto(singoloPiatto))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\r\n                <span class=\"oi oi-pencil\" style=\"color: white\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "td");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-danger");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                     (e => CancellaPiatto(singoloPiatto))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "\r\n                <span class=\"oi oi-trash\" style=\"color: white\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 45 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 47 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"

}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "form");
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "label");
            __builder.AddMarkupContent(58, "\r\n        Descrizione piatto\r\n        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "text");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                            nuovoPiatto.NomePiatto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.NomePiatto = __value, nuovoPiatto.NomePiatto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "<br>\r\n\r\n    ");
            __builder.OpenElement(65, "label");
            __builder.AddMarkupContent(66, "\r\n        Tipo del Piatto\r\n        ");
            __builder.OpenElement(67, "select");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "id", "tipoPiatto");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                            nuovoPiatto.TipoPiatto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.TipoPiatto = __value, nuovoPiatto.TipoPiatto));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value", "Seleziona");
            __builder.AddAttribute(75, "default", true);
            __builder.AddContent(76, "Seleziona il tipo del piatto");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "Antipasto");
            __builder.AddContent(80, "Antipasto");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "option");
            __builder.AddAttribute(83, "value", "Primo");
            __builder.AddContent(84, "Primo");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "Secondo");
            __builder.AddContent(88, "Secondo");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "Contorno");
            __builder.AddContent(92, "Contorno");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "Dolce");
            __builder.AddContent(96, "Dolce");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "<br>\r\n    ");
            __builder.OpenElement(100, "label");
            __builder.AddMarkupContent(101, "\r\n        Allergeni contenuti\r\n        ");
            __builder.OpenElement(102, "select");
            __builder.AddAttribute(103, "class", "form-control");
            __builder.AddAttribute(104, "id", "allergeni");
            __builder.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                           nuovoPiatto.AllergeniContenuti

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.AllergeniContenuti = __value, nuovoPiatto.AllergeniContenuti));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "M/F");
            __builder.AddAttribute(110, "default", true);
            __builder.AddContent(111, "Seleziona Allergeni");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.OpenElement(113, "option");
            __builder.AddAttribute(114, "value", "Glutine");
            __builder.AddContent(115, "Glutine");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "option");
            __builder.AddAttribute(118, "value", "Gova");
            __builder.AddContent(119, "Gova");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "Glutine/Gova/Noci/Crostacei\r\n            ");
            __builder.OpenElement(121, "option");
            __builder.AddAttribute(122, "value", "Noci");
            __builder.AddContent(123, "Noci");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "option");
            __builder.AddAttribute(126, "value", "Crostacei");
            __builder.AddContent(127, "Crostacei");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "<br>\r\n    ");
            __builder.OpenElement(131, "label");
            __builder.AddMarkupContent(132, "\r\n        Stagione del piatto\r\n        ");
            __builder.OpenElement(133, "select");
            __builder.AddAttribute(134, "class", "form-control");
            __builder.AddAttribute(135, "id", "stagione");
            __builder.AddAttribute(136, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                          nuovoPiatto.StagionePiatto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.StagionePiatto = __value, nuovoPiatto.StagionePiatto));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(138, "\r\n            ");
            __builder.OpenElement(139, "option");
            __builder.AddAttribute(140, "value", "Seleziona stagione");
            __builder.AddAttribute(141, "default", true);
            __builder.AddContent(142, "Seleziona Stagione");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "Inverno");
            __builder.AddContent(146, "Inverno");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "Primavera");
            __builder.AddContent(150, "Primavera");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "value", "Estate");
            __builder.AddContent(154, "Estate");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n            ");
            __builder.OpenElement(156, "option");
            __builder.AddAttribute(157, "value", "Autunno");
            __builder.AddContent(158, "Autunno");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "<br>\r\n    ");
            __builder.OpenElement(162, "label");
            __builder.AddMarkupContent(163, "\r\n        Prezzo del piatto\r\n        ");
            __builder.OpenElement(164, "input");
            __builder.AddAttribute(165, "type", "number");
            __builder.AddAttribute(166, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                            nuovoPiatto.PrezzoPiatto

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(167, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.PrezzoPiatto = __value, nuovoPiatto.PrezzoPiatto, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "<br>\r\n    ");
            __builder.OpenElement(170, "label");
            __builder.AddMarkupContent(171, "\r\n        Descrizione piatto\r\n        ");
            __builder.OpenElement(172, "input");
            __builder.AddAttribute(173, "type", "text");
            __builder.AddAttribute(174, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                            nuovoPiatto.DescizionePiatto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(175, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoPiatto.DescizionePiatto = __value, nuovoPiatto.DescizionePiatto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "<br>\r\n\r\n    <br>");
            __builder.OpenElement(178, "button");
            __builder.AddAttribute(179, "class", "btn btn-primary");
            __builder.AddAttribute(180, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                                    (e => SalvaPiatto())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(181, "Salva");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n    ");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "class", "btn btn-danger");
            __builder.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
                                             (e => AnnullaPiatto())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(186, "Annulla");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n");
#nullable restore
#line 101 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\ardit\source\repos\MenuRistorante\MenuRistorante\Pages\GestionePiatti.razor"
       
    public MenuRistorante.Data.PiattiRistorante nuovoPiatto;

    private void AggiungiPiatto()
    {
        nuovoPiatto = new MenuRistorante.Data.PiattiRistorante();
    }
    public void ModificaPiatto(MenuRistorante.Data.PiattiRistorante PiattoDaModificare)
    {
        nuovoPiatto = PiattoDaModificare;
    }
    public void CancellaPiatto(MenuRistorante.Data.PiattiRistorante PiattoDaCancellare)
    {
        dbPiatti.TabellaPiatti.Remove(PiattoDaCancellare);
        dbPiatti.SaveChanges();
    }
    public void SalvaPiatto()
    {
        if (nuovoPiatto.IdPiatto == 0)
        {
            dbPiatti.TabellaPiatti.Add(nuovoPiatto);
        }
        else
        {
            dbPiatti.TabellaPiatti.Update(nuovoPiatto);
        }
        dbPiatti.SaveChanges();
        nuovoPiatto = null;
    }
    public void AnnullaPiatto()
    {
        nuovoPiatto = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MenuRistorante.Data.PiattiDatabase dbPiatti { get; set; }
    }
}
#pragma warning restore 1591

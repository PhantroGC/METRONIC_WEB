


//var BtnOverView = document.getElementById("BtnOverView")
var BtComponents = document.getElementById("BtnComponents");

//$("#BtnOverView").html(function () {
//    let ul = document.createElement("ul");
//    let li = document.createElement("li");
//    let texto = document.createTextNode("Este es la prueba de la lista");
//    li.appendChild(texto);
//    ul.appendChild(li);
//    document.body.appendChild(ul)
//})

$.ajax(
    {
        type: "POST",
        url: "/Home/ObtenerDatosDelUsuario",
        data: {},
        processData: false,
        contentType: false,
        async: false,
        success: function (Data) {

            //let ul = document.createElement("ul");
            //for ( item of Data.success)
            //{

            //    $("#BtnOverView").html(function()
            //    {
            //        let 
            //        $(".menu-icon me-0").html(function ()
            //        {
            //            var Menu = item.Descripcion_Menu;
            //            return Menu;
            //        })

            ////}
            //if (Data.success[1].id_Menu == Data.success[2].PadreId)
            //{
            //    console.log(Data.success[3].Descripcion_Menu)
            $.each(Data.success, function (index,Menu)
            {
                if (Menu.Descripcion_Menu.length == 2) {
                    
                    console.log(Menu.Descripcion_Menu)
                    //$.each(Data.success, function (index, Menu) {
                    //    console.log(Menu.Descripcion_Menu)
                    //})
                }
            })
           

            

            function MenuPrincipal()
            {
                var html = [];
                /*html.push('<div class="menu-sub menu-sub-dropdown w-225px px-1 py-4" >')*/
                $.each(Data.success, function (index,Menu)
                {
                    if (Menu.PadreId == 0)
                    {
                        //MENU COMIENZO
                        html.push('<div data-kt-menu-trigger="click" data-kt-menu-placement="right-start" data-kt-menu-flip="bottom" class="menu-item py-2">')
                        html.push('<div class="menu-link menu-center" data-bs-toggle="tooltip" data-bs-trigger="hover" data-bs-dismiss="click" data-bs-placement="right">')
                        html.push('<span class="menu-icon me-0">' + Menu.Descripcion_Menu + '</span>')
                        html.push('</div>')
                        html.push(SubMenu(this))
                        html.push('</div>')

                        //SUBMENU COMENTADO
                        //html.push('<div class="menu-sub menu-sub-dropdown w-225px px-1 py-4 show" style="z-index:105; position:fixed; inset:0px auto auto 0px; margin: 0px; transform: translate3d(100px, 567px, 0px)" data-popper-placement="right-start">')
                        ////SUBMENU 
                        //html.push('<div class="menu-item">')
                        //html.push('<div class="menu-content">')
                        //html.push('<p>DESDE EL SUB MENU</p>')
                        //html.push('</div>')
                        //html.push('</div>')
                    }
                })
                /*html.push('</div>')*/
                $("#Lista").append(html.join('\n'));    
            }
            function SubMenu()
            {
                var html = [];
                html.push('<div class="menu-sub menu-sub-dropdown w-225px px-1 py-4 show" style="z-index:105; position:fixed; inset:0px auto auto 0px; margin: 0px; transform: translate3d(100px, 462px, 0px)" data-popper-placement="right-start">')
                $.each(Data.success, function (index, SubMenu)
                {
                    if (SubMenu.PadreId > 0)
                    {
                        //SUBMENU
                        html.push('<div data-kt-menu-trigger="click" class="menu-item menu-accordion">')
                        html.push('<div class="menu-item">')
                        html.push('<div class="menu-bullet">')
                        html.push('<a class="menu-link" href="' + SubMenu.Url_Menu + '">' + SubMenu.Descripcion_Menu + '</a>')
                        html.push('</div>')
                        html.push('</div>')
                        html.push('</div>')
                       
                    }

                })
                html.push('</div>')
                return html.join('\n')
            }
            function LIMenu()
            {
               
                var html = [];
                $.each(Data.success, function (index,Menu)
                {
                    if (Menu.PadreId == 0)
                    {
                        //Es un Menu Principal
                        html.push('<li>')
                        html.push('<a>' + Menu.Descripcion_Menu + '</a>')
                      /*   html.push(ULSubMenu(this))  */
                        html.push('</li>')
                    }
                   
                })
                return html.join("\n");
            }
            window.onload = MenuPrincipal;
            
           


        }
    })




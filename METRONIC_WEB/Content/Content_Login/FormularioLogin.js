var formulario = document.getElementById("formulario");
formulario.addEventListener('submit', function (e) {
    e.preventDefault();
    console.log("esta funcionando");

    var formdata = new FormData(formulario);
  
    //console.log(datos.get("usuario"));
    //console.log(datos.get("password"))

    $.ajax(
        {
            type: "POST",
            url: "/Home/Autenticar",
            data: formdata,
            processData: false,
            contentType: false,
            async : false,
            success: function(data)
            {
                if (data.success) {
                    
                    window.location.href = "/Home/Usuario";
                    console.log(data)
                    
                                 
                }
                else
                {
                    alert("El usuario o contraseña son incorrectos")
                    console.log(data)
                }
            }
        })
    //fetch(url,
    //    {
    //        method: 'POST',
    //        body: formdata
    //    }).then(function (response)
    //    {
    //        if (response.ok) {

    //            /*window.location.href = "/Home/Usuario";*/
    //            console.log(response)
    //            alert("Logeado")
    //        }
    //        else
    //        {
    //            alert("No logeado")
    //        }

    //    })

})
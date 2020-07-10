$('#btnLogin').click(function () {

    var nombre_usuario = $('#nombre_usuario').val();
    var password = $('#password').val();

    if (nombre_usuario == '') {
        $('#lblErrorLogin').text('El nombre de usuario no puede estar vacío');
        return;
    }

    if (password == '') {
        $('#lblErrorLogin').text('El password no puede estar vacío');
        return;
    }

    var usuario = { nombre_usuario: nombre_usuario, password: password }

    //console.log(usuario)

    $.ajax({
        url: SesionIndexParams.iniciarSesionURL,
        data: usuario,
        success: function (data) {

            if (data.Error) {

                if (data.Mensaje == 'Seleccionar Colegio') {
                    bootbox.alert("asd")
                }
                else {
                    $('#lblErrorLogin').text(data.Mensaje);
                }
                
            }
            else {
                location.href = SesionIndexParams.inicioURL;
            }

        },
        error: function (err) {
            console.log(err);
        }
    })

});

$('#btnRegistrar').click(function () {
    location.href = SesionIndexParams.registrarURL;
});

$(document).keypress(function (tecla) {
    if (tecla.keyCode == 13) {
        $('#btnLogin').click();
    }
});
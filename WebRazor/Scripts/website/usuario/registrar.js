$('#btnRegistrar').click(function () {

    var nombre = $('#nombre').val();
    var apellido = $('#apellido').val();
    var nombre_usuario = $('#nombre_usuario').val();
    var password = $('#password').val();
    var password_confirm = $('#password_confirm').val();
    var email = $('#email').val();
    var celular = $('#celular').val();
    var codigo_colegio = $('#codigoColegio').val();

    if (nombre_usuario === '') {
        bootbox.alert("Verifique el usuario", function () { $('#nombre_usuario').focus(); });
        
        return;
    }

    if (password === '') {
        alert("Verifique el password", function () { $('#password').focus(); });
        //$('#password').focus();
        return;
    }

    if (password_confirm === '') {
        bootbox.alert("Verifique la confirmación del password", function () { $('#password_confirm').focus(); });
        //$('#password_confirm').focus();
        return;
    }

    if (password !== password_confirm) {
        bootbox.alert("Las contraseñas no coinciden", function () { $('#password_confirm').focus(); });
        //$('#password_confirm').focus();
        return;
    }

    if (nombre === '') {
        bootbox.alert("Verifique el nombre", function () { $('#nombre').focus(); });
        //$('#nombre').focus();
        return;
    }

    if (apellido === '') {
        bootbox.alert("Verifique el apellido", function () { $('#apellido').focus(); });
        //$('#apellido').focus();
        return;
    }

    if (email === '') {
        bootbox.alert("Verifique el email", function () { $('#email').focus(); });
        //$('#email').focus();
        return;
    }

    if (celular === '') {
        bootbox.alert("Verifique el celular", function () { $('#celular').focus(); });
        //$('#celular').focus();
        return;
    }

    if (codigo_colegio === '') {
        bootbox.alert("Verifique el código del colegio", function () { $('#codigoColegio').focus(); });
        //$('#codigoColegio').focus();
        return;
    }

    var usuario = { nombre: nombre, apellido: apellido, nombre_usuario: nombre_usuario, password: password, email: email, celular: celular };
    
    $.ajax({
        url: RegistrarUsuarioParams.registrarUsuarioURL + "?codigo_colegio=" + codigo_colegio,
        data: usuario,
        type: 'POST',
        success: function (data) {

                if (!data.Error)
                {
                    var textoVacio = '';
                    $('#nombre').val(textoVacio);
                    $('#apellido').val(textoVacio);
                    $('#nombre_usuario').val(textoVacio);
                    $('#password').val(textoVacio);
                    $('#password_confirm').val(textoVacio);
                    $('#email').val(textoVacio);
                    $('#celular').val(textoVacio);

                    bootbox.alert(data.Mensaje, function () { location.href = RegistrarUsuarioParams.volverURL;})
            }
                else {
                    bootbox.alert(data.Mensaje);
                }
                
            
        },
        error: function (err) {
            console.log(err);
        }
    });

    return false;
    

});

$('#btnCancelar').click(function () {
    location.href = RegistrarUsuarioParams.volverURL;
});
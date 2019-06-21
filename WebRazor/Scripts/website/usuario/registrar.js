$('#btnRegistrar').click(function () {

    var nombre = $('#nombre').val();
    var apellido = $('#apellido').val();
    var nombre_usuario = $('#nombre_usuario').val();
    var password = $('#password').val();
    var password_confirm = $('#password_confirm').val();
    var email = $('#email').val();
    var celular = $('#celular').val();

    if (nombre_usuario === '') {
        alert("Verifique el usuario");
        $('#nombre_usuario').focus();
    }

    if (password === '') {
        alert("Verifique el password");
        $('#password').focus();
    }

    if (password_confirm === '') {
        alert("Verifique la confirmación del password");
        $('#password_confirm').focus();
    }

    if (password !== password_confirm) {
        alert("Las contraseñas no coinciden");
        $('#password_confirm').focus();
    }

    if (nombre === '') {
        alert("Verifique el nombre");
        $('#nombre').focus();
    }

    if (apellido === '') {
        alert("Verifique el apellido");
        $('#apellido').focus();
    }

    if (email === '') {
        alert("Verifique el email");
        $('#email').focus();
    }

    if (celular === '') {
        alert("Verifique el celular");
        $('#celular').focus();
    }

    var usuario = { nombre: nombre, apellido: apellido, nombre_usuario: nombre_usuario, password: password, email: email, celular: celular };

    $.ajax({
        url: RegistrarUsuarioParams.registrarUsuarioURL,
        data: usuario,
        success: function (data) {
           
                $('#lblRespuesta').text(data.Mensaje);
            
        },
        error: function (err) {
            console.log(err);
        }
    });
    

});
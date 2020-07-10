function crearPagina() {
    var nombre = $('#nombre').val();
    var menu = $('#menu').val();
    var controlador = $('#controlador').val();
    var accion = $('#accion').val();
    var orden = $('#orden').val();
    var icono = $('#icono').val();

    if (nombre === '') {
        bootbox.alert("Debe ingresar un nombre", function () { $('#nombre').focus() });
        return;
    }

    if (menu === '') {
        bootbox.alert("Debe ingresar un menú", function () { $('#menu').focus() });
        return;
    }

    if (controlador === '') {
        bootbox.alert("Debe ingresar un controlador", function () { $('#controlador').focus() });
        return;
    }

    if (accion === '') {
        bootbox.alert("Debe ingresar una acción", function () { $('#accion').focus() });
        return;
    }

    if (orden === '') {
        bootbox.alert("Debe ingresar un orden", function () { $('#orden').focus() });
        return;
    }

    if (icono === '') {
        bootbox.alert("Debe ingresar un icono", function () { $('#icono').focus() });
        return;
    }

    var pagina = {nombre: nombre, menu: menu, controlador: controlador, accion: accion, orden: orden, icono: icono}

    $.ajax({
        url: nuevaPaginaParams.crearURL,
        data: pagina,
        success: function (data) {
            if (data.Error) {
                bootbox.alert(data.Mensaje);
            }
            else {
                cerrarModal();
            }
        },
        error: function (err) {
            console.log(err);
        }
    });
}

function cerrarModal() {
    $.colorbox.close();
}
function agregarPagina(idRol, idPagina) {

    $.ajax({
        url: RolPaginasParams.agregarPaginaRolURL + "?id_rol=" + idRol + "&id_pagina=" + idPagina,
        beforeSend: function () {
            agregarBotonProcesando(idPagina, "Agregando...", "btn btn-eliminar");
        },
        success: function (data) {
            if (!data.Error) {
                var btn = $('#' + idPagina);
                btn.html("Quitar");
                btn.removeProp('disabled');
                btn.removeClass('btn-primario');
                btn.addClass('btn-eliminar');
                btn.attr("onclick", "quitarPagina(" + idRol + "," + idPagina + ")");


            }
            else {
                bootbox.alert(data.Mensaje)
            }
        }
    });

    
}

function quitarPagina(idRol, idPagina) {
    $.ajax({
        url: RolPaginasParams.quitarPaginaRolURL + "?id_rol=" + idRol + "&id_pagina=" + idPagina,
        beforeSend: function () {
            agregarBotonProcesando(idPagina, "Quitando...", "btn btn-primario");
        },
        success: function (data) {
            if (!data.Error) {
                var btn = $('#' + idPagina);
                btn.html("Agregar");
                btn.removeProp('disabled');
                btn.removeClass('btn-eliminar');
                btn.addClass('btn-success');
                btn.attr("onclick", "agregarPagina(" + idRol +"," + idPagina +")");
            }
            else {
                bootbox.alert(data.Mensaje)
            }
        }
    });
    
}

function agregarBotonProcesando(idBoton, mensaje, cssClass) {
    var btn = $('#' + idBoton);
    btn.html(mensaje);
    btn.prop('disabled','disabled');
}
tablelang = {
    'oPaginate': {
        'sNext': 'Siguiente',
        'sPrevious': 'Anterior'
    },
    'sLengthMenu': 'Mostar _MENU_ registros',
    'sInfo': 'Registros del _START_ al _END_  -  Total: _TOTAL_',
    'sSearch': 'Buscar:',
    'sEmptyTable': 'No hay registros en la tabla',
    'sInfoEmpty': 'No hay registros filtrados',
    'sInfoFiltered': ' de un total de _MAX_ ',
    'sZeroRecords': 'No hay registros para mostrar'
};

$(document).ready(function () {

    $.extend(jQuery.fn.dataTableExt.oSort, {
        "date-uk-pre": function (a) {
            if (a == null || a == "") {
                return 0;
            }
            var ukDatea = a.split('/');
            return (ukDatea[2] + ukDatea[1] + ukDatea[0]) * 1;
        },
        "date-uk-asc": function (a, b) {
            return ((a < b) ? -1 : ((a > b) ? 1 : 0));
        },
        "date-uk-desc": function (a, b) {
            return ((a < b) ? 1 : ((a > b) ? -1 : 0));
        }
    });


    $('body').find('input[data-behavior=date]').each(function () {
        if ($(this).attr('data-active') == "true") {
            $(this).datetimepicker({
                timepicker: false,
                format: 'd/m/Y'
            });
        }
    });

    $('input[data-behavior]').bind('paste', function (e) {
        try {
            var parsedNumber = "";
            switch ($(this).attr('data-behavior')) {
                case 'number':
                    if (e.originalEvent.clipboardData.getData('text').includes(',') || e.originalEvent.clipboardData.getData('text').includes('.'))
                        return false;
                    parsedNumber = parseInt(e.originalEvent.clipboardData.getData('text'));
                    break;
                case 'float':
                    if (e.currentTarget.value.includes(',') || e.currentTarget.value.includes('.')) {
                        if (e.originalEvent.clipboardData.getData('text').includes(',') || e.originalEvent.clipboardData.getData('text').includes('.')) {
                            return false;
                        }
                    }
                    parsedNumber = parseFloat(e.originalEvent.clipboardData.getData('text'));
                    break;
            }
            if (isNaN(parsedNumber) || parsedNumber == null || parsedNumber == undefined || parsedNumber == "")
                return false;
        }
        catch (err) {
            return false;
        }
    });

    $('input[data-behavior]').keypress(function (tecla) {
        input = $(this).attr('data-behavior');

        switch (input) {
            case 'number':
                if (tecla.keyCode == 8 || tecla.keyCode == 46 || tecla.keyCode == 37 || tecla.keyCode == 39 || tecla.keyCode == 36
                    || tecla.keyCode == 116 || tecla.keyCode == 9 || tecla.keyCode == 16 || tecla.keyCode == 35) return true;
                if (tecla.charCode < 48 || tecla.charCode > 57) return false;
                break;
            case 'float':
                if (tecla.keyCode == 8 || tecla.keyCode == 46 || tecla.keyCode == 37 || tecla.keyCode == 39 || tecla.keyCode == 36
                    || tecla.keyCode == 116 || tecla.keyCode == 9 || tecla.keyCode == 16 || tecla.keyCode == 35) return true;
                if (tecla.charCode == 46 && $(this).val().indexOf('.') != -1) return false;
                if ((tecla.charCode < 48 || tecla.charCode > 57) && tecla.charCode != 46) {
                    return false;
                }

                break;
        }
    });

    


});

Number.prototype.format = function (n, x, s, c) {
    var re = '\\d(?=(\\d{' + (x || 3) + '})+' + (n > 0 ? '\\D' : '$') + ')',
        num = this.toFixed(Math.max(0, ~~n));

    return (c ? num.replace('.', c) : num).replace(new RegExp(re, 'g'), '$&' + (s || ','));
};



function FechaYMD(fecha) {
    var ar_fecha = fecha.split('/')
    var dia = ar_fecha[0];
    var mes = ar_fecha[1];
    var anio = ar_fecha[2];
    if (dia.length > 2) {
        var aux = dia;
        dia = anio;
        anio = aux;
    }
    return anio + '/' + mes + '/' + dia;
};

function FechaDMY(fecha) {
    var ar_fecha = fecha.split('/')
    var dia = parseInt(ar_fecha[0]) < 10 ? '0' + ar_fecha[0] : ar_fecha[0];
    var mes = parseInt(ar_fecha[1]) < 10 ? '0' + ar_fecha[1] : ar_fecha[1];
    var anio = ar_fecha[2];
    return dia + '/' + mes + '/' + anio;
};

function FechaActualDMY() {
    var f = new Date();
    return ((parseInt(f.getDate()) < 10 ? '0' + f.getDate() : f.getDate()) + '/' + ((parseInt(f.getMonth()) + 1) < 10 ? '0' + (parseInt(f.getMonth()) + 1) : (parseInt(f.getMonth()) + 1)) + '/' + f.getFullYear());
};

function CompareDate(Date1, Date2) {
    var parts_d1 = Date1.split('/');
    var d1 = new Date(parts_d1[2], parts_d1[1] - 1, parts_d1[0]);
    var parts_d2 = Date2.split('/');
    var d2 = new Date(parts_d2[2], parts_d2[1] - 1, parts_d2[0]);
    if (d1 > d2)
        return 1;
    else {
        if (d1 < d2)
            return -1;
        else
            return 0;
    }
};



$.fn.Tabs = function (accion) {
    var tab = $(this);
    tab.prop('id', tab.prop('id') + accion);
    var titles = '<div class="tab-select tab-select' + tab.prop("id") + '"></div>';
    var selecttab;
    tab.before(titles);
    tab.find('.tab-content').each(function () {
        var content = $(this);
        content.css('display', 'none');
        $('<span class="tab-title tab-title' + tab.prop("id") + '"></span>')
            .html($(this).attr('data-tab'))
            .appendTo('.tab-select' + tab.prop("id"))
            .bind('click', function () {
                $('.tab-title' + tab.prop("id")).each(function () { $(this).removeClass('tab-active') });
                selecttab = $(this);
                $(selecttab).addClass('tab-active');
                tab.find('.tab-content').each(function () {
                    if ($(this).prop('id') == content.prop('id'))
                        $(this).css('display', 'block');
                    else
                        $(this).css('display', 'none');
                });
            });
    });
    tab.children('.tab-content').first().css('display', 'block');
    $('.tab-title' + tab.prop("id")).first().addClass('tab-active');
};



$.fn.ToogleFilters = function (TagFilter) {
    $(this).toggle(function () {
        $('.dataTables_wrapper').css({ 'border-radius': '0 0 5px 5px', 'border-top': '0' });
        $(TagFilter).css('display', 'block');
        $('#' + $(this).attr("id") + '_Filter').removeClass("fa fa-sort-desc").addClass("fa fa-sort-asc");
    }, function () {
        $('.dataTables_wrapper').css({ 'border-radius': '5px', 'border-top': '1px solid #bbb' });
        $(TagFilter).css('display', 'none');
        $('#' + $(this).attr("id") + '_Filter').removeClass("fa fa-sort-asc").addClass("fa fa-sort-desc");
    });
}



//--------------------------
function getAllParameters(ctrl, parameters) {
    var params = parameters || {};
    $(ctrl).children('div .tab-content').children('div').each(function (index) {



        if ($(this).attr('data-param') == 'true') {

            var k = $(this).children('div').children('b').html();
            var v;
            if ($(this).children('div').children().is('input[type=text]')) {
                if ($(this).children('div').children().is('input[data-behavior=date]')) {
                    v = typeof $(this).children('div').children('input').val() != "undefined" ? FechaYMD($(this).children('div').children('input').val()) : null;
                }
                else {
                    v = $(this).children('div').children('input').val().trim() != '' ? $(this).children('div').children('input').val() : null;
                }
            }
            if ($(this).children('div').children().is('textarea')) {
                v = $(this).children('div').children('textarea').val().trim() != '' ? $(this).children('div').children('textarea').val() : null;
            }
            if ($(this).children('div').children().is('select')) {
                v = $.parseJSON($(this).children('div').children('select').val());
            }
            if ($(this).children('div').children().is('input[type=checkbox]')) {
                v = $(this).children('div').children('input[type=checkbox]').prop('checked')
            }
            if ($(this).children('div').children().is('table')) {
                k = $(this).parent().attr('data-member');
                tableName = $('#' + $(this).children('div').children('table').prop('id')).DataTable();
                var rows = new Array();
                $.each(tableName.rows('.selected').data(), function (i, v) {
                    rows.push(JSON.parse(v.Key));
                });
                v = rows;
            }
            params[k] = v;
        }

    });
    //});
    return params;
};

//---------------------------


function viewModalNew(nameModal, controller, widthModal, heightModal, titleModal, extraParams, tableName, ctrlParams, fnReloadComplete) {
    btns = [
        { text: 'Aceptar', cssClass: 'btn-modal-primary', result: 'ACEPTAR' }//,
    ];
    nameModal = app.ui.Modal.load(
        '../' + controller + '/NewModal',
        {},
        btns,
        { width: widthModal, height: heightModal, title: titleModal },
        function (result) {
            if (result == 'ACEPTAR' && (typeof validateParams !== undefined ? validateParams('New') : true)) {
                app.ui.Submit(
                    '../' + controller + '/Create',
                    { data: JSON.stringify(getAllParameters(ctrlParams + 'New', extraParams)) },
                    function (response) {
                        if (response == 1) {
                            app.ui.modalManager.removeModal(nameModal);
                            if (fnReloadComplete != null && fnReloadComplete != undefined)
                                tableName.ajax.reload(fnReloadComplete);
                            else
                                tableName.ajax.reload();
                        }
                    }
                );
            };

            if (result == 'NUEVO' && (typeof validateParams !== undefined ? validateParams('New') : true)) {
                app.ui.Submit(
                    '../' + controller + '/Create',
                    { data: JSON.stringify(getAllParameters(ctrlParams + 'New', extraParams)) },
                    function (response) {
                        if (response == 1) {
                            if (fnReloadComplete != null && fnReloadComplete != undefined)
                                tableName.ajax.reload(fnReloadComplete);
                            else
                                tableName.ajax.reload();
                        }
                    }
                );
            };
        },
        null,
        null
    );
    app.ui.modalManager.addModal(nameModal);
};

function viewModalEdit(nameModal, controller, params, extraParams, widthModal, heightModal, tableName, ctrlParams, fnReloadComplete) {
    btns = [{ text: 'Cancelar', cssClass: 'btn-modal-primary', result: 'CANCELAR', onClick: 'app.ui.modalManager.removeModal(app.ui.modalManager.currentModal())' },
    { text: 'Aceptar', cssClass: 'btn-modal-primary', result: 'ACEPTAR' }
    ];
    nameModal = app.ui.Modal.load(
        '../' + controller + '/EditModal',
        params,
        btns,
        { width: widthModal, height: heightModal, title: 'Editar' },
        function (result) {
            if (result == 'ACEPTAR' && (typeof validateParams !== undefined ? validateParams('Edit') : true)) {
                //validateParams = undefined;
                app.ui.Submit("../" + controller + "/Update", { data: JSON.stringify(getAllParameters(ctrlParams, extraParams)) },
                    function (response) {
                        if (response == 1) {
                            app.ui.modalManager.closeAllModal();
                            if (fnReloadComplete != null && fnReloadComplete != undefined)
                                tableName.ajax.reload(fnReloadComplete);
                            else
                                tableName.ajax.reload();
                        }
                    });
            }
        },
        null,
        null
    );
    app.ui.modalManager.addModal(nameModal);
};

function viewModalDelete(nameModal, controller, params, extraParams, widthModal, heightModal, tableName, ctrlParams, fnReloadComplete) {
    btns = [{ text: 'Cancelar', cssClass: 'btn-modal-primary', result: 'CANCELAR', onClick: 'app.ui.modalManager.removeModal(app.ui.modalManager.currentModal())' },
    { text: 'Aceptar', cssClass: 'btn-modal-primary', result: 'ACEPTAR' }
    ];
    nameModal = app.ui.Modal.load(
        '../' + controller + '/DeleteModal',
        params,
        btns,
        { width: widthModal, height: heightModal, title: 'Dar de Baja' },
        function (result) {
            if (result == 'ACEPTAR') {
                app.ui.Submit("../" + controller + "/Delete", { data: JSON.stringify(getAllParameters(ctrlParams, extraParams)) },
                    function (response) {
                        if (response == 1) {
                            app.ui.modalManager.closeAllModal();
                            if (fnReloadComplete != null && fnReloadComplete != undefined)
                                tableName.ajax.reload(fnReloadComplete);
                            else
                                tableName.ajax.reload();
                        }
                    });
            }
        },
        null,
        null
    );
    app.ui.modalManager.addModal(nameModal);
};

function viewModalGeneric(nameModal, controller, params, active, extraParams, widthModal, heightModal, titleModal, tableName, ctrlParams, fnReloadComplete) {
    if (active == '' || active == null || active == undefined) {
        btns = [{ text: 'Dar de Baja', cssClass: 'btn-modal-primary', result: 'ELIMINAR' },
        { text: 'Editar', cssClass: 'btn-modal-primary', result: 'EDITAR' }
        ];
    }
    else {
        btns = [{ text: '--- Registro dado de baja ---', cssClass: 'btn-modal-message', result: '' },
        ];
    };

    nameModal = app.ui.Modal.load(
        '../' + controller + '/DetailsModal',
        params,
        btns,
        { width: widthModal, height: heightModal, title: titleModal },
        function (result) {
            if (result == 'EDITAR') {
                viewModalEdit(nameModal + 'Edit', controller, params, extraParams, widthModal, heightModal, tableName, ctrlParams + 'Edit', fnReloadComplete);
            }
            if (result == 'ELIMINAR') {
                viewModalDelete(nameModal + 'Delete', controller, params, extraParams, widthModal, heightModal, tableName, ctrlParams + 'Delete', fnReloadComplete);
            }
        },
        null,
        null
    );
    app.ui.modalManager.addModal(nameModal);
};

function viewModal(nameModal, controller, method, params, btns, widthModal, heightModal, titleModal) {
    nameModal = app.ui.Modal.load(
        '../' + controller + '/' + method,
        params,
        btns,
        { width: widthModal, height: heightModal, title: titleModal },
        null,
        null,
        null
    );
    app.ui.modalManager.addModal(nameModal);
};

$.fn.dataTable.Api.register('sum()', function () {
    return this.flatten().reduce(function (a, b) {
        if (typeof a === 'string') {
            a = a.replace(",", ".");
            a = a.replace(/[^\d.-]/g, '') * 1;

        }
        if (typeof b === 'string') {
            b = b.replace(",", ".");
            b = b.replace(/[^\d.-]/g, '') * 1;
        }

        return a + b;
    }, 0);
});

function validateParams(action) {
    return true;
};

function loadCombo(ctrl, methodController, filters, valueSelected) {
    var data = {};
    $.extend(data, { data: filters });
    $.ajax({
        url: methodController,
        data: data,
        async: false,
        type: 'POST',
        dataType: 'json',
        success: function (dato) {
            $(ctrl).empty();
            $.each(dato, function (i, item) {
                $(ctrl).append($('<option></option>').val(item.Value).html(item.Text));
            });

        },
        error: function (data, status, jqXHR) {
        },
        complete: function () {
            if (valueSelected != null && valueSelected != undefined)
                $(ctrl).val(valueSelected);
        }
    });

};
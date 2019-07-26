(function (window) {
    // Funcion de inicialización
    function fnInit() {
        this.version = 1.0;
        this.action_param = 'action';
    }

    var app = new fnInit();


    app.ui = {
        BeforeSend: function () {
            $('body').append('<div id=\"over\"> <div class=\"overlay\"></div> <div class=\"container-overlay\"> <div class=\"content-overlay\"> <div class=\"spinner\"> <i class=\"fa fa-spinner fa-spin fa-4x\"></i> <div><b>PROCESANDO...</b></div> </div> </div> </div> </div>');
        },
        AfterSend: function () {
            setTimeout(function () { $('#over').remove(); }, 350);
        },


        DelayMessage: function (message, delayclass) {
            $("<div class='" + delayclass + "'>" + message + "</div>").css({ 'left': FixLeft(message) }).appendTo('body').delay(2000).fadeOut('fast', function () { $(this).remove(); });
            function FixLeft(m) {
                var res = (($(window).width() - (m.length * 7.4) - 40)) / 2;
                return res + 'px';
            };
        },

        CustomDelayMessage: function (message, delayclass, DelayTime/*Milliseconds*/) {
            $("<div class='" + delayclass + "'>" + message + "</div>").css({ 'left': FixLeft(message) }).appendTo('body').delay(DelayTime).fadeOut('fast', function () { $(this).remove(); });
            function FixLeft(m) {
                var res = (($(window).width() - (m.length * 7.4) - 40)) / 2;
                return res + 'px';
            };
        },

        ExportExcel: function (table, params, title) {

            var JSONData = table.rows().data();
            var Data = typeof JSONData != 'object' ? JSON.parse(JSONData) : JSONData;

            HeaderTypes = {};
            for (var i = 0; i < params.length; i++) {
                HeaderTypes[params[i]] = 'String';
            }
            var TitleData = '<Row ss:Height="25">\n' +
                '<Cell ss:StyleID="s26" ss:MergeAcross="' + (params.length - 1) + '">' +
                '<Data ss:Type="String">' +
                title + '</Data>' +
                '</Cell>' +
                '</Row>\n';

            var headerRow = '<Row ss:Height="21">\n';
            for (var colName in HeaderTypes) {
                headerRow += '<Cell ss:StyleID="s25">';
                headerRow += '<Data ss:Type="String">';
                headerRow += colName + '</Data>';
                headerRow += '</Cell>';
            }
            headerRow += '</Row>\n';

            var xml = '<?xml version="1.0" encoding="none"?>\n' +
                '<?mso-application progid="Excel.Sheet"?>\n' +
                '<Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"\n' +
                'xmlns:o="urn:schemas-microsoft-com:office:office"\n' +
                'xmlns:x="urn:schemas-microsoft-com:office:excel"\n' +
                'xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet"\n' +
                'xmlns:html="http://www.w3.org/TR/REC-html40">\n' +
                '<Styles>\n' +
                '<Style ss:ID="Default" ss:Name="Normal">\n' +
                '<Alignment ss:Vertical="Bottom"/>\n' +
                '<Borders/>\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="11" ss:Color="#000000"/>\n' +
                '<Interior/>\n' +
                '<NumberFormat/>\n' +
                '<Protection/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s25">\n' +
                '<Borders>\n' +
                '<Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1"/>\n' +
                '</Borders>\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="11" ss:Color="#333333" ss:Bold="1"/>\n' +
                '<Interior ss:Color="#C0C0C0" ss:Pattern="Solid"/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s26">\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="14" ss:Bold="1"/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s27">\n' +
                '<Borders>\n' +
                '<Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="0.2"/>\n' +
                '</Borders>\n' +
                '</Style>\n' +
                '</Styles>\n' +
                '<Worksheet ss:Name="Hoja1">\n' +
                '<Table>\n' + TitleData + headerRow;


            for (var i = 0; i < Data.length; i++) {
                xml += '<Row>\n';
                for (var index in Data[i]) {
                    if ($.inArray(index, params) != -1) {
                        xml += '<Cell ss:StyleID="s27" >';
                        if (Data[i][index] % 1 == 0 || Data[i][index].replace(',', '.') % Data[i][index].replace(',', '.') == 0) {//index.toString() == 'Total' || index.toString() == 'Monto' || index.toString() == 'Importe'
                            xml += '<Data ss:Type="Number">';
                            xml += Data[i][index].replace(',', '.') + '</Data>';
                        }
                        else {
                            xml += '<Data ss:Type="String">';
                            xml += Data[i][index] + '</Data>';
                        }
                        xml += '</Cell>\n';

                    }
                }
                xml += '</Row>\n';
            }

            xml += '</Table>\n' +
                '</Worksheet>\n' +
                '</Workbook>';

            var link = document.createElement("a");
            var blob = new Blob([xml], {
                'type': 'application/vnd.ms-excel'
            });
            link.href = window.URL.createObjectURL(blob);
            link.style = "visibility:hidden";

            var fileName = (title + '_' + new Date().toLocaleString()).replace(/ /g, "_");

            link.download = fileName;//+ ".xls";

            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        },

        ExportExcelConPuntos: function (table, params, title) {

            var JSONData = table.rows().data();
            var Data = typeof JSONData != 'object' ? JSON.parse(JSONData) : JSONData;

            HeaderTypes = {};
            for (var i = 0; i < params.length; i++) {
                HeaderTypes[params[i]] = 'String';
            }
            var TitleData = '<Row ss:Height="25">\n' +
                '<Cell ss:StyleID="s26" ss:MergeAcross="' + (params.length - 1) + '">' +
                '<Data ss:Type="String">' +
                title + '</Data>' +
                '</Cell>' +
                '</Row>\n';

            var headerRow = '<Row ss:Height="21">\n';
            for (var colName in HeaderTypes) {
                headerRow += '<Cell ss:StyleID="s25">';
                headerRow += '<Data ss:Type="String">';
                headerRow += colName + '</Data>';
                headerRow += '</Cell>';
            }
            headerRow += '</Row>\n';

            var xml = '<?xml version="1.0" encoding="none"?>\n' +
                '<?mso-application progid="Excel.Sheet"?>\n' +
                '<Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"\n' +
                'xmlns:o="urn:schemas-microsoft-com:office:office"\n' +
                'xmlns:x="urn:schemas-microsoft-com:office:excel"\n' +
                'xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet"\n' +
                'xmlns:html="http://www.w3.org/TR/REC-html40">\n' +
                '<Styles>\n' +
                '<Style ss:ID="Default" ss:Name="Normal">\n' +
                '<Alignment ss:Vertical="Bottom"/>\n' +
                '<Borders/>\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="11" ss:Color="#000000"/>\n' +
                '<Interior/>\n' +
                '<NumberFormat/>\n' +
                '<Protection/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s25">\n' +
                '<Borders>\n' +
                '<Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1"/>\n' +
                '</Borders>\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="11" ss:Color="#333333" ss:Bold="1"/>\n' +
                '<Interior ss:Color="#C0C0C0" ss:Pattern="Solid"/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s26">\n' +
                '<Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="14" ss:Bold="1"/>\n' +
                '</Style>\n' +
                '<Style ss:ID="s27">\n' +
                '<Borders>\n' +
                '<Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="0.2"/>\n' +
                '</Borders>\n' +
                '</Style>\n' +
                '</Styles>\n' +
                '<Worksheet ss:Name="Hoja1">\n' +
                '<Table>\n' + TitleData + headerRow;


            for (var i = 0; i < Data.length; i++) {
                xml += '<Row>\n';
                for (var index in Data[i]) {
                    if ($.inArray(index, params) != -1) {
                        xml += '<Cell ss:StyleID="s27" >';
                        if (Data[i][index] % 1 == 0 || Data[i][index].replace(',', '.') % Data[i][index].replace(',', '.') == 0) {//index.toString() == 'Total' || index.toString() == 'Monto' || index.toString() == 'Importe'
                            xml += '<Data ss:Type="String">';
                            xml += Data[i][index].replace(',', '.') + '</Data>';
                        }
                        else {
                            xml += '<Data ss:Type="String">';
                            xml += Data[i][index] + '</Data>';
                        }
                        xml += '</Cell>\n';


                    }
                }
                xml += '</Row>\n';
            }

            xml += '</Table>\n' +
                '</Worksheet>\n' +
                '</Workbook>';

            var link = document.createElement("a");
            var blob = new Blob([xml], {
                'type': 'application/vnd.ms-excel'
            });
            link.href = window.URL.createObjectURL(blob);
            link.style = "visibility:hidden";

            var fileName = (title + '_' + new Date().toLocaleString()).replace(/ /g, "_");

            link.download = fileName;//+ ".xls";

            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        },

        ExportPDF: function (table, params, title) {

            var xml = '<?xml version="1.0" encoding="iso-8859-1"?>\n' +
                '  <xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0" xmlns:fo="http://www.w3.org/1999/XSL/Format">\n' +
                '    <xsl:template match="/">\n' +
                '      <fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format">\n' +
                '        <fo:layout-master-set>\n' +
                '          <fo:simple-page-master master-name="page" page-height="29.7cm" page-width="21cm" margin-top="1cm" margin-bottom="2cm" margin-left="2.5cm" margin-right="2.5cm" >\n' +
                '            <fo:region-before extent="3cm"/>\n' +
                '            <fo:region-body margin-top="3cm"/>\n' +
                '            <fo:region-after extent="1.5cm"/>\n' +
                '          </fo:simple-page-master>\n' +
                '          <fo:page-sequence-master master-name="all">\n' +
                '            <fo:repeatable-page-master-alternatives>\n' +
                '              <fo:conditional-page-master-reference master-reference="page" page-position="first"/>\n' +
                '            </fo:repeatable-page-master-alternatives>\n' +
                '          </fo:page-sequence-master>\n' +
                '        </fo:layout-master-set>\n' +
                '        <fo:page-sequence master-reference="all">\n' +
                '          <fo:flow flow-name="xsl-region-body">\n' +
                '            <fo:block><xsl:apply-templates/></fo:block>\n' +
                '          </fo:flow>\n' +
                '        </fo:page-sequence>\n' +
                '      </fo:root>\n' +
                '    </xsl:template>\n' +
                '    <xsl:template match="p">\n' +
                '      <fo:block><xsl:apply-templates/></fo:block>\n' +
                '    </xsl:template>\n' +
                '    <xsl:template match="s1">\n' +
                '      <fo:block font-size="24pt" color="red" font-weight="bold">\n' +
                '        <xsl:apply-templates select="@title"/>\n' +
                '          </fo:block>\n' +
                '        <xsl:apply-templates/>\n' +
                '    </xsl:template>\n' +
                '  </xsl:stylesheet>\n';

            var link = document.createElement("a");
            var blob = new Blob([xml], {
                'type': 'application/pdf'
            });
            link.href = window.URL.createObjectURL(blob);
            link.style = "visibility:hidden";

            var fileName = (title + '_' + new Date().toLocaleString()).replace(/ /g, "_");
            link.download = fileName + ".pdf";

            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        },

        SucursalSubmit: function (url, data) {
            app.ui.BeforeSend();
            $.ajax({
                url: url,
                data: data,
                type: 'POST',
                dataType: 'text',
                success: function (dato) {
                    location.href = dato;
                    app.ui.AfterSend();
                },
                error: function (dato, status, jqXHR) {

                    app.ui.DelayMessage('Ha ocurrido un error inesperado.', 'message-error');
                    app.ui.AfterSend();
                }
            });
        },


        stringSubmit: function (url, data, fnResponse) {
            app.ui.BeforeSend();
            $.ajax({
                url: url,
                data: data,
                type: 'POST',
                dataType: 'text',
                success: function (dato) {
                    if (dato == "ok") {
                        app.ui.DelayMessage('La operación se ejecutó con éxito.', 'message-info');
                        if (fnResponse != null)
                            fnResponse(1);
                    } else if (dato == "ko") {
                        if (fnResponse != null)
                            fnResponse(1);
                    }
                    else {
                        app.ui.CustomDelayMessage(dato.includes('||') ? dato.split('||')[1] : 'La operación no se ejecutó con éxito.', 'message-error', 4000);
                        if (fnResponse != null)
                            fnResponse(0);
                    }
                    app.ui.AfterSend();
                },
                error: function (dato, status, jqXHR) {
                    app.ui.DelayMessage('Ha ocurrido un error inesperado.', 'message-error');
                    if (fnResponse != null)
                        fnResponse(-1);
                    app.ui.AfterSend();
                }
            });
        },

        SesionSubmit: function (url, data) {
            app.ui.BeforeSend();
            $.ajax({
                url: url,
                data: data,
                type: 'POST',
                dataType: 'text',
                success: function (dato) {
                    if (dato == "false") {
                        app.ui.DelayMessage('Usuario o Contraseña inválidos.', 'message-info');
                    }
                    else {
                        location.href = dato;
                    }
                    app.ui.AfterSend();
                },
                error: function (dato, status, jqXHR) {
                    app.ui.DelayMessage('Ha ocurrido un error inesperado.', 'message-error');
                    app.ui.AfterSend();
                }
            });
        },

        DataSubmit: function (url, data, fnResponse) {
            app.ui.BeforeSend();
            $.ajax({
                url: url,
                data: data,
                type: 'POST',
                dataType: 'json',
                async: false,
                success: function (dato) {
                    if (dato.status == "success") {
                        app.ui.DelayMessage("La acción se ejecutó exitosamente", "message-succes");
                        if (fnResponse != null)
                            fnResponse(dato);
                    }
                    else {
                        messages = dato.message.split('.');
                        htmlMjs = '';
                        for (i = 0; i < messages.length; i++) {
                            htmlMjs += '<div>' + messages[i] + '</div>';
                        }
                        app.ui.CustomDelayMessage(htmlMjs, "message-info", 4000);
                        if (fnResponse != null)
                            fnResponse(0);
                    }
                    app.ui.AfterSend();
                },
                error: function (dato, status, jqXHR) {
                    app.ui.DelayMessage("Ha ocurrido un error inesperado", "message-error");//
                    if (fnResponse != null)
                        fnResponse(-1);
                    app.ui.AfterSend();
                }
            });
        },

        Submit: function (url, data, fnResponse) {
            app.ui.BeforeSend();
            $.ajax({
                url: url,
                data: data,
                type: 'POST',
                dataType: 'json',
                success: function (dato) {
                    if (dato.status == "success") {
                        app.ui.DelayMessage("La acción se ejecutó exitosamente", "message-succes");
                        if (fnResponse != null)
                            fnResponse(1);
                    }
                    else {
                        messages = dato.message.split('.');
                        htmlMjs = '';
                        for (i = 0; i < messages.length; i++) {
                            htmlMjs += '<div>' + messages[i] + '</div>';
                        }
                        app.ui.DelayMessage(htmlMjs, "message-info");
                        if (fnResponse != null)
                            fnResponse(0);
                    }
                    app.ui.AfterSend();
                },
                error: function (dato, status, jqXHR) {
                    app.ui.DelayMessage("Ha ocurrido un error inesperado", "message-error");
                    if (fnResponse != null)
                        fnResponse(-1);
                    app.ui.AfterSend();
                }
            });
        },

        modalManager: function () {
            var method = {},
                count = 0,
                lifo = new Array()

            method.addModal = function (m) {
                lifo.push(m);
                count++;
                $(m.close).bind('click', function () { app.ui.modalManager.removeModal(m) });

                $(m.container).trigger('beforeOpen');

                m.container.css('zIndex', 100000 + count);
                m.overlay.css('zIndex', 100000 + count);

                m.title.append(m.options.title);

                switch (m.options.type) {
                    case 'info':
                        msg = $('<div style="float:left; margin: 10px 30px">' + m.options.msg + '</div>');
                        html = $('<div></div>');
                        html.empty().append(msg);

                        m.setContent(html);
                        break;

                    case 'error':
                        icono = $('<i class="fa fa-info-circle fa-4x"></i>');
                        msg = $('<div style="float:left; margin: 10px 20px">' + m.options.msg + '</div>');
                        html = $('<div></div>');
                        html.empty().append(msg, icono);

                        m.setContent(html);
                        break;

                    case 'confirm':
                        msg = $('<div style="float:left; margin: 10px 20px">' + m.options.msg + '</div>');
                        html = $('<div></div>');
                        html.empty().append(msg);

                        m.setContent(html);
                        break;

                    case 'load':
                        html = $('<div></div>');
                        app.ui.BeforeSend();
                        var request = {
                            url: m.options.url,
                            data: { data: m.options.params },
                            dataType: 'html',
                            cache: false,
                            error: function (request, status, error) {
                                m.setContent('No se puede cargar el contenido.');
                                app.ui.AfterSend();
                            },
                            success: function (html) {
                                m.setContent(html);
                                app.ui.AfterSend();
                            }
                        };
                        $.ajax(request);

                        break;

                }

                $('body').css('overflow', 'hidden');

                $('body').append(m.overlay, m.container);

                $(window).bind('resize', function () { m.resize(); });


                $('body').off('keydown').on('keydown', this, function (e) {
                    if (e.keyCode == 27) {
                        app.ui.modalManager.removeModal(lifo[count - 1]);
                        e.preventDefault();
                    }
                });

                m.options.viewport = m.viewport($(m.container));
                m.container.css({ top: m.options.viewport.top, left: m.options.viewport.left });
            };

            method.removeModal = function (m) {
                $('body').css('overflow', 'visible');

                $(m.container).trigger('beforeClose');

                $(m.container).unbind('beforeOpen');
                $(m.container).unbind('beforeClose');

                m.clearValue();
                lifo.pop(m);
                count--;

                $(window).unbind('resize', function () { m.resize(); });
                $('body').off('keydown', this);

                setTimeout(function () {
                    $(m.content).empty();
                    $(m.foot).empty();
                    $(m.container).remove();
                    $(m.overlay).remove();
                }, 0);//300

            };

            method.currentModal = function () {
                return lifo[count - 1];
            };

            method.currentModal.addValue = function (value) {
                lifo[count - 1].value[lifo[count - 1].value.length] = value;
            };

            method.getModal = function (index) {
                if (lifo.length == 0 || index < 0 || index >= lifo.length)
                    alert('Indice fuera de rango')
                else
                    return lifo[index];
            };

            method.closeAllModal = function () {
                for (i = lifo.length - 1; i > -1; i--) {
                    app.ui.modalManager.removeModal((app.ui.modalManager.currentModal()));
                }
            };

            return method;
        }()


    };

    app.ui.Modal = function (options, fnProcess, fnBeforeOpen, fnBeforeClose) {
        var t = this;
        t.options = $.extend(app.ui.Modal.prototype.options, options);
        t.overlay = $('<div class="overlay-modal"></div>'),
            t.container = $('<div class="container-modal"></div>');
        t.content = $('<div class="content-modal"></div>');
        t.title = $('<div class="title-modal"></div>');
        t.close = $('<span class="btn-close"><i class="fa fa-sign-out fa-lg"></i></span>');
        t.foot = $('<div class="foot-modal"></div>');

        $(t.container).css({ width: t.options.width, height: t.options.height });
        if (t.options.title == '') {
            $(t.content).css({ width: t.options.width, height: t.options.height - 34 });
        }
        else {
            $(t.title).css({ width: t.options.width, height: 34 });
            $(t.content).css({ width: t.options.width, height: t.options.height - 74 });
        }
        $(t.foot).css({ width: t.options.width, height: 38 });

        switch (t.options.type) {
            case 'info':
                $(t.title).css('background-color', '#67A7D4');
                $(t.content).addClass('info-modal');
                $(t.foot).css('background-color', '#D4D4D4');
                break;

            case 'error':
                $(t.title).css('background-color', '#67A7D4');
                $(t.content).addClass('error-modal');
                $(t.foot).css('background-color', '#D4D4D4');
                break;

            case 'confirm':
                $(t.title).css('background-color', '#67A7D4');
                $(t.content).addClass('info-modal');
                $(t.foot).css('background-color', '#D4D4D4');
                break;

            case 'load':
                $(t.title).css('background-color', '#67A7D4');
                $(t.content).addClass('load-modal');
                $(t.foot).css('background-color', '#D4D4D4');
                break;
        }

        if (fnBeforeOpen != null)
            $(t.container).bind('beforeOpen', fnBeforeOpen);

        if (fnBeforeClose != null)
            $(t.container).bind('beforeClose', fnBeforeClose);

        $.each(t.options.buttons, function (i, val) {
            var btn = $('<button onClick=' + val.onClick + ' class=' + val.cssClass + ' type="button"> ' + val.text + ' </button>').data('result', val.result);
            btn.on('click', function (e) {
                e.preventDefault();
                res = $.data(this, 'result');
                t.process = fnProcess(res);
            });

            $(t.foot).append(btn);
        });


        if (t.options.title == '') {
            $(t.container).append(t.content, t.foot);
        }
        else {
            $(t.title).append(t.close);
            $(t.container).append(t.title, t.content, t.foot);
        }

        return t;
    };

    app.ui.Modal.prototype = {
        value: [],
        process: null,
        options: {
            width: '300px',
            height: 'auto',
            title: '',
            viewport: {},
            buttons: []
        },

        viewport: function () {
            return {
                top: $(window).height() > this.container.height() ? (($(window).height() - this.container.height()) / 2) + $(window).scrollTop() + "px" : 0,
                left: $(window).width() > this.container.width() ? (($(window).width() - this.container.width()) / 2) + $(window).scrollLeft() + "px" : 0
            }

        },

        resize: function () {
            this.options.viewport = this.viewport();
            this.container.css({ top: this.options.viewport.top, left: this.options.viewport.left });
        },

        setContent: function (html) {
            this.content.empty().append(html);
        },

        addValue: function (val) {
            this.value[this.value.length] = val;
        },

        clearValue: function () {
            this.value.length = 0;
        }
    };


    $.extend(app.ui.Modal, {

        info: function (msg, options, fnProcess, fnBeforeOpen, fnBeforeClose) {
            var buttons = [
                { text: 'Aceptar', cssClass: 'btn-modal-primary', result: 'ACEPTAR', onClick: 'app.ui.modalManager.removeModal(app.ui.modalManager.currentModal())' }
            ];
            options = $.extend(options, { type: 'info', title: options.title || '<i class="fa fa-info-circle fa-lg" style="color: #226CC7"></i> Información', msg: msg, buttons: buttons });

            return new app.ui.Modal(options, fnProcess, fnBeforeOpen, fnBeforeClose);
        },

        error: function (msg, options, fnProcess, fnBeforeOpen, fnBeforeClose) {
            var buttons = [
                { text: 'Aceptar', cssClass: 'btn-modal', result: 'ACEPTAR' }
            ];
            options = $.extend(options, { type: 'error', title: options.title || 'Error', msg: msg, buttons: buttons });

            return new app.ui.Modal(options, fnProcess, fnBeforeOpen, fnBeforeClose);
        },

        confirm: function (msg, options, fnProcess, fnBeforeOpen, fnBeforeClose) {
            var buttons = [
                { text: 'Cancelar', cssClass: 'btn-modal-primary', result: 'NO' },
                { text: 'Aceptar', cssClass: 'btn-modal-primary', result: 'SI' },
            ];

            options = $.extend(options, { type: 'confirm', title: options.title || 'Confirmación', msg: msg, buttons: buttons });
            return new app.ui.Modal(options, fnProcess, fnBeforeOpen, fnBeforeClose);
        },

        load: function (url, params, buttons, options, fnProcess, fnBeforeOpen, fnBeforeClose) {
            options = $.extend(options, { type: 'load', title: options.title || '', url: url, params: params, buttons: buttons });

            return new app.ui.Modal(options, fnProcess, fnBeforeOpen, fnBeforeClose)
        }

    });

    window.app = app;
})(window);

$(document).ready(function () {
    //$('#container').height($(window).height() - 155 - $(window).scroll());
    //$('#container').css('min-height', ($(window).height() - 155) + 'px');
    //$('.form-body').css('min-height', ($(window).height() - 215) + 'px');
    //$(window).bind('resize', function () {
    //    $('#container').height($(window).height() - 155 - $(window).scroll());
    //    $('#container').css('min-height', ($(window).height() - 155) + 'px');
    //    $('.form-body').css('min-height', ($(window).height() - 215) + 'px');
    //});

});
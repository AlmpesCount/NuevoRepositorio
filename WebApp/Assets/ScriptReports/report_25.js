    $(document).ready(function () {
        $('#ThirdTable').DataTable({
            "scrollY": 350,
            "scrollX": true,
            "ajax": {
                "url": "/consultareporte/cargarreporte25",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "Periodo", "autoWidth": true },
                { "data": "F_Recep", "autoWidth": true },
                { "data": "NroVenta", "autoWidth": true },
                { "data": "NroVenValida", "autoWidth": true },
                { "data": "LlamadasTotal", "autoWidth": true },
                { "data": "CETTiempo", "autoWidth": true },
                { "data": "NroVueltas", "autoWidth": true },
                { "data": "OKAlmpes", "autoWidth": true },
                { "data": "LlamadasUnico", "autoWidth": true },
                { "data": "CETUnico", "autoWidth": true },
                { "data": "BBDDAcumulado", "autoWidth": true },
                { "data": "RetiroLeads", "autoWidth": true },
                { "data": "BBDDTotal", "autoWidth": true },
                { "data": "AvanceBBDD", "autoWidth": true },
                { "data": "PorcBBDD", "autoWidth": true },
                { "data": "AvanceCET", "autoWidth": true },
                { "data": "AceptacionPorc", "autoWidth": true },
                { "data": "VentasTiempo", "autoWidth": true },
                { "data": "VentasTMO", "autoWidth": true }
            ],
            "language": {
                "sProcessing": "Procesando...",
                "sLengthMenu": "Mostrar _MENU_ registros",
                "sZeroRecords": "No se encontraron resultados",
                "sEmptyTable": "Ningún dato disponible en esta tabla",
                "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
                "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
                "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
                "sInfoPostFix": "",
                "sSearch": "Buscar:",
                "sUrl": "",
                "sInfoThousands": ",",
                "sLoadingRecords": "Cargando...",
                "oPaginate": {
                    "sFirst": "Primero",
                    "sLast": "Último",
                    "sNext": "Siguiente",
                    "sPrevious": "Anterior"
                },
                "oAria": {
                    "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                    "sSortDescending": ": Activar para ordenar la columna de manera descendente"
                }
            },
            initComplete: function () {
                this.api().column(0).every(function () {
                    var column = this;
                    var select = $('<select style=" width: 150px; text-align: center;"><option value=""></option></select>')
                        .appendTo($(column.footer()).empty())
                        .on('change', function () {
                            var val = $.fn.dataTable.util.escapeRegex(
                                $(this).val()
                            );

                            column
                                .search(val ? '^' + val + '$' : '', true, false)
                                .draw();
                        });

                    column.data().unique().sort().each(function (d, j) {
                        select.append('<option value="' + d + '">' + d + '</option>')
                    });
                });
            },
            //Esta parte sirve para sumar las columnas y mostrar esta en el footer de la tabla
            "footerCallback": function (row, data, start, end, display) {
                var api = this.api(), data;

                // Remove the formatting to get integer data for summation
                var intVal = function (i) {
                    return typeof i === 'string' ?
                        i.replace(/[\$,]/g, '') * 1 :
                        typeof i === 'number' ?
                        i : 0;
                };

                // Total over this page
                NVenta = api
                    .column(2, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                NVenValida = api
                    .column(3, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                LlamadasTot = api
                    .column(4, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                LlamadasUnico = api
                    .column(8, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);
                CETUnico = api
                    .column(9, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                BBDDAcum = api
                    .column(10, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                RetiroLeads = api
                    .column(11, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                BBDDTotal = api
                    .column(12, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                VentaTmp = api
                   .column(17, { page: 'current' })
                   .data()
                   .reduce(function (a, b) {
                       return intVal(a) + intVal(b);
                   }, 0);

                VentasTMO = api
                   .column(18, { page: 'current' })
                   .data()
                   .reduce(function (a, b) {
                       return intVal(a) + intVal(b);
                   }, 0);

                // Update footer
                $(api.column(2).footer()).html(
                   NVenta
                );
                $(api.column(3).footer()).html(
                   NVenValida
                );
                $(api.column(4).footer()).html(
                   LlamadasTot
                );
                $(api.column(6).footer()).html(
                   (LlamadasTot / LlamadasUnico).toFixed(1)
                );
                $(api.column(7).footer()).html(
                   ((NVenValida / NVenta) * 100).toFixed(0) + '%'
                );
                $(api.column(8).footer()).html(
                   LlamadasUnico
                );
                $(api.column(9).footer()).html(
                   CETUnico
                );
                $(api.column(10).footer()).html(
                   BBDDAcum
                );
                $(api.column(11).footer()).html(
                   RetiroLeads
                );
                $(api.column(12).footer()).html(
                   BBDDTotal
                );
                $(api.column(13).footer()).html(
                   ((LlamadasUnico / BBDDAcum) * 100).toFixed(0) + '%'
                );
                $(api.column(14).footer()).html(
                   ((LlamadasUnico / BBDDTotal) * 100).toFixed(0) + '%'
                );
                $(api.column(15).footer()).html(
                   ((CETUnico / LlamadasUnico) * 100).toFixed(0) + '%'
                );
                $(api.column(16).footer()).html(
                   ((NVenta / CETUnico) * 100).toFixed(0) + '%'
                );
                $(api.column(17).footer()).html(
                   VentaTmp
                );
                $(api.column(18).footer()).html(
                   (VentaTmp / NVenta).toFixed(2)
                );
            }
        });
    });
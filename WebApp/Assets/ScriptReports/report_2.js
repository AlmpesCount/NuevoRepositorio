$(document).ready(function () {
    $('#SecondTable').DataTable({
        "scrollY": 350,
        "scrollX": true,
        "ajax": {
            "url": "/consultareporte/CargarReporte2",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Zona", "autoWidth": true },
            { "data": "FRecep", "autoWidth": true },
            { "data": "NroVenta", "autoWidth": true },
            { "data": "NroVenValida", "autoWidth": true },
            { "data": "BBDD", "autoWidth": true },
            { "data": "Indecopi", "autoWidth": true },
            { "data": "RetiroLead", "autoWidth": true },
            { "data": "RecorridoReal", "autoWidth": true },
            { "data": "CETReal", "autoWidth": true },
            { "data": "NroVuelta", "autoWidth": true },
            { "data": "PorcCET", "autoWidth": true },
            { "data": "PorcAceptacion", "autoWidth": true },
            { "data": "AvancePorc", "autoWidth": true },
            { "data": "PorcEfectividad", "autoWidth": true },
            { "data": "Recorrido", "autoWidth": true },
            { "data": "CET", "autoWidth": true },
            { "data": "CETVueltas", "autoWidth": true }
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

            BBDD = api
                .column(4, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            Indecopi = api
                .column(5, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            RetiroLead = api
                .column(6, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            RecorridoReal = api
                .column(7, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            CETReal = api
                .column(8, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            NVueltas = api
                .column(9, { page: 'current' })
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
               BBDD
            );
            $(api.column(5).footer()).html(
               Indecopi
            );
            $(api.column(6).footer()).html(
               RetiroLead
            );
            $(api.column(7).footer()).html(
               RecorridoReal
            );
            $(api.column(8).footer()).html(
               CETReal
            );
            $(api.column(9).footer()).html(
               NVueltas.toFixed(0)
            );
            $(api.column(10).footer()).html(
               ((CETReal / RecorridoReal) * 100).toFixed(0) + '%'
            );
            $(api.column(11).footer()).html(
               ((NVenta / CETReal) * 100).toFixed(1) + '%'
            );
            $(api.column(12).footer()).html(
               ((BBDD / (RecorridoReal - Indecopi)) * 100).toFixed(1) + '%'
            );
            $(api.column(13).footer()).html(
               ((NVenta / CETReal) * 100).toFixed(1) + '%'
            );
        }
    });
});
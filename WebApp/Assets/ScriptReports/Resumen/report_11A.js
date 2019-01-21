$(document).ready(function () {
    $('#FirstTable').DataTable({
        "scrollY": 250,
        "scrollX": true,
        "ajax": {
            "url": "/summary/FirstMonth",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Dia", "autoWidth": true },
            { "data": "VentaTotal", "autoWidth": true },
            { "data": "VentaValida", "autoWidth": true },
            { "data": "VentaAprobada", "autoWidth": true },
            { "data": "PassingValido", "autoWidth": true },
            { "data": "PassingAprobado", "autoWidth": true },
            { "data": "Venta", "autoWidth": true },
            { "data": "Validado", "autoWidth": true },
            { "data": "Aprobado", "autoWidth": true }
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
            },
            "decimal": ",",
            "thousands": ","
        },
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
            VentaTotal = api
                .column(1, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            VentaValida = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            VentaAprobada = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Venta = api
                .column(6, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Valido = api
                .column(7, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Aprobado = api
                .column(8, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            // Update footer
            $(api.column(1).footer()).html(
               VentaTotal
            );
            $(api.column(2).footer()).html(
               VentaValida
            );
            $(api.column(3).footer()).html(
               VentaAprobada
            );
            $(api.column(4).footer()).html(
               ((VentaValida / VentaTotal) * 100).toFixed(0) + '%'
            );
            $(api.column(5).footer()).html(
               ((VentaAprobada / VentaValida) * 100).toFixed(0) + '%'
            );
            $(api.column(6).footer()).html(
               Venta.toFixed(0) + '%'
            );
            $(api.column(7).footer()).html(
               Valido.toFixed(0) + '%'
            );
            $(api.column(8).footer()).html(
               Aprobado.toFixed(0) + '%'
            );
        },
    });
});
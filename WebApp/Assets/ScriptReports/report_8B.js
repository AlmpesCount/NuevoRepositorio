$(document).ready(function () {
    $('#SecondTable').DataTable({
        "ajax": {
            "url": "/consultareporte/SecondReport8",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Periodo", "autoWidth": true },
            { "data": "Crediscotia1", "autoWidth": true },
            { "data": "Crediscotia2", "autoWidth": true },
            { "data": "Crediscotia3", "autoWidth": true },
            { "data": "Crediscotia4", "autoWidth": true },
            { "data": "Almpes1", "autoWidth": true },
            { "data": "Almpes2", "autoWidth": true },
            { "data": "AlmpesCET", "autoWidth": true },
            { "data": "TotalGeneral", "autoWidth": true }
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

            // Total over all pages
            total = api
                .column(1)
                .column(2)
                .column(3)
                .column(4)
                .column(5)
                .column(6)
                .column(7)
                .column(8)
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);


            // Total over this page
            T1 = api
                .column(1, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            T2 = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            T3 = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            T4 = api
                .column(4, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Q1 = api
                .column(5, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Q2 = api
                .column(6, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            Cet = api
                .column(7, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            TotalGeneral = api
                .column(8, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            // Update footer
            $(api.column(1).footer()).html(
               T1
            );
            $(api.column(2).footer()).html(
               T2
            );
            $(api.column(3).footer()).html(
               T3
            );
            $(api.column(4).footer()).html(
               T4
            );
            $(api.column(5).footer()).html(
               Q1
            );
            $(api.column(6).footer()).html(
               Q2
            );
            $(api.column(7).footer()).html(
               Cet
            );
            $(api.column(8).footer()).html(
               TotalGeneral
            );
        },
    });
});

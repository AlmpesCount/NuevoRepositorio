$(document).ready(function () {
    $('#ThirdTable').DataTable({
        "ajax": {
            "url": "/consultareporte/ThirdReport8",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Descripcion", "autoWidth": true },
            { "data": "Tipo", "autoWidth": true },
            { "data": "Almpes1", "autoWidth": true },
            { "data": "Almpes2", "autoWidth": true },
            { "data": "AlmpesCet", "autoWidth": true },
            { "data": "AlmpesW1", "autoWidth": true },
            { "data": "AlmpesNA", "autoWidth": true },
            { "data": "AlmpesTotal", "autoWidth": true },
            { "data": "Crediscotia1", "autoWidth": true },
            { "data": "Crediscotia2", "autoWidth": true },
            { "data": "Crediscotia3", "autoWidth": true },
            { "data": "Crediscotia4", "autoWidth": true },
            { "data": "Crediscotia5", "autoWidth": true },
            { "data": "CrediscotiaTotal", "autoWidth": true },
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
        initComplete: function () {
            this.api().column(1).every( function () {
                var column = this;
                var select = $('<select style=" width: 105px;"><option value=""></option></select>')
                    .appendTo( $(column.footer()).empty() )
                    .on( 'change', function () {
                        var val = $.fn.dataTable.util.escapeRegex(
                            $(this).val()
                        );
 
                        column
                            .search( val ? '^'+val+'$' : '', true, false )
                            .draw();
                    } );
 
                column.data().unique().sort().each( function ( d, j ) {
                    select.append( '<option value="'+d+'">'+d+'</option>' )
                } );
            } );
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
                .column(2)
                .column(3)
                .column(4)
                .column(5)
                .column(6)
                .column(7)
                .column(8)
                .column(9)
                .column(10)
                .column(11)
                .column(12)
                .column(13)
                .column(14)
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);


            // Total over this page
            Almpes1 = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Almpes2 = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            AlmpesCet = api
                .column(4, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            AlmpesW1 = api
                .column(5, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            AlmpesNA = api
                .column(6, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            AlmpesTotal = api
                .column(7, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            Crediscotia1 = api
                .column(8, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Crediscotia2 = api
                .column(9, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Crediscotia3 = api
                .column(10, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Crediscotia4 = api
                .column(11, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            Crediscotia5 = api
                .column(12, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            CrediscotiaTotal = api
                .column(13, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);

            TotalGeneral = api
                .column(14, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(a) + intVal(b);
                }, 0);
            // Update footer
            $(api.column(2).footer()).html(
               Almpes1
            );
            $(api.column(3).footer()).html(
               Almpes2
            );
            $(api.column(4).footer()).html(
               AlmpesCet
            );
            $(api.column(5).footer()).html(
               AlmpesW1
            );
            $(api.column(6).footer()).html(
               AlmpesNA
            );
            $(api.column(7).footer()).html(
               AlmpesTotal
            );
            $(api.column(8).footer()).html(
               Crediscotia1
            );
            $(api.column(9).footer()).html(
               Crediscotia2
            );
            $(api.column(10).footer()).html(
               Crediscotia3
            );
            $(api.column(11).footer()).html(
               Crediscotia4
            );
            $(api.column(12).footer()).html(
               Crediscotia5
            );
            $(api.column(13).footer()).html(
               CrediscotiaTotal
            );
            $(api.column(14).footer()).html(
               TotalGeneral
            );
        },
    });
});

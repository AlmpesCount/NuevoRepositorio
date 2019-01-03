    $(document).ready(function () {
        $('#myTable').DataTable({
            "ajax": {
                "url": "/consultareporte/CargarReporte9",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "Periodo", "autoWidth": true },
                { "data": "Anio", "autoWidth": true },
                { "data": "Column0", "autoWidth": true },
                { "data": "Column1", "autoWidth": true },
                { "data": "Column2", "autoWidth": true },
                { "data": "Column3", "autoWidth": true },
                { "data": "Column4", "autoWidth": true },
                { "data": "Column5", "autoWidth": true },
                { "data": "Column6", "autoWidth": true },
                { "data": "Column7", "autoWidth": true },
                { "data": "Column8", "autoWidth": true },
                { "data": "Column9", "autoWidth": true },
                { "data": "Column11", "autoWidth": true },
                { "data": "Column12", "autoWidth": true },
                { "data": "Column13", "autoWidth": true }
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
        });
    });
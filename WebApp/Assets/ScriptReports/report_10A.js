 $(document).ready(function () {
        $('#myTable').DataTable({
            "ajax": {
                "url": "/consultareporte/cargarreporte10",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "PeriodoOrd", "autoWidth": true },
                { "data": "Periodo", "autoWidth": true },
                { "data": "VentaTotal", "autoWidth": true },
                { "data": "VentaAprobada", "autoWidth": true },
                { "data": "VentaActivada", "autoWidth": true },
                { "data": "ActivadaMes", "autoWidth": true},
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
        });

        //$('#myTable tfoot th').each(function () {
        //    var title = $(this).text();
        //    $(this).html('<input type="text" placeholder="Buscar ' + title + '" style="width:150px;"/>');
        //});

        //// DataTable
        //var table = $('#myTable').DataTable();

        //// Apply the search
        //table.columns().every(function () {
        //    var that = this;

        //    $('input', this.footer()).on('keyup change', function () {
        //        if (that.search() !== this.value) {
        //            that
        //                .search(this.value)
        //                .draw();
        //        }
        //    });
        //});
//        $.fn.dataTable.ext.search.push(
//    function (settings, data, dataIndex) {
//        var min = parseInt($('#min').val(), 10);
//        var max = parseInt($('#max').val(), 10);
//        var age = parseFloat(data[5]) || 0; // use data for the age column

//        if ((isNaN(min) && isNaN(max)) ||
//             (isNaN(min) && age <= max) ||
//             (min <= age && isNaN(max)) ||
//             (min <= age && age <= max)) {
//            return true;
//        }
//        return false;
//    }
//);

//        $(document).ready(function () {
//            var table = $('#myTable').DataTable();

//            // Event listener to the two range filtering inputs to redraw on input
//            $('#min, #max').keyup(function () {
//                table.draw();
//            });
//        });
    });
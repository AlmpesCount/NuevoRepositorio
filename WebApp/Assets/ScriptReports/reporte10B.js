 $(document).ready(function () {
     $('#SecondTable').DataTable({
            "ajax": {
                "url": "/consultareporte/cargarreporte10",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "Mes", "autoWidth": true },
                { "data": "Anio", "autoWidth": true},
                { "data": "VentaTotal", "autoWidth": true },
                { "data": "VentaValida", "autoWidth": true },
                { "data": "VentaAprobada", "autoWidth": true },
                { "data": "VentaActivada", "autoWidth": true },
                { "data": "ActivadaMes", "autoWidth": true},
                { "data": "ActivasMes0", "autoWidth": true },
                { "data": "ActivadasMes1", "autoWidth": true },
                { "data": "ActivadasMes2", "autoWidth": true },
                { "data": "Uso", "autoWidth": true }
            ],
            //Esta parte del codigo sirve para pasar datos de la tabla a español
            "language": {
                "sProcessing": "Procesando...",
                "sLengthMenu": "Mostrar _MENU_ registros",
                "sZeroRecords": "No se encontraron resultados",
                "sEmptyTable": "Ningún dato disponible en esta tabla",
                "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
                "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
                "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
                "sInfoPostFix": "",
                "sSearch": "Ingrese año a buscar:",
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
                    .column(2)
                    .column(3)
                    .column(4)
                    .column(5)
                    .column(6)
                    .column(7)
                    .column(8)
                    .column(9)
                    .column(10)
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);


                // Total over this page
                VentaTotal = api
                    .column(2, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                VentaValida = api
                    .column(3, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                VentaAprobada = api
                    .column(4, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);
                VentaActivada = api
                    .column(5, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                ActivadaMes = api
                    .column(6, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                ActivadasMes0 = api
                    .column(7, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);
                ActivadasMes1 = api
                    .column(8, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                ActivadasMes2 = api
                    .column(9, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                Uso = api
                    .column(10, { page: 'current' })
                    .data()
                    .reduce(function (a, b) {
                        return intVal(a) + intVal(b);
                    }, 0);

                // Update footer
                $(api.column(2).footer()).html(
                   VentaTotal
                );
                $(api.column(3).footer()).html(
                   VentaValida
                );
                $(api.column(4).footer()).html(
                   VentaAprobada
                );
                $(api.column(5).footer()).html(
                   VentaActivada
                );
                $(api.column(6).footer()).html(
                   ActivadaMes
                );
                $(api.column(7).footer()).html(
                   ActivadasMes0
                );
                $(api.column(8).footer()).html(
                   ActivadasMes1
                );
                $(api.column(9).footer()).html(
                   ActivadasMes2
                );
                $(api.column(10).footer()).html(
                   Uso
                );
            },
        });

     //$('#SecondTable tfoot th').each(function () {
     //       var title = $(this).text();
     //       $(this).html('<input type="text" placeholder="Buscar ' + title + '" style="width:150px;"/>');
     //   });

     //var table = $('#SecondTable').DataTable();

     //   table.columns().every(function () {
     //       var that = this;

     //       $('input', this.footer()).on('keyup change', function () {
     //           if (that.search() !== this.value) {
     //               that
     //                   .search(this.value)
     //                   .draw();
     //           }
     //       });
     //   });
    });
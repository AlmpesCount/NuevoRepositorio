$(document).ready(function () {
    $('#FirstTable').DataTable({
        "ajax": {
            "url": "/consultareporte/cargarreporte1",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Zona", "autoWidth": true },
            { "data": "Semana", "autoWidth": true },
            { "data": "DiaSemana", "autoWidth": true },
            { "data": "Fecha", "autoWidth": true },
            { "data": "NroVenta", "autoWidth": true },
            { "data": "NroVeValida", "autoWidth": true },
            { "data": "Dotacion", "autoWidth": true },
            { "data": "RecorridoDia", "autoWidth": true },
            { "data": "ContactoEfectivoTitular", "autoWidth": true },
            { "data": "RecorridoReal", "autoWidth": true },
            { "data": "CETReal", "autoWidth": true },
            { "data": "NroVueltas", "autoWidth": true },
            { "data": "VentasTMO", "autoWidth": true },
            { "data": "CETTMO", "autoWidth": true },
            { "data": "PorcCETReal", "autoWidth": true },
            { "data": "PorcAcepReal", "autoWidth": true },

            { "data": "CETTiempo", "autoWidth": true },
            { "data": "VentasTiempo", "autoWidth": true },
            { "data": "RecorridoUnico", "autoWidth": true },

            { "data": "CETUnico", "autoWidth": true },
            { "data": "BBDDAsignada", "autoWidth": true },
            { "data": "Indecopi", "autoWidth": true },
            { "data": "RetiroLeads", "autoWidth": true },  
            { "data": "RecorridoDiaTiempo", "autoWidth": true },           
            { "data": "CTRTiempo", "autoWidth": true },
            { "data": "ContactoTerceroRelacionado", "autoWidth": true }   
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
        },
        "scrollY": 350,
        "scrollX": true,
    });
});
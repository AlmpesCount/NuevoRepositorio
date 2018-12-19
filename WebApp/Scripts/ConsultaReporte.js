$("#grid").jqGrid({
        url: "/ConsultaReporte/Reporte10Lists",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['Periodo', 'PeriodoOrd',
                      'Mes', 'Anio',
                      'TipoVenta', 'Cantidad'],
        colModel: [
        { name: 'Periodo', index: 'Periodo', width: 10 },
        { name: 'PeriodoOrd', index: 'PeriodoOrd', width: 15 },
        { name: 'Mes', index: 'Mes', width: 15 },
        { name: 'Anio', index: 'Anio', width: 15 },
        { name: 'TipoVenta', index: 'TipoVenta', width: 15 },
        { name: 'Cantidad', index: 'Cantidad', width: 15 }
        ],
        pager: jQuery('#pager'),
        rowNum: 10,
        rowList: [10, 150, 300],
        height: '100%',
        viewrecords: true,
        caption: 'Todo List',
        loadonce: true,
        emptyrecords: 'No records to display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    });
    $('#filterButton').click(function (event) {
        event.preventDefault();
        filterGrid();
});

function filterGrid() {
    var postDataValues = $("#grid").jqGrid('getGridParam', 'postData');

    // grab all the filter ids and values and add to the post object
    $('.filterItem').each(function (index, item) {
        postDataValues[$(item).attr('id')] = $(item).val();
    });

    $('#grid').jqGrid().setGridParam({ postData: postDataValues, page: 1 }).trigger('reloadGrid');
}
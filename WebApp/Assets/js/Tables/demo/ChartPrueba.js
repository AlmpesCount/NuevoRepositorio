$(document).ready(function () {
    showGraph();
});

function showGraph() {
    $.ajax({
        type: 'GET',
        url: '/charts/CargarChartArea',
        success: function (lstReporte) {
            console.log(lstReporte);
            var pord = []; var per = [];
            var vtot = []; var vapr = [];
            var vact = []; var ames = [];

            for (var i in lstReporte) {
                pord.push(lstReporte[i].PeriodoOrd);
                per.push(lstReporte[i].Periodo);
                vtot.push(lstReporte[i].VentaTotal);
                vapr.push(lstReporte[i].VentaAprobada);
                vact.push(lstReporte[i].VentaActivada);
                ames.push(lstReporte[i].ActivadaMes);
            }

            Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
            Chart.defaults.global.defaultFontColor = '#292b2c';

            var ChartData = {
                labels: pord,
                datasets: [{
                    label: "Activadas del Mes",
                    lineTension: 0.3,
                    backgroundColor: "rgba(212,198,2,0.2)",
                    borderColor: "rgba(212,198,2,1)",
                    pointRadius: 5,
                    pointBackgroundColor: "rgba(212,198,2,1)",
                    pointBorderColor: "rgba(255,255,255,0.8)",
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: "rgba(212,198,2,1)",
                    pointHitRadius: 50,
                    pointBorderWidth: 2,
                    data: ames
                },
                {
                    label: "Venta Activada",
                    lineTension: 0.3,
                    backgroundColor: "rgba(110,212,2,0.2)",
                    borderColor: "rgba(110,212,2,1)",
                    pointRadius: 5,
                    pointBackgroundColor: "rgba(110,212,2,1)",
                    pointBorderColor: "rgba(255,255,255,0.8)",
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: "rgba(110,212,2,1)",
                    pointHitRadius: 50,
                    pointBorderWidth: 2,
                    data: vact
                },
                {
                    label: "Venta Aprobada",
                    lineTension: 0.3,
                    backgroundColor: "rgba(212,2,5,0.2)",
                    borderColor: "rgba(212,2,5,1)",
                    pointRadius: 5,
                    pointBackgroundColor: "rgba(212,2,5,1)",
                    pointBorderColor: "rgba(255,255,255,0.8)",
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: "rgba(212,2,5,1)",
                    pointHitRadius: 50,
                    pointBorderWidth: 2,
                    data: vapr
                },
                {
                    label: "Venta Total",
                    lineTension: 0.3,
                    backgroundColor: "rgba(2,117,216,0.2)",
                    borderColor: "rgba(2,117,216,1)",
                    pointRadius: 5,
                    pointBackgroundColor: "rgba(2,117,216,1)",
                    pointBorderColor: "rgba(255,255,255,0.8)",
                    pointHoverRadius: 5,
                    pointHoverBackgroundColor: "rgba(2,117,216,1)",
                    pointHitRadius: 50,
                    pointBorderWidth: 2,
                    data: vtot
                }],
            };

            var ctx = document.getElementById("myAreaChart");

            var myLineChart = new Chart(ctx, {
                type: 'line',
                data: ChartData,
                options: {
                    scales: {
                        xAxes: [{
                            time: {
                                unit: 'date'
                            },
                            gridLines: {
                                display: false
                            },
                            ticks: {
                                maxTicksLimit: 10
                            }
                        }],
                        yAxes: [{
                            ticks: {
                                min: 0,
                                max: 2500,
                                maxTicksLimit: 5
                            },
                            gridLines: {
                                color: "rgba(0, 0, 0, .125)",
                            }
                        }],
                    },
                    //legend: {
                    //    display: false
                    //}
                }
            });
        }
    })
}


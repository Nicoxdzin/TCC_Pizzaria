using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using Guna.UI2.WinForms;
using Controller1;
using System.Windows.Forms.DataVisualization.Charting;


namespace TCC_Pizzaria
{
    public partial class GraficoPedido : Form
    {
        public GraficoPedido()
        {
            InitializeComponent();
        }

        private void GraficoPedido_Load(object sender, EventArgs e)
        {
            /*
            PedidoController pedidoController = new PedidoController();
           
            grafico1.DataSource = pedidoController.ContarPedidos();
            // Definir o ChartArea
           

            // Definir o Series
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.DateTime;
            foreach (DataRow row in grafico1.Rows)
            {
                DateTime dataPedido = Convert.ToDateTime(row["data_pedido"]);
                int totalPedidos = Convert.ToInt32(row["total_pedidos"]);

                series.Points.AddXY(dataPedido, totalPedidos);
            }

            // Adicionar o Series ao Chart
            chart.Series.Add(series);

            // Adicionar o Chart ao formulário (ou a um controle de container adequado)
            Controls.Add(chart);
            */
        }
    }
}

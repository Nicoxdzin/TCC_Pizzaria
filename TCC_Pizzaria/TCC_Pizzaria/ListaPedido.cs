using Controller1;
using model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_Pizzaria
{
    public partial class ListaPedido : Form
    {
        private PedidoController pedidoController;
        public ListaPedido()
        {           
           InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaPedido_Load(object sender, EventArgs e)
        {
            pedidoController = new PedidoController();

            dtgView1.AutoGenerateColumns = true;
            dtgView1.DataSource = pedidoController.ObterPedidos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {           

            if(dtgView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha antes de prosseguir.");
                return;
            }
            else
            {
                int Id = (int)dtgView1.SelectedRows[0].Cells[0].Value;

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dtgView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha antes de prosseguir.");
                return;
            }
            else
            {
                PedidoController pedido_controller = new PedidoController();
                int id = (int)dtgView1.SelectedRows[0].Cells[0].Value;
                Pedido pedido = new Pedido { Id = id };
                pedido = pedido_controller.DeletarPedido(pedido);
                MessageBox.Show("Excluido com sucesso!");
                dtgView1.DataSource = pedidoController.ObterPedidos();

            }           
        }
    }
}

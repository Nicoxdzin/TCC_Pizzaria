using Controller1;
using model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                int id = (int)dtgView1.SelectedRows[0].Cells["Id"].Value;
                AtualizaPedido atualizaPedido = new AtualizaPedido(id);
                atualizaPedido.ShowDialog();
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
                DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    PedidoController pedido_controller = new PedidoController();
                    int id = (int)dtgView1.SelectedRows[0].Cells[0].Value;
                    Pedido pedido = new Pedido { Id = id };
                    pedido = pedido_controller.DeletarPedido(pedido);
                    MessageBox.Show("Excluído com sucesso!");
                    dtgView1.DataSource = pedidoController.ObterPedidos();
                }

            }           
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPedidos(txtPesquisaNome.Text);
        }

        private void FiltrarPedidos(string termoPesquisa)
        {
            List<Pedido> pedidosFiltrados = pedidoController.PesquisarPedidoNome(termoPesquisa);

            dtgView1.DataSource = pedidosFiltrados;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataPesquisa = dtPickerData.Value.Date;

            List<Pedido> pedidosFiltrados = pedidoController.ObterPedidosPorData(dataPesquisa);
            dtgView1.DataSource = pedidosFiltrados;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NovoPedido());
        }
           private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
           
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblCurrentChildForm.text = childForm.Name;

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

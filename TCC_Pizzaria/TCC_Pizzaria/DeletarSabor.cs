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
    public partial class DeletarSabor : Form
    {
        public DeletarSabor()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletarSabor_Load(object sender, EventArgs e)
        {
            SaborController saborController = new SaborController();

            ListaSabor.AutoGenerateColumns = true;
            ListaSabor.DataSource = saborController.ObterSabor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ListaSabor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha antes de prosseguir.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaborController saborController = new SaborController();
                    int id = (int)ListaSabor.SelectedRows[0].Cells[0].Value;
                    Sabor sabor = new Sabor { Id = id };
                    sabor = saborController.DeletarSabor(sabor);
                    MessageBox.Show("Excluído com sucesso!");
                    ListaSabor.DataSource = saborController.ObterSabor();
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3C1LucasPereira24.Code.BLL;
using _3C1LucasPereira24.Code.DTO;



namespace _3C1LucasPereira24
{
    public partial class Frm_Rede : Form
    {


        RedeBLL redbll = new RedeBLL();
        RedeDTO reddto = new RedeDTO();



        public Frm_Rede()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            reddto.Produto = txtProduto.Text;
            reddto.Preco = txtPreco.Text;

            redbll.Inserir(reddto);

            MessageBox.Show("Cadastrado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtProduto.Clear();
            txtPreco.Clear();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            reddto.Id = int.Parse(txtId.Text);
            reddto.Produto = txtPreco.Text;
            reddto.Preco = txtPreco.Text;

            redbll.Listar();

            DialogResult dialogResult = MessageBox.Show("Alteracao realizada", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Clear();
            txtProduto.Clear();
            txtPreco.Clear();




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            reddto.Id = int.Parse(txtId.Text);

            redbll.Excluir(reddto);

            MessageBox.Show("Excluido com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

          


        }

        private void Frm_Rede_Load(object sender, EventArgs e)
        {
            dgvRedes.DataSource = redbll.Listar();
        }

        private void dgvRedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dgvRedes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dgvRedes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dgvRedes.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}

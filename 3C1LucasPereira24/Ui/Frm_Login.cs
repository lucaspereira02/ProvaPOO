using _3C1LucasPereira24.Code.BLL;
using _3C1LucasPereira24.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1LucasPereira24.Ui
{
    public partial class Frm_Login : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();


        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;


            if (loginBLL.RealizarLogin(loginDTO) == true)
            {

                Frm_Rede frm_Rede = new Frm_Rede();
                frm_Rede.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }









        }
    }
}

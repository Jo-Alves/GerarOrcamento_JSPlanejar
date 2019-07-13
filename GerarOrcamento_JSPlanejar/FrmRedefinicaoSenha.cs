using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmRedefinicaoSenha : Form
    {
        public FrmRedefinicaoSenha(string Usuario)
        {
            InitializeComponent();
            lbl_Usuario.Text = Usuario;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_ConfirmarSenha.Text.Trim() == txt_Senha.Text.Trim())
            {
                if (txt_ConfirmarSenha.TextLength >= 5 && txt_Senha.TextLength >= 5)
                {
                    try
                    {
                        ClassUsuario usuario = new ClassUsuario();
                        usuario._Usuario = lbl_Usuario.Text;
                        usuario._Senha = Security.Cry(txt_ConfirmarSenha.Text);
                        usuario.RedefinirSenha();
                        MessageBox.Show("Senha redefinida com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("A senha deve conter mais de cinco caracteres!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("As senhas não correspondem", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }

        private void txt_ConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }
    }
}

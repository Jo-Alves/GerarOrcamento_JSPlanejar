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
    public partial class FrmInformarDicaSenha : Form
    {
        public FrmInformarDicaSenha(string PerguntaSeguranca)
        {
            InitializeComponent();
            lbl_PerguntaSeguranca.Text = PerguntaSeguranca;
        }

        public string RespostaSeguranca { get; set; }
        public string AcaoFechar { get; set; }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_DicaSenha.Text == "")
            {
                MessageBox.Show("Digite a dica de senha!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RespostaSeguranca = Security.Cry(txt_DicaSenha.Text.Trim());
                txt_DicaSenha.Clear();
                txt_DicaSenha.Focus();
                this.Close();
            }
        }

       private void lblFechar_Click(object sender, EventArgs e)
        {
            RespostaSeguranca = "";
            AcaoFechar = "Fechar";
            Close();
        }

        private void lblFechar_MouseEnter(object sender, EventArgs e)
        {
            lblFechar.BackColor = Color.Red;
        }

        private void lblFechar_MouseLeave(object sender, EventArgs e)
        {
            lblFechar.BackColor = Color.Transparent;
        }

        private void txt_DicaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }
    }
}

using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmRestauracaoSistema : Form
    {
        public FrmRestauracaoSistema()
        {
            InitializeComponent();
        }

        private void btn_RestaurarSistema_Click(object sender, EventArgs e)
        {
            if (txtDiretório.Text != "")
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexaoMaster"]));
                SqlCommand comando = new SqlCommand("", conexao);
                comando.CommandText = "Restore Database dbControleOrcamento from disk = '" + txtDiretório.Text + "'";


                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Restaução do banco de dados realizada com sucesso!", "Mensagem de segurança do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
            else
                MessageBox.Show("Escolha o local do arquivo para a restauração!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Escolher local";
            Open.Filter = "Sistema de Segurança|*.bak*";
            Cursor = Cursors.WaitCursor;
            if (Open.ShowDialog() == DialogResult.OK)
            {
                txtDiretório.Text = Open.FileName;
            }
        }
    }
}

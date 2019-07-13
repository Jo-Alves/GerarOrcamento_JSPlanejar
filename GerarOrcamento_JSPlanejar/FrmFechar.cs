using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmFechar : Form
    {
        public FrmFechar()
        {
            InitializeComponent();
        }

        public bool Fechar { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {           
            Fechar = true;
            Close();
        }

        string dateTime;
        private void InformarData()
        {
            DateTime Data = DateTime.Now;
            int dia = Data.Day, mes = Data.Month, ano = Data.Year, hora = Data.Hour, min = Data.Minute, sec = Data.Second;
            dateTime = dia + "-" + mes + "-" + ano + ", " + hora + "_" + min + "_" + sec;

        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            GerarBackup();
            Fechar = false;
        }

        private void GerarBackup()
        {
            CriarPasta();
            InformarData();
            Cursor = Cursors.WaitCursor;
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "Backup Database dbControleOrcamento to disk = '"+ Pasta + "Backup de segurança - " + dateTime + ".bak'";
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Backup Realizado com sucesso! O arquivo se encontra em " + Pasta + "Backup de Segurança - " + dateTime + ".bak", "Mensagem de segurança do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.Default;
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

        string Pasta = @"C:\Orçamento_JsPlanejar\Sistema de segurança\";
        private void CriarPasta()
        {            
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        private void FrmFechar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnGerarBackup_Click(sender, e);
            else //if (e.KeyCode == Keys.Escape)
                btnFechar_Click(sender, e);
        }
    }
}

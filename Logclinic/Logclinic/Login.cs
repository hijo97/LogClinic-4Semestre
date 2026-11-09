using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logclinic
{
    public partial class FrmLogin : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tbloperador;
        private String strsql, strconex;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            strconex = $"data source={Program.LocalBank}; initial catalog=LogClinic; integrated security=true";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tbloperador = new DataTable();
            strsql = "select * from operador where usuario='" + txtUsuario.Text + "' and senha = '"+ txtSenha.Text +"'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tbloperador);

            if (tbloperador.Rows.Count == 1)
            {
                Program.OperadorId = tbloperador.Rows[0]["id"].ToString();
                Program.NivelAcesso = tbloperador.Rows[0]["perfil"].ToString();
                
                

                MessageBox.Show("Registro encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //MessageBox.Show($"O seu nível é: {Program.NivelAcesso}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                Form menu = new FrmPrincipal();
                menu.Show();
                this.Visible = false;
                

            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           // MessageBox.Show($"O seu nível é: {Program.NivelAcesso}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

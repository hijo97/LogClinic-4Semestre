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
    public partial class FrmPrincipal : Form
    {
        
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tbloperador;
        private String strsql, strconex;
        private Form frmAtivo;

        Form login = new FrmLogin();

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Cyan;
        }

        private void OperadorLogado()
        {
            strconex = $"data source={Program.LocalBank}; initial catalog=LogClinic; integrated security=true";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tbloperador = new DataTable();
            strsql = $"select * from operador where id = {Program.OperadorId}";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tbloperador);

            //int IdOperador =

            if (Program.OperadorId != "NULL")
            {
                string Operador = tbloperador.Rows[0]["nome"].ToString();
                lblOperador.Text = $"Olá!  {Operador} ";
            }else 
            {

                string Operador = Program.OperadorId;
                lblOperador.Text = $"Olá!  {Operador} ";

                panelMenu.Enabled = false;
                btnLogout.Text = "Login";
            }
        }


        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Form login = new FrmLogin();
            login.Close();

            OperadorLogado();
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInicio);
            ActiveFormClose();

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPaciente);
            FormShow(new FrmPacientes());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            Program.NivelAcesso = "";
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveFormClose();            

            if (btnLogout.Text == "Logout") {
                Program.NivelAcesso = "NULL";
                Program.OperadorId = "NULL";

                OperadorLogado();
            }
            else if (btnLogout.Text == "Sair")
            {
                Close();
                login.Close();
                
            }
            else
            {
               login.Show();
               OperadorLogado();
               btnLogout.Text = "Sair";
            }       
             
        }

        
        private void btnServicos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnServicos);
            FormShow(new FrmServicos());
        }
    }
}

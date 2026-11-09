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
    public partial class FrmPacientes : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblpaciente;
        private DataTable tblconvenio;
        private SqlCommand comando;
        private String strsql, strconex;
        
        public FrmPacientes()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------
        //----------------------- FUNÇÃO PARA LIMPAR O FORMULARIO PACIENTE -------------
        //------------------------------------------------------------------------------
        public void LimpaFomulario()
        {
            //limpa as caixas de textos
            mtbBuscaCpf.Text = "";
            mtbCpf.Text = "";
            txtNome.Text = "";
            mtbDataNascimento.Text = "";            
            mtbRg.Text = "";
            mtbTelefone.Text = "";
            txtEmpresa.Text = "";
            txtEmail.Text = "";
            mtbCep.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtUf.Text = "";
            cboGenero.Text = "";
            cboConvenio.SelectedValue = "0";

        }

        //------------------------------------------------------------------------------
        //-------------------- FUNÇÃO PARA HABILITAR O FORMULARIO PACIENTE -------------
        //------------------------------------------------------------------------------
        public void OnFormPaciente()
        {
            txtNome.Enabled = true;
            mtbRg.Enabled = true;
            mtbDataNascimento.Enabled = true;
            cboGenero.Enabled = true;
            mtbTelefone.Enabled = true;
            txtEmail.Enabled = true;
            mtbCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtUf.Enabled = true;
            txtEmpresa.Enabled = true;
            cboConvenio.Enabled = true;
            btnSalvar.Visible = false;
        }

        //------------------------------------------------------------------------------
        //-------------------- FUNÇÃO PARA DESABILITA O FORMULARIO PACIENTE -------------
        //------------------------------------------------------------------------------
        public void OffFormPaciente()
        {
            mtbCpf.Enabled = true;
            txtNome.Enabled = false;
            mtbRg.Enabled = false;
            mtbDataNascimento.Enabled = false;
            cboGenero.Enabled = false;
            mtbTelefone.Enabled = false;
            txtEmail.Enabled = false;
            mtbCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtUf.Enabled = false;
            txtEmpresa.Enabled = false;
            cboConvenio.Enabled = false;
            btnSalvar.Visible = false;
        }

           
        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            //altera a vibilidade dos grupos, painel e botões
            mtbBuscaCpf.Enabled = true;
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovaConsulta.Enabled = false;
            groupBoxPaciente.Visible = false;
            panelBotoes.Visible = false;
            groupBoxPaciente.Visible = false;

            panelBotoes.Visible = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;

            mtbBuscaCpf.Focus();


            //Abre obanco de dados
            //strconex = "data source=(LOCAL); initial catalog=LogClinic; integrated security=true";
            strconex = $"data source={Program.LocalBank}; initial catalog=LogClinic; integrated security=true";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblconvenio = new DataTable();
            strsql = "SELECT id, (nome + ' - ' + cobertura) AS convfull FROM convenio";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblconvenio);
            cboConvenio.DataSource = tblconvenio;
            cboConvenio.DisplayMember = "convfull";
            cboConvenio.ValueMember = "id";
            cboConvenio.SelectedValue.ToString();

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)  //BOTÃO 'NOVO PACIENTE'
        {
            LimpaFomulario();

            //Habilita o botão 'Novo Paciente' e dasabilita a caixa de texto 'busca CPF' e botão 'consultar'
            panelConsulta.Enabled = false;

            groupBoxPaciente.Visible = true;
            groupBoxPaciente.Enabled = true;

            panelBotoes.Visible = true;
            btnGravar.Visible = true;
            btnGravar.Enabled = true;
            btnApagar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = true;

            
            OffFormPaciente();

            mtbCpf.Focus();

        }


        private void BtnNovaConsulta_Click(object sender, EventArgs e)
        {
            mtbBuscaCpf.Enabled = true;
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovaConsulta.Enabled = false;
            groupBoxPaciente.Visible = false;
            panelBotoes.Visible = false;
            btnSalvar.Visible = false;

            LimpaFomulario();

        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaFomulario();

            panelConsulta.Enabled = true;
            mtbBuscaCpf.Enabled = true;
            btnConsultar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovaConsulta.Enabled = false;
            btnSalvar.Visible = false;

            groupBoxPaciente.Visible = false;


            panelBotoes.Visible = false;

            mtbBuscaCpf.Focus();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            strsql = "INSERT INTO paciente(nome, data_nascimento, genero, CPF, telefone, email, empresa, cep, logradouro, numero, complemento, bairro, cidade, estado, uf, convenio_id, rg) "
        + "VALUES (@nome, @datanasc, @genero, @cpf, @phone, @email, @empresa, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @uf, @idconvenio, @rg)"; 
            comando = new SqlCommand(strsql, conexao);
            
            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@datanasc", mtbDataNascimento.Text));
            comando.Parameters.Add(new SqlParameter("@genero", cboGenero.Text));
            comando.Parameters.Add(new SqlParameter("@cpf", mtbCpf.Text.Replace(".","").Replace(",","").Replace("-","")));
            comando.Parameters.Add(new SqlParameter("@rg", mtbRg.Text.Replace(".","").Replace(",", "").Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@phone", mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text.ToLower()));
            comando.Parameters.Add(new SqlParameter("@empresa", txtEmpresa.Text));
            comando.Parameters.Add(new SqlParameter("@cep", mtbCep.Text.Replace("-","")));
            comando.Parameters.Add(new SqlParameter("@endereco", txtEndereco.Text));
            comando.Parameters.Add(new SqlParameter("@numero", txtNumero.Text));
            comando.Parameters.Add(new SqlParameter("@complemento",txtComplemento.Text));
            comando.Parameters.Add(new SqlParameter("@bairro", txtBairro.Text));
            comando.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
            comando.Parameters.Add(new SqlParameter("@estado", txtEstado.Text));
            comando.Parameters.Add(new SqlParameter("@uf", txtUf.Text.ToUpper()));
            comando.Parameters.Add(new SqlParameter("@idconvenio", Convert.ToInt32(cboConvenio.SelectedValue)));

            comando.ExecuteNonQuery();

            MessageBox.Show("Registro Gravado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            LimpaFomulario();

        }


        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbCpf.Text.Length == 13)
            {
                OnFormPaciente();
            }
            else
            {
                OffFormPaciente();
            }           

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (mtbCpf.Enabled==true)
            
            {
                //Consulta se o CPF já está no Cadastrado
                tblpaciente = new DataTable();
                strsql = "select * from paciente where cpf='" + mtbCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "") + "'";
                adapter = new SqlDataAdapter(strsql, conexao);
                adapter.Fill(tblpaciente);

                if (tblpaciente.Rows.Count == 1)
                {

                    MessageBox.Show("CPF já Cadastrado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    OffFormPaciente();

                    mtbCpf.Text = "";
                    mtbCpf.Focus();
                }

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            groupBoxPaciente.Enabled = true;
            OnFormPaciente();
            mtbBuscaCpf.Enabled = false;
            mtbCpf.Enabled = false;
            btnGravar.Visible = false;
            btnSalvar.Visible = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strsql = "UPDATE paciente SET nome = @nome, data_nascimento = @datanasc, genero = @genero, telefone = @phone, email = @email, empresa = @empresa, cep = @cep, logradouro = @endereco, numero = @numero,"
                +" complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, uf = @uf, convenio_id = @idconvenio, rg = @rg WHERE cpf = @cpf";
            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@datanasc", mtbDataNascimento.Text));
            comando.Parameters.Add(new SqlParameter("@genero", cboGenero.Text));
            comando.Parameters.Add(new SqlParameter("@cpf", mtbCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@rg", mtbRg.Text.Replace(".", "").Replace(",", "").Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@phone", mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text.ToLower()));
            comando.Parameters.Add(new SqlParameter("@empresa", txtEmpresa.Text));
            comando.Parameters.Add(new SqlParameter("@cep", mtbCep.Text.Replace("-", "")));
            comando.Parameters.Add(new SqlParameter("@endereco", txtEndereco.Text));
            comando.Parameters.Add(new SqlParameter("@numero", txtNumero.Text));
            comando.Parameters.Add(new SqlParameter("@complemento", txtComplemento.Text));
            comando.Parameters.Add(new SqlParameter("@bairro", txtBairro.Text));
            comando.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
            comando.Parameters.Add(new SqlParameter("@estado", txtEstado.Text));
            comando.Parameters.Add(new SqlParameter("@uf", txtUf.Text.ToUpper()));
            comando.Parameters.Add(new SqlParameter("@idconvenio", Convert.ToInt32(cboConvenio.SelectedValue)));

            comando.ExecuteNonQuery();

            MessageBox.Show("Registro Alterado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            OffFormPaciente();
            btnGravar.Visible = true;
            btnGravar.Enabled = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            OnFormPaciente();

            MessageBox.Show("VAI APAGAR?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            strsql = "DELETE FROM paciente WHERE cpf = @cpf";
            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@cpf", mtbCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "")));
            
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro Alterado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LimpaFomulario();

            OffFormPaciente();
            btnGravar.Visible = true;
            btnGravar.Enabled = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            tblpaciente = new DataTable();
            strsql = "select * from paciente where cpf='" + mtbBuscaCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "") + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblpaciente);

            if (tblpaciente.Rows.Count == 1)
            {

                MessageBox.Show("Registro encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Mantem as caixas de textos protegidas
                label1.Enabled = true;
                btnConsultar.Enabled = false;
                btnNovaConsulta.Enabled = true;
                
                btnGravar.Visible = true;
                btnCadastrar.Enabled = true;
                
                btnSalvar.Visible = false;

                groupBoxPaciente.Visible = true;
                groupBoxPaciente.Enabled = false;

                panelBotoes.Visible = true;
                
                btnAlterar.Enabled = true;

                mtbBuscaCpf.Text = "";

                //exibe os dados no formulário encontrados no banco de dados
                txtNome.Text = tblpaciente.Rows[0]["nome"].ToString();
                mtbDataNascimento.Text = tblpaciente.Rows[0]["data_nascimento"].ToString();
                mtbCpf.Text = tblpaciente.Rows[0]["cpf"].ToString();
                mtbRg.Text = tblpaciente.Rows[0]["rg"].ToString();
                mtbTelefone.Text = tblpaciente.Rows[0]["telefone"].ToString();
                txtEmpresa.Text = tblpaciente.Rows[0]["empresa"].ToString();
                txtEmail.Text = tblpaciente.Rows[0]["email"].ToString();
                mtbCep.Text = tblpaciente.Rows[0]["cep"].ToString();
                txtEndereco.Text = tblpaciente.Rows[0]["logradouro"].ToString();
                txtComplemento.Text = tblpaciente.Rows[0]["complemento"].ToString();
                txtBairro.Text = tblpaciente.Rows[0]["bairro"].ToString();
                txtCidade.Text = tblpaciente.Rows[0]["cidade"].ToString();
                txtEstado.Text = tblpaciente.Rows[0]["estado"].ToString();
                txtUf.Text = tblpaciente.Rows[0]["uf"].ToString();
                cboGenero.Text = tblpaciente.Rows[0]["genero"].ToString();
                cboConvenio.SelectedValue = tblpaciente.Rows[0]["convenio_id"];
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Habilita o botão 'Novo Paciente' e dasabilita a caixa de texto 'busca CPF' e botão 'consultar'
               mtbBuscaCpf.Text = "";
               mtbBuscaCpf.Focus();

            }
        }


    }
}
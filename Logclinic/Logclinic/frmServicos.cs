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
    public partial class FrmServicos : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblservicos;
        private SqlCommand comando;
        private String strsql, strconex;
               

        public FrmServicos()
        {

            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------------
        //          DIMENSIONAMENTO E CONFIGURAÇÃO DO DATAGRID
        //----------------------------------------------------------------------------------------------------------

        public void DataGridOrganize() {
                
                //  A property abaixo tem que ser false caso contrario os comandos de estilo são ignorados.         
                datagridProcedimentos.EnableHeadersVisualStyles = false;

                //  Header colors e fontes          
                datagridProcedimentos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                datagridProcedimentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                //  O fonte default vem do componente pai do grid, no caso o form
                datagridProcedimentos.ColumnHeadersDefaultCellStyle.Font = new Font(datagridProcedimentos.Font.Name, datagridProcedimentos.Font.Size + 1, FontStyle.Bold);

                //  Define o estilo da linha divisoria entre os headers
                datagridProcedimentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;

                //  Auto size em fill estende a coluna ate que ocupe todo o espaco disponivel no grid
                datagridProcedimentos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //  Coluna  1   -   Código
                datagridProcedimentos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridProcedimentos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //  Coluna  2   -   Nome do Procedimento
                datagridProcedimentos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridProcedimentos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //  Coluna  3   -   Valor
                datagridProcedimentos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridProcedimentos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                //  Formato de numero com 2 casas decimais
                datagridProcedimentos.Columns[2].DefaultCellStyle.Format = "N2";   // 9.999,99

                //  Coluna  4   -   Tempo
                datagridProcedimentos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridProcedimentos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //  Coluna  5   -   Descrição
                datagridProcedimentos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagridProcedimentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //  Dimensiona a largura da coluna pelo maior conteudo entre as cels da coluna
                datagridProcedimentos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridProcedimentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridProcedimentos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                datagridProcedimentos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //  Bordas das celulas do grid. No caso selecionamos apenas linhas horizontais
                datagridProcedimentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                datagridProcedimentos.GridColor = Color.BurlyWood;     // Cor das linhas

                //  Cor da parte do grid nao preenchida pela lista igual a das linhas
                datagridProcedimentos.BackgroundColor = datagridProcedimentos.DefaultCellStyle.BackColor;

                //  Seleção de linhas            
                //  Marca a linha toda
                datagridProcedimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //  Seleciona uma ou mais linhas ( control + click )
                datagridProcedimentos.MultiSelect = true;
                //  Cor da linha selecionada
                datagridProcedimentos.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                //Limpa a selecao na apresentacao do grid
                datagridProcedimentos.ClearSelection();

                //  Cor de fundo, fonte e cor da fonte
                datagridProcedimentos.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
                datagridProcedimentos.DefaultCellStyle.Font = new Font(datagridProcedimentos.Font.Name, datagridProcedimentos.Font.Size - 1, FontStyle.Regular);
                datagridProcedimentos.DefaultCellStyle.ForeColor = Color.DarkSlateGray;

                //  Linhas alternadas de cores diferentes para facilitar a leitura
                datagridProcedimentos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

                //  Altura das linhas de texto. 1.8 vezes a altura do fonte
                datagridProcedimentos.RowTemplate.Height = Convert.ToInt16(1.8 * datagridProcedimentos.DefaultCellStyle.Font.Height);

                //  Row Headers são celulas vazias a esquerda de cada linha. Como no excel onde fica a numeracao
                datagridProcedimentos.RowHeadersVisible = true;
                datagridProcedimentos.RowHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

                //  Fazendo altura = largura por estética apenas. Nao é necessário.
                datagridProcedimentos.RowHeadersWidth = datagridProcedimentos.RowTemplate.Height;

                //  Tira o rowheader
                datagridProcedimentos.RowHeadersVisible = false;

                //  Muda seleção de linhas para apenas uma de cada vez
                datagridProcedimentos.MultiSelect = false;

                //  Limpa quer seleção  anterior
                datagridProcedimentos.ClearSelection();

                //-------------------------------------------------------------------------
                // PROTEÇÃO O GRID DE MODIFICAÇÕES
                //-------------------------------------------------------------------------

                //  Protege o grid todo
                datagridProcedimentos.ReadOnly = true;

                //  Impede que o usuario mude (com o mouse) a altura de linha
                datagridProcedimentos.AllowUserToResizeRows = false;

                //  Impede que o usuario mude a largura de uma coluna
                datagridProcedimentos.AllowUserToResizeColumns = false;

                //  Permite que o usuario mude as colunas de lugar
                datagridProcedimentos.AllowUserToOrderColumns = false;
            }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            

            strconex = $"data source={Program.LocalBank}; initial catalog=LogClinic; integrated security=true";
            conexao = new SqlConnection(strconex);
            conexao.Open();
            
            tblservicos = new DataTable();
            strsql = "SELECT cod AS Código, nome AS Procedimento, valor AS Valor, tempo AS Tempo, descricao AS Descriçao FROM servicos";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblservicos);
            datagridProcedimentos.DataSource = tblservicos;

        
            DataGridOrganize();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06_200581
{
    public partial class FrmPrincipal : Form
    {
        #region Inicializção
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variáveis Globais
        bool muda;
        float soma;
        float media;
        int[] x = new int[50];
        int i, j, aux, quantidade;
        #endregion

        #region Icone Fechar
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Encerrando aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                e.Cancel = true;
            }

        }

        #endregion

        #region Lixo
        private void LblAnimacao_Click(object sender, EventArgs e)
        {

        }
        private void GrpAlturasFornecidas_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #region Animação da Mensagem
        private void TmrAnimacao_Tick(object sender, EventArgs e)
        {
            if (muda == true)
            {
                LblMsgAnimacao.ForeColor = Color.Blue;
                muda = false;
            }
            else
            {
                LblMsgAnimacao.ForeColor = Color.Black;
                muda = true;

            }
        }
        #endregion

        #region Validando os valores de entrada da quantidade
        private void TxtBoxEntradaQuantidade_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtBoxEntradaQuantidade.Text != "")
                {
                    quantidade = Convert.ToInt16(TxtBoxEntradaQuantidade.Text);
                    if (quantidade == 0)
                    {
                        MessageBox.Show("Valor da quantidade inválido ! \n Não pode ser nulo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBoxEntradaQuantidade.Clear(); TxtBoxEntradaQuantidade.Focus();
                    }
                    if (quantidade > 50)
                    {
                        MessageBox.Show("Valor da quantidade inválido ! \n Não pode ser maior que 50", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBoxEntradaQuantidade.Clear(); TxtBoxEntradaQuantidade.Focus();
                    }
                }
                LblContagemAltura.Text = Convert.ToString(i);
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro !", "Erro");
                return;
            }
        }
        #endregion

        #region Opção Calcular ROL do menu strip
        private void MenuCalcularRol_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= quantidade; i++)
            {
                for (j = i +1;j <= quantidade;j++)
                {
                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
            }
            for (i = 1; i <= quantidade;i++)
            {
                LstBoxAlturasEmRol.Items.Add(Convert.ToString(x[i]));
            }
        }
        #endregion

        #region Sobre do menu strip
        private void MenuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do aluno: Mateus Salles Novaes Rocha \nRA: 200581 \nDisciplina: Programação visual e games","Elaborado por:");
        }
        #endregion

        #region Botão Calcular Média do menu strip
        private void MenuCalcularMedia_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= quantidade; i++) {
                soma += x[i];
            }
           
            media = soma / quantidade;

            LblCalculoMediaDasAlturas.Text = Convert.ToString(media);
        }
        #endregion

        #region Botão Limpar do menu strip
        private void Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma ?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 )==DialogResult.Yes) {
                TxtBoxEntradaQuantidade.Clear();
                TxtBoxEntradaAltura.Clear();
                LstBoxAlturasFornecidas.Items.Clear();
                LstBoxAlturasEmRol.Items.Clear();
                LblCalculoMediaDasAlturas.Text = "";
                LblContagemAltura.Text = "0";
                TxtBoxEntradaAltura.Enabled = true;
                TxtBoxEntradaQuantidade.Enabled = true;
                i = 1;
                muda = true;
                soma = 0;
                media = 0;
            }

        }
        #endregion

        #region Form Load
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            i = 1;
            muda = true;
        }
        #endregion

        #region Verfica os valores de entrada da altura
        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Validando os valores de entrada da altura
        private void TxtBoxEntradaAltura_Validating(object sender, CancelEventArgs e)
        {
            x[i] = int.Parse(TxtBoxEntradaAltura.Text);
            if (x[i] > 150 && x[i] < 220)
            {
                if (TxtBoxEntradaAltura.Text != "")
                {
                    if (i < quantidade)
                    {
                        x[i] = int.Parse(TxtBoxEntradaAltura.Text);
                        LstBoxAlturasFornecidas.Items.Add(Convert.ToString(x[i]));
                        i++;
                        LblContagemAltura.Text = Convert.ToString(i);
                        TxtBoxEntradaAltura.Clear(); TxtBoxEntradaAltura.Focus();
                    }
                    else
                    {
                        LblContagemAltura.Text = Convert.ToString(i);
                        x[quantidade] = int.Parse(TxtBoxEntradaAltura.Text);
                        LblContagemAltura.Enabled = false;
                        TxtBoxEntradaAltura.Enabled = false;
                        TxtBoxEntradaQuantidade.Enabled = false;
                        LstBoxAlturasFornecidas.Items.Add(Convert.ToString(x[i]));
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Valor da altura inválido ! \n O valor precisar ser > 150 e < 220", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxEntradaAltura.Clear(); TxtBoxEntradaAltura.Focus();
            }
        } 
        #endregion
    }
}

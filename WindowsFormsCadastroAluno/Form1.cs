using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCadastroAluno
{
    public partial class CadastroAlunos : Form
    {
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
                //Adiciona o conteúdo das caixas de texto nas colunas correspondentes
                dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);

                //Limpa as caixas de texto
                txtNome.Clear();
                txtCurso.Clear();

                //Exibe uma mensagem ao usuário de inclusão com sucesso
                MessageBox.Show("Aluno Incluido Com Sucesso!", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Exibe na label o contador de linhas do GridView atualizado após a inserção
                lblTotal.Text = dgvAlunos.RowCount.ToString();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
                //Verifica a existência de linhas no Grid
                if (dgvAlunos.Rows.Count > 0)
            {
                //Remove a linha selecionada no Grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);

                //Exibe uma mensagem ao usuário de exclusão com sucesso
                MessageBox.Show("Aluno Excluído Com Sucesso!", "Exclusão",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Exibe na label o contador de linhas do GridView atualizado após a remoção
                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                //Move o conteúdo da primeira célula da linha selecionada para a caixa de texto
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                //Move o novo valor da caixa de texto alteração para a célula selecionada
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text;

                //Exibe a mensagem de alteracao com sucesso
                MessageBox.Show("Aluno Alterado Com Sucesso!", "Alterado",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;

            //Exibe na label o contador de linhas do GridView após ser zerado
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Finaliza a aplicação
            Application.Exit();
        }
    }
}

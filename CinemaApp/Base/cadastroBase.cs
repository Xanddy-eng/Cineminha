using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace CinemaApp.Base
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsEditMode { get; set; } = false;
        public CadastroBase()
        {
            InitializeComponent();
        }
              

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridViewConsulta.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = (int)dataGridViewConsulta.SelectedRows[0].Cells[0].Value;
                    Excluir(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampos()
        {
            IsEditMode = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                    ((MaterialTextBoxEdit)control).Clear();
                if (control is MaterialMaskedTextBox)
                    ((MaterialMaskedTextBox)control).Clear();
            }
        }

    }
}

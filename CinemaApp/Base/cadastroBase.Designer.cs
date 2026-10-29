using ReaLTaiizor;

namespace CinemaApp.Base
{
    partial class CadastroBase
    {
        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabPageConsulta;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.Sair = new ReaLTaiizor.Controls.Button();
            this.Salvar = new ReaLTaiizor.Controls.Button();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.Excluir = new ReaLTaiizor.Controls.Button();
            this.Editar = new ReaLTaiizor.Controls.Button();
            this.Novo = new ReaLTaiizor.Controls.Button();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.TabControlCadastro.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlCadastro
            // 
            this.TabControlCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlCadastro.Controls.Add(this.tabPageCadastro);
            this.TabControlCadastro.Controls.Add(this.tabPageConsulta);
            this.TabControlCadastro.Depth = 0;
            this.TabControlCadastro.ItemSize = new System.Drawing.Size(50, 20);
            this.TabControlCadastro.Location = new System.Drawing.Point(6, 67);
            this.TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TabControlCadastro.Multiline = true;
            this.TabControlCadastro.Name = "TabControlCadastro";
            this.TabControlCadastro.SelectedIndex = 0;
            this.TabControlCadastro.Size = new System.Drawing.Size(742, 359);
            this.TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.Sair);
            this.tabPageCadastro.Controls.Add(this.Salvar);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(734, 331);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair.BackColor = System.Drawing.Color.Transparent;
            this.Sair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Sair.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sair.Image = null;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Sair.Location = new System.Drawing.Point(482, 285);
            this.Sair.Name = "Sair";
            this.Sair.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Sair.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Sair.Size = new System.Drawing.Size(120, 40);
            this.Sair.TabIndex = 2;
            this.Sair.Text = "Sair";
            this.Sair.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Salvar.BackColor = System.Drawing.Color.Transparent;
            this.Salvar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Salvar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Salvar.Image = null;
            this.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salvar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Salvar.Location = new System.Drawing.Point(608, 285);
            this.Salvar.Name = "Salvar";
            this.Salvar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Salvar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Salvar.Size = new System.Drawing.Size(120, 40);
            this.Salvar.TabIndex = 1;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.Excluir);
            this.tabPageConsulta.Controls.Add(this.Editar);
            this.tabPageConsulta.Controls.Add(this.Novo);
            this.tabPageConsulta.Controls.Add(this.dataGridViewConsulta);
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 24);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(734, 331);
            this.tabPageConsulta.TabIndex = 1;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Excluir.BackColor = System.Drawing.Color.Transparent;
            this.Excluir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Excluir.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Excluir.Image = null;
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Excluir.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Excluir.Location = new System.Drawing.Point(356, 283);
            this.Excluir.Name = "Excluir";
            this.Excluir.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Excluir.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Excluir.Size = new System.Drawing.Size(120, 40);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Editar
            // 
            this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Editar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Editar.Image = null;
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Editar.Location = new System.Drawing.Point(482, 283);
            this.Editar.Name = "Editar";
            this.Editar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Editar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Editar.Size = new System.Drawing.Size(120, 40);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "Editar";
            this.Editar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Novo
            // 
            this.Novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Novo.BackColor = System.Drawing.Color.Transparent;
            this.Novo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Novo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Novo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Novo.Image = null;
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Novo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Novo.Location = new System.Drawing.Point(608, 283);
            this.Novo.Name = "Novo";
            this.Novo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Novo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Novo.Size = new System.Drawing.Size(120, 40);
            this.Novo.TabIndex = 3;
            this.Novo.Text = "Novo";
            this.Novo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(722, 271);
            this.dataGridViewConsulta.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(636, 32);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // CadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 432);
            this.Controls.Add(this.TabControlCadastro);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "CadastroBase";
            this.Text = "Cadastro Base";
            this.TabControlCadastro.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private ReaLTaiizor.Controls.Button Salvar;
        private ReaLTaiizor.Controls.Button Sair;
        private ReaLTaiizor.Controls.Button Excluir;
        private ReaLTaiizor.Controls.Button Editar;
        private ReaLTaiizor.Controls.Button Novo;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
    }
}
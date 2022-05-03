namespace eAgenda_2._0
{
    partial class ListagemTarefas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizarItens = new System.Windows.Forms.Button();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 14);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(87, 51);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.Location = new System.Drawing.Point(556, 14);
            this.btnAtualizarItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(87, 51);
            this.btnAtualizarItens.TabIndex = 8;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = true;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.Location = new System.Drawing.Point(420, 13);
            this.btnCadastrarItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(87, 51);
            this.btnCadastrarItens.TabIndex = 7;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(284, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 51);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(148, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 51);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 347);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(624, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.BackColor = System.Drawing.Color.White;
            this.listTarefasPendentes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listTarefasPendentes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listTarefasPendentes.ForeColor = System.Drawing.Color.White;
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 20;
            this.listTarefasPendentes.Location = new System.Drawing.Point(6, 15);
            this.listTarefasPendentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(612, 284);
            this.listTarefasPendentes.TabIndex = 6;
            this.listTarefasPendentes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTarefasPendentes_DrawItem);
            this.listTarefasPendentes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listTarefasPendentes_MouseDoubleClick);
            this.listTarefasPendentes.MouseHover += new System.EventHandler(this.listTarefasPendentes_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(624, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 20;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(11, 20);
            this.listTarefasConcluidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(580, 264);
            this.listTarefasConcluidas.TabIndex = 7;
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAtualizarItens);
            this.Controls.Add(this.btnCadastrarItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ListagemTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Tarefas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizarItens;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

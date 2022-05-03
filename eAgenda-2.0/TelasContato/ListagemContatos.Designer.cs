namespace eAgenda_2._0.TelasContato
{
    partial class ListagemContatos
    {
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
            this.components = new System.ComponentModel.Container();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.tabContatosOrdenados = new System.Windows.Forms.TabPage();
            this.listContatosOrdenados = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabContatos.SuspendLayout();
            this.tabContatosOrdenados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(580, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 51);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(294, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 51);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 13);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(82, 52);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // listContatos
            // 
            this.listContatos.ItemHeight = 20;
            this.listContatos.Location = new System.Drawing.Point(6, 6);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(635, 324);
            this.listContatos.TabIndex = 0;
            this.listContatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listContatos_MouseDoubleClick);
            this.listContatos.MouseHover += new System.EventHandler(this.listContatos_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContatos);
            this.tabControl1.Controls.Add(this.tabContatosOrdenados);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 366);
            this.tabControl1.TabIndex = 13;
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.listContatos);
            this.tabContatos.Location = new System.Drawing.Point(4, 29);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatos.Size = new System.Drawing.Size(647, 333);
            this.tabContatos.TabIndex = 0;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // tabContatosOrdenados
            // 
            this.tabContatosOrdenados.Controls.Add(this.listContatosOrdenados);
            this.tabContatosOrdenados.Location = new System.Drawing.Point(4, 29);
            this.tabContatosOrdenados.Name = "tabContatosOrdenados";
            this.tabContatosOrdenados.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatosOrdenados.Size = new System.Drawing.Size(647, 333);
            this.tabContatosOrdenados.TabIndex = 1;
            this.tabContatosOrdenados.Text = "Contatos ordenados";
            this.tabContatosOrdenados.UseVisualStyleBackColor = true;
            // 
            // listContatosOrdenados
            // 
            this.listContatosOrdenados.ItemHeight = 20;
            this.listContatosOrdenados.Location = new System.Drawing.Point(3, 3);
            this.listContatosOrdenados.Name = "listContatosOrdenados";
            this.listContatosOrdenados.Size = new System.Drawing.Size(635, 324);
            this.listContatosOrdenados.TabIndex = 1;
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.MaximizeBox = false;
            this.Name = "ListagemContatos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contatos";
            this.tabControl1.ResumeLayout(false);
            this.tabContatos.ResumeLayout(false);
            this.tabContatosOrdenados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.TabPage tabContatosOrdenados;
        private System.Windows.Forms.ListBox listContatosOrdenados;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
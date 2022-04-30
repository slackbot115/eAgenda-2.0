namespace eAgenda_2._0
{
    partial class CadastroItensTarefa
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTituloItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensTarefa = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.pbarCompletude = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(316, 386);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 52);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(222, 386);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 52);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtTituloItem
            // 
            this.txtTituloItem.Location = new System.Drawing.Point(66, 76);
            this.txtTituloItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTituloItem.Name = "txtTituloItem";
            this.txtTituloItem.Size = new System.Drawing.Size(222, 27);
            this.txtTituloItem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título:";
            // 
            // listItensTarefa
            // 
            this.listItensTarefa.FormattingEnabled = true;
            this.listItensTarefa.ItemHeight = 20;
            this.listItensTarefa.Location = new System.Drawing.Point(14, 135);
            this.listItensTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listItensTarefa.Name = "listItensTarefa";
            this.listItensTarefa.Size = new System.Drawing.Size(382, 164);
            this.listItensTarefa.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(298, 76);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 31);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarefa:";
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.Location = new System.Drawing.Point(67, 25);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(110, 20);
            this.labelTituloTarefa.TabIndex = 13;
            this.labelTituloTarefa.Text = "[Titulo Tarefa]";
            // 
            // pbarCompletude
            // 
            this.pbarCompletude.Location = new System.Drawing.Point(118, 317);
            this.pbarCompletude.Name = "pbarCompletude";
            this.pbarCompletude.Size = new System.Drawing.Size(143, 28);
            this.pbarCompletude.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Completude: ";
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbarCompletude);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listItensTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloItem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens da Tarefa";
            this.Load += new System.EventHandler(this.CadastroItensTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtTituloItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.ProgressBar pbarCompletude;
        private System.Windows.Forms.Label label3;
    }
}
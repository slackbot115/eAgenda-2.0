namespace eAgenda_2._0.TelasTarefa
{
    partial class DetalhesTarefa
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbarCompletude = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prioridade:";
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrioridade.Enabled = false;
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.comboPrioridade.Location = new System.Drawing.Point(103, 103);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(151, 28);
            this.comboPrioridade.TabIndex = 12;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(103, 61);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(262, 27);
            this.txtTitulo.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(103, 13);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(84, 27);
            this.txtNumero.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número:";
            // 
            // listItensTarefa
            // 
            this.listItensTarefa.CheckOnClick = true;
            this.listItensTarefa.Enabled = false;
            this.listItensTarefa.FormattingEnabled = true;
            this.listItensTarefa.Location = new System.Drawing.Point(13, 169);
            this.listItensTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listItensTarefa.Name = "listItensTarefa";
            this.listItensTarefa.Size = new System.Drawing.Size(352, 246);
            this.listItensTarefa.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Itens:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Completude: ";
            // 
            // pbarCompletude
            // 
            this.pbarCompletude.Location = new System.Drawing.Point(117, 429);
            this.pbarCompletude.Name = "pbarCompletude";
            this.pbarCompletude.Size = new System.Drawing.Size(248, 28);
            this.pbarCompletude.TabIndex = 20;
            // 
            // DetalhesTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbarCompletude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listItensTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPrioridade);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DetalhesTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da tarefa";
            this.Load += new System.EventHandler(this.DetalhesTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPrioridade;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listItensTarefa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbarCompletude;
    }
}
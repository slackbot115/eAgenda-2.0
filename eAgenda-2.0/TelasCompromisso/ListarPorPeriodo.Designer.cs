namespace eAgenda_2._0.TelasCompromisso
{
    partial class ListarPorPeriodo
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
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listDatasDoPeriodo = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Location = new System.Drawing.Point(12, 49);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(250, 27);
            this.dateDataInicial.TabIndex = 0;
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Location = new System.Drawing.Point(403, 49);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(250, 27);
            this.dateDataFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de término:";
            // 
            // listDatasDoPeriodo
            // 
            this.listDatasDoPeriodo.FormattingEnabled = true;
            this.listDatasDoPeriodo.ItemHeight = 20;
            this.listDatasDoPeriodo.Location = new System.Drawing.Point(12, 106);
            this.listDatasDoPeriodo.Name = "listDatasDoPeriodo";
            this.listDatasDoPeriodo.Size = new System.Drawing.Size(641, 244);
            this.listDatasDoPeriodo.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(486, 370);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 68);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(304, 370);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(167, 68);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // ListarPorPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listDatasDoPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDataFinal);
            this.Controls.Add(this.dateDataInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ListarPorPeriodo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarPorPeriodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listDatasDoPeriodo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnListar;
    }
}
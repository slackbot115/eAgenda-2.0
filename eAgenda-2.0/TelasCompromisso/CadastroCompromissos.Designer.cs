namespace eAgenda_2._0.TelasCompromisso
{
    partial class CadastroCompromissos
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
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboContatos = new System.Windows.Forms.ComboBox();
            this.dateDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.dateHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(89, 95);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(397, 27);
            this.txtLocal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Local*:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(89, 54);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(397, 27);
            this.txtAssunto.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(89, 13);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(84, 27);
            this.txtNumero.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Assunto*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data do \r\ncompromisso*:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hora de início:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hora de término:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(404, 308);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 52);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(295, 308);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 52);
            this.btnGravar.TabIndex = 25;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Contato*: ";
            // 
            // comboContatos
            // 
            this.comboContatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContatos.FormattingEnabled = true;
            this.comboContatos.Location = new System.Drawing.Point(86, 240);
            this.comboContatos.Name = "comboContatos";
            this.comboContatos.Size = new System.Drawing.Size(208, 28);
            this.comboContatos.TabIndex = 28;
            // 
            // dateDataCompromisso
            // 
            this.dateDataCompromisso.Location = new System.Drawing.Point(122, 141);
            this.dateDataCompromisso.Name = "dateDataCompromisso";
            this.dateDataCompromisso.Size = new System.Drawing.Size(364, 27);
            this.dateDataCompromisso.TabIndex = 29;
            // 
            // dateHoraInicio
            // 
            this.dateHoraInicio.Location = new System.Drawing.Point(124, 193);
            this.dateHoraInicio.Name = "dateHoraInicio";
            this.dateHoraInicio.Size = new System.Drawing.Size(113, 27);
            this.dateHoraInicio.TabIndex = 30;
            // 
            // dateHoraTermino
            // 
            this.dateHoraTermino.Location = new System.Drawing.Point(371, 193);
            this.dateHoraTermino.Name = "dateHoraTermino";
            this.dateHoraTermino.Size = new System.Drawing.Size(115, 27);
            this.dateHoraTermino.TabIndex = 31;
            // 
            // CadastroCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 373);
            this.Controls.Add(this.dateHoraTermino);
            this.Controls.Add(this.dateHoraInicio);
            this.Controls.Add(this.dateDataCompromisso);
            this.Controls.Add(this.comboContatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastroCompromissos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Compromissos";
            this.Load += new System.EventHandler(this.CadastroCompromissos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboContatos;
        private System.Windows.Forms.DateTimePicker dateDataCompromisso;
        private System.Windows.Forms.DateTimePicker dateHoraInicio;
        private System.Windows.Forms.DateTimePicker dateHoraTermino;
    }
}
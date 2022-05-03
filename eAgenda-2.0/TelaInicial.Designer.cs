namespace eAgenda_2._0
{
    partial class TelaInicial
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(12, 22);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(177, 113);
            this.btnTarefas.TabIndex = 2;
            this.btnTarefas.Text = "Gerenciamento de Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Location = new System.Drawing.Point(251, 22);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(177, 113);
            this.btnContatos.TabIndex = 3;
            this.btnContatos.Text = "Gerenciamento de Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Location = new System.Drawing.Point(490, 22);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(177, 113);
            this.btnCompromissos.TabIndex = 4;
            this.btnCompromissos.Text = "Gerenciamento de Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eAgenda_2._0.Properties.Resources.tarefas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eAgenda_2._0.Properties.Resources.contatos1;
            this.pictureBox2.Location = new System.Drawing.Point(251, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eAgenda_2._0.Properties.Resources.compromissos;
            this.pictureBox3.Location = new System.Drawing.Point(490, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 404);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

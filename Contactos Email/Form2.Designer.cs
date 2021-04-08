
namespace Contactos_Email
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gbTipoContato = new System.Windows.Forms.GroupBox();
            this.radioComunicaçaoSocial = new System.Windows.Forms.RadioButton();
            this.radioComerciante = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbTipoContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.gbTipoContato);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(51, 208);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(273, 38);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // gbTipoContato
            // 
            this.gbTipoContato.Controls.Add(this.radioComunicaçaoSocial);
            this.gbTipoContato.Controls.Add(this.radioComerciante);
            this.gbTipoContato.Location = new System.Drawing.Point(17, 114);
            this.gbTipoContato.Name = "gbTipoContato";
            this.gbTipoContato.Size = new System.Drawing.Size(186, 75);
            this.gbTipoContato.TabIndex = 4;
            this.gbTipoContato.TabStop = false;
            this.gbTipoContato.Text = "Tipo de Contato";
            // 
            // radioComunicaçaoSocial
            // 
            this.radioComunicaçaoSocial.AutoSize = true;
            this.radioComunicaçaoSocial.Location = new System.Drawing.Point(6, 44);
            this.radioComunicaçaoSocial.Name = "radioComunicaçaoSocial";
            this.radioComunicaçaoSocial.Size = new System.Drawing.Size(133, 19);
            this.radioComunicaçaoSocial.TabIndex = 1;
            this.radioComunicaçaoSocial.TabStop = true;
            this.radioComunicaçaoSocial.Text = "Comunicação Social";
            this.radioComunicaçaoSocial.UseVisualStyleBackColor = true;
            // 
            // radioComerciante
            // 
            this.radioComerciante.AutoSize = true;
            this.radioComerciante.Location = new System.Drawing.Point(6, 19);
            this.radioComerciante.Name = "radioComerciante";
            this.radioComerciante.Size = new System.Drawing.Size(93, 19);
            this.radioComerciante.TabIndex = 0;
            this.radioComerciante.TabStop = true;
            this.radioComerciante.Text = "Comerciante";
            this.radioComerciante.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 330);
            this.MinimumSize = new System.Drawing.Size(420, 330);
            this.Name = "Form2";
            this.Text = "Adicionar Contato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTipoContato.ResumeLayout(false);
            this.gbTipoContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gbTipoContato;
        private System.Windows.Forms.RadioButton radioComunicaçaoSocial;
        private System.Windows.Forms.RadioButton radioComerciante;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
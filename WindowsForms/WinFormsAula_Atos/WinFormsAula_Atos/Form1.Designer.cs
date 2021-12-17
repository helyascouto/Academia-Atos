
namespace WinFormsAula_Atos
{
    partial class Form1
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
            this.btnNome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResutado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnconfirmarIdade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbnNao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbnSim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEsqueda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btmCentro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnNome.Location = new System.Drawing.Point(6, 137);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(157, 23);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Confirmar";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira n1";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(6, 46);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(157, 23);
            this.txtN1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira n2";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(6, 90);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(157, 23);
            this.txtN2.TabIndex = 2;
            // 
            // lblResutado
            // 
            this.lblResutado.AutoSize = true;
            this.lblResutado.Location = new System.Drawing.Point(6, 137);
            this.lblResutado.Name = "lblResutado";
            this.lblResutado.Size = new System.Drawing.Size(0, 15);
            this.lblResutado.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtN2);
            this.groupBox1.Controls.Add(this.btnNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblResutado);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdade);
            this.groupBox2.Controls.Add(this.btnconfirmarIdade);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.lbnNao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbnSim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(290, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(6, 90);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(157, 23);
            this.txtIdade.TabIndex = 2;
            // 
            // btnconfirmarIdade
            // 
            this.btnconfirmarIdade.Location = new System.Drawing.Point(0, 191);
            this.btnconfirmarIdade.Name = "btnconfirmarIdade";
            this.btnconfirmarIdade.Size = new System.Drawing.Size(157, 23);
            this.btnconfirmarIdade.TabIndex = 0;
            this.btnconfirmarIdade.Text = "Confirmar";
            this.btnconfirmarIdade.UseVisualStyleBackColor = true;
            this.btnconfirmarIdade.Click += new System.EventHandler(this.btnconfirmarIdade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lbnNao
            // 
            this.lbnNao.AutoSize = true;
            this.lbnNao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbnNao.Location = new System.Drawing.Point(81, 173);
            this.lbnNao.Name = "lbnNao";
            this.lbnNao.Size = new System.Drawing.Size(27, 15);
            this.lbnNao.TabIndex = 1;
            this.lbnNao.Text = "não";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Você e maior de idade?";
            // 
            // lbnSim
            // 
            this.lbnSim.AutoSize = true;
            this.lbnSim.Location = new System.Drawing.Point(39, 173);
            this.lbnSim.Name = "lbnSim";
            this.lbnSim.Size = new System.Drawing.Size(27, 15);
            this.lbnSim.TabIndex = 1;
            this.lbnSim.Text = "Sim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "idade";
            // 
            // btnEsqueda
            // 
            this.btnEsqueda.Location = new System.Drawing.Point(60, 387);
            this.btnEsqueda.Name = "btnEsqueda";
            this.btnEsqueda.Size = new System.Drawing.Size(157, 23);
            this.btnEsqueda.TabIndex = 0;
            this.btnEsqueda.Text = "esquerda";
            this.btnEsqueda.UseVisualStyleBackColor = true;
            this.btnEsqueda.Click += new System.EventHandler(this.btnEsqueda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(241, 387);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(157, 23);
            this.btnDireita.TabIndex = 0;
            this.btnDireita.Text = "direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btmCentro
            // 
            this.btmCentro.Location = new System.Drawing.Point(156, 330);
            this.btmCentro.Name = "btmCentro";
            this.btmCentro.Size = new System.Drawing.Size(157, 23);
            this.btmCentro.TabIndex = 0;
            this.btmCentro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btmCentro);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnEsqueda);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblResutado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnconfirmarIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbnNao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbnSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEsqueda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btmCentro;
    }
}


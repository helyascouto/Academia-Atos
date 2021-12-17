namespace Serializaçao_WinForms
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
            this.btnSerializar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeserializarXml = new System.Windows.Forms.Button();
            this.txbXml = new System.Windows.Forms.TextBox();
            this.btnSerializeXML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeserializarJson = new System.Windows.Forms.Button();
            this.txbJson = new System.Windows.Forms.TextBox();
            this.btnSerializeJsomL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSoap = new System.Windows.Forms.TextBox();
            this.btnDeserializeSoap = new System.Windows.Forms.Button();
            this.btnSerializeSoap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(259, 25);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(84, 23);
            this.btnSerializar.TabIndex = 0;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a ser serializado:";
            // 
            // txbMensagem
            // 
            this.txbMensagem.Location = new System.Drawing.Point(144, 26);
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.Size = new System.Drawing.Size(109, 23);
            this.txbMensagem.TabIndex = 2;
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(349, 25);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializar.TabIndex = 3;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto a ser serializado:";
            // 
            // btnDeserializarXml
            // 
            this.btnDeserializarXml.Location = new System.Drawing.Point(351, 21);
            this.btnDeserializarXml.Name = "btnDeserializarXml";
            this.btnDeserializarXml.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializarXml.TabIndex = 3;
            this.btnDeserializarXml.Text = "Deserializar";
            this.btnDeserializarXml.UseVisualStyleBackColor = true;
            this.btnDeserializarXml.Click += new System.EventHandler(this.btnDesserializarXML_Click);
            // 
            // txbXml
            // 
            this.txbXml.Location = new System.Drawing.Point(144, 22);
            this.txbXml.Name = "txbXml";
            this.txbXml.Size = new System.Drawing.Size(109, 23);
            this.txbXml.TabIndex = 2;
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.Location = new System.Drawing.Point(261, 21);
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(84, 23);
            this.btnSerializeXML.TabIndex = 0;
            this.btnSerializeXML.Text = "Serializar";
            this.btnSerializeXML.UseVisualStyleBackColor = true;
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto a ser serializado:";
            // 
            // btnDeserializarJson
            // 
            this.btnDeserializarJson.Location = new System.Drawing.Point(349, 26);
            this.btnDeserializarJson.Name = "btnDeserializarJson";
            this.btnDeserializarJson.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializarJson.TabIndex = 3;
            this.btnDeserializarJson.Text = "Deserializar";
            this.btnDeserializarJson.UseVisualStyleBackColor = true;
            this.btnDeserializarJson.Click += new System.EventHandler(this.btnDeserializarJson_Click);
            // 
            // txbJson
            // 
            this.txbJson.Location = new System.Drawing.Point(144, 27);
            this.txbJson.Name = "txbJson";
            this.txbJson.Size = new System.Drawing.Size(109, 23);
            this.txbJson.TabIndex = 2;
            // 
            // btnSerializeJsomL
            // 
            this.btnSerializeJsomL.Location = new System.Drawing.Point(259, 26);
            this.btnSerializeJsomL.Name = "btnSerializeJsomL";
            this.btnSerializeJsomL.Size = new System.Drawing.Size(84, 23);
            this.btnSerializeJsomL.TabIndex = 0;
            this.btnSerializeJsomL.Text = "Serializar";
            this.btnSerializeJsomL.UseVisualStyleBackColor = true;
            this.btnSerializeJsomL.Click += new System.EventHandler(this.btnSerializeJsomL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbXml);
            this.groupBox1.Controls.Add(this.btnDeserializarXml);
            this.groupBox1.Controls.Add(this.btnSerializeXML);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDeserializarJson);
            this.groupBox2.Controls.Add(this.btnSerializeJsomL);
            this.groupBox2.Controls.Add(this.txbJson);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnDeserializar);
            this.groupBox3.Controls.Add(this.txbMensagem);
            this.groupBox3.Controls.Add(this.btnSerializar);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 67);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TXT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txbSoap);
            this.groupBox4.Controls.Add(this.btnDeserializeSoap);
            this.groupBox4.Controls.Add(this.btnSerializeSoap);
            this.groupBox4.Location = new System.Drawing.Point(12, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 69);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SOAP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Texto a ser serializado:";
            // 
            // txbSoap
            // 
            this.txbSoap.Location = new System.Drawing.Point(144, 22);
            this.txbSoap.Name = "txbSoap";
            this.txbSoap.Size = new System.Drawing.Size(109, 23);
            this.txbSoap.TabIndex = 2;
            // 
            // btnDeserializeSoap
            // 
            this.btnDeserializeSoap.Location = new System.Drawing.Point(349, 21);
            this.btnDeserializeSoap.Name = "btnDeserializeSoap";
            this.btnDeserializeSoap.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializeSoap.TabIndex = 3;
            this.btnDeserializeSoap.Text = "Deserializar";
            this.btnDeserializeSoap.UseVisualStyleBackColor = true;
            this.btnDeserializeSoap.Click += new System.EventHandler(this.btnDeserializeSoap_Click);
            // 
            // btnSerializeSoap
            // 
            this.btnSerializeSoap.Location = new System.Drawing.Point(259, 21);
            this.btnSerializeSoap.Name = "btnSerializeSoap";
            this.btnSerializeSoap.Size = new System.Drawing.Size(84, 23);
            this.btnSerializeSoap.TabIndex = 0;
            this.btnSerializeSoap.Text = "Serializar";
            this.btnSerializeSoap.UseVisualStyleBackColor = true;
            this.btnSerializeSoap.Click += new System.EventHandler(this.btnSerializeSoap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSerializar;
        private Label label1;
        private TextBox txbMensagem;
        private Button btnDeserializar;
        private Label label2;
        private Button btnDeserializarXml;
        private TextBox txbXml;
        private Button btnSerializeXML;
        private Label label3;
        private Button btnDeserializarJson;
        private TextBox txbJson;
        private Button btnSerializeJsomL;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox txbSoap;
        private Button btnDeserializeSoap;
        private Button btnSerializeSoap;
    }
}
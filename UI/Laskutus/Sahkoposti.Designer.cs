namespace VillageNewbies.UI
{
    partial class Sahkoposti
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_SMTP = new System.Windows.Forms.ComboBox();
            this.textBox_LahettajaSalasana = new System.Windows.Forms.TextBox();
            this.Textbox_LahettajaEmail = new System.Windows.Forms.TextBox();
            this.label_SMTP = new System.Windows.Forms.Label();
            this.label_LahettajaSalasana = new System.Windows.Forms.Label();
            this.label_LahettajaEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_VastOttajanEmail = new System.Windows.Forms.TextBox();
            this.label_VastOttajanEmail = new System.Windows.Forms.Label();
            this.label_VastOttajanTiedot = new System.Windows.Forms.Label();
            this.richTextBox_Viesti = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Selaa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Aihe = new System.Windows.Forms.TextBox();
            this.label_Aihe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Laheta = new System.Windows.Forms.Button();
            this.label_Viesti = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_SMTP);
            this.panel1.Controls.Add(this.textBox_LahettajaSalasana);
            this.panel1.Controls.Add(this.Textbox_LahettajaEmail);
            this.panel1.Controls.Add(this.label_SMTP);
            this.panel1.Controls.Add(this.label_LahettajaSalasana);
            this.panel1.Controls.Add(this.label_LahettajaEmail);
            this.panel1.Location = new System.Drawing.Point(23, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 160);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_SMTP
            // 
            this.comboBox_SMTP.FormattingEnabled = true;
            this.comboBox_SMTP.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.office365.com"});
            this.comboBox_SMTP.Location = new System.Drawing.Point(142, 96);
            this.comboBox_SMTP.Name = "comboBox_SMTP";
            this.comboBox_SMTP.Size = new System.Drawing.Size(199, 24);
            this.comboBox_SMTP.TabIndex = 2;
            // 
            // textBox_LahettajaSalasana
            // 
            this.textBox_LahettajaSalasana.Location = new System.Drawing.Point(142, 58);
            this.textBox_LahettajaSalasana.Name = "textBox_LahettajaSalasana";
            this.textBox_LahettajaSalasana.PasswordChar = '*';
            this.textBox_LahettajaSalasana.Size = new System.Drawing.Size(199, 22);
            this.textBox_LahettajaSalasana.TabIndex = 1;
            // 
            // Textbox_LahettajaEmail
            // 
            this.Textbox_LahettajaEmail.Location = new System.Drawing.Point(142, 21);
            this.Textbox_LahettajaEmail.Name = "Textbox_LahettajaEmail";
            this.Textbox_LahettajaEmail.Size = new System.Drawing.Size(199, 22);
            this.Textbox_LahettajaEmail.TabIndex = 1;
            // 
            // label_SMTP
            // 
            this.label_SMTP.AutoSize = true;
            this.label_SMTP.Location = new System.Drawing.Point(30, 99);
            this.label_SMTP.Name = "label_SMTP";
            this.label_SMTP.Size = new System.Drawing.Size(103, 17);
            this.label_SMTP.TabIndex = 0;
            this.label_SMTP.Text = "SMTP-palvelin:";
            // 
            // label_LahettajaSalasana
            // 
            this.label_LahettajaSalasana.AutoSize = true;
            this.label_LahettajaSalasana.Location = new System.Drawing.Point(30, 61);
            this.label_LahettajaSalasana.Name = "label_LahettajaSalasana";
            this.label_LahettajaSalasana.Size = new System.Drawing.Size(71, 17);
            this.label_LahettajaSalasana.TabIndex = 0;
            this.label_LahettajaSalasana.Text = "Salasana:";
            // 
            // label_LahettajaEmail
            // 
            this.label_LahettajaEmail.AutoSize = true;
            this.label_LahettajaEmail.Location = new System.Drawing.Point(30, 24);
            this.label_LahettajaEmail.Name = "label_LahettajaEmail";
            this.label_LahettajaEmail.Size = new System.Drawing.Size(46, 17);
            this.label_LahettajaEmail.TabIndex = 0;
            this.label_LahettajaEmail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lähettäjän tiedot";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_VastOttajanEmail);
            this.panel2.Controls.Add(this.label_VastOttajanEmail);
            this.panel2.Location = new System.Drawing.Point(23, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 87);
            this.panel2.TabIndex = 2;
            // 
            // textBox_VastOttajanEmail
            // 
            this.textBox_VastOttajanEmail.Location = new System.Drawing.Point(142, 23);
            this.textBox_VastOttajanEmail.Name = "textBox_VastOttajanEmail";
            this.textBox_VastOttajanEmail.Size = new System.Drawing.Size(199, 22);
            this.textBox_VastOttajanEmail.TabIndex = 1;
            // 
            // label_VastOttajanEmail
            // 
            this.label_VastOttajanEmail.AutoSize = true;
            this.label_VastOttajanEmail.Location = new System.Drawing.Point(30, 26);
            this.label_VastOttajanEmail.Name = "label_VastOttajanEmail";
            this.label_VastOttajanEmail.Size = new System.Drawing.Size(46, 17);
            this.label_VastOttajanEmail.TabIndex = 0;
            this.label_VastOttajanEmail.Text = "Email:";
            // 
            // label_VastOttajanTiedot
            // 
            this.label_VastOttajanTiedot.AutoSize = true;
            this.label_VastOttajanTiedot.Location = new System.Drawing.Point(45, 249);
            this.label_VastOttajanTiedot.Name = "label_VastOttajanTiedot";
            this.label_VastOttajanTiedot.Size = new System.Drawing.Size(142, 17);
            this.label_VastOttajanTiedot.TabIndex = 3;
            this.label_VastOttajanTiedot.Text = "Vastaanottajan tiedot";
            // 
            // richTextBox_Viesti
            // 
            this.richTextBox_Viesti.Location = new System.Drawing.Point(493, 31);
            this.richTextBox_Viesti.Name = "richTextBox_Viesti";
            this.richTextBox_Viesti.Size = new System.Drawing.Size(451, 415);
            this.richTextBox_Viesti.TabIndex = 4;
            this.richTextBox_Viesti.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Selaa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_Aihe);
            this.panel3.Controls.Add(this.label_Aihe);
            this.panel3.Location = new System.Drawing.Point(23, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 120);
            this.panel3.TabIndex = 5;
            // 
            // Btn_Selaa
            // 
            this.Btn_Selaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Selaa.Location = new System.Drawing.Point(142, 62);
            this.Btn_Selaa.Name = "Btn_Selaa";
            this.Btn_Selaa.Size = new System.Drawing.Size(82, 30);
            this.Btn_Selaa.TabIndex = 3;
            this.Btn_Selaa.Text = "Selaa";
            this.Btn_Selaa.UseVisualStyleBackColor = true;
            this.Btn_Selaa.Click += new System.EventHandler(this.Btn_Selaa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liitetiedosto:";
            // 
            // textBox_Aihe
            // 
            this.textBox_Aihe.Location = new System.Drawing.Point(142, 26);
            this.textBox_Aihe.Name = "textBox_Aihe";
            this.textBox_Aihe.Size = new System.Drawing.Size(199, 22);
            this.textBox_Aihe.TabIndex = 1;
            // 
            // label_Aihe
            // 
            this.label_Aihe.AutoSize = true;
            this.label_Aihe.Location = new System.Drawing.Point(33, 29);
            this.label_Aihe.Name = "label_Aihe";
            this.label_Aihe.Size = new System.Drawing.Size(40, 17);
            this.label_Aihe.TabIndex = 0;
            this.label_Aihe.Text = "Aihe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sähköpostin tiedot";
            // 
            // button_Laheta
            // 
            this.button_Laheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Laheta.Location = new System.Drawing.Point(852, 470);
            this.button_Laheta.Name = "button_Laheta";
            this.button_Laheta.Size = new System.Drawing.Size(92, 35);
            this.button_Laheta.TabIndex = 6;
            this.button_Laheta.Text = "Lähetä";
            this.button_Laheta.UseVisualStyleBackColor = true;
            this.button_Laheta.Click += new System.EventHandler(this.button_Laheta_Click);
            // 
            // label_Viesti
            // 
            this.label_Viesti.AutoSize = true;
            this.label_Viesti.Location = new System.Drawing.Point(493, 8);
            this.label_Viesti.Name = "label_Viesti";
            this.label_Viesti.Size = new System.Drawing.Size(42, 17);
            this.label_Viesti.TabIndex = 7;
            this.label_Viesti.Text = "Viesti";
            // 
            // Sahkoposti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 532);
            this.Controls.Add(this.label_Viesti);
            this.Controls.Add(this.button_Laheta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox_Viesti);
            this.Controls.Add(this.label_VastOttajanTiedot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Sahkoposti";
            this.Text = "Sahkoposti";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_SMTP;
        private System.Windows.Forms.TextBox textBox_LahettajaSalasana;
        private System.Windows.Forms.TextBox Textbox_LahettajaEmail;
        private System.Windows.Forms.Label label_SMTP;
        private System.Windows.Forms.Label label_LahettajaSalasana;
        private System.Windows.Forms.Label label_LahettajaEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_VastOttajanEmail;
        private System.Windows.Forms.Label label_VastOttajanEmail;
        private System.Windows.Forms.Label label_VastOttajanTiedot;
        private System.Windows.Forms.RichTextBox richTextBox_Viesti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Aihe;
        private System.Windows.Forms.Label label_Aihe;
        private System.Windows.Forms.Button Btn_Selaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Laheta;
        private System.Windows.Forms.Label label_Viesti;
    }
}
namespace VillageNewbies.UI
{
    partial class AsiakasHallinta
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
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Etunimi = new System.Windows.Forms.Label();
            this.textBox_Etunimi = new System.Windows.Forms.TextBox();
            this.label_Sukunimi = new System.Windows.Forms.Label();
            this.textBox_Sukunimi = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_PuhNro = new System.Windows.Forms.Label();
            this.textBox_Puhnro = new System.Windows.Forms.TextBox();
            this.label_Osoite = new System.Windows.Forms.Label();
            this.textBox_Osoite = new System.Windows.Forms.TextBox();
            this.dataGridView_Asiakkaat = new System.Windows.Forms.DataGridView();
            this.label_PostNro = new System.Windows.Forms.Label();
            this.textBox_Postinro = new System.Windows.Forms.TextBox();
            this.btn_lisaa = new System.Windows.Forms.Button();
            this.btn_muokkaa = new System.Windows.Forms.Button();
            this.btn_poista = new System.Windows.Forms.Button();
            this.label_PostiPaikka = new System.Windows.Forms.Label();
            this.textBox_Postitoimipaikka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_EtsiSukunimellä = new System.Windows.Forms.Label();
            this.Btn_Tyhjenna = new System.Windows.Forms.Button();
            this.label_EtsiPostiNro = new System.Windows.Forms.Label();
            this.textBox_EtsiPostiNro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asiakkaat)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(15, 97);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(91, 94);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // label_Etunimi
            // 
            this.label_Etunimi.AutoSize = true;
            this.label_Etunimi.Location = new System.Drawing.Point(237, 97);
            this.label_Etunimi.Name = "label_Etunimi";
            this.label_Etunimi.Size = new System.Drawing.Size(54, 17);
            this.label_Etunimi.TabIndex = 0;
            this.label_Etunimi.Text = "Etunimi";
            // 
            // textBox_Etunimi
            // 
            this.textBox_Etunimi.Location = new System.Drawing.Point(311, 94);
            this.textBox_Etunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Etunimi.Name = "textBox_Etunimi";
            this.textBox_Etunimi.Size = new System.Drawing.Size(100, 22);
            this.textBox_Etunimi.TabIndex = 2;
            this.textBox_Etunimi.TextChanged += new System.EventHandler(this.textBox_Etunimi_TextChanged);
            // 
            // label_Sukunimi
            // 
            this.label_Sukunimi.AutoSize = true;
            this.label_Sukunimi.Location = new System.Drawing.Point(439, 97);
            this.label_Sukunimi.Name = "label_Sukunimi";
            this.label_Sukunimi.Size = new System.Drawing.Size(65, 17);
            this.label_Sukunimi.TabIndex = 0;
            this.label_Sukunimi.Text = "Sukunimi";
            // 
            // textBox_Sukunimi
            // 
            this.textBox_Sukunimi.Location = new System.Drawing.Point(572, 94);
            this.textBox_Sukunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Sukunimi.Name = "textBox_Sukunimi";
            this.textBox_Sukunimi.Size = new System.Drawing.Size(100, 22);
            this.textBox_Sukunimi.TabIndex = 3;
            this.textBox_Sukunimi.TextChanged += new System.EventHandler(this.textBox_Sukunimi_TextChanged);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(237, 175);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(42, 17);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(311, 175);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 22);
            this.textBox_Email.TabIndex = 8;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label_PuhNro
            // 
            this.label_PuhNro.AutoSize = true;
            this.label_PuhNro.Location = new System.Drawing.Point(15, 178);
            this.label_PuhNro.Name = "label_PuhNro";
            this.label_PuhNro.Size = new System.Drawing.Size(37, 17);
            this.label_PuhNro.TabIndex = 0;
            this.label_PuhNro.Text = "Puh.";
            // 
            // textBox_Puhnro
            // 
            this.textBox_Puhnro.Location = new System.Drawing.Point(91, 175);
            this.textBox_Puhnro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Puhnro.Name = "textBox_Puhnro";
            this.textBox_Puhnro.Size = new System.Drawing.Size(100, 22);
            this.textBox_Puhnro.TabIndex = 7;
            this.textBox_Puhnro.TextChanged += new System.EventHandler(this.textBox_Puhnro_TextChanged);
            // 
            // label_Osoite
            // 
            this.label_Osoite.AutoSize = true;
            this.label_Osoite.Location = new System.Drawing.Point(13, 141);
            this.label_Osoite.Name = "label_Osoite";
            this.label_Osoite.Size = new System.Drawing.Size(49, 17);
            this.label_Osoite.TabIndex = 0;
            this.label_Osoite.Text = "Osoite";
            // 
            // textBox_Osoite
            // 
            this.textBox_Osoite.Location = new System.Drawing.Point(91, 139);
            this.textBox_Osoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Osoite.Name = "textBox_Osoite";
            this.textBox_Osoite.Size = new System.Drawing.Size(100, 22);
            this.textBox_Osoite.TabIndex = 4;
            this.textBox_Osoite.TextChanged += new System.EventHandler(this.textBox_Osoite_TextChanged);
            // 
            // dataGridView_Asiakkaat
            // 
            this.dataGridView_Asiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Asiakkaat.Location = new System.Drawing.Point(16, 229);
            this.dataGridView_Asiakkaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Asiakkaat.Name = "dataGridView_Asiakkaat";
            this.dataGridView_Asiakkaat.ReadOnly = true;
            this.dataGridView_Asiakkaat.RowHeadersVisible = false;
            this.dataGridView_Asiakkaat.RowHeadersWidth = 51;
            this.dataGridView_Asiakkaat.RowTemplate.Height = 24;
            this.dataGridView_Asiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Asiakkaat.Size = new System.Drawing.Size(1107, 294);
            this.dataGridView_Asiakkaat.TabIndex = 10;
            this.dataGridView_Asiakkaat.SelectionChanged += new System.EventHandler(this.dataGridView_Asiakkaat_SelectionChanged);
            // 
            // label_PostNro
            // 
            this.label_PostNro.AutoSize = true;
            this.label_PostNro.Location = new System.Drawing.Point(218, 139);
            this.label_PostNro.Name = "label_PostNro";
            this.label_PostNro.Size = new System.Drawing.Size(87, 17);
            this.label_PostNro.TabIndex = 0;
            this.label_PostNro.Text = "Postinumero";
            // 
            // textBox_Postinro
            // 
            this.textBox_Postinro.Location = new System.Drawing.Point(311, 136);
            this.textBox_Postinro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Postinro.Name = "textBox_Postinro";
            this.textBox_Postinro.Size = new System.Drawing.Size(100, 22);
            this.textBox_Postinro.TabIndex = 5;
            this.textBox_Postinro.TextChanged += new System.EventHandler(this.textBox_Postinro_TextChanged);
            // 
            // btn_lisaa
            // 
            this.btn_lisaa.Location = new System.Drawing.Point(211, 551);
            this.btn_lisaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lisaa.Name = "btn_lisaa";
            this.btn_lisaa.Size = new System.Drawing.Size(112, 23);
            this.btn_lisaa.TabIndex = 11;
            this.btn_lisaa.Text = "Lisää";
            this.btn_lisaa.UseVisualStyleBackColor = true;
            this.btn_lisaa.Click += new System.EventHandler(this.btn_lisaa_Click);
            // 
            // btn_muokkaa
            // 
            this.btn_muokkaa.Location = new System.Drawing.Point(349, 551);
            this.btn_muokkaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_muokkaa.Name = "btn_muokkaa";
            this.btn_muokkaa.Size = new System.Drawing.Size(100, 23);
            this.btn_muokkaa.TabIndex = 12;
            this.btn_muokkaa.Text = "Muokkaa";
            this.btn_muokkaa.UseVisualStyleBackColor = true;
            this.btn_muokkaa.Click += new System.EventHandler(this.btn_muokkaa_Click);
            // 
            // btn_poista
            // 
            this.btn_poista.Location = new System.Drawing.Point(483, 551);
            this.btn_poista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_poista.Name = "btn_poista";
            this.btn_poista.Size = new System.Drawing.Size(101, 23);
            this.btn_poista.TabIndex = 13;
            this.btn_poista.Text = "Poista";
            this.btn_poista.UseVisualStyleBackColor = true;
            this.btn_poista.Click += new System.EventHandler(this.btn_poista_Click);
            // 
            // label_PostiPaikka
            // 
            this.label_PostiPaikka.AutoSize = true;
            this.label_PostiPaikka.Location = new System.Drawing.Point(439, 142);
            this.label_PostiPaikka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PostiPaikka.Name = "label_PostiPaikka";
            this.label_PostiPaikka.Size = new System.Drawing.Size(109, 17);
            this.label_PostiPaikka.TabIndex = 4;
            this.label_PostiPaikka.Text = "Postitoimipaikka";
            // 
            // textBox_Postitoimipaikka
            // 
            this.textBox_Postitoimipaikka.Location = new System.Drawing.Point(572, 142);
            this.textBox_Postitoimipaikka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Postitoimipaikka.Name = "textBox_Postitoimipaikka";
            this.textBox_Postitoimipaikka.Size = new System.Drawing.Size(100, 22);
            this.textBox_Postitoimipaikka.TabIndex = 6;
            this.textBox_Postitoimipaikka.TextChanged += new System.EventHandler(this.textBox_Postitoimipaikka_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 39);
            this.label9.TabIndex = 6;
            this.label9.Text = "Asiakashallinta";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(859, 175);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(205, 22);
            this.textBox_Search.TabIndex = 9;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label_EtsiSukunimellä
            // 
            this.label_EtsiSukunimellä.AutoSize = true;
            this.label_EtsiSukunimellä.Location = new System.Drawing.Point(911, 135);
            this.label_EtsiSukunimellä.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EtsiSukunimellä.Name = "label_EtsiSukunimellä";
            this.label_EtsiSukunimellä.Size = new System.Drawing.Size(109, 17);
            this.label_EtsiSukunimellä.TabIndex = 8;
            this.label_EtsiSukunimellä.Text = "Etsi sukunimellä";
            // 
            // Btn_Tyhjenna
            // 
            this.Btn_Tyhjenna.Location = new System.Drawing.Point(706, 100);
            this.Btn_Tyhjenna.Name = "Btn_Tyhjenna";
            this.Btn_Tyhjenna.Size = new System.Drawing.Size(103, 58);
            this.Btn_Tyhjenna.TabIndex = 10;
            this.Btn_Tyhjenna.Text = "Tyhjennä tekstikentät";
            this.Btn_Tyhjenna.UseVisualStyleBackColor = true;
            this.Btn_Tyhjenna.Click += new System.EventHandler(this.Btn_Tyhjenna_Click);
            // 
            // label_EtsiPostiNro
            // 
            this.label_EtsiPostiNro.AutoSize = true;
            this.label_EtsiPostiNro.Location = new System.Drawing.Point(914, 32);
            this.label_EtsiPostiNro.Name = "label_EtsiPostiNro";
            this.label_EtsiPostiNro.Size = new System.Drawing.Size(127, 17);
            this.label_EtsiPostiNro.TabIndex = 14;
            this.label_EtsiPostiNro.Text = "Etsi postinumerolla";
            // 
            // textBox_EtsiPostiNro
            // 
            this.textBox_EtsiPostiNro.Location = new System.Drawing.Point(932, 65);
            this.textBox_EtsiPostiNro.Name = "textBox_EtsiPostiNro";
            this.textBox_EtsiPostiNro.Size = new System.Drawing.Size(100, 22);
            this.textBox_EtsiPostiNro.TabIndex = 15;
            this.textBox_EtsiPostiNro.TextChanged += new System.EventHandler(this.textBox_EtsiPostiNro_TextChanged);
            // 
            // AsiakasHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 597);
            this.Controls.Add(this.textBox_EtsiPostiNro);
            this.Controls.Add(this.label_EtsiPostiNro);
            this.Controls.Add(this.Btn_Tyhjenna);
            this.Controls.Add(this.label_EtsiSukunimellä);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Postitoimipaikka);
            this.Controls.Add(this.label_PostiPaikka);
            this.Controls.Add(this.btn_poista);
            this.Controls.Add(this.btn_muokkaa);
            this.Controls.Add(this.btn_lisaa);
            this.Controls.Add(this.dataGridView_Asiakkaat);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Osoite);
            this.Controls.Add(this.textBox_Postinro);
            this.Controls.Add(this.textBox_Puhnro);
            this.Controls.Add(this.textBox_Sukunimi);
            this.Controls.Add(this.textBox_Etunimi);
            this.Controls.Add(this.label_Osoite);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_PostNro);
            this.Controls.Add(this.label_PuhNro);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Sukunimi);
            this.Controls.Add(this.label_Etunimi);
            this.Controls.Add(this.label_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsiakasHallinta";
            this.Text = "AsiakasHallinta";
            this.Load += new System.EventHandler(this.AsiakasHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asiakkaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Etunimi;
        private System.Windows.Forms.TextBox textBox_Etunimi;
        private System.Windows.Forms.Label label_Sukunimi;
        private System.Windows.Forms.TextBox textBox_Sukunimi;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_PuhNro;
        private System.Windows.Forms.TextBox textBox_Puhnro;
        private System.Windows.Forms.Label label_Osoite;
        private System.Windows.Forms.TextBox textBox_Osoite;
        private System.Windows.Forms.DataGridView dataGridView_Asiakkaat;
        private System.Windows.Forms.Label label_PostNro;
        private System.Windows.Forms.TextBox textBox_Postinro;
        private System.Windows.Forms.Button btn_lisaa;
        private System.Windows.Forms.Button btn_muokkaa;
        private System.Windows.Forms.Button btn_poista;
        private System.Windows.Forms.Label label_PostiPaikka;
        private System.Windows.Forms.TextBox textBox_Postitoimipaikka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_EtsiSukunimellä;
        private System.Windows.Forms.Button Btn_Tyhjenna;
        private System.Windows.Forms.Label label_EtsiPostiNro;
        private System.Windows.Forms.TextBox textBox_EtsiPostiNro;
    }
}
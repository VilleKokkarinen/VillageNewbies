﻿namespace VillageNewbies.UI
{
    partial class PalveluHallinta
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
            this.btn_Poista = new System.Windows.Forms.Button();
            this.btn_Muokkaa = new System.Windows.Forms.Button();
            this.btn_Lisaa = new System.Windows.Forms.Button();
            this.dataGridView_Palvelut = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PalveluID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Hinta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ALV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Kuvaus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_AlueID = new System.Windows.Forms.ComboBox();
            this.textBox_PalveluNimi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Palvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Poista
            // 
            this.btn_Poista.Location = new System.Drawing.Point(459, 513);
            this.btn_Poista.Name = "btn_Poista";
            this.btn_Poista.Size = new System.Drawing.Size(78, 26);
            this.btn_Poista.TabIndex = 14;
            this.btn_Poista.Text = "Poista";
            this.btn_Poista.UseVisualStyleBackColor = true;
            this.btn_Poista.Click += new System.EventHandler(this.btn_Poista_Click);
            // 
            // btn_Muokkaa
            // 
            this.btn_Muokkaa.Location = new System.Drawing.Point(348, 513);
            this.btn_Muokkaa.Name = "btn_Muokkaa";
            this.btn_Muokkaa.Size = new System.Drawing.Size(78, 26);
            this.btn_Muokkaa.TabIndex = 13;
            this.btn_Muokkaa.Text = "Muokkaa";
            this.btn_Muokkaa.UseVisualStyleBackColor = true;
            this.btn_Muokkaa.Click += new System.EventHandler(this.btn_Muokkaa_Click);
            // 
            // btn_Lisaa
            // 
            this.btn_Lisaa.Location = new System.Drawing.Point(245, 513);
            this.btn_Lisaa.Name = "btn_Lisaa";
            this.btn_Lisaa.Size = new System.Drawing.Size(78, 26);
            this.btn_Lisaa.TabIndex = 12;
            this.btn_Lisaa.Text = "Lisää";
            this.btn_Lisaa.UseVisualStyleBackColor = true;
            this.btn_Lisaa.Click += new System.EventHandler(this.btn_Lisaa_Click);
            // 
            // dataGridView_Palvelut
            // 
            this.dataGridView_Palvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Palvelut.Location = new System.Drawing.Point(34, 214);
            this.dataGridView_Palvelut.Name = "dataGridView_Palvelut";
            this.dataGridView_Palvelut.RowHeadersWidth = 51;
            this.dataGridView_Palvelut.RowTemplate.Height = 24;
            this.dataGridView_Palvelut.Size = new System.Drawing.Size(503, 271);
            this.dataGridView_Palvelut.TabIndex = 15;
            this.dataGridView_Palvelut.SelectionChanged += new System.EventHandler(this.dataGridView_Palvelut_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(306, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kuvaus:";
            // 
            // textBox_PalveluID
            // 
            this.textBox_PalveluID.Location = new System.Drawing.Point(161, 30);
            this.textBox_PalveluID.Name = "textBox_PalveluID";
            this.textBox_PalveluID.Size = new System.Drawing.Size(119, 22);
            this.textBox_PalveluID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(30, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Palvelun Nimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(306, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "alv%";
            // 
            // textBox_Hinta
            // 
            this.textBox_Hinta.Location = new System.Drawing.Point(161, 154);
            this.textBox_Hinta.Name = "textBox_Hinta";
            this.textBox_Hinta.Size = new System.Drawing.Size(119, 22);
            this.textBox_Hinta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(31, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hinta €";
            // 
            // textBox_ALV
            // 
            this.textBox_ALV.Location = new System.Drawing.Point(440, 152);
            this.textBox_ALV.Name = "textBox_ALV";
            this.textBox_ALV.Size = new System.Drawing.Size(119, 22);
            this.textBox_ALV.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(306, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toimialue ID:";
            // 
            // textBox_Kuvaus
            // 
            this.textBox_Kuvaus.Location = new System.Drawing.Point(440, 94);
            this.textBox_Kuvaus.Name = "textBox_Kuvaus";
            this.textBox_Kuvaus.Size = new System.Drawing.Size(119, 22);
            this.textBox_Kuvaus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palvelu ID:";
            // 
            // comboBox_AlueID
            // 
            this.comboBox_AlueID.FormattingEnabled = true;
            this.comboBox_AlueID.Location = new System.Drawing.Point(440, 26);
            this.comboBox_AlueID.Name = "comboBox_AlueID";
            this.comboBox_AlueID.Size = new System.Drawing.Size(119, 24);
            this.comboBox_AlueID.TabIndex = 7;
            // 
            // textBox_PalveluNimi
            // 
            this.textBox_PalveluNimi.Location = new System.Drawing.Point(161, 96);
            this.textBox_PalveluNimi.Name = "textBox_PalveluNimi";
            this.textBox_PalveluNimi.Size = new System.Drawing.Size(119, 22);
            this.textBox_PalveluNimi.TabIndex = 3;
            // 
            // PalveluHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(571, 580);
            this.Controls.Add(this.comboBox_AlueID);
            this.Controls.Add(this.btn_Poista);
            this.Controls.Add(this.btn_Muokkaa);
            this.Controls.Add(this.btn_Lisaa);
            this.Controls.Add(this.dataGridView_Palvelut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_PalveluID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PalveluNimi);
            this.Controls.Add(this.textBox_Hinta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ALV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Kuvaus);
            this.Controls.Add(this.label1);
            this.Name = "PalveluHallinta";
            this.Text = "Palveluiden Hallinta";
            this.Load += new System.EventHandler(this.PalveluHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Palvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Poista;
        private System.Windows.Forms.Button btn_Muokkaa;
        private System.Windows.Forms.Button btn_Lisaa;
        private System.Windows.Forms.DataGridView dataGridView_Palvelut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PalveluID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Hinta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ALV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Kuvaus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_AlueID;
        private System.Windows.Forms.TextBox textBox_PalveluNimi;
    }
}
﻿namespace VillageNewbies.UI
{
    partial class MokinHallinta
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
            this.textBox_MokkiID = new System.Windows.Forms.TextBox();
            this.textBox_Alue = new System.Windows.Forms.TextBox();
            this.textBox_PostiNro = new System.Windows.Forms.TextBox();
            this.textBox_MokinNimi = new System.Windows.Forms.TextBox();
            this.textBox_Osoite = new System.Windows.Forms.TextBox();
            this.textBox_Kuvaus = new System.Windows.Forms.TextBox();
            this.textBox6_Maara = new System.Windows.Forms.TextBox();
            this.textBox_Varustelu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Mokit = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Lisaa = new System.Windows.Forms.Button();
            this.btn_Muokkaa = new System.Windows.Forms.Button();
            this.btn_Poista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Mokit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_MokkiID
            // 
            this.textBox_MokkiID.Location = new System.Drawing.Point(135, 32);
            this.textBox_MokkiID.Name = "textBox_MokkiID";
            this.textBox_MokkiID.Size = new System.Drawing.Size(119, 22);
            this.textBox_MokkiID.TabIndex = 0;
            // 
            // textBox_Alue
            // 
            this.textBox_Alue.Location = new System.Drawing.Point(409, 32);
            this.textBox_Alue.Name = "textBox_Alue";
            this.textBox_Alue.Size = new System.Drawing.Size(119, 22);
            this.textBox_Alue.TabIndex = 1;
            // 
            // textBox_PostiNro
            // 
            this.textBox_PostiNro.Location = new System.Drawing.Point(135, 158);
            this.textBox_PostiNro.Name = "textBox_PostiNro";
            this.textBox_PostiNro.Size = new System.Drawing.Size(119, 22);
            this.textBox_PostiNro.TabIndex = 2;
            // 
            // textBox_MokinNimi
            // 
            this.textBox_MokinNimi.Location = new System.Drawing.Point(409, 158);
            this.textBox_MokinNimi.Name = "textBox_MokinNimi";
            this.textBox_MokinNimi.Size = new System.Drawing.Size(119, 22);
            this.textBox_MokinNimi.TabIndex = 3;
            // 
            // textBox_Osoite
            // 
            this.textBox_Osoite.Location = new System.Drawing.Point(135, 98);
            this.textBox_Osoite.Name = "textBox_Osoite";
            this.textBox_Osoite.Size = new System.Drawing.Size(119, 22);
            this.textBox_Osoite.TabIndex = 4;
            // 
            // textBox_Kuvaus
            // 
            this.textBox_Kuvaus.Location = new System.Drawing.Point(409, 95);
            this.textBox_Kuvaus.Name = "textBox_Kuvaus";
            this.textBox_Kuvaus.Size = new System.Drawing.Size(119, 22);
            this.textBox_Kuvaus.TabIndex = 5;
            // 
            // textBox6_Maara
            // 
            this.textBox6_Maara.Location = new System.Drawing.Point(135, 221);
            this.textBox6_Maara.Name = "textBox6_Maara";
            this.textBox6_Maara.Size = new System.Drawing.Size(119, 22);
            this.textBox6_Maara.TabIndex = 6;
            // 
            // textBox_Varustelu
            // 
            this.textBox_Varustelu.Location = new System.Drawing.Point(409, 221);
            this.textBox_Varustelu.Name = "textBox_Varustelu";
            this.textBox_Varustelu.Size = new System.Drawing.Size(119, 22);
            this.textBox_Varustelu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // dataGrid_Mokit
            // 
            this.dataGrid_Mokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Mokit.Location = new System.Drawing.Point(25, 296);
            this.dataGrid_Mokit.Name = "dataGrid_Mokit";
            this.dataGrid_Mokit.RowHeadersWidth = 51;
            this.dataGrid_Mokit.RowTemplate.Height = 24;
            this.dataGrid_Mokit.Size = new System.Drawing.Size(503, 271);
            this.dataGrid_Mokit.TabIndex = 9;
            this.dataGrid_Mokit.SelectionChanged += new System.EventHandler(this.dataGrid_Mokit_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toimialue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Postinro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mökkin nimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Katuosoite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kuvaus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Henkilömäärä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Varustelu";
            // 
            // btn_Lisaa
            // 
            this.btn_Lisaa.Location = new System.Drawing.Point(236, 595);
            this.btn_Lisaa.Name = "btn_Lisaa";
            this.btn_Lisaa.Size = new System.Drawing.Size(78, 26);
            this.btn_Lisaa.TabIndex = 18;
            this.btn_Lisaa.Text = "Lisää";
            this.btn_Lisaa.UseVisualStyleBackColor = true;
            // 
            // btn_Muokkaa
            // 
            this.btn_Muokkaa.Location = new System.Drawing.Point(339, 595);
            this.btn_Muokkaa.Name = "btn_Muokkaa";
            this.btn_Muokkaa.Size = new System.Drawing.Size(78, 26);
            this.btn_Muokkaa.TabIndex = 19;
            this.btn_Muokkaa.Text = "Muokkaa";
            this.btn_Muokkaa.UseVisualStyleBackColor = true;
            // 
            // btn_Poista
            // 
            this.btn_Poista.Location = new System.Drawing.Point(450, 595);
            this.btn_Poista.Name = "btn_Poista";
            this.btn_Poista.Size = new System.Drawing.Size(78, 26);
            this.btn_Poista.TabIndex = 20;
            this.btn_Poista.Text = "Poista";
            this.btn_Poista.UseVisualStyleBackColor = true;
            // 
            // MokinHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 637);
            this.Controls.Add(this.btn_Poista);
            this.Controls.Add(this.btn_Muokkaa);
            this.Controls.Add(this.btn_Lisaa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGrid_Mokit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_MokkiID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Alue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PostiNro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MokinNimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Osoite);
            this.Controls.Add(this.textBox_Kuvaus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6_Maara);
            this.Controls.Add(this.textBox_Varustelu);
            this.Name = "MokinHallinta";
            this.Text = "MökinHallinta";
            this.Load += new System.EventHandler(this.MokinHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Mokit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MokkiID;
        private System.Windows.Forms.TextBox textBox_Alue;
        private System.Windows.Forms.TextBox textBox_PostiNro;
        private System.Windows.Forms.TextBox textBox_MokinNimi;
        private System.Windows.Forms.TextBox textBox_Osoite;
        private System.Windows.Forms.TextBox textBox_Kuvaus;
        private System.Windows.Forms.TextBox textBox6_Maara;
        private System.Windows.Forms.TextBox textBox_Varustelu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Mokit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Lisaa;
        private System.Windows.Forms.Button btn_Muokkaa;
        private System.Windows.Forms.Button btn_Poista;
    }
}
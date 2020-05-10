namespace VillageNewbies.UI
{
    partial class AlueidenHallinta
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
            this.dataGridView_Alueet = new System.Windows.Forms.DataGridView();
            this.label_AlueID = new System.Windows.Forms.Label();
            this.label_Nimi = new System.Windows.Forms.Label();
            this.textBox_AlueID = new System.Windows.Forms.TextBox();
            this.textBox_Nimi = new System.Windows.Forms.TextBox();
            this.button_Lisaa = new System.Windows.Forms.Button();
            this.button_Muokka = new System.Windows.Forms.Button();
            this.button_Poista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alueet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Alueet
            // 
            this.dataGridView_Alueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Alueet.Location = new System.Drawing.Point(12, 169);
            this.dataGridView_Alueet.Name = "dataGridView_Alueet";
            this.dataGridView_Alueet.RowHeadersWidth = 51;
            this.dataGridView_Alueet.RowTemplate.Height = 24;
            this.dataGridView_Alueet.Size = new System.Drawing.Size(340, 269);
            this.dataGridView_Alueet.TabIndex = 7;
            this.dataGridView_Alueet.SelectionChanged += new System.EventHandler(this.dataGridView_Alueet_SelectionChanged);
            // 
            // label_AlueID
            // 
            this.label_AlueID.AutoSize = true;
            this.label_AlueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlueID.ForeColor = System.Drawing.SystemColors.Menu;
            this.label_AlueID.Location = new System.Drawing.Point(9, 94);
            this.label_AlueID.Name = "label_AlueID";
            this.label_AlueID.Size = new System.Drawing.Size(71, 20);
            this.label_AlueID.TabIndex = 0;
            this.label_AlueID.Text = "Alue ID";
            // 
            // label_Nimi
            // 
            this.label_Nimi.AutoSize = true;
            this.label_Nimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nimi.ForeColor = System.Drawing.SystemColors.Menu;
            this.label_Nimi.Location = new System.Drawing.Point(222, 94);
            this.label_Nimi.Name = "label_Nimi";
            this.label_Nimi.Size = new System.Drawing.Size(47, 20);
            this.label_Nimi.TabIndex = 2;
            this.label_Nimi.Text = "Nimi";
            // 
            // textBox_AlueID
            // 
            this.textBox_AlueID.Location = new System.Drawing.Point(86, 91);
            this.textBox_AlueID.Name = "textBox_AlueID";
            this.textBox_AlueID.Size = new System.Drawing.Size(100, 22);
            this.textBox_AlueID.TabIndex = 1;
            // 
            // textBox_Nimi
            // 
            this.textBox_Nimi.Location = new System.Drawing.Point(277, 91);
            this.textBox_Nimi.Name = "textBox_Nimi";
            this.textBox_Nimi.Size = new System.Drawing.Size(100, 22);
            this.textBox_Nimi.TabIndex = 3;
            // 
            // button_Lisaa
            // 
            this.button_Lisaa.Location = new System.Drawing.Point(87, 461);
            this.button_Lisaa.Name = "button_Lisaa";
            this.button_Lisaa.Size = new System.Drawing.Size(75, 23);
            this.button_Lisaa.TabIndex = 4;
            this.button_Lisaa.Text = "Lisää";
            this.button_Lisaa.UseVisualStyleBackColor = true;
            this.button_Lisaa.Click += new System.EventHandler(this.button_Lisaa_Click);
            // 
            // button_Muokka
            // 
            this.button_Muokka.Location = new System.Drawing.Point(182, 461);
            this.button_Muokka.Name = "button_Muokka";
            this.button_Muokka.Size = new System.Drawing.Size(75, 23);
            this.button_Muokka.TabIndex = 5;
            this.button_Muokka.Text = "Muokkaa";
            this.button_Muokka.UseVisualStyleBackColor = true;
            this.button_Muokka.Click += new System.EventHandler(this.button_Muokka_Click);
            // 
            // button_Poista
            // 
            this.button_Poista.Location = new System.Drawing.Point(277, 461);
            this.button_Poista.Name = "button_Poista";
            this.button_Poista.Size = new System.Drawing.Size(75, 23);
            this.button_Poista.TabIndex = 6;
            this.button_Poista.Text = "Poista";
            this.button_Poista.UseVisualStyleBackColor = true;
            this.button_Poista.Click += new System.EventHandler(this.button_Poista_Click);
            // 
            // AlueidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(427, 505);
            this.Controls.Add(this.button_Poista);
            this.Controls.Add(this.button_Muokka);
            this.Controls.Add(this.button_Lisaa);
            this.Controls.Add(this.textBox_Nimi);
            this.Controls.Add(this.textBox_AlueID);
            this.Controls.Add(this.label_Nimi);
            this.Controls.Add(this.label_AlueID);
            this.Controls.Add(this.dataGridView_Alueet);
            this.Name = "AlueidenHallinta";
            this.Text = "AlueidenHallinta";
            this.Load += new System.EventHandler(this.AlueidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alueet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Alueet;
        private System.Windows.Forms.Label label_AlueID;
        private System.Windows.Forms.Label label_Nimi;
        private System.Windows.Forms.TextBox textBox_AlueID;
        private System.Windows.Forms.TextBox textBox_Nimi;
        private System.Windows.Forms.Button button_Lisaa;
        private System.Windows.Forms.Button button_Muokka;
        private System.Windows.Forms.Button button_Poista;
    }
}
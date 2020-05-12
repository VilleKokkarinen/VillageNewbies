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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alueet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Alueet
            // 
            this.dataGridView_Alueet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Alueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Alueet.Location = new System.Drawing.Point(9, 137);
            this.dataGridView_Alueet.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Alueet.MultiSelect = false;
            this.dataGridView_Alueet.Name = "dataGridView_Alueet";
            this.dataGridView_Alueet.ReadOnly = true;
            this.dataGridView_Alueet.RowHeadersVisible = false;
            this.dataGridView_Alueet.RowHeadersWidth = 51;
            this.dataGridView_Alueet.RowTemplate.Height = 24;
            this.dataGridView_Alueet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Alueet.Size = new System.Drawing.Size(275, 219);
            this.dataGridView_Alueet.TabIndex = 0;
            this.dataGridView_Alueet.SelectionChanged += new System.EventHandler(this.dataGridView_Alueet_SelectionChanged);
            // 
            // label_AlueID
            // 
            this.label_AlueID.AutoSize = true;
            this.label_AlueID.Location = new System.Drawing.Point(7, 76);
            this.label_AlueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AlueID.Name = "label_AlueID";
            this.label_AlueID.Size = new System.Drawing.Size(42, 13);
            this.label_AlueID.TabIndex = 1;
            this.label_AlueID.Text = "Alue ID";
            // 
            // label_Nimi
            // 
            this.label_Nimi.AutoSize = true;
            this.label_Nimi.Location = new System.Drawing.Point(146, 76);
            this.label_Nimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nimi.Name = "label_Nimi";
            this.label_Nimi.Size = new System.Drawing.Size(27, 13);
            this.label_Nimi.TabIndex = 1;
            this.label_Nimi.Text = "Nimi";
            // 
            // textBox_AlueID
            // 
            this.textBox_AlueID.Location = new System.Drawing.Point(56, 75);
            this.textBox_AlueID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AlueID.Name = "textBox_AlueID";
            this.textBox_AlueID.Size = new System.Drawing.Size(76, 20);
            this.textBox_AlueID.TabIndex = 2;
            this.textBox_AlueID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AlueID_KeyPress);
            // 
            // textBox_Nimi
            // 
            this.textBox_Nimi.Location = new System.Drawing.Point(188, 73);
            this.textBox_Nimi.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nimi.Name = "textBox_Nimi";
            this.textBox_Nimi.Size = new System.Drawing.Size(76, 20);
            this.textBox_Nimi.TabIndex = 3;
            // 
            // button_Lisaa
            // 
            this.button_Lisaa.Location = new System.Drawing.Point(65, 375);
            this.button_Lisaa.Margin = new System.Windows.Forms.Padding(2);
            this.button_Lisaa.Name = "button_Lisaa";
            this.button_Lisaa.Size = new System.Drawing.Size(56, 19);
            this.button_Lisaa.TabIndex = 4;
            this.button_Lisaa.Text = "Lisää";
            this.button_Lisaa.UseVisualStyleBackColor = true;
            this.button_Lisaa.Click += new System.EventHandler(this.button_Lisaa_Click);
            // 
            // button_Muokka
            // 
            this.button_Muokka.Location = new System.Drawing.Point(136, 375);
            this.button_Muokka.Margin = new System.Windows.Forms.Padding(2);
            this.button_Muokka.Name = "button_Muokka";
            this.button_Muokka.Size = new System.Drawing.Size(56, 19);
            this.button_Muokka.TabIndex = 4;
            this.button_Muokka.Text = "Muokkaa";
            this.button_Muokka.UseVisualStyleBackColor = true;
            this.button_Muokka.Click += new System.EventHandler(this.button_Muokka_Click);
            // 
            // button_Poista
            // 
            this.button_Poista.Location = new System.Drawing.Point(208, 375);
            this.button_Poista.Margin = new System.Windows.Forms.Padding(2);
            this.button_Poista.Name = "button_Poista";
            this.button_Poista.Size = new System.Drawing.Size(56, 19);
            this.button_Poista.TabIndex = 4;
            this.button_Poista.Text = "Poista";
            this.button_Poista.UseVisualStyleBackColor = true;
            this.button_Poista.Click += new System.EventHandler(this.button_Poista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alueiden Hallinta";
            // 
            // AlueidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Poista);
            this.Controls.Add(this.button_Muokka);
            this.Controls.Add(this.button_Lisaa);
            this.Controls.Add(this.textBox_Nimi);
            this.Controls.Add(this.textBox_AlueID);
            this.Controls.Add(this.label_Nimi);
            this.Controls.Add(this.label_AlueID);
            this.Controls.Add(this.dataGridView_Alueet);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
    }
}
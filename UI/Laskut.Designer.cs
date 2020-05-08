namespace VillageNewbies.UI
{
    partial class Laskut
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
            this.dataGridView_laskut = new System.Windows.Forms.DataGridView();
            this.Btn_Poista = new System.Windows.Forms.Button();
            this.label_LaskuID = new System.Windows.Forms.Label();
            this.textBox_LaskuID = new System.Windows.Forms.TextBox();
            this.label_VarausID = new System.Windows.Forms.Label();
            this.textBox_VarausID = new System.Windows.Forms.TextBox();
            this.label_Summa = new System.Windows.Forms.Label();
            this.textBox_Summa = new System.Windows.Forms.TextBox();
            this.label_ALV = new System.Windows.Forms.Label();
            this.textBox_ALV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_laskut)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_laskut
            // 
            this.dataGridView_laskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_laskut.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_laskut.Name = "dataGridView_laskut";
            this.dataGridView_laskut.RowHeadersWidth = 51;
            this.dataGridView_laskut.RowTemplate.Height = 24;
            this.dataGridView_laskut.Size = new System.Drawing.Size(604, 332);
            this.dataGridView_laskut.TabIndex = 0;
            this.dataGridView_laskut.SelectionChanged += new System.EventHandler(this.dataGridView_laskut_SelectionChanged);
            // 
            // Btn_Poista
            // 
            this.Btn_Poista.Location = new System.Drawing.Point(487, 374);
            this.Btn_Poista.Name = "Btn_Poista";
            this.Btn_Poista.Size = new System.Drawing.Size(75, 23);
            this.Btn_Poista.TabIndex = 1;
            this.Btn_Poista.Text = "Poista";
            this.Btn_Poista.UseVisualStyleBackColor = true;
            this.Btn_Poista.Click += new System.EventHandler(this.Btn_Poista_Click);
            // 
            // label_LaskuID
            // 
            this.label_LaskuID.AutoSize = true;
            this.label_LaskuID.Location = new System.Drawing.Point(661, 29);
            this.label_LaskuID.Name = "label_LaskuID";
            this.label_LaskuID.Size = new System.Drawing.Size(63, 17);
            this.label_LaskuID.TabIndex = 2;
            this.label_LaskuID.Text = "Lasku ID";
            // 
            // textBox_LaskuID
            // 
            this.textBox_LaskuID.Location = new System.Drawing.Point(763, 26);
            this.textBox_LaskuID.Name = "textBox_LaskuID";
            this.textBox_LaskuID.Size = new System.Drawing.Size(100, 22);
            this.textBox_LaskuID.TabIndex = 3;
            // 
            // label_VarausID
            // 
            this.label_VarausID.AutoSize = true;
            this.label_VarausID.Location = new System.Drawing.Point(661, 67);
            this.label_VarausID.Name = "label_VarausID";
            this.label_VarausID.Size = new System.Drawing.Size(70, 17);
            this.label_VarausID.TabIndex = 2;
            this.label_VarausID.Text = "Varaus ID";
            // 
            // textBox_VarausID
            // 
            this.textBox_VarausID.Location = new System.Drawing.Point(763, 64);
            this.textBox_VarausID.Name = "textBox_VarausID";
            this.textBox_VarausID.Size = new System.Drawing.Size(100, 22);
            this.textBox_VarausID.TabIndex = 3;
            // 
            // label_Summa
            // 
            this.label_Summa.AutoSize = true;
            this.label_Summa.Location = new System.Drawing.Point(661, 105);
            this.label_Summa.Name = "label_Summa";
            this.label_Summa.Size = new System.Drawing.Size(55, 17);
            this.label_Summa.TabIndex = 2;
            this.label_Summa.Text = "Summa";
            // 
            // textBox_Summa
            // 
            this.textBox_Summa.Location = new System.Drawing.Point(763, 102);
            this.textBox_Summa.Name = "textBox_Summa";
            this.textBox_Summa.Size = new System.Drawing.Size(100, 22);
            this.textBox_Summa.TabIndex = 3;
            // 
            // label_ALV
            // 
            this.label_ALV.AutoSize = true;
            this.label_ALV.Location = new System.Drawing.Point(661, 142);
            this.label_ALV.Name = "label_ALV";
            this.label_ALV.Size = new System.Drawing.Size(34, 17);
            this.label_ALV.TabIndex = 2;
            this.label_ALV.Text = "ALV";
            // 
            // textBox_ALV
            // 
            this.textBox_ALV.Location = new System.Drawing.Point(763, 139);
            this.textBox_ALV.Name = "textBox_ALV";
            this.textBox_ALV.Size = new System.Drawing.Size(100, 22);
            this.textBox_ALV.TabIndex = 3;
            // 
            // Laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.textBox_ALV);
            this.Controls.Add(this.textBox_Summa);
            this.Controls.Add(this.textBox_VarausID);
            this.Controls.Add(this.textBox_LaskuID);
            this.Controls.Add(this.label_ALV);
            this.Controls.Add(this.label_Summa);
            this.Controls.Add(this.label_VarausID);
            this.Controls.Add(this.label_LaskuID);
            this.Controls.Add(this.Btn_Poista);
            this.Controls.Add(this.dataGridView_laskut);
            this.Name = "Laskut";
            this.Text = "Laskut";
            this.Load += new System.EventHandler(this.Laskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_laskut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_laskut;
        private System.Windows.Forms.Button Btn_Poista;
        private System.Windows.Forms.Label label_LaskuID;
        private System.Windows.Forms.TextBox textBox_LaskuID;
        private System.Windows.Forms.Label label_VarausID;
        private System.Windows.Forms.TextBox textBox_VarausID;
        private System.Windows.Forms.Label label_Summa;
        private System.Windows.Forms.TextBox textBox_Summa;
        private System.Windows.Forms.Label label_ALV;
        private System.Windows.Forms.TextBox textBox_ALV;
    }
}
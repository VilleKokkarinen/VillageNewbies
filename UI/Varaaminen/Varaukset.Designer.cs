namespace VillageNewbies.UI
{
    partial class Varaukset
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
            this.dataGridView_Varaukset = new System.Windows.Forms.DataGridView();
            this.button_Poista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Varaukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Varaukset
            // 
            this.dataGridView_Varaukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Varaukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Varaukset.Location = new System.Drawing.Point(9, 124);
            this.dataGridView_Varaukset.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Varaukset.MultiSelect = false;
            this.dataGridView_Varaukset.Name = "dataGridView_Varaukset";
            this.dataGridView_Varaukset.ReadOnly = true;
            this.dataGridView_Varaukset.RowHeadersVisible = false;
            this.dataGridView_Varaukset.RowHeadersWidth = 51;
            this.dataGridView_Varaukset.RowTemplate.Height = 24;
            this.dataGridView_Varaukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Varaukset.Size = new System.Drawing.Size(775, 184);
            this.dataGridView_Varaukset.TabIndex = 0;
            this.dataGridView_Varaukset.SelectionChanged += new System.EventHandler(this.dataGridView_Varaukset_SelectionChanged);
            // 
            // button_Poista
            // 
            this.button_Poista.Location = new System.Drawing.Point(348, 325);
            this.button_Poista.Margin = new System.Windows.Forms.Padding(2);
            this.button_Poista.Name = "button_Poista";
            this.button_Poista.Size = new System.Drawing.Size(56, 19);
            this.button_Poista.TabIndex = 1;
            this.button_Poista.Text = "Poista";
            this.button_Poista.UseVisualStyleBackColor = true;
            this.button_Poista.Click += new System.EventHandler(this.button_Poista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varaukset";
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Poista);
            this.Controls.Add(this.dataGridView_Varaukset);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Varaukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Varaukset;
        private System.Windows.Forms.Button button_Poista;
        private System.Windows.Forms.Label label1;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Varaukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Varaukset
            // 
            this.dataGridView_Varaukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Varaukset.Location = new System.Drawing.Point(12, 37);
            this.dataGridView_Varaukset.Name = "dataGridView_Varaukset";
            this.dataGridView_Varaukset.RowHeadersWidth = 51;
            this.dataGridView_Varaukset.RowTemplate.Height = 24;
            this.dataGridView_Varaukset.Size = new System.Drawing.Size(527, 342);
            this.dataGridView_Varaukset.TabIndex = 0;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Varaukset);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Varaukset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Varaukset;
    }
}
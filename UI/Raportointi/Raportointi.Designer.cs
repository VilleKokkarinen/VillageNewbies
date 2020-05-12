using System.Windows.Forms;
namespace VillageNewbies.UI
{
    partial class Raportointi
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
            this.CheckListAsiakkaat = new System.Windows.Forms.CheckedListBox();
            this.CheckListVaraukset = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CheckListAsiakkaat
            // 
            this.CheckListAsiakkaat.FormattingEnabled = true;
            this.CheckListAsiakkaat.Location = new System.Drawing.Point(13, 196);
            this.CheckListAsiakkaat.Name = "CheckListAsiakkaat";
            this.CheckListAsiakkaat.Size = new System.Drawing.Size(325, 310);
            this.CheckListAsiakkaat.TabIndex = 0;
            this.CheckListAsiakkaat.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckListAsiakkaat_ItemCheck);
            this.CheckListAsiakkaat.SelectedIndexChanged += new System.EventHandler(this.CheckListAsiakkaat_SelectedIndexChanged);
            // 
            // CheckListVaraukset
            // 
            this.CheckListVaraukset.FormattingEnabled = true;
            this.CheckListVaraukset.Location = new System.Drawing.Point(434, 196);
            this.CheckListVaraukset.Name = "CheckListVaraukset";
            this.CheckListVaraukset.Size = new System.Drawing.Size(304, 293);
            this.CheckListVaraukset.TabIndex = 1;
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 546);
            this.Controls.Add(this.CheckListVaraukset);
            this.Controls.Add(this.CheckListAsiakkaat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox CheckListAsiakkaat;
        private CheckedListBox CheckListVaraukset;
    }
}
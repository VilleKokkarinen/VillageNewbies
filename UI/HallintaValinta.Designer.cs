namespace VillageNewbies.UI
{
    partial class HallintaValinta
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Palvelu = new System.Windows.Forms.Button();
            this.button_Alue = new System.Windows.Forms.Button();
            this.button_Mokki = new System.Windows.Forms.Button();
            this.button_Asiakas = new System.Windows.Forms.Button();
            this.label_Asiakas = new System.Windows.Forms.Label();
            this.label_Mokit = new System.Windows.Forms.Label();
            this.label_Alue = new System.Windows.Forms.Label();
            this.label_Palvelu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mitä haluat hallita?";
            // 
            // button_Palvelu
            // 
            this.button_Palvelu.Image = global::VillageNewbies.Properties.Resources.services1;
            this.button_Palvelu.Location = new System.Drawing.Point(413, 119);
            this.button_Palvelu.Name = "button_Palvelu";
            this.button_Palvelu.Size = new System.Drawing.Size(107, 78);
            this.button_Palvelu.TabIndex = 1;
            this.button_Palvelu.UseVisualStyleBackColor = true;
            // 
            // button_Alue
            // 
            this.button_Alue.Image = global::VillageNewbies.Properties.Resources.location;
            this.button_Alue.Location = new System.Drawing.Point(286, 119);
            this.button_Alue.Name = "button_Alue";
            this.button_Alue.Size = new System.Drawing.Size(107, 78);
            this.button_Alue.TabIndex = 1;
            this.button_Alue.UseVisualStyleBackColor = true;
            this.button_Alue.Click += new System.EventHandler(this.button_Alue_Click);
            // 
            // button_Mokki
            // 
            this.button_Mokki.Image = global::VillageNewbies.Properties.Resources.cabin;
            this.button_Mokki.Location = new System.Drawing.Point(150, 119);
            this.button_Mokki.Name = "button_Mokki";
            this.button_Mokki.Size = new System.Drawing.Size(107, 78);
            this.button_Mokki.TabIndex = 1;
            this.button_Mokki.UseVisualStyleBackColor = true;
            this.button_Mokki.Click += new System.EventHandler(this.button_Mokki_Click);
            // 
            // button_Asiakas
            // 
            this.button_Asiakas.Image = global::VillageNewbies.Properties.Resources.user;
            this.button_Asiakas.Location = new System.Drawing.Point(12, 119);
            this.button_Asiakas.Name = "button_Asiakas";
            this.button_Asiakas.Size = new System.Drawing.Size(107, 78);
            this.button_Asiakas.TabIndex = 1;
            this.button_Asiakas.UseVisualStyleBackColor = true;
            // 
            // label_Asiakas
            // 
            this.label_Asiakas.AutoSize = true;
            this.label_Asiakas.Location = new System.Drawing.Point(24, 204);
            this.label_Asiakas.Name = "label_Asiakas";
            this.label_Asiakas.Size = new System.Drawing.Size(69, 17);
            this.label_Asiakas.TabIndex = 2;
            this.label_Asiakas.Text = "Asiakkaat";
            // 
            // label_Mokit
            // 
            this.label_Mokit.AutoSize = true;
            this.label_Mokit.Location = new System.Drawing.Point(177, 204);
            this.label_Mokit.Name = "label_Mokit";
            this.label_Mokit.Size = new System.Drawing.Size(41, 17);
            this.label_Mokit.TabIndex = 2;
            this.label_Mokit.Text = "Mökit";
            // 
            // label_Alue
            // 
            this.label_Alue.AutoSize = true;
            this.label_Alue.Location = new System.Drawing.Point(317, 204);
            this.label_Alue.Name = "label_Alue";
            this.label_Alue.Size = new System.Drawing.Size(48, 17);
            this.label_Alue.TabIndex = 2;
            this.label_Alue.Text = "Alueet";
            // 
            // label_Palvelu
            // 
            this.label_Palvelu.AutoSize = true;
            this.label_Palvelu.Location = new System.Drawing.Point(442, 204);
            this.label_Palvelu.Name = "label_Palvelu";
            this.label_Palvelu.Size = new System.Drawing.Size(58, 17);
            this.label_Palvelu.TabIndex = 2;
            this.label_Palvelu.Text = "Palvelut";
            // 
            // HallintaValinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 238);
            this.Controls.Add(this.label_Palvelu);
            this.Controls.Add(this.label_Alue);
            this.Controls.Add(this.label_Mokit);
            this.Controls.Add(this.label_Asiakas);
            this.Controls.Add(this.button_Palvelu);
            this.Controls.Add(this.button_Alue);
            this.Controls.Add(this.button_Mokki);
            this.Controls.Add(this.button_Asiakas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HallintaValinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Valinta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Asiakas;
        private System.Windows.Forms.Button button_Mokki;
        private System.Windows.Forms.Button button_Alue;
        private System.Windows.Forms.Button button_Palvelu;
        private System.Windows.Forms.Label label_Asiakas;
        private System.Windows.Forms.Label label_Mokit;
        private System.Windows.Forms.Label label_Alue;
        private System.Windows.Forms.Label label_Palvelu;
    }
}
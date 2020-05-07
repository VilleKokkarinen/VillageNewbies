namespace VillageNewbies
{
    partial class Form1
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
            this.Left_panel = new System.Windows.Forms.Panel();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn_Varaukset = new System.Windows.Forms.Button();
            this.Btn_Hallinta = new System.Windows.Forms.Button();
            this.Btn_Varaus = new System.Windows.Forms.Button();
            this.Central_Panel = new System.Windows.Forms.Panel();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Left_panel.SuspendLayout();
            this.Central_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Left_panel.Controls.Add(this.Btn4);
            this.Left_panel.Controls.Add(this.Btn_Varaukset);
            this.Left_panel.Controls.Add(this.Btn_Hallinta);
            this.Left_panel.Controls.Add(this.Btn_Varaus);
            this.Left_panel.Location = new System.Drawing.Point(1, 102);
            this.Left_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(142, 349);
            this.Left_panel.TabIndex = 0;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(22, 189);
            this.Btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(71, 40);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "Laskutus";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn_Varaukset
            // 
            this.Btn_Varaukset.Location = new System.Drawing.Point(22, 135);
            this.Btn_Varaukset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Varaukset.Name = "Btn_Varaukset";
            this.Btn_Varaukset.Size = new System.Drawing.Size(71, 40);
            this.Btn_Varaukset.TabIndex = 2;
            this.Btn_Varaukset.Text = "Varaukset";
            this.Btn_Varaukset.UseVisualStyleBackColor = true;
            this.Btn_Varaukset.Click += new System.EventHandler(this.Btn_Varaukset_Click);
            // 
            // Btn_Hallinta
            // 
            this.Btn_Hallinta.Location = new System.Drawing.Point(22, 83);
            this.Btn_Hallinta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Hallinta.Name = "Btn_Hallinta";
            this.Btn_Hallinta.Size = new System.Drawing.Size(71, 29);
            this.Btn_Hallinta.TabIndex = 1;
            this.Btn_Hallinta.Text = "Hallinta";
            this.Btn_Hallinta.UseVisualStyleBackColor = true;
            this.Btn_Hallinta.Click += new System.EventHandler(this.Btn_Hallinta_Click);
            // 
            // Btn_Varaus
            // 
            this.Btn_Varaus.Location = new System.Drawing.Point(22, 31);
            this.Btn_Varaus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Varaus.Name = "Btn_Varaus";
            this.Btn_Varaus.Size = new System.Drawing.Size(71, 28);
            this.Btn_Varaus.TabIndex = 0;
            this.Btn_Varaus.Text = "Uusi varaus";
            this.Btn_Varaus.UseVisualStyleBackColor = true;
            this.Btn_Varaus.Click += new System.EventHandler(this.Btn_Varaus_Click);
            // 
            // Central_Panel
            // 
            this.Central_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Central_Panel.Controls.Add(this.PicBox1);
            this.Central_Panel.Location = new System.Drawing.Point(138, 102);
            this.Central_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Central_Panel.Name = "Central_Panel";
            this.Central_Panel.Size = new System.Drawing.Size(662, 349);
            this.Central_Panel.TabIndex = 1;
            // 
            // PicBox1
            // 
            this.PicBox1.Image = global::VillageNewbies.Properties.Resources.mokki2;
            this.PicBox1.Location = new System.Drawing.Point(0, 2);
            this.PicBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(660, 344);
            this.PicBox1.TabIndex = 0;
            this.PicBox1.TabStop = false;
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Top_panel.Controls.Add(this.pictureBox1);
            this.Top_panel.Location = new System.Drawing.Point(1, 1);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(800, 102);
            this.Top_panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VillageNewbies.Properties.Resources.teksti;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Central_Panel);
            this.Controls.Add(this.Left_panel);
            this.Name = "Form1";
            this.Left_panel.ResumeLayout(false);
            this.Central_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel Central_Panel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn_Varaukset;
        private System.Windows.Forms.Button Btn_Hallinta;
        private System.Windows.Forms.Button Btn_Varaus;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


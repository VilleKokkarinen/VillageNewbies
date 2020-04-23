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
            this.Central_Panel = new System.Windows.Forms.Panel();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Btn_Varaus = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.Left_panel.SuspendLayout();
            this.Central_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Left_panel.Controls.Add(this.Btn4);
            this.Left_panel.Controls.Add(this.Btn3);
            this.Left_panel.Controls.Add(this.Btn2);
            this.Left_panel.Controls.Add(this.Btn_Varaus);
            this.Left_panel.Location = new System.Drawing.Point(1, 125);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(189, 429);
            this.Left_panel.TabIndex = 0;
            // 
            // Central_Panel
            // 
            this.Central_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Central_Panel.Controls.Add(this.PicBox1);
            this.Central_Panel.Location = new System.Drawing.Point(184, 125);
            this.Central_Panel.Name = "Central_Panel";
            this.Central_Panel.Size = new System.Drawing.Size(883, 429);
            this.Central_Panel.TabIndex = 1;
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Top_panel.Location = new System.Drawing.Point(1, 1);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1066, 125);
            this.Top_panel.TabIndex = 2;
            // 
            // Btn_Varaus
            // 
            this.Btn_Varaus.Location = new System.Drawing.Point(29, 38);
            this.Btn_Varaus.Name = "Btn_Varaus";
            this.Btn_Varaus.Size = new System.Drawing.Size(95, 34);
            this.Btn_Varaus.TabIndex = 0;
            this.Btn_Varaus.Text = "Varaus";
            this.Btn_Varaus.UseVisualStyleBackColor = true;
            this.Btn_Varaus.Click += new System.EventHandler(this.Btn_Varaus_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(29, 102);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(95, 36);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Hallinta";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(29, 166);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(95, 49);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "Varausten historia";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(29, 233);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(95, 49);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "Laskutus";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // PicBox1
            // 
            this.PicBox1.Image = global::VillageNewbies.Properties.Resources.mokki2;
            this.PicBox1.Location = new System.Drawing.Point(0, 3);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(880, 423);
            this.PicBox1.TabIndex = 0;
            this.PicBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Central_Panel);
            this.Controls.Add(this.Left_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Left_panel.ResumeLayout(false);
            this.Central_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel Central_Panel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn_Varaus;
        private System.Windows.Forms.PictureBox PicBox1;
    }
}


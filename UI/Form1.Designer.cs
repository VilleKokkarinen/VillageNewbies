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
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Central_Panel = new System.Windows.Forms.Panel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Left_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Left_Panel.Controls.Add(this.button3);
            this.Left_Panel.Controls.Add(this.button2);
            this.Left_Panel.Controls.Add(this.button1);
            this.Left_Panel.Location = new System.Drawing.Point(2, 109);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(200, 447);
            this.Left_Panel.TabIndex = 0;
            // 
            // Central_Panel
            // 
            this.Central_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Central_Panel.Location = new System.Drawing.Point(203, 109);
            this.Central_Panel.Name = "Central_Panel";
            this.Central_Panel.Size = new System.Drawing.Size(865, 447);
            this.Central_Panel.TabIndex = 1;
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Top_Panel.Location = new System.Drawing.Point(2, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1066, 112);
            this.Top_Panel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Central_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Left_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel Central_Panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Top_Panel;
    }
}


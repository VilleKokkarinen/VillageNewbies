namespace VillageNewbies.UI
{
    partial class MokkiRaportointi
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checklist_Cabins = new System.Windows.Forms.CheckedListBox();
            this.checklist_Cabin_Reservations = new System.Windows.Forms.CheckedListBox();
            this.txtCabinDetails = new System.Windows.Forms.TextBox();
            this.checklist_Cabin_Reservation_Services = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // checklist_Cabins
            // 
            this.checklist_Cabins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Cabins.CheckOnClick = true;
            this.checklist_Cabins.DisplayMember = "Text";
            this.checklist_Cabins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checklist_Cabins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checklist_Cabins.FormattingEnabled = true;
            this.checklist_Cabins.HorizontalScrollbar = true;
            this.checklist_Cabins.Location = new System.Drawing.Point(38, 186);
            this.checklist_Cabins.Name = "checklist_Cabins";
            this.checklist_Cabins.Size = new System.Drawing.Size(225, 259);
            this.checklist_Cabins.TabIndex = 51;
            this.checklist_Cabins.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklist_Cabins_ItemCheck);
            this.checklist_Cabins.SelectedIndexChanged += new System.EventHandler(this.checklist_Cabins_SelectedIndexChanged);
            // 
            // checklist_Cabin_Reservations
            // 
            this.checklist_Cabin_Reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Cabin_Reservations.CheckOnClick = true;
            this.checklist_Cabin_Reservations.DisplayMember = "Text";
            this.checklist_Cabin_Reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checklist_Cabin_Reservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checklist_Cabin_Reservations.FormattingEnabled = true;
            this.checklist_Cabin_Reservations.HorizontalScrollbar = true;
            this.checklist_Cabin_Reservations.Location = new System.Drawing.Point(269, 16);
            this.checklist_Cabin_Reservations.Name = "checklist_Cabin_Reservations";
            this.checklist_Cabin_Reservations.Size = new System.Drawing.Size(292, 429);
            this.checklist_Cabin_Reservations.TabIndex = 52;
            this.checklist_Cabin_Reservations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklist_Cabin_Reservations_ItemCheck);
            this.checklist_Cabin_Reservations.SelectedIndexChanged += new System.EventHandler(this.checklist_Cabin_Reservations_SelectedIndexChanged);
            // 
            // txtCabinDetails
            // 
            this.txtCabinDetails.Location = new System.Drawing.Point(1043, 16);
            this.txtCabinDetails.Multiline = true;
            this.txtCabinDetails.Name = "txtCabinDetails";
            this.txtCabinDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCabinDetails.Size = new System.Drawing.Size(274, 429);
            this.txtCabinDetails.TabIndex = 53;
            // 
            // checklist_Cabin_Reservation_Services
            // 
            this.checklist_Cabin_Reservation_Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Cabin_Reservation_Services.CheckOnClick = true;
            this.checklist_Cabin_Reservation_Services.DisplayMember = "Text";
            this.checklist_Cabin_Reservation_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checklist_Cabin_Reservation_Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checklist_Cabin_Reservation_Services.FormattingEnabled = true;
            this.checklist_Cabin_Reservation_Services.HorizontalScrollbar = true;
            this.checklist_Cabin_Reservation_Services.Location = new System.Drawing.Point(567, 16);
            this.checklist_Cabin_Reservation_Services.Name = "checklist_Cabin_Reservation_Services";
            this.checklist_Cabin_Reservation_Services.Size = new System.Drawing.Size(470, 429);
            this.checklist_Cabin_Reservation_Services.TabIndex = 54;
            // 
            // MokkiRaportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 485);
            this.Controls.Add(this.checklist_Cabin_Reservation_Services);
            this.Controls.Add(this.txtCabinDetails);
            this.Controls.Add(this.checklist_Cabin_Reservations);
            this.Controls.Add(this.checklist_Cabins);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MokkiRaportointi";
            this.Text = "Mökkien raportointi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckedListBox checklist_Cabins;
        private System.Windows.Forms.CheckedListBox checklist_Cabin_Reservations;
        private System.Windows.Forms.TextBox txtCabinDetails;
        private System.Windows.Forms.CheckedListBox checklist_Cabin_Reservation_Services;
    }
}
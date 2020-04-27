namespace VillageNewbies.UI
{
    partial class Varaus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combobox_Cabin_something = new System.Windows.Forms.ComboBox();
            this.txt_SearchCabin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Cabin_ReservedTill = new System.Windows.Forms.TextBox();
            this.txt_Cabin_State = new System.Windows.Forms.TextBox();
            this.txt_Cabin_Type = new System.Windows.Forms.TextBox();
            this.checklist_Loan_Cabins = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cmb_Alue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Clb_Palvelut = new System.Windows.Forms.CheckedListBox();
            this.labelAsiakas_id = new System.Windows.Forms.Label();
            this.txtboxAsiakas_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxEtunimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxSukunimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxPostinro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxlahiosoite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxPuhelinnro = new System.Windows.Forms.TextBox();
            this.buttonLisääMuokkaa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.checklist_Loan_Cabins);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(319, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 778);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 458);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 316);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combobox_Cabin_something);
            this.groupBox3.Controls.Add(this.txt_SearchCabin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(324, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(249, 122);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hae mökkejä";
            // 
            // combobox_Cabin_something
            // 
            this.combobox_Cabin_something.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_Cabin_something.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_Cabin_something.DisplayMember = "Text";
            this.combobox_Cabin_something.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Cabin_something.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combobox_Cabin_something.FormattingEnabled = true;
            this.combobox_Cabin_something.Location = new System.Drawing.Point(9, 71);
            this.combobox_Cabin_something.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_Cabin_something.Name = "combobox_Cabin_something";
            this.combobox_Cabin_something.Size = new System.Drawing.Size(185, 33);
            this.combobox_Cabin_something.TabIndex = 47;
            // 
            // txt_SearchCabin
            // 
            this.txt_SearchCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_SearchCabin.Location = new System.Drawing.Point(9, 28);
            this.txt_SearchCabin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SearchCabin.Name = "txt_SearchCabin";
            this.txt_SearchCabin.Size = new System.Drawing.Size(185, 30);
            this.txt_SearchCabin.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Cabin_ReservedTill);
            this.groupBox2.Controls.Add(this.txt_Cabin_State);
            this.groupBox2.Controls.Add(this.txt_Cabin_Type);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(325, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(248, 153);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mökin tiedot";
            // 
            // txt_Cabin_ReservedTill
            // 
            this.txt_Cabin_ReservedTill.Location = new System.Drawing.Point(8, 113);
            this.txt_Cabin_ReservedTill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cabin_ReservedTill.Name = "txt_Cabin_ReservedTill";
            this.txt_Cabin_ReservedTill.ReadOnly = true;
            this.txt_Cabin_ReservedTill.Size = new System.Drawing.Size(228, 30);
            this.txt_Cabin_ReservedTill.TabIndex = 3;
            // 
            // txt_Cabin_State
            // 
            this.txt_Cabin_State.Location = new System.Drawing.Point(8, 73);
            this.txt_Cabin_State.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cabin_State.Name = "txt_Cabin_State";
            this.txt_Cabin_State.ReadOnly = true;
            this.txt_Cabin_State.Size = new System.Drawing.Size(189, 30);
            this.txt_Cabin_State.TabIndex = 2;
            // 
            // txt_Cabin_Type
            // 
            this.txt_Cabin_Type.Location = new System.Drawing.Point(8, 31);
            this.txt_Cabin_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cabin_Type.Name = "txt_Cabin_Type";
            this.txt_Cabin_Type.ReadOnly = true;
            this.txt_Cabin_Type.Size = new System.Drawing.Size(191, 30);
            this.txt_Cabin_Type.TabIndex = 1;
            // 
            // checklist_Loan_Cabins
            // 
            this.checklist_Loan_Cabins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Loan_Cabins.CheckOnClick = true;
            this.checklist_Loan_Cabins.DisplayMember = "Text";
            this.checklist_Loan_Cabins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checklist_Loan_Cabins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checklist_Loan_Cabins.FormattingEnabled = true;
            this.checklist_Loan_Cabins.HorizontalScrollbar = true;
            this.checklist_Loan_Cabins.Location = new System.Drawing.Point(4, 16);
            this.checklist_Loan_Cabins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checklist_Loan_Cabins.Name = "checklist_Loan_Cabins";
            this.checklist_Loan_Cabins.Size = new System.Drawing.Size(299, 319);
            this.checklist_Loan_Cabins.TabIndex = 50;
            this.checklist_Loan_Cabins.SelectedIndexChanged += new System.EventHandler(this.checklist_Loan_Cabins_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(591, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 164);
            this.listBox1.TabIndex = 0;
            // 
            // Cmb_Alue
            // 
            this.Cmb_Alue.FormattingEnabled = true;
            this.Cmb_Alue.Location = new System.Drawing.Point(100, 17);
            this.Cmb_Alue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_Alue.Name = "Cmb_Alue";
            this.Cmb_Alue.Size = new System.Drawing.Size(163, 24);
            this.Cmb_Alue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alue";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 130);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tulopäivä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lähtöpäivä";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Henkilömäärä";
            // 
            // Clb_Palvelut
            // 
            this.Clb_Palvelut.FormattingEnabled = true;
            this.Clb_Palvelut.Location = new System.Drawing.Point(12, 248);
            this.Clb_Palvelut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clb_Palvelut.Name = "Clb_Palvelut";
            this.Clb_Palvelut.Size = new System.Drawing.Size(301, 89);
            this.Clb_Palvelut.TabIndex = 9;
            // 
            // labelAsiakas_id
            // 
            this.labelAsiakas_id.AutoSize = true;
            this.labelAsiakas_id.Location = new System.Drawing.Point(16, 471);
            this.labelAsiakas_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAsiakas_id.Name = "labelAsiakas_id";
            this.labelAsiakas_id.Size = new System.Drawing.Size(76, 17);
            this.labelAsiakas_id.TabIndex = 10;
            this.labelAsiakas_id.Text = "Asiakas_id";
            // 
            // txtboxAsiakas_id
            // 
            this.txtboxAsiakas_id.Location = new System.Drawing.Point(148, 471);
            this.txtboxAsiakas_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxAsiakas_id.Name = "txtboxAsiakas_id";
            this.txtboxAsiakas_id.Size = new System.Drawing.Size(132, 22);
            this.txtboxAsiakas_id.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Etunimi";
            // 
            // txtboxEtunimi
            // 
            this.txtboxEtunimi.Location = new System.Drawing.Point(148, 508);
            this.txtboxEtunimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxEtunimi.Name = "txtboxEtunimi";
            this.txtboxEtunimi.Size = new System.Drawing.Size(132, 22);
            this.txtboxEtunimi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sukunimi";
            // 
            // txtboxSukunimi
            // 
            this.txtboxSukunimi.Location = new System.Drawing.Point(148, 546);
            this.txtboxSukunimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSukunimi.Name = "txtboxSukunimi";
            this.txtboxSukunimi.Size = new System.Drawing.Size(132, 22);
            this.txtboxSukunimi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postinumero";
            // 
            // txtboxPostinro
            // 
            this.txtboxPostinro.Location = new System.Drawing.Point(148, 585);
            this.txtboxPostinro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPostinro.Name = "txtboxPostinro";
            this.txtboxPostinro.Size = new System.Drawing.Size(132, 22);
            this.txtboxPostinro.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lähiosoite";
            // 
            // txtboxlahiosoite
            // 
            this.txtboxlahiosoite.Location = new System.Drawing.Point(148, 623);
            this.txtboxlahiosoite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxlahiosoite.Name = "txtboxlahiosoite";
            this.txtboxlahiosoite.Size = new System.Drawing.Size(132, 22);
            this.txtboxlahiosoite.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 661);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(148, 661);
            this.txtboxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(132, 22);
            this.txtboxEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 702);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Puhelin Nro";
            // 
            // txtboxPuhelinnro
            // 
            this.txtboxPuhelinnro.Location = new System.Drawing.Point(148, 702);
            this.txtboxPuhelinnro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPuhelinnro.Name = "txtboxPuhelinnro";
            this.txtboxPuhelinnro.Size = new System.Drawing.Size(132, 22);
            this.txtboxPuhelinnro.TabIndex = 23;
            // 
            // buttonLisääMuokkaa
            // 
            this.buttonLisääMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisääMuokkaa.Location = new System.Drawing.Point(48, 759);
            this.buttonLisääMuokkaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLisääMuokkaa.Name = "buttonLisääMuokkaa";
            this.buttonLisääMuokkaa.Size = new System.Drawing.Size(216, 28);
            this.buttonLisääMuokkaa.TabIndex = 24;
            this.buttonLisääMuokkaa.Text = "Lisää / Muokkaa";
            this.buttonLisääMuokkaa.UseVisualStyleBackColor = true;
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 805);
            this.Controls.Add(this.buttonLisääMuokkaa);
            this.Controls.Add(this.txtboxPuhelinnro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxlahiosoite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxPostinro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxSukunimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxEtunimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxAsiakas_id);
            this.Controls.Add(this.labelAsiakas_id);
            this.Controls.Add(this.Clb_Palvelut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Alue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Varaus";
            this.Text = "Varaus";
            this.Load += new System.EventHandler(this.Varaus_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Cmb_Alue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox Clb_Palvelut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combobox_Cabin_something;
        private System.Windows.Forms.TextBox txt_SearchCabin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Cabin_ReservedTill;
        private System.Windows.Forms.TextBox txt_Cabin_State;
        private System.Windows.Forms.TextBox txt_Cabin_Type;
        private System.Windows.Forms.CheckedListBox checklist_Loan_Cabins;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAsiakas_id;
        private System.Windows.Forms.TextBox txtboxAsiakas_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxEtunimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxSukunimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxPostinro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxlahiosoite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtboxPuhelinnro;
        private System.Windows.Forms.Button buttonLisääMuokkaa;
    }
}
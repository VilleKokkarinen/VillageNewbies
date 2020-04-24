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
            this.combobox_Loan_ItemType = new System.Windows.Forms.ComboBox();
            this.txt_LoanItem_SearchItem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Loan_ReservedTill = new System.Windows.Forms.TextBox();
            this.txt_Loan_Item_State = new System.Windows.Forms.TextBox();
            this.txt_Loan_ItemType = new System.Windows.Forms.TextBox();
            this.checklist_Loan_Items = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cmb_Alue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Clb_Ominaisuudet = new System.Windows.Forms.CheckedListBox();
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
            this.panel1.Controls.Add(this.checklist_Loan_Items);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(239, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 632);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 257);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combobox_Loan_ItemType);
            this.groupBox3.Controls.Add(this.txt_LoanItem_SearchItem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(243, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 99);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hae Tavaroita";
            // 
            // combobox_Loan_ItemType
            // 
            this.combobox_Loan_ItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_Loan_ItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_Loan_ItemType.DisplayMember = "Text";
            this.combobox_Loan_ItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Loan_ItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combobox_Loan_ItemType.FormattingEnabled = true;
            this.combobox_Loan_ItemType.Location = new System.Drawing.Point(7, 58);
            this.combobox_Loan_ItemType.Name = "combobox_Loan_ItemType";
            this.combobox_Loan_ItemType.Size = new System.Drawing.Size(140, 28);
            this.combobox_Loan_ItemType.TabIndex = 47;
            // 
            // txt_LoanItem_SearchItem
            // 
            this.txt_LoanItem_SearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_LoanItem_SearchItem.Location = new System.Drawing.Point(7, 23);
            this.txt_LoanItem_SearchItem.Name = "txt_LoanItem_SearchItem";
            this.txt_LoanItem_SearchItem.Size = new System.Drawing.Size(140, 26);
            this.txt_LoanItem_SearchItem.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Loan_ReservedTill);
            this.groupBox2.Controls.Add(this.txt_Loan_Item_State);
            this.groupBox2.Controls.Add(this.txt_Loan_ItemType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(244, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 124);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tavaran tiedot";
            // 
            // txt_Loan_ReservedTill
            // 
            this.txt_Loan_ReservedTill.Location = new System.Drawing.Point(6, 92);
            this.txt_Loan_ReservedTill.Name = "txt_Loan_ReservedTill";
            this.txt_Loan_ReservedTill.ReadOnly = true;
            this.txt_Loan_ReservedTill.Size = new System.Drawing.Size(172, 26);
            this.txt_Loan_ReservedTill.TabIndex = 3;
            // 
            // txt_Loan_Item_State
            // 
            this.txt_Loan_Item_State.Location = new System.Drawing.Point(6, 59);
            this.txt_Loan_Item_State.Name = "txt_Loan_Item_State";
            this.txt_Loan_Item_State.ReadOnly = true;
            this.txt_Loan_Item_State.Size = new System.Drawing.Size(143, 26);
            this.txt_Loan_Item_State.TabIndex = 2;
            // 
            // txt_Loan_ItemType
            // 
            this.txt_Loan_ItemType.Location = new System.Drawing.Point(6, 25);
            this.txt_Loan_ItemType.Name = "txt_Loan_ItemType";
            this.txt_Loan_ItemType.ReadOnly = true;
            this.txt_Loan_ItemType.Size = new System.Drawing.Size(144, 26);
            this.txt_Loan_ItemType.TabIndex = 1;
            // 
            // checklist_Loan_Items
            // 
            this.checklist_Loan_Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Loan_Items.CheckOnClick = true;
            this.checklist_Loan_Items.DisplayMember = "Text";
            this.checklist_Loan_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checklist_Loan_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checklist_Loan_Items.FormattingEnabled = true;
            this.checklist_Loan_Items.HorizontalScrollbar = true;
            this.checklist_Loan_Items.Location = new System.Drawing.Point(3, 13);
            this.checklist_Loan_Items.Name = "checklist_Loan_Items";
            this.checklist_Loan_Items.Size = new System.Drawing.Size(225, 276);
            this.checklist_Loan_Items.TabIndex = 50;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(443, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 134);
            this.listBox1.TabIndex = 0;
            // 
            // Cmb_Alue
            // 
            this.Cmb_Alue.FormattingEnabled = true;
            this.Cmb_Alue.Location = new System.Drawing.Point(75, 14);
            this.Cmb_Alue.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Alue.Name = "Cmb_Alue";
            this.Cmb_Alue.Size = new System.Drawing.Size(123, 21);
            this.Cmb_Alue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alue";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 106);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tulopäivä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lähtöpäivä";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 149);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Henkilömäärä";
            // 
            // Clb_Ominaisuudet
            // 
            this.Clb_Ominaisuudet.FormattingEnabled = true;
            this.Clb_Ominaisuudet.Location = new System.Drawing.Point(25, 223);
            this.Clb_Ominaisuudet.Margin = new System.Windows.Forms.Padding(2);
            this.Clb_Ominaisuudet.Name = "Clb_Ominaisuudet";
            this.Clb_Ominaisuudet.Size = new System.Drawing.Size(91, 64);
            this.Clb_Ominaisuudet.TabIndex = 9;
            // 
            // labelAsiakas_id
            // 
            this.labelAsiakas_id.AutoSize = true;
            this.labelAsiakas_id.Location = new System.Drawing.Point(12, 383);
            this.labelAsiakas_id.Name = "labelAsiakas_id";
            this.labelAsiakas_id.Size = new System.Drawing.Size(58, 13);
            this.labelAsiakas_id.TabIndex = 10;
            this.labelAsiakas_id.Text = "Asiakas_id";
            // 
            // txtboxAsiakas_id
            // 
            this.txtboxAsiakas_id.Location = new System.Drawing.Point(111, 383);
            this.txtboxAsiakas_id.Name = "txtboxAsiakas_id";
            this.txtboxAsiakas_id.Size = new System.Drawing.Size(100, 20);
            this.txtboxAsiakas_id.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Etunimi";
            // 
            // txtboxEtunimi
            // 
            this.txtboxEtunimi.Location = new System.Drawing.Point(111, 413);
            this.txtboxEtunimi.Name = "txtboxEtunimi";
            this.txtboxEtunimi.Size = new System.Drawing.Size(100, 20);
            this.txtboxEtunimi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sukunimi";
            // 
            // txtboxSukunimi
            // 
            this.txtboxSukunimi.Location = new System.Drawing.Point(111, 444);
            this.txtboxSukunimi.Name = "txtboxSukunimi";
            this.txtboxSukunimi.Size = new System.Drawing.Size(100, 20);
            this.txtboxSukunimi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postinumero";
            // 
            // txtboxPostinro
            // 
            this.txtboxPostinro.Location = new System.Drawing.Point(111, 475);
            this.txtboxPostinro.Name = "txtboxPostinro";
            this.txtboxPostinro.Size = new System.Drawing.Size(100, 20);
            this.txtboxPostinro.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lähiosoite";
            // 
            // txtboxlahiosoite
            // 
            this.txtboxlahiosoite.Location = new System.Drawing.Point(111, 506);
            this.txtboxlahiosoite.Name = "txtboxlahiosoite";
            this.txtboxlahiosoite.Size = new System.Drawing.Size(100, 20);
            this.txtboxlahiosoite.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(111, 537);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Puhelin Nro";
            // 
            // txtboxPuhelinnro
            // 
            this.txtboxPuhelinnro.Location = new System.Drawing.Point(111, 570);
            this.txtboxPuhelinnro.Name = "txtboxPuhelinnro";
            this.txtboxPuhelinnro.Size = new System.Drawing.Size(100, 20);
            this.txtboxPuhelinnro.TabIndex = 23;
            // 
            // buttonLisääMuokkaa
            // 
            this.buttonLisääMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisääMuokkaa.Location = new System.Drawing.Point(36, 617);
            this.buttonLisääMuokkaa.Name = "buttonLisääMuokkaa";
            this.buttonLisääMuokkaa.Size = new System.Drawing.Size(162, 23);
            this.buttonLisääMuokkaa.TabIndex = 24;
            this.buttonLisääMuokkaa.Text = "Lisää / Muokkaa";
            this.buttonLisääMuokkaa.UseVisualStyleBackColor = true;
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 654);
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
            this.Controls.Add(this.Clb_Ominaisuudet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Alue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckedListBox Clb_Ominaisuudet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combobox_Loan_ItemType;
        private System.Windows.Forms.TextBox txt_LoanItem_SearchItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Loan_ReservedTill;
        private System.Windows.Forms.TextBox txt_Loan_Item_State;
        private System.Windows.Forms.TextBox txt_Loan_ItemType;
        private System.Windows.Forms.CheckedListBox checklist_Loan_Items;
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
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
            this.label_HaeSukuNimella = new System.Windows.Forms.Label();
            this.textBox_HaeSukunimella = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_Cabin_Show_Reserved = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.combobox_Cabin_Region = new System.Windows.Forms.ComboBox();
            this.txt_Cabin_Search_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Cabin_Price = new System.Windows.Forms.TextBox();
            this.txt_Cabin_Details = new System.Windows.Forms.TextBox();
            this.txt_Cabin_State = new System.Windows.Forms.TextBox();
            this.txt_Cabin_MaxResidents = new System.Windows.Forms.TextBox();
            this.checklist_Loan_Cabins = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_HenkMaara = new System.Windows.Forms.ComboBox();
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
            this.Btn_Varaa = new System.Windows.Forms.Button();
            this.Lbl_Hinta = new System.Windows.Forms.Label();
            this.txtHinta = new System.Windows.Forms.TextBox();
            this.Btn_Tyhjenna = new System.Windows.Forms.Button();
            this.label_PostiToimiPaikka = new System.Windows.Forms.Label();
            this.textBox_PostiToimiPaikka = new System.Windows.Forms.TextBox();
            this.dpTulo = new VillageNewbies.UI.datepikkeriHost();
            this.dpLahto = new VillageNewbies.UI.datepikkeriHost();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label_HaeSukuNimella);
            this.panel1.Controls.Add(this.textBox_HaeSukunimella);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.checklist_Loan_Cabins);
            this.panel1.Location = new System.Drawing.Point(239, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 632);
            this.panel1.TabIndex = 0;
            // 
            // label_HaeSukuNimella
            // 
            this.label_HaeSukuNimella.AutoSize = true;
            this.label_HaeSukuNimella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HaeSukuNimella.ForeColor = System.Drawing.Color.White;
            this.label_HaeSukuNimella.Location = new System.Drawing.Point(824, 337);
            this.label_HaeSukuNimella.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_HaeSukuNimella.Name = "label_HaeSukuNimella";
            this.label_HaeSukuNimella.Size = new System.Drawing.Size(112, 17);
            this.label_HaeSukuNimella.TabIndex = 55;
            this.label_HaeSukuNimella.Text = "Hae sukunimellä";
            // 
            // textBox_HaeSukunimella
            // 
            this.textBox_HaeSukunimella.Location = new System.Drawing.Point(928, 337);
            this.textBox_HaeSukunimella.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_HaeSukunimella.Name = "textBox_HaeSukunimella";
            this.textBox_HaeSukunimella.Size = new System.Drawing.Size(92, 20);
            this.textBox_HaeSukunimella.TabIndex = 54;
            this.textBox_HaeSukunimella.TextChanged += new System.EventHandler(this.textBox_HaeSukunimella_TextChanged);
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
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 257);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_Cabin_Show_Reserved);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.combobox_Cabin_Region);
            this.groupBox3.Controls.Add(this.txt_Cabin_Search_Name);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(243, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 97);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hae mökkejä";
            // 
            // check_Cabin_Show_Reserved
            // 
            this.check_Cabin_Show_Reserved.AutoSize = true;
            this.check_Cabin_Show_Reserved.Location = new System.Drawing.Point(241, 24);
            this.check_Cabin_Show_Reserved.Name = "check_Cabin_Show_Reserved";
            this.check_Cabin_Show_Reserved.Size = new System.Drawing.Size(122, 24);
            this.check_Cabin_Show_Reserved.TabIndex = 49;
            this.check_Cabin_Show_Reserved.Text = "Näytä varatut";
            this.check_Cabin_Show_Reserved.UseVisualStyleBackColor = true;
            this.check_Cabin_Show_Reserved.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "kunnalla";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "nimellä";
            // 
            // combobox_Cabin_Region
            // 
            this.combobox_Cabin_Region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_Cabin_Region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_Cabin_Region.DisplayMember = "Text";
            this.combobox_Cabin_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Cabin_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combobox_Cabin_Region.FormattingEnabled = true;
            this.combobox_Cabin_Region.Location = new System.Drawing.Point(83, 57);
            this.combobox_Cabin_Region.Name = "combobox_Cabin_Region";
            this.combobox_Cabin_Region.Size = new System.Drawing.Size(140, 28);
            this.combobox_Cabin_Region.TabIndex = 47;
            this.combobox_Cabin_Region.SelectedIndexChanged += new System.EventHandler(this.combobox_Cabin_Region_SelectedIndexChanged);
            // 
            // txt_Cabin_Search_Name
            // 
            this.txt_Cabin_Search_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Cabin_Search_Name.Location = new System.Drawing.Point(83, 25);
            this.txt_Cabin_Search_Name.Name = "txt_Cabin_Search_Name";
            this.txt_Cabin_Search_Name.Size = new System.Drawing.Size(140, 26);
            this.txt_Cabin_Search_Name.TabIndex = 45;
            this.txt_Cabin_Search_Name.TextChanged += new System.EventHandler(this.txt_Cabin_Search_Name_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_Cabin_Price);
            this.groupBox2.Controls.Add(this.txt_Cabin_Details);
            this.groupBox2.Controls.Add(this.txt_Cabin_State);
            this.groupBox2.Controls.Add(this.txt_Cabin_MaxResidents);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(244, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 175);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mökin tiedot";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "hinta per yö";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "tiedot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tila";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "max asukkaat";
            // 
            // txt_Cabin_Price
            // 
            this.txt_Cabin_Price.Location = new System.Drawing.Point(417, 25);
            this.txt_Cabin_Price.Name = "txt_Cabin_Price";
            this.txt_Cabin_Price.ReadOnly = true;
            this.txt_Cabin_Price.Size = new System.Drawing.Size(39, 26);
            this.txt_Cabin_Price.TabIndex = 4;
            // 
            // txt_Cabin_Details
            // 
            this.txt_Cabin_Details.Location = new System.Drawing.Point(117, 94);
            this.txt_Cabin_Details.Multiline = true;
            this.txt_Cabin_Details.Name = "txt_Cabin_Details";
            this.txt_Cabin_Details.ReadOnly = true;
            this.txt_Cabin_Details.Size = new System.Drawing.Size(172, 75);
            this.txt_Cabin_Details.TabIndex = 3;
            // 
            // txt_Cabin_State
            // 
            this.txt_Cabin_State.Location = new System.Drawing.Point(117, 59);
            this.txt_Cabin_State.Name = "txt_Cabin_State";
            this.txt_Cabin_State.ReadOnly = true;
            this.txt_Cabin_State.Size = new System.Drawing.Size(137, 26);
            this.txt_Cabin_State.TabIndex = 2;
            // 
            // txt_Cabin_MaxResidents
            // 
            this.txt_Cabin_MaxResidents.Location = new System.Drawing.Point(117, 25);
            this.txt_Cabin_MaxResidents.Name = "txt_Cabin_MaxResidents";
            this.txt_Cabin_MaxResidents.ReadOnly = true;
            this.txt_Cabin_MaxResidents.Size = new System.Drawing.Size(29, 26);
            this.txt_Cabin_MaxResidents.TabIndex = 1;
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
            this.checklist_Loan_Cabins.Location = new System.Drawing.Point(3, 13);
            this.checklist_Loan_Cabins.Name = "checklist_Loan_Cabins";
            this.checklist_Loan_Cabins.Size = new System.Drawing.Size(225, 276);
            this.checklist_Loan_Cabins.TabIndex = 50;
            this.checklist_Loan_Cabins.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklist_Loan_Cabins_ItemCheck);
            this.checklist_Loan_Cabins.SelectedIndexChanged += new System.EventHandler(this.checklist_Loan_Cabins_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 23);
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
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lähtöpäivä";
            // 
            // comboBox_HenkMaara
            // 
            this.comboBox_HenkMaara.FormattingEnabled = true;
            this.comboBox_HenkMaara.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_HenkMaara.Location = new System.Drawing.Point(75, 115);
            this.comboBox_HenkMaara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_HenkMaara.Name = "comboBox_HenkMaara";
            this.comboBox_HenkMaara.Size = new System.Drawing.Size(92, 21);
            this.comboBox_HenkMaara.TabIndex = 7;
            this.comboBox_HenkMaara.SelectedIndexChanged += new System.EventHandler(this.comboBox_HenkMaara_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Henkilömäärä";
            // 
            // Clb_Palvelut
            // 
            this.Clb_Palvelut.FormattingEnabled = true;
            this.Clb_Palvelut.Location = new System.Drawing.Point(8, 164);
            this.Clb_Palvelut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clb_Palvelut.Name = "Clb_Palvelut";
            this.Clb_Palvelut.Size = new System.Drawing.Size(227, 34);
            this.Clb_Palvelut.TabIndex = 9;
            // 
            // labelAsiakas_id
            // 
            this.labelAsiakas_id.AutoSize = true;
            this.labelAsiakas_id.Location = new System.Drawing.Point(12, 276);
            this.labelAsiakas_id.Name = "labelAsiakas_id";
            this.labelAsiakas_id.Size = new System.Drawing.Size(58, 13);
            this.labelAsiakas_id.TabIndex = 10;
            this.labelAsiakas_id.Text = "Asiakas_id";
            // 
            // txtboxAsiakas_id
            // 
            this.txtboxAsiakas_id.Location = new System.Drawing.Point(111, 274);
            this.txtboxAsiakas_id.Name = "txtboxAsiakas_id";
            this.txtboxAsiakas_id.Size = new System.Drawing.Size(100, 20);
            this.txtboxAsiakas_id.TabIndex = 11;
            this.txtboxAsiakas_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAsiakas_id_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Etunimi";
            // 
            // txtboxEtunimi
            // 
            this.txtboxEtunimi.Location = new System.Drawing.Point(111, 298);
            this.txtboxEtunimi.Name = "txtboxEtunimi";
            this.txtboxEtunimi.Size = new System.Drawing.Size(100, 20);
            this.txtboxEtunimi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sukunimi";
            // 
            // txtboxSukunimi
            // 
            this.txtboxSukunimi.Location = new System.Drawing.Point(111, 328);
            this.txtboxSukunimi.Name = "txtboxSukunimi";
            this.txtboxSukunimi.Size = new System.Drawing.Size(100, 20);
            this.txtboxSukunimi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postinumero";
            // 
            // txtboxPostinro
            // 
            this.txtboxPostinro.Location = new System.Drawing.Point(111, 353);
            this.txtboxPostinro.Name = "txtboxPostinro";
            this.txtboxPostinro.Size = new System.Drawing.Size(100, 20);
            this.txtboxPostinro.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lähiosoite";
            // 
            // txtboxlahiosoite
            // 
            this.txtboxlahiosoite.Location = new System.Drawing.Point(111, 399);
            this.txtboxlahiosoite.Name = "txtboxlahiosoite";
            this.txtboxlahiosoite.Size = new System.Drawing.Size(100, 20);
            this.txtboxlahiosoite.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(111, 423);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtboxEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Puhelin Nro";
            // 
            // txtboxPuhelinnro
            // 
            this.txtboxPuhelinnro.Location = new System.Drawing.Point(111, 448);
            this.txtboxPuhelinnro.Name = "txtboxPuhelinnro";
            this.txtboxPuhelinnro.Size = new System.Drawing.Size(100, 20);
            this.txtboxPuhelinnro.TabIndex = 23;
            // 
            // buttonLisääMuokkaa
            // 
            this.buttonLisääMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisääMuokkaa.Location = new System.Drawing.Point(24, 483);
            this.buttonLisääMuokkaa.Name = "buttonLisääMuokkaa";
            this.buttonLisääMuokkaa.Size = new System.Drawing.Size(162, 23);
            this.buttonLisääMuokkaa.TabIndex = 24;
            this.buttonLisääMuokkaa.Text = "Lisää / Muokkaa";
            this.buttonLisääMuokkaa.UseVisualStyleBackColor = true;
            this.buttonLisääMuokkaa.Click += new System.EventHandler(this.buttonLisääMuokkaa_Click);
            // 
            // Btn_Varaa
            // 
            this.Btn_Varaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Varaa.Location = new System.Drawing.Point(46, 600);
            this.Btn_Varaa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Varaa.Name = "Btn_Varaa";
            this.Btn_Varaa.Size = new System.Drawing.Size(102, 41);
            this.Btn_Varaa.TabIndex = 25;
            this.Btn_Varaa.Text = "Varaa";
            this.Btn_Varaa.UseVisualStyleBackColor = true;
            this.Btn_Varaa.Click += new System.EventHandler(this.Btn_Varaa_Click);
            // 
            // Lbl_Hinta
            // 
            this.Lbl_Hinta.AutoSize = true;
            this.Lbl_Hinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hinta.Location = new System.Drawing.Point(12, 536);
            this.Lbl_Hinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Hinta.Name = "Lbl_Hinta";
            this.Lbl_Hinta.Size = new System.Drawing.Size(52, 22);
            this.Lbl_Hinta.TabIndex = 26;
            this.Lbl_Hinta.Text = "Hinta";
            // 
            // txtHinta
            // 
            this.txtHinta.Location = new System.Drawing.Point(111, 540);
            this.txtHinta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHinta.Name = "txtHinta";
            this.txtHinta.Size = new System.Drawing.Size(76, 20);
            this.txtHinta.TabIndex = 27;
            this.txtHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHinta_KeyPress);
            // 
            // Btn_Tyhjenna
            // 
            this.Btn_Tyhjenna.Location = new System.Drawing.Point(11, 213);
            this.Btn_Tyhjenna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Tyhjenna.Name = "Btn_Tyhjenna";
            this.Btn_Tyhjenna.Size = new System.Drawing.Size(70, 47);
            this.Btn_Tyhjenna.TabIndex = 28;
            this.Btn_Tyhjenna.Text = "Tyhjenä tekstikentät";
            this.Btn_Tyhjenna.UseVisualStyleBackColor = true;
            this.Btn_Tyhjenna.Click += new System.EventHandler(this.Btn_Tyhjenna_Click);
            // 
            // label_PostiToimiPaikka
            // 
            this.label_PostiToimiPaikka.AutoSize = true;
            this.label_PostiToimiPaikka.Location = new System.Drawing.Point(14, 379);
            this.label_PostiToimiPaikka.Name = "label_PostiToimiPaikka";
            this.label_PostiToimiPaikka.Size = new System.Drawing.Size(83, 13);
            this.label_PostiToimiPaikka.TabIndex = 16;
            this.label_PostiToimiPaikka.Text = "Postitoimipaikka";
            // 
            // textBox_PostiToimiPaikka
            // 
            this.textBox_PostiToimiPaikka.Location = new System.Drawing.Point(111, 375);
            this.textBox_PostiToimiPaikka.Name = "textBox_PostiToimiPaikka";
            this.textBox_PostiToimiPaikka.Size = new System.Drawing.Size(100, 20);
            this.textBox_PostiToimiPaikka.TabIndex = 17;
            // 
            // dpTulo
            // 
            this.dpTulo.Location = new System.Drawing.Point(75, 20);
            this.dpTulo.Name = "dpTulo";
            this.dpTulo.Size = new System.Drawing.Size(100, 27);
            this.dpTulo.TabIndex = 56;
            // 
            // dpLahto
            // 
            this.dpLahto.Location = new System.Drawing.Point(75, 67);
            this.dpLahto.Name = "dpLahto";
            this.dpLahto.Size = new System.Drawing.Size(100, 27);
            this.dpLahto.TabIndex = 57;
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 654);
            this.Controls.Add(this.dpTulo);
            this.Controls.Add(this.dpLahto);
            this.Controls.Add(this.Btn_Tyhjenna);
            this.Controls.Add(this.txtHinta);
            this.Controls.Add(this.Lbl_Hinta);
            this.Controls.Add(this.Btn_Varaa);
            this.Controls.Add(this.buttonLisääMuokkaa);
            this.Controls.Add(this.txtboxPuhelinnro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxlahiosoite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_PostiToimiPaikka);
            this.Controls.Add(this.txtboxPostinro);
            this.Controls.Add(this.label_PostiToimiPaikka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxSukunimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxEtunimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxAsiakas_id);
            this.Controls.Add(this.labelAsiakas_id);
            this.Controls.Add(this.Clb_Palvelut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_HenkMaara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Varaus";
            this.Text = "Varaus";
            this.Load += new System.EventHandler(this.Varaus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_HenkMaara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox Clb_Palvelut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combobox_Cabin_Region;
        private System.Windows.Forms.TextBox txt_Cabin_Search_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Cabin_Details;
        private System.Windows.Forms.TextBox txt_Cabin_State;
        private System.Windows.Forms.TextBox txt_Cabin_MaxResidents;
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
        private System.Windows.Forms.Button Btn_Varaa;
        private System.Windows.Forms.Label Lbl_Hinta;
        private System.Windows.Forms.TextBox txtHinta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Cabin_Price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox check_Cabin_Show_Reserved;
        private System.Windows.Forms.Label label_HaeSukuNimella;
        private System.Windows.Forms.TextBox textBox_HaeSukunimella;
        private System.Windows.Forms.Button Btn_Tyhjenna;
        private System.Windows.Forms.Label label_PostiToimiPaikka;
        private System.Windows.Forms.TextBox textBox_PostiToimiPaikka;
        private datepikkeriHost dpTulo;
        private datepikkeriHost dpLahto;
    }
}
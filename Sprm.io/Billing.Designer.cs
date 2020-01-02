namespace Sprm
{
    partial class Billing
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.input_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.input_num = new System.Windows.Forms.TextBox();
            this.input_street = new System.Windows.Forms.TextBox();
            this.input_zip = new System.Windows.Forms.TextBox();
            this.input_city = new System.Windows.Forms.TextBox();
            this.input_tel = new System.Windows.Forms.TextBox();
            this.rb_solo = new System.Windows.Forms.RadioButton();
            this.rb_master = new System.Windows.Forms.RadioButton();
            this.rb_amex = new System.Windows.Forms.RadioButton();
            this.rb_visa = new System.Windows.Forms.RadioButton();
            this.input_profile = new System.Windows.Forms.TextBox();
            this.navigation = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.table.SuspendLayout();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_name
            // 
            this.input_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_name.Location = new System.Drawing.Point(497, 50);
            this.input_name.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(309, 26);
            this.input_name.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(222, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 39);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(538, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "Save Profile";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.BackColor = System.Drawing.Color.White;
            this.table.Controls.Add(this.label1);
            this.table.Controls.Add(this.cb_country);
            this.table.Controls.Add(this.label18);
            this.table.Controls.Add(this.label17);
            this.table.Controls.Add(this.label16);
            this.table.Controls.Add(this.label15);
            this.table.Controls.Add(this.label14);
            this.table.Controls.Add(this.comboBox2);
            this.table.Controls.Add(this.comboBox1);
            this.table.Controls.Add(this.label13);
            this.table.Controls.Add(this.label12);
            this.table.Controls.Add(this.label11);
            this.table.Controls.Add(this.label10);
            this.table.Controls.Add(this.label9);
            this.table.Controls.Add(this.label8);
            this.table.Controls.Add(this.textBox6);
            this.table.Controls.Add(this.textBox7);
            this.table.Controls.Add(this.input_num);
            this.table.Controls.Add(this.input_street);
            this.table.Controls.Add(this.input_zip);
            this.table.Controls.Add(this.input_city);
            this.table.Controls.Add(this.input_tel);
            this.table.Controls.Add(this.rb_solo);
            this.table.Controls.Add(this.rb_master);
            this.table.Controls.Add(this.rb_amex);
            this.table.Controls.Add(this.input_name);
            this.table.Controls.Add(this.rb_visa);
            this.table.Controls.Add(this.input_profile);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.table.Location = new System.Drawing.Point(222, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(978, 499);
            this.table.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(505, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 9);
            this.label1.TabIndex = 41;
            this.label1.Text = "Country";
            // 
            // cb_country
            // 
            this.cb_country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_country.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Items.AddRange(new object[] {
            "EU",
            "US"});
            this.cb_country.Location = new System.Drawing.Point(497, 178);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(309, 26);
            this.cb_country.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(86, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 9);
            this.label18.TabIndex = 39;
            this.label18.Text = "Profile";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(505, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 9);
            this.label17.TabIndex = 38;
            this.label17.Text = "Name";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(505, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 9);
            this.label16.TabIndex = 37;
            this.label16.Text = "Telephone";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(86, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 9);
            this.label15.TabIndex = 36;
            this.label15.Text = "Year";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(222, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 9);
            this.label14.TabIndex = 35;
            this.label14.Text = "Month";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox2.Location = new System.Drawing.Point(78, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 26);
            this.comboBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(214, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 26);
            this.comboBox1.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(705, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 9);
            this.label13.TabIndex = 33;
            this.label13.Text = "Zip";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(505, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 9);
            this.label12.TabIndex = 32;
            this.label12.Text = "City";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(705, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 9);
            this.label11.TabIndex = 31;
            this.label11.Text = "Number";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(505, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 9);
            this.label10.TabIndex = 30;
            this.label10.Text = "Street";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(86, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 9);
            this.label9.TabIndex = 29;
            this.label9.Text = "Number";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(279, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 9);
            this.label8.TabIndex = 28;
            this.label8.Text = "CVV";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.Location = new System.Drawing.Point(271, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 26);
            this.textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox7.Location = new System.Drawing.Point(78, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 26);
            this.textBox7.TabIndex = 25;
            // 
            // input_num
            // 
            this.input_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_num.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_num.Location = new System.Drawing.Point(697, 114);
            this.input_num.Name = "input_num";
            this.input_num.Size = new System.Drawing.Size(109, 26);
            this.input_num.TabIndex = 24;
            // 
            // input_street
            // 
            this.input_street.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_street.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_street.Location = new System.Drawing.Point(497, 114);
            this.input_street.Name = "input_street";
            this.input_street.Size = new System.Drawing.Size(194, 26);
            this.input_street.TabIndex = 22;
            // 
            // input_zip
            // 
            this.input_zip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_zip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_zip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_zip.Location = new System.Drawing.Point(697, 146);
            this.input_zip.Name = "input_zip";
            this.input_zip.Size = new System.Drawing.Size(109, 26);
            this.input_zip.TabIndex = 21;
            // 
            // input_city
            // 
            this.input_city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_city.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_city.Location = new System.Drawing.Point(497, 146);
            this.input_city.Name = "input_city";
            this.input_city.Size = new System.Drawing.Size(194, 26);
            this.input_city.TabIndex = 19;
            // 
            // input_tel
            // 
            this.input_tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_tel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_tel.Location = new System.Drawing.Point(497, 82);
            this.input_tel.Name = "input_tel";
            this.input_tel.Size = new System.Drawing.Size(309, 26);
            this.input_tel.TabIndex = 17;
            // 
            // rb_solo
            // 
            this.rb_solo.BackgroundImage = global::Sprm.io.Properties.Resources.solo;
            this.rb_solo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rb_solo.FlatAppearance.BorderSize = 0;
            this.rb_solo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_solo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_solo.Location = new System.Drawing.Point(243, 222);
            this.rb_solo.Name = "rb_solo";
            this.rb_solo.Size = new System.Drawing.Size(104, 46);
            this.rb_solo.TabIndex = 11;
            this.rb_solo.UseVisualStyleBackColor = true;
            // 
            // rb_master
            // 
            this.rb_master.BackgroundImage = global::Sprm.io.Properties.Resources.mastercard;
            this.rb_master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rb_master.FlatAppearance.BorderSize = 0;
            this.rb_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_master.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_master.Location = new System.Drawing.Point(78, 222);
            this.rb_master.Name = "rb_master";
            this.rb_master.Size = new System.Drawing.Size(104, 46);
            this.rb_master.TabIndex = 10;
            this.rb_master.UseVisualStyleBackColor = true;
            // 
            // rb_amex
            // 
            this.rb_amex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_amex.BackgroundImage")));
            this.rb_amex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rb_amex.FlatAppearance.BorderSize = 0;
            this.rb_amex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_amex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_amex.Location = new System.Drawing.Point(243, 170);
            this.rb_amex.Name = "rb_amex";
            this.rb_amex.Size = new System.Drawing.Size(104, 46);
            this.rb_amex.TabIndex = 9;
            this.rb_amex.UseVisualStyleBackColor = true;
            // 
            // rb_visa
            // 
            this.rb_visa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_visa.BackgroundImage")));
            this.rb_visa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rb_visa.Checked = true;
            this.rb_visa.FlatAppearance.BorderSize = 0;
            this.rb_visa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_visa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_visa.Location = new System.Drawing.Point(78, 170);
            this.rb_visa.Name = "rb_visa";
            this.rb_visa.Size = new System.Drawing.Size(104, 46);
            this.rb_visa.TabIndex = 2;
            this.rb_visa.TabStop = true;
            this.rb_visa.UseVisualStyleBackColor = true;
            // 
            // input_profile
            // 
            this.input_profile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_profile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_profile.Location = new System.Drawing.Point(78, 50);
            this.input_profile.Margin = new System.Windows.Forms.Padding(3, 50, 50, 3);
            this.input_profile.Name = "input_profile";
            this.input_profile.Size = new System.Drawing.Size(266, 26);
            this.input_profile.TabIndex = 1;
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.White;
            this.navigation.Controls.Add(this.dataGridView2);
            this.navigation.Controls.Add(this.panel1);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(222, 499);
            this.navigation.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.title,
            this.load});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView2.Location = new System.Drawing.Point(0, 55);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(222, 444);
            this.dataGridView2.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "payment";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 5;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.title.DefaultCellStyle = dataGridViewCellStyle2;
            this.title.HeaderText = "title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // load
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            this.load.DefaultCellStyle = dataGridViewCellStyle3;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.HeaderText = "load_profile";
            this.load.Name = "load";
            this.load.ReadOnly = true;
            this.load.Width = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 55);
            this.panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Profiles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.navigation);
            this.Name = "Billing";
            this.Size = new System.Drawing.Size(1200, 499);
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel2.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.TextBox input_profile;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.RadioButton rb_visa;
        private System.Windows.Forms.RadioButton rb_solo;
        private System.Windows.Forms.RadioButton rb_master;
        private System.Windows.Forms.RadioButton rb_amex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.TextBox input_street;
        private System.Windows.Forms.TextBox input_zip;
        private System.Windows.Forms.TextBox input_city;
        private System.Windows.Forms.TextBox input_tel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewButtonColumn load;
    }
}

namespace auto.Forms
{
    partial class FormInfoAuto
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.TextBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimaze = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximaze = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonOrder = new FontAwesome.Sharp.IconButton();
            this.labelPrice = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIzm = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.panelTitleBar);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.labelModel);
            this.panel1.Controls.Add(this.labelBrand);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimeFinish);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 896);
            this.panel1.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(136, 27);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(848, 31);
            this.labelMessage.TabIndex = 36;
            this.labelMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.panelTitleBar.Controls.Add(this.btnMinimaze);
            this.panelTitleBar.Controls.Add(this.btnMaximaze);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1100, 20);
            this.panelTitleBar.TabIndex = 35;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.btnMinimaze.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimaze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimaze.IconColor = System.Drawing.SystemColors.Control;
            this.btnMinimaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimaze.IconSize = 21;
            this.btnMinimaze.Location = new System.Drawing.Point(1020, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(22, 21);
            this.btnMinimaze.TabIndex = 4;
            this.btnMinimaze.TabStop = false;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnMaximaze
            // 
            this.btnMaximaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.btnMaximaze.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximaze.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximaze.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximaze.IconSize = 21;
            this.btnMaximaze.Location = new System.Drawing.Point(1048, 0);
            this.btnMaximaze.Name = "btnMaximaze";
            this.btnMaximaze.Size = new System.Drawing.Size(22, 21);
            this.btnMaximaze.TabIndex = 3;
            this.btnMaximaze.TabStop = false;
            this.btnMaximaze.Click += new System.EventHandler(this.btnMaximaze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.SystemColors.Control;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 21;
            this.btnExit.Location = new System.Drawing.Point(1076, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 21);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconButtonOrder
            // 
            this.iconButtonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.iconButtonOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonOrder.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.iconButtonOrder.FlatAppearance.BorderSize = 3;
            this.iconButtonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOrder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOrder.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonOrder.ForeColor = System.Drawing.Color.Violet;
            this.iconButtonOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOrder.IconColor = System.Drawing.Color.Black;
            this.iconButtonOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOrder.IconSize = 48;
            this.iconButtonOrder.Location = new System.Drawing.Point(255, 0);
            this.iconButtonOrder.Name = "iconButtonOrder";
            this.iconButtonOrder.Rotation = 0D;
            this.iconButtonOrder.Size = new System.Drawing.Size(255, 60);
            this.iconButtonOrder.TabIndex = 34;
            this.iconButtonOrder.Text = "Забронировать";
            this.iconButtonOrder.UseVisualStyleBackColor = false;
            this.iconButtonOrder.Click += new System.EventHandler(this.iconButtonOrder_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(320, 751);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(239, 36);
            this.labelPrice.TabIndex = 33;
            // 
            // labelYear
            // 
            this.labelYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.labelYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelYear.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(320, 705);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(239, 36);
            this.labelYear.TabIndex = 32;
            // 
            // labelModel
            // 
            this.labelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.labelModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelModel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.ForeColor = System.Drawing.Color.White;
            this.labelModel.Location = new System.Drawing.Point(320, 646);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(239, 36);
            this.labelModel.TabIndex = 31;
            // 
            // labelBrand
            // 
            this.labelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.labelBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(320, 589);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.ReadOnly = true;
            this.labelBrand.Size = new System.Drawing.Size(239, 36);
            this.labelBrand.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(654, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "День окончания аренды";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(654, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "День начала аренды";
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeFinish.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeFinish.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeFinish.Location = new System.Drawing.Point(660, 755);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(266, 38);
            this.dateTimeFinish.TabIndex = 27;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeStart.Location = new System.Drawing.Point(660, 650);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(266, 38);
            this.dateTimeStart.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(190, 755);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(190, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(190, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(190, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Бренд";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(136, 408);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(848, 141);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.pictureBox1.Location = new System.Drawing.Point(320, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnIzm
            // 
            this.btnIzm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.btnIzm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIzm.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnIzm.FlatAppearance.BorderSize = 3;
            this.btnIzm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIzm.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzm.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnIzm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIzm.IconColor = System.Drawing.Color.Black;
            this.btnIzm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIzm.IconSize = 48;
            this.btnIzm.Location = new System.Drawing.Point(0, 0);
            this.btnIzm.Name = "btnIzm";
            this.btnIzm.Rotation = 0D;
            this.btnIzm.Size = new System.Drawing.Size(255, 60);
            this.btnIzm.TabIndex = 37;
            this.btnIzm.Text = "Изменить";
            this.btnIzm.UseVisualStyleBackColor = false;
            this.btnIzm.Click += new System.EventHandler(this.btnIzm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButtonOrder);
            this.panel2.Controls.Add(this.btnIzm);
            this.panel2.Location = new System.Drawing.Point(320, 818);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 60);
            this.panel2.TabIndex = 38;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 48;
            this.iconButton1.Location = new System.Drawing.Point(59, 342);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(255, 60);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.Text = "Добавить";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.iconButton2.FlatAppearance.BorderSize = 3;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton2.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 48;
            this.iconButton2.Location = new System.Drawing.Point(798, 342);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(255, 60);
            this.iconButton2.TabIndex = 39;
            this.iconButton2.Text = "Удалить";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // FormInfoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1104, 896);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfoAuto";
            this.Text = "FormInfoAuto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox btnMinimaze;
        private FontAwesome.Sharp.IconPictureBox btnMaximaze;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconButton iconButtonOrder;
        private System.Windows.Forms.TextBox labelPrice;
        private System.Windows.Forms.TextBox labelYear;
        private System.Windows.Forms.TextBox labelModel;
        private System.Windows.Forms.TextBox labelBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox labelMessage;
        private FontAwesome.Sharp.IconButton btnIzm;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
namespace WinMain
{
    partial class MainNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.lblCurrentTime = new System.Windows.Forms.TextBox();
            this.txtRQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTicketCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDaYin = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtPreDay = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblTicketTotalPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblReturnMoney = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPayMoney = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYHCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zhaoling = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ccInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtBc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTicketNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLine);
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.txtRQ);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(683, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 15;
            this.label27.Text = "班次";
            // 
            // txtBc
            // 
            this.txtBc.Location = new System.Drawing.Point(718, 33);
            this.txtBc.Name = "txtBc";
            this.txtBc.Size = new System.Drawing.Size(100, 21);
            this.txtBc.TabIndex = 14;
            this.txtBc.Text = "线路";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "票号";
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Location = new System.Drawing.Point(565, 32);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(100, 21);
            this.txtTicketNo.TabIndex = 12;
            this.txtTicketNo.Text = "线路";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "线路";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "日期";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(400, 32);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(100, 21);
            this.txtLine.TabIndex = 7;
            this.txtLine.Text = "线路";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Location = new System.Drawing.Point(227, 31);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(100, 21);
            this.lblCurrentTime.TabIndex = 3;
            // 
            // txtRQ
            // 
            this.txtRQ.Location = new System.Drawing.Point(62, 31);
            this.txtRQ.Name = "txtRQ";
            this.txtRQ.Size = new System.Drawing.Size(100, 21);
            this.txtRQ.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "出发站";
            // 
            // txtStartStation
            // 
            this.txtStartStation.Location = new System.Drawing.Point(333, 27);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(100, 21);
            this.txtStartStation.TabIndex = 5;
            this.txtStartStation.Text = "火车站";
            this.txtStartStation.TextChanged += new System.EventHandler(this.Cal);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMain);
            this.groupBox2.Location = new System.Drawing.Point(0, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1094, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowDrop = true;
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.Black;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowEditingIcon = false;
            this.dgvMain.Size = new System.Drawing.Size(1094, 205);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.TabStop = false;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ccInfo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.zhaoling);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblTicketTotalPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblTicketCount);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1094, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.Depth = 0;
            this.lblTicketCount.Hint = "";
            this.lblTicketCount.Location = new System.Drawing.Point(601, 68);
            this.lblTicketCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.PasswordChar = '\0';
            this.lblTicketCount.SelectedText = "";
            this.lblTicketCount.SelectionLength = 0;
            this.lblTicketCount.SelectionStart = 0;
            this.lblTicketCount.Size = new System.Drawing.Size(421, 23);
            this.lblTicketCount.TabIndex = 1;
            this.lblTicketCount.Text = "0";
            this.lblTicketCount.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.materialFlatButton2);
            this.groupBox4.Controls.Add(this.btnDaYin);
            this.groupBox4.Controls.Add(this.txtPreDay);
            this.groupBox4.Controls.Add(this.materialFlatButton1);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.lblReturnMoney);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtPayMoney);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtYHCount);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtFullCount);
            this.groupBox4.Controls.Add(this.txtEndStation);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtStartStation);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 218);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "购票信息";
            // 
            // btnDaYin
            // 
            this.btnDaYin.AutoSize = true;
            this.btnDaYin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDaYin.BackColor = System.Drawing.Color.Red;
            this.btnDaYin.BackgroundImage = global::WinMain.Properties.Resources.登录bg;
            this.btnDaYin.Depth = 0;
            this.btnDaYin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDaYin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDaYin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDaYin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDaYin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDaYin.Location = new System.Drawing.Point(15, 176);
            this.btnDaYin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDaYin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Primary = false;
            this.btnDaYin.Size = new System.Drawing.Size(81, 36);
            this.btnDaYin.TabIndex = 30;
            this.btnDaYin.Text = "打印（Y）";
            this.btnDaYin.UseVisualStyleBackColor = false;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // txtPreDay
            // 
            this.txtPreDay.Location = new System.Drawing.Point(59, 51);
            this.txtPreDay.Name = "txtPreDay";
            this.txtPreDay.Size = new System.Drawing.Size(100, 21);
            this.txtPreDay.TabIndex = 28;
            this.txtPreDay.Text = "0";
            this.txtPreDay.TextChanged += new System.EventHandler(this.Cal);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 29;
            this.label28.Text = "预售日";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1031, 142);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 27;
            this.label25.Text = "（元）";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(533, 142);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 26;
            this.label26.Text = "应    收：";
            // 
            // lblTicketTotalPrice
            // 
            this.lblTicketTotalPrice.Depth = 0;
            this.lblTicketTotalPrice.Enabled = false;
            this.lblTicketTotalPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTicketTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTicketTotalPrice.Hint = "";
            this.lblTicketTotalPrice.Location = new System.Drawing.Point(601, 135);
            this.lblTicketTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketTotalPrice.Name = "lblTicketTotalPrice";
            this.lblTicketTotalPrice.PasswordChar = '\0';
            this.lblTicketTotalPrice.SelectedText = "";
            this.lblTicketTotalPrice.SelectionLength = 0;
            this.lblTicketTotalPrice.SelectionStart = 0;
            this.lblTicketTotalPrice.Size = new System.Drawing.Size(427, 23);
            this.lblTicketTotalPrice.TabIndex = 25;
            this.lblTicketTotalPrice.Text = "0";
            this.lblTicketTotalPrice.UseSystemPasswordChar = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(407, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 24;
            this.label23.Text = "（元）";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(287, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 23;
            this.label24.Text = "找  零";
            // 
            // lblReturnMoney
            // 
            this.lblReturnMoney.Depth = 0;
            this.lblReturnMoney.Enabled = false;
            this.lblReturnMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReturnMoney.ForeColor = System.Drawing.Color.Red;
            this.lblReturnMoney.Hint = "";
            this.lblReturnMoney.Location = new System.Drawing.Point(333, 118);
            this.lblReturnMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReturnMoney.Name = "lblReturnMoney";
            this.lblReturnMoney.PasswordChar = '\0';
            this.lblReturnMoney.SelectedText = "";
            this.lblReturnMoney.SelectionLength = 0;
            this.lblReturnMoney.SelectionStart = 0;
            this.lblReturnMoney.Size = new System.Drawing.Size(63, 23);
            this.lblReturnMoney.TabIndex = 22;
            this.lblReturnMoney.Text = "0.0";
            this.lblReturnMoney.UseSystemPasswordChar = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 21;
            this.label19.Text = "（元）";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 20;
            this.label22.Text = "收  款";
            // 
            // txtPayMoney
            // 
            this.txtPayMoney.Depth = 0;
            this.txtPayMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPayMoney.ForeColor = System.Drawing.Color.Red;
            this.txtPayMoney.Hint = "";
            this.txtPayMoney.Location = new System.Drawing.Point(59, 114);
            this.txtPayMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPayMoney.Name = "txtPayMoney";
            this.txtPayMoney.PasswordChar = '\0';
            this.txtPayMoney.SelectedText = "";
            this.txtPayMoney.SelectionLength = 0;
            this.txtPayMoney.SelectionStart = 0;
            this.txtPayMoney.Size = new System.Drawing.Size(63, 23);
            this.txtPayMoney.TabIndex = 19;
            this.txtPayMoney.Text = "0.0";
            this.txtPayMoney.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "（张）";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "优  惠";
            // 
            // txtYHCount
            // 
            this.txtYHCount.Depth = 0;
            this.txtYHCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYHCount.ForeColor = System.Drawing.Color.Red;
            this.txtYHCount.Hint = "";
            this.txtYHCount.Location = new System.Drawing.Point(333, 78);
            this.txtYHCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtYHCount.Name = "txtYHCount";
            this.txtYHCount.PasswordChar = '\0';
            this.txtYHCount.SelectedText = "";
            this.txtYHCount.SelectionLength = 0;
            this.txtYHCount.SelectionStart = 0;
            this.txtYHCount.Size = new System.Drawing.Size(63, 23);
            this.txtYHCount.TabIndex = 16;
            this.txtYHCount.Text = "0";
            this.txtYHCount.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "（张）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "全  票";
            // 
            // txtFullCount
            // 
            this.txtFullCount.Depth = 0;
            this.txtFullCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullCount.ForeColor = System.Drawing.Color.Red;
            this.txtFullCount.Hint = "";
            this.txtFullCount.Location = new System.Drawing.Point(59, 78);
            this.txtFullCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullCount.Name = "txtFullCount";
            this.txtFullCount.PasswordChar = '\0';
            this.txtFullCount.SelectedText = "";
            this.txtFullCount.SelectionLength = 0;
            this.txtFullCount.SelectionStart = 0;
            this.txtFullCount.Size = new System.Drawing.Size(63, 23);
            this.txtFullCount.TabIndex = 13;
            this.txtFullCount.Text = "0";
            this.txtFullCount.UseSystemPasswordChar = false;
            // 
            // txtEndStation
            // 
            this.txtEndStation.Location = new System.Drawing.Point(59, 24);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(100, 21);
            this.txtEndStation.TabIndex = 11;
            this.txtEndStation.Text = "新桥机场";
            this.txtEndStation.TextChanged += new System.EventHandler(this.Cal);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "到达站";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "票    数：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "乘车信息：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 17;
            this.label13.Text = "找    零：";
            // 
            // zhaoling
            // 
            this.zhaoling.Depth = 0;
            this.zhaoling.Hint = "";
            this.zhaoling.Location = new System.Drawing.Point(601, 106);
            this.zhaoling.MouseState = MaterialSkin.MouseState.HOVER;
            this.zhaoling.Name = "zhaoling";
            this.zhaoling.PasswordChar = '\0';
            this.zhaoling.SelectedText = "";
            this.zhaoling.SelectionLength = 0;
            this.zhaoling.SelectionStart = 0;
            this.zhaoling.Size = new System.Drawing.Size(427, 23);
            this.zhaoling.TabIndex = 18;
            this.zhaoling.Text = "0";
            this.zhaoling.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1031, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "（张）";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1031, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "（元）";
            // 
            // ccInfo
            // 
            this.ccInfo.Depth = 0;
            this.ccInfo.Hint = "";
            this.ccInfo.Location = new System.Drawing.Point(601, 36);
            this.ccInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ccInfo.Name = "ccInfo";
            this.ccInfo.PasswordChar = '\0';
            this.ccInfo.SelectedText = "";
            this.ccInfo.SelectionLength = 0;
            this.ccInfo.SelectionStart = 0;
            this.ccInfo.Size = new System.Drawing.Size(421, 23);
            this.ccInfo.TabIndex = 21;
            this.ccInfo.Text = "0";
            this.ccInfo.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Red;
            this.materialFlatButton1.BackgroundImage = global::WinMain.Properties.Resources.登录bg;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.materialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.materialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialFlatButton1.Location = new System.Drawing.Point(146, 176);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 31;
            this.materialFlatButton1.Text = "退票（F7）";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.Red;
            this.materialFlatButton2.BackgroundImage = global::WinMain.Properties.Resources.登录bg;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.materialFlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.materialFlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.materialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialFlatButton2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialFlatButton2.Location = new System.Drawing.Point(303, 176);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton2.TabIndex = 32;
            this.materialFlatButton2.Text = "售票查询（F6）";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 1);
            this.panel1.TabIndex = 33;
            // 
            // MainNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 618);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainNew";
            this.Text = "机场巴士购票系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRQ;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.TextBox lblCurrentTime;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTicketNo;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFullCount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblReturnMoney;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPayMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtYHCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBc;
        private System.Windows.Forms.Label label28;
        private MaterialSkin.Controls.MaterialFlatButton btnDaYin;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblTicketCount;
        private System.Windows.Forms.TextBox txtPreDay;
        protected MaterialSkin.Controls.MaterialSingleLineTextField lblTicketTotalPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField ccInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialSingleLineTextField zhaoling;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Panel panel1;

    }
}
namespace PcrommV2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rightSideP = new System.Windows.Forms.Panel();
            this.cashP = new System.Windows.Forms.Panel();
            this.cashTextbox = new System.Windows.Forms.TextBox();
            this.cashDirect = new System.Windows.Forms.RadioButton();
            this.cashAll = new System.Windows.Forms.RadioButton();
            this.cash1000 = new System.Windows.Forms.RadioButton();
            this.cash5000 = new System.Windows.Forms.RadioButton();
            this.cash10000 = new System.Windows.Forms.RadioButton();
            this.cash50000 = new System.Windows.Forms.RadioButton();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.payB = new System.Windows.Forms.Button();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cartPay = new System.Windows.Forms.Panel();
            this.cartPriceL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cartP = new System.Windows.Forms.Panel();
            this.orderBy = new System.Windows.Forms.FlowLayoutPanel();
            this.leftSideP = new System.Windows.Forms.Panel();
            this.menuCafeB = new System.Windows.Forms.Button();
            this.menuDrinkB = new System.Windows.Forms.Button();
            this.menuNodleB = new System.Windows.Forms.Button();
            this.menuFoodB = new System.Windows.Forms.Button();
            this.menuDessertB = new System.Windows.Forms.Button();
            this.menuAllB = new System.Windows.Forms.Button();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemListFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemListCafe = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListNoodle = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListFood = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListDessert = new System.Windows.Forms.FlowLayoutPanel();
            this.rightSideP.SuspendLayout();
            this.cashP.SuspendLayout();
            this.cartPay.SuspendLayout();
            this.cartP.SuspendLayout();
            this.leftSideP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightSideP
            // 
            this.rightSideP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rightSideP.Controls.Add(this.cashP);
            this.rightSideP.Controls.Add(this.requestTextBox);
            this.rightSideP.Controls.Add(this.payB);
            this.rightSideP.Controls.Add(this.cardRadioButton);
            this.rightSideP.Controls.Add(this.cashRadioButton);
            this.rightSideP.Controls.Add(this.label7);
            this.rightSideP.Controls.Add(this.cartPay);
            this.rightSideP.Controls.Add(this.cartP);
            this.rightSideP.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSideP.Location = new System.Drawing.Point(1166, 0);
            this.rightSideP.Name = "rightSideP";
            this.rightSideP.Size = new System.Drawing.Size(274, 870);
            this.rightSideP.TabIndex = 3;
            // 
            // cashP
            // 
            this.cashP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.cashP.Controls.Add(this.cashTextbox);
            this.cashP.Controls.Add(this.cashDirect);
            this.cashP.Controls.Add(this.cashAll);
            this.cashP.Controls.Add(this.cash1000);
            this.cashP.Controls.Add(this.cash5000);
            this.cashP.Controls.Add(this.cash10000);
            this.cashP.Controls.Add(this.cash50000);
            this.cashP.Location = new System.Drawing.Point(0, 644);
            this.cashP.Name = "cashP";
            this.cashP.Size = new System.Drawing.Size(300, 70);
            this.cashP.TabIndex = 20;
            // 
            // cashTextbox
            // 
            this.cashTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cashTextbox.Location = new System.Drawing.Point(186, 36);
            this.cashTextbox.Name = "cashTextbox";
            this.cashTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cashTextbox.Size = new System.Drawing.Size(80, 21);
            this.cashTextbox.TabIndex = 6;
            // 
            // cashDirect
            // 
            this.cashDirect.AutoSize = true;
            this.cashDirect.Location = new System.Drawing.Point(109, 40);
            this.cashDirect.Name = "cashDirect";
            this.cashDirect.Size = new System.Drawing.Size(71, 16);
            this.cashDirect.TabIndex = 5;
            this.cashDirect.TabStop = true;
            this.cashDirect.Text = "직접입력";
            this.cashDirect.UseVisualStyleBackColor = true;
            this.cashDirect.CheckedChanged += new System.EventHandler(this.cashDirect_CheckedChanged);
            // 
            // cashAll
            // 
            this.cashAll.AutoSize = true;
            this.cashAll.Location = new System.Drawing.Point(10, 40);
            this.cashAll.Name = "cashAll";
            this.cashAll.Size = new System.Drawing.Size(87, 16);
            this.cashAll.TabIndex = 4;
            this.cashAll.TabStop = true;
            this.cashAll.Text = "금액에 맞게";
            this.cashAll.UseVisualStyleBackColor = true;
            this.cashAll.CheckedChanged += new System.EventHandler(this.cashAll_CheckedChanged);
            // 
            // cash1000
            // 
            this.cash1000.AutoSize = true;
            this.cash1000.Location = new System.Drawing.Point(204, 14);
            this.cash1000.Name = "cash1000";
            this.cash1000.Size = new System.Drawing.Size(65, 16);
            this.cash1000.TabIndex = 3;
            this.cash1000.TabStop = true;
            this.cash1000.Text = "1천원권";
            this.cash1000.UseVisualStyleBackColor = true;
            this.cash1000.CheckedChanged += new System.EventHandler(this.cash1000_CheckedChanged);
            // 
            // cash5000
            // 
            this.cash5000.AutoSize = true;
            this.cash5000.Location = new System.Drawing.Point(141, 14);
            this.cash5000.Name = "cash5000";
            this.cash5000.Size = new System.Drawing.Size(65, 16);
            this.cash5000.TabIndex = 2;
            this.cash5000.TabStop = true;
            this.cash5000.Text = "5천원권";
            this.cash5000.UseVisualStyleBackColor = true;
            this.cash5000.CheckedChanged += new System.EventHandler(this.cash5000_CheckedChanged);
            // 
            // cash10000
            // 
            this.cash10000.AutoSize = true;
            this.cash10000.Location = new System.Drawing.Point(76, 14);
            this.cash10000.Name = "cash10000";
            this.cash10000.Size = new System.Drawing.Size(65, 16);
            this.cash10000.TabIndex = 1;
            this.cash10000.TabStop = true;
            this.cash10000.Text = "1만원권";
            this.cash10000.UseVisualStyleBackColor = true;
            this.cash10000.CheckedChanged += new System.EventHandler(this.cash10000_CheckedChanged);
            // 
            // cash50000
            // 
            this.cash50000.AutoSize = true;
            this.cash50000.Location = new System.Drawing.Point(10, 14);
            this.cash50000.Name = "cash50000";
            this.cash50000.Size = new System.Drawing.Size(65, 16);
            this.cash50000.TabIndex = 0;
            this.cash50000.TabStop = true;
            this.cash50000.Text = "5만원권";
            this.cash50000.UseVisualStyleBackColor = true;
            this.cash50000.CheckedChanged += new System.EventHandler(this.cash50000_CheckedChanged);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.requestTextBox.ForeColor = System.Drawing.Color.Gray;
            this.requestTextBox.Location = new System.Drawing.Point(0, 714);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(274, 78);
            this.requestTextBox.TabIndex = 19;
            this.requestTextBox.Text = "요청사항을 입력해주세요";
            this.requestTextBox.Click += new System.EventHandler(this.requestTextBox_Click);
            // 
            // payB
            // 
            this.payB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.payB.FlatAppearance.BorderSize = 0;
            this.payB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payB.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.payB.Location = new System.Drawing.Point(0, 788);
            this.payB.Name = "payB";
            this.payB.Size = new System.Drawing.Size(274, 82);
            this.payB.TabIndex = 18;
            this.payB.Text = "결제";
            this.payB.UseVisualStyleBackColor = false;
            this.payB.Click += new System.EventHandler(this.payB_Click);
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardRadioButton.ForeColor = System.Drawing.Color.White;
            this.cardRadioButton.Location = new System.Drawing.Point(168, 603);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(92, 25);
            this.cardRadioButton.TabIndex = 17;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "신용카드";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.cardRadioButton_CheckedChanged);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cashRadioButton.ForeColor = System.Drawing.Color.White;
            this.cashRadioButton.Location = new System.Drawing.Point(105, 603);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(60, 25);
            this.cashRadioButton.TabIndex = 16;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "현금";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "결제정보";
            // 
            // cartPay
            // 
            this.cartPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.cartPay.Controls.Add(this.cartPriceL);
            this.cartPay.Controls.Add(this.label8);
            this.cartPay.Controls.Add(this.label5);
            this.cartPay.Location = new System.Drawing.Point(0, 534);
            this.cartPay.Name = "cartPay";
            this.cartPay.Size = new System.Drawing.Size(300, 53);
            this.cartPay.TabIndex = 14;
            // 
            // cartPriceL
            // 
            this.cartPriceL.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cartPriceL.Location = new System.Drawing.Point(126, 14);
            this.cartPriceL.Name = "cartPriceL";
            this.cartPriceL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cartPriceL.Size = new System.Drawing.Size(115, 21);
            this.cartPriceL.TabIndex = 5;
            this.cartPriceL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(240, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "총 주문금액";
            // 
            // cartP
            // 
            this.cartP.BackColor = System.Drawing.Color.Black;
            this.cartP.Controls.Add(this.orderBy);
            this.cartP.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartP.Location = new System.Drawing.Point(0, 0);
            this.cartP.Name = "cartP";
            this.cartP.Size = new System.Drawing.Size(274, 535);
            this.cartP.TabIndex = 0;
            // 
            // orderBy
            // 
            this.orderBy.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.orderBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderBy.BackgroundImage")));
            this.orderBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderBy.Location = new System.Drawing.Point(0, 0);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(274, 535);
            this.orderBy.TabIndex = 0;
            // 
            // leftSideP
            // 
            this.leftSideP.BackColor = System.Drawing.Color.Transparent;
            this.leftSideP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftSideP.Controls.Add(this.menuCafeB);
            this.leftSideP.Controls.Add(this.menuDrinkB);
            this.leftSideP.Controls.Add(this.menuNodleB);
            this.leftSideP.Controls.Add(this.menuFoodB);
            this.leftSideP.Controls.Add(this.menuDessertB);
            this.leftSideP.Controls.Add(this.menuAllB);
            this.leftSideP.Controls.Add(this.logoPB);
            this.leftSideP.Controls.Add(this.panel1);
            this.leftSideP.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSideP.Location = new System.Drawing.Point(0, 0);
            this.leftSideP.Name = "leftSideP";
            this.leftSideP.Size = new System.Drawing.Size(300, 870);
            this.leftSideP.TabIndex = 2;
            // 
            // menuCafeB
            // 
            this.menuCafeB.BackColor = System.Drawing.Color.Transparent;
            this.menuCafeB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0005_cafe01;
            this.menuCafeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuCafeB.FlatAppearance.BorderSize = 0;
            this.menuCafeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuCafeB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold);
            this.menuCafeB.Location = new System.Drawing.Point(0, 739);
            this.menuCafeB.Margin = new System.Windows.Forms.Padding(0);
            this.menuCafeB.Name = "menuCafeB";
            this.menuCafeB.Size = new System.Drawing.Size(300, 131);
            this.menuCafeB.TabIndex = 6;
            this.menuCafeB.Text = "카페";
            this.menuCafeB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuCafeB.UseVisualStyleBackColor = false;
            this.menuCafeB.Click += new System.EventHandler(this.menuCafeB_Click);
            this.menuCafeB.MouseLeave += new System.EventHandler(this.menuCafeB_MouseLeave);
            this.menuCafeB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuCafeB_MouseMove);
            // 
            // menuDrinkB
            // 
            this.menuDrinkB.BackColor = System.Drawing.Color.Transparent;
            this.menuDrinkB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0003_drink011;
            this.menuDrinkB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuDrinkB.FlatAppearance.BorderSize = 0;
            this.menuDrinkB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuDrinkB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold);
            this.menuDrinkB.Location = new System.Drawing.Point(0, 608);
            this.menuDrinkB.Margin = new System.Windows.Forms.Padding(0);
            this.menuDrinkB.Name = "menuDrinkB";
            this.menuDrinkB.Size = new System.Drawing.Size(300, 131);
            this.menuDrinkB.TabIndex = 5;
            this.menuDrinkB.Text = "음료류";
            this.menuDrinkB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuDrinkB.UseVisualStyleBackColor = false;
            this.menuDrinkB.Click += new System.EventHandler(this.menuDrinkB_Click);
            this.menuDrinkB.MouseLeave += new System.EventHandler(this.menuDrinkB_MouseLeave);
            this.menuDrinkB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuDrinkB_MouseMove);
            // 
            // menuNodleB
            // 
            this.menuNodleB.BackColor = System.Drawing.Color.Transparent;
            this.menuNodleB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0000_noodle01;
            this.menuNodleB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuNodleB.FlatAppearance.BorderSize = 0;
            this.menuNodleB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuNodleB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold);
            this.menuNodleB.Location = new System.Drawing.Point(0, 477);
            this.menuNodleB.Margin = new System.Windows.Forms.Padding(0);
            this.menuNodleB.Name = "menuNodleB";
            this.menuNodleB.Size = new System.Drawing.Size(300, 131);
            this.menuNodleB.TabIndex = 4;
            this.menuNodleB.Text = "면류";
            this.menuNodleB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuNodleB.UseVisualStyleBackColor = false;
            this.menuNodleB.Click += new System.EventHandler(this.menuNodleB_Click);
            this.menuNodleB.MouseLeave += new System.EventHandler(this.menuNodleB_MouseLeave);
            this.menuNodleB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuNodleB_MouseMove);
            // 
            // menuFoodB
            // 
            this.menuFoodB.BackColor = System.Drawing.Color.Transparent;
            this.menuFoodB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0001_food01;
            this.menuFoodB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuFoodB.FlatAppearance.BorderSize = 0;
            this.menuFoodB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuFoodB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold);
            this.menuFoodB.Location = new System.Drawing.Point(0, 346);
            this.menuFoodB.Margin = new System.Windows.Forms.Padding(0);
            this.menuFoodB.Name = "menuFoodB";
            this.menuFoodB.Size = new System.Drawing.Size(300, 131);
            this.menuFoodB.TabIndex = 3;
            this.menuFoodB.Text = "밥류";
            this.menuFoodB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuFoodB.UseVisualStyleBackColor = false;
            this.menuFoodB.Click += new System.EventHandler(this.menuFoodB_Click);
            this.menuFoodB.MouseLeave += new System.EventHandler(this.menuFoodB_MouseLeave);
            this.menuFoodB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuFoodB_MouseMove);
            // 
            // menuDessertB
            // 
            this.menuDessertB.BackColor = System.Drawing.Color.Transparent;
            this.menuDessertB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0004_dessert01;
            this.menuDessertB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuDessertB.FlatAppearance.BorderSize = 0;
            this.menuDessertB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuDessertB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold);
            this.menuDessertB.Location = new System.Drawing.Point(0, 215);
            this.menuDessertB.Margin = new System.Windows.Forms.Padding(0);
            this.menuDessertB.Name = "menuDessertB";
            this.menuDessertB.Size = new System.Drawing.Size(300, 131);
            this.menuDessertB.TabIndex = 2;
            this.menuDessertB.Text = "디저트";
            this.menuDessertB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuDessertB.UseVisualStyleBackColor = false;
            this.menuDessertB.Click += new System.EventHandler(this.menuDessertB_Click);
            this.menuDessertB.MouseLeave += new System.EventHandler(this.menuDessertB_MouseLeave);
            this.menuDessertB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuDessertB_MouseMove);
            // 
            // menuAllB
            // 
            this.menuAllB.BackColor = System.Drawing.Color.Transparent;
            this.menuAllB.BackgroundImage = global::PcrommV2.Properties.Resources.btn_0002_Allfood01;
            this.menuAllB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuAllB.FlatAppearance.BorderSize = 0;
            this.menuAllB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuAllB.Font = new System.Drawing.Font("HY헤드라인M", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuAllB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuAllB.Location = new System.Drawing.Point(0, 84);
            this.menuAllB.Margin = new System.Windows.Forms.Padding(0);
            this.menuAllB.Name = "menuAllB";
            this.menuAllB.Size = new System.Drawing.Size(300, 131);
            this.menuAllB.TabIndex = 1;
            this.menuAllB.Text = "전체보기";
            this.menuAllB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuAllB.UseVisualStyleBackColor = false;
            this.menuAllB.Click += new System.EventHandler(this.menuAllB_Click);
            this.menuAllB.MouseLeave += new System.EventHandler(this.menuAllB_MouseLeave);
            this.menuAllB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuAllB_MouseMove);
            // 
            // logoPB
            // 
            this.logoPB.BackgroundImage = global::PcrommV2.Properties.Resources.logo_22;
            this.logoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPB.Location = new System.Drawing.Point(108, 1);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(192, 84);
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            this.logoPB.DoubleClick += new System.EventHandler(this.logoPB_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(265, 842);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 28);
            this.panel1.TabIndex = 23;
            // 
            // itemListFlow
            // 
            this.itemListFlow.AutoScroll = true;
            this.itemListFlow.BackColor = System.Drawing.Color.Black;
            this.itemListFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListFlow.Location = new System.Drawing.Point(0, 0);
            this.itemListFlow.Name = "itemListFlow";
            this.itemListFlow.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListFlow.Size = new System.Drawing.Size(866, 870);
            this.itemListFlow.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.itemListFlow);
            this.panel2.Controls.Add(this.itemListCafe);
            this.panel2.Controls.Add(this.itemListDrink);
            this.panel2.Controls.Add(this.itemListNoodle);
            this.panel2.Controls.Add(this.itemListFood);
            this.panel2.Controls.Add(this.itemListDessert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 870);
            this.panel2.TabIndex = 0;
            // 
            // itemListCafe
            // 
            this.itemListCafe.AutoScroll = true;
            this.itemListCafe.BackColor = System.Drawing.Color.Black;
            this.itemListCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListCafe.Location = new System.Drawing.Point(0, 0);
            this.itemListCafe.Name = "itemListCafe";
            this.itemListCafe.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListCafe.Size = new System.Drawing.Size(866, 870);
            this.itemListCafe.TabIndex = 27;
            // 
            // itemListDrink
            // 
            this.itemListDrink.AutoScroll = true;
            this.itemListDrink.BackColor = System.Drawing.Color.Black;
            this.itemListDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListDrink.Location = new System.Drawing.Point(0, 0);
            this.itemListDrink.Name = "itemListDrink";
            this.itemListDrink.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListDrink.Size = new System.Drawing.Size(866, 870);
            this.itemListDrink.TabIndex = 26;
            // 
            // itemListNoodle
            // 
            this.itemListNoodle.AutoScroll = true;
            this.itemListNoodle.BackColor = System.Drawing.Color.Black;
            this.itemListNoodle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListNoodle.Location = new System.Drawing.Point(0, 0);
            this.itemListNoodle.Name = "itemListNoodle";
            this.itemListNoodle.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListNoodle.Size = new System.Drawing.Size(866, 870);
            this.itemListNoodle.TabIndex = 25;
            // 
            // itemListFood
            // 
            this.itemListFood.AutoScroll = true;
            this.itemListFood.BackColor = System.Drawing.Color.Black;
            this.itemListFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListFood.Location = new System.Drawing.Point(0, 0);
            this.itemListFood.Name = "itemListFood";
            this.itemListFood.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListFood.Size = new System.Drawing.Size(866, 870);
            this.itemListFood.TabIndex = 24;
            // 
            // itemListDessert
            // 
            this.itemListDessert.AutoScroll = true;
            this.itemListDessert.BackColor = System.Drawing.Color.Black;
            this.itemListDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListDessert.Location = new System.Drawing.Point(0, 0);
            this.itemListDessert.Name = "itemListDessert";
            this.itemListDessert.Padding = new System.Windows.Forms.Padding(27, 20, 20, 20);
            this.itemListDessert.Size = new System.Drawing.Size(866, 870);
            this.itemListDessert.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 870);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.leftSideP);
            this.Controls.Add(this.rightSideP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rightSideP.ResumeLayout(false);
            this.rightSideP.PerformLayout();
            this.cashP.ResumeLayout(false);
            this.cashP.PerformLayout();
            this.cartPay.ResumeLayout(false);
            this.cartPay.PerformLayout();
            this.cartP.ResumeLayout(false);
            this.leftSideP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightSideP;
        private System.Windows.Forms.Panel cashP;
        private System.Windows.Forms.TextBox cashTextbox;
        private System.Windows.Forms.RadioButton cashDirect;
        private System.Windows.Forms.RadioButton cashAll;
        private System.Windows.Forms.RadioButton cash1000;
        private System.Windows.Forms.RadioButton cash5000;
        private System.Windows.Forms.RadioButton cash10000;
        private System.Windows.Forms.RadioButton cash50000;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Button payB;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel cartPay;
        private System.Windows.Forms.Label cartPriceL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel cartP;
        private System.Windows.Forms.Panel leftSideP;
        private System.Windows.Forms.Button menuCafeB;
        private System.Windows.Forms.Button menuDrinkB;
        private System.Windows.Forms.Button menuNodleB;
        private System.Windows.Forms.Button menuFoodB;
        private System.Windows.Forms.Button menuDessertB;
        private System.Windows.Forms.Button menuAllB;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.FlowLayoutPanel itemListFlow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel itemListCafe;
        private System.Windows.Forms.FlowLayoutPanel itemListDrink;
        private System.Windows.Forms.FlowLayoutPanel itemListNoodle;
        private System.Windows.Forms.FlowLayoutPanel itemListFood;
        private System.Windows.Forms.FlowLayoutPanel itemListDessert;
        private System.Windows.Forms.FlowLayoutPanel orderBy;
    }
}
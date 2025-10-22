namespace Bus_Insurance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ListGW = new System.Windows.Forms.DataGridView();
            this.idGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumberGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelEntryGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelExpierGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceEntryGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceExpierGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituationGW = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.updateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.statusValue = new MaterialSkin.Controls.MaterialCheckBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.timerChecker = new System.Windows.Forms.Timer(this.components);
            this.nameSearchValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.carNumberSearchValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.carNumberValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fuelEntryValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.insuranceEntryValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.explainValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.themeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.header = new MaterialSkin.Controls.MaterialLabel();
            this.versionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.showListButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ListGW)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Depth = 0;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(5, 427);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Primary = true;
            this.addButton.Size = new System.Drawing.Size(86, 36);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "افزودن فایل";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ListGW
            // 
            this.ListGW.AllowUserToAddRows = false;
            this.ListGW.AllowUserToDeleteRows = false;
            this.ListGW.AllowUserToResizeColumns = false;
            this.ListGW.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ListGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListGW.BackgroundColor = System.Drawing.Color.White;
            this.ListGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGW,
            this.FullNameGW,
            this.CarNumberGW,
            this.FuelEntryGW,
            this.FuelExpierGW,
            this.InsuranceEntryGW,
            this.InsuranceExpierGW,
            this.SituationGW});
            this.ListGW.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListGW.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.ListGW.EnableHeadersVisualStyles = false;
            this.ListGW.Location = new System.Drawing.Point(2, 129);
            this.ListGW.Name = "ListGW";
            this.ListGW.ReadOnly = true;
            this.ListGW.RowHeadersVisible = false;
            this.ListGW.ShowCellToolTips = false;
            this.ListGW.Size = new System.Drawing.Size(852, 286);
            this.ListGW.TabIndex = 20;
            this.ListGW.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListGW_CellMouseDoubleClick);
            // 
            // idGW
            // 
            this.idGW.Frozen = true;
            this.idGW.HeaderText = "شماره";
            this.idGW.Name = "idGW";
            this.idGW.ReadOnly = true;
            this.idGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idGW.Width = 60;
            // 
            // FullNameGW
            // 
            this.FullNameGW.Frozen = true;
            this.FullNameGW.HeaderText = "نام و نام خانوادگی";
            this.FullNameGW.Name = "FullNameGW";
            this.FullNameGW.ReadOnly = true;
            this.FullNameGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FullNameGW.Width = 160;
            // 
            // CarNumberGW
            // 
            this.CarNumberGW.Frozen = true;
            this.CarNumberGW.HeaderText = "شماره پلاک";
            this.CarNumberGW.Name = "CarNumberGW";
            this.CarNumberGW.ReadOnly = true;
            this.CarNumberGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CarNumberGW.Width = 120;
            // 
            // FuelEntryGW
            // 
            this.FuelEntryGW.Frozen = true;
            this.FuelEntryGW.HeaderText = "شروع سوخت";
            this.FuelEntryGW.Name = "FuelEntryGW";
            this.FuelEntryGW.ReadOnly = true;
            this.FuelEntryGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FuelEntryGW.Width = 110;
            // 
            // FuelExpierGW
            // 
            this.FuelExpierGW.Frozen = true;
            this.FuelExpierGW.HeaderText = "پایان سوخت";
            this.FuelExpierGW.Name = "FuelExpierGW";
            this.FuelExpierGW.ReadOnly = true;
            this.FuelExpierGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FuelExpierGW.Width = 110;
            // 
            // InsuranceEntryGW
            // 
            this.InsuranceEntryGW.Frozen = true;
            this.InsuranceEntryGW.HeaderText = "شروع بیمه";
            this.InsuranceEntryGW.Name = "InsuranceEntryGW";
            this.InsuranceEntryGW.ReadOnly = true;
            this.InsuranceEntryGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InsuranceEntryGW.Width = 110;
            // 
            // InsuranceExpierGW
            // 
            this.InsuranceExpierGW.Frozen = true;
            this.InsuranceExpierGW.HeaderText = "پایان بیمه";
            this.InsuranceExpierGW.Name = "InsuranceExpierGW";
            this.InsuranceExpierGW.ReadOnly = true;
            this.InsuranceExpierGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InsuranceExpierGW.Width = 110;
            // 
            // SituationGW
            // 
            this.SituationGW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SituationGW.Frozen = true;
            this.SituationGW.HeaderText = "بررسی";
            this.SituationGW.Name = "SituationGW";
            this.SituationGW.ReadOnly = true;
            this.SituationGW.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SituationGW.Width = 70;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(5, 471);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = false;
            this.cancelButton.Size = new System.Drawing.Size(74, 36);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "صرف نظر";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Depth = 0;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(87, 471);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(81, 36);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "بروز رسانی";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.BackColor = System.Drawing.Color.Transparent;
            this.statusValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusValue.Depth = 0;
            this.statusValue.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.statusValue.Location = new System.Drawing.Point(115, 429);
            this.statusValue.Margin = new System.Windows.Forms.Padding(0);
            this.statusValue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.statusValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusValue.Name = "statusValue";
            this.statusValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusValue.Ripple = true;
            this.statusValue.Size = new System.Drawing.Size(112, 30);
            this.statusValue.TabIndex = 21;
            this.statusValue.Text = "وضعیت بررسی";
            this.statusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusValue.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(176, 471);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(52, 36);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLinkLabel.Font = new System.Drawing.Font("B Nazanin", 15F);
            this.aboutLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.aboutLinkLabel.LinkColor = System.Drawing.Color.Blue;
            this.aboutLinkLabel.Location = new System.Drawing.Point(763, 28);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(91, 29);
            this.aboutLinkLabel.TabIndex = 22;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "دربارۀ سازنده";
            this.aboutLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // timerChecker
            // 
            this.timerChecker.Interval = 1000;
            this.timerChecker.Tick += new System.EventHandler(this.timerChecker_Tick);
            // 
            // nameSearchValue
            // 
            this.nameSearchValue.Depth = 0;
            this.nameSearchValue.Hint = "جستجو بر اساس نام";
            this.nameSearchValue.Location = new System.Drawing.Point(687, 84);
            this.nameSearchValue.MaxLength = 32767;
            this.nameSearchValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameSearchValue.Name = "nameSearchValue";
            this.nameSearchValue.PasswordChar = '\0';
            this.nameSearchValue.SelectedText = "";
            this.nameSearchValue.SelectionLength = 0;
            this.nameSearchValue.SelectionStart = 0;
            this.nameSearchValue.Size = new System.Drawing.Size(167, 33);
            this.nameSearchValue.TabIndex = 7;
            this.nameSearchValue.TabStop = false;
            this.nameSearchValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameSearchValue.UseSystemPasswordChar = false;
            this.nameSearchValue.TextChanged += new System.EventHandler(this.nameSearchValue_TextChanged);
            // 
            // carNumberSearchValue
            // 
            this.carNumberSearchValue.Depth = 0;
            this.carNumberSearchValue.Hint = "جستجو بر اساس پلاک";
            this.carNumberSearchValue.Location = new System.Drawing.Point(535, 84);
            this.carNumberSearchValue.MaxLength = 32767;
            this.carNumberSearchValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.carNumberSearchValue.Name = "carNumberSearchValue";
            this.carNumberSearchValue.PasswordChar = '\0';
            this.carNumberSearchValue.SelectedText = "";
            this.carNumberSearchValue.SelectionLength = 0;
            this.carNumberSearchValue.SelectionStart = 0;
            this.carNumberSearchValue.Size = new System.Drawing.Size(146, 33);
            this.carNumberSearchValue.TabIndex = 6;
            this.carNumberSearchValue.TabStop = false;
            this.carNumberSearchValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.carNumberSearchValue.UseSystemPasswordChar = false;
            this.carNumberSearchValue.TextChanged += new System.EventHandler(this.carNumberSearchValue_TextChanged);
            // 
            // nameValue
            // 
            this.nameValue.Depth = 0;
            this.nameValue.Hint = "نام";
            this.nameValue.Location = new System.Drawing.Point(707, 430);
            this.nameValue.MaxLength = 30;
            this.nameValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameValue.Name = "nameValue";
            this.nameValue.PasswordChar = '\0';
            this.nameValue.SelectedText = "";
            this.nameValue.SelectionLength = 0;
            this.nameValue.SelectionStart = 0;
            this.nameValue.Size = new System.Drawing.Size(147, 33);
            this.nameValue.TabIndex = 1;
            this.nameValue.TabStop = false;
            this.nameValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameValue.UseSystemPasswordChar = false;
            this.nameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameValue_KeyPress);
            this.nameValue.Leave += new System.EventHandler(this.nameValue_Leave);
            // 
            // carNumberValue
            // 
            this.carNumberValue.Depth = 0;
            this.carNumberValue.Hint = "شماره پلاک";
            this.carNumberValue.Location = new System.Drawing.Point(573, 430);
            this.carNumberValue.MaxLength = 13;
            this.carNumberValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.carNumberValue.Name = "carNumberValue";
            this.carNumberValue.PasswordChar = '\0';
            this.carNumberValue.SelectedText = "";
            this.carNumberValue.SelectionLength = 0;
            this.carNumberValue.SelectionStart = 0;
            this.carNumberValue.Size = new System.Drawing.Size(128, 33);
            this.carNumberValue.TabIndex = 2;
            this.carNumberValue.TabStop = false;
            this.carNumberValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.carNumberValue.UseSystemPasswordChar = false;
            this.carNumberValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumberValue_KeyPress);
            this.carNumberValue.Leave += new System.EventHandler(this.carNumberValue_Leave);
            this.carNumberValue.TextChanged += new System.EventHandler(this.carNumberValue_TextChanged);
            // 
            // fuelEntryValue
            // 
            this.fuelEntryValue.Depth = 0;
            this.fuelEntryValue.Hint = "تاریخ شروع سوخت";
            this.fuelEntryValue.Location = new System.Drawing.Point(408, 430);
            this.fuelEntryValue.MaxLength = 10;
            this.fuelEntryValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.fuelEntryValue.Name = "fuelEntryValue";
            this.fuelEntryValue.PasswordChar = '\0';
            this.fuelEntryValue.SelectedText = "";
            this.fuelEntryValue.SelectionLength = 0;
            this.fuelEntryValue.SelectionStart = 0;
            this.fuelEntryValue.Size = new System.Drawing.Size(153, 33);
            this.fuelEntryValue.TabIndex = 3;
            this.fuelEntryValue.TabStop = false;
            this.fuelEntryValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.fuelEntryValue.UseSystemPasswordChar = false;
            this.fuelEntryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fuelEntryValue_KeyPress);
            this.fuelEntryValue.Leave += new System.EventHandler(this.fuelEntryValue_Leave);
            this.fuelEntryValue.TextChanged += new System.EventHandler(this.fuelEntryValue_TextChanged);
            // 
            // insuranceEntryValue
            // 
            this.insuranceEntryValue.Depth = 0;
            this.insuranceEntryValue.Hint = "تاریخ شروع بیمه";
            this.insuranceEntryValue.Location = new System.Drawing.Point(249, 430);
            this.insuranceEntryValue.MaxLength = 10;
            this.insuranceEntryValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.insuranceEntryValue.Name = "insuranceEntryValue";
            this.insuranceEntryValue.PasswordChar = '\0';
            this.insuranceEntryValue.SelectedText = "";
            this.insuranceEntryValue.SelectionLength = 0;
            this.insuranceEntryValue.SelectionStart = 0;
            this.insuranceEntryValue.Size = new System.Drawing.Size(153, 33);
            this.insuranceEntryValue.TabIndex = 4;
            this.insuranceEntryValue.TabStop = false;
            this.insuranceEntryValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.insuranceEntryValue.UseSystemPasswordChar = false;
            this.insuranceEntryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insuranceEntryValue_KeyPress);
            this.insuranceEntryValue.Leave += new System.EventHandler(this.insuranceEntryValue_Leave);
            this.insuranceEntryValue.TextChanged += new System.EventHandler(this.insuranceEntryValue_TextChanged);
            // 
            // explainValue
            // 
            this.explainValue.Depth = 0;
            this.explainValue.Hint = "توضیحات";
            this.explainValue.Location = new System.Drawing.Point(249, 474);
            this.explainValue.MaxLength = 200;
            this.explainValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.explainValue.Name = "explainValue";
            this.explainValue.PasswordChar = '\0';
            this.explainValue.SelectedText = "";
            this.explainValue.SelectionLength = 0;
            this.explainValue.SelectionStart = 0;
            this.explainValue.Size = new System.Drawing.Size(605, 33);
            this.explainValue.TabIndex = 5;
            this.explainValue.TabStop = false;
            this.explainValue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.explainValue.UseSystemPasswordChar = false;
            this.explainValue.Leave += new System.EventHandler(this.explainValue_Leave);
            // 
            // themeCheckBox
            // 
            this.themeCheckBox.AutoSize = true;
            this.themeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.themeCheckBox.Checked = true;
            this.themeCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.themeCheckBox.Depth = 0;
            this.themeCheckBox.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.themeCheckBox.Location = new System.Drawing.Point(2, 87);
            this.themeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.themeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeCheckBox.Name = "themeCheckBox";
            this.themeCheckBox.Ripple = true;
            this.themeCheckBox.Size = new System.Drawing.Size(255, 30);
            this.themeCheckBox.TabIndex = 30;
            this.themeCheckBox.Text = "برای فعال سازی حالت روشن کلیک کنید";
            this.themeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.themeCheckBox.UseVisualStyleBackColor = false;
            this.themeCheckBox.CheckedChanged += new System.EventHandler(this.themeCheckBox_CheckedChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(2, 123);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(852, 1);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(2, 422);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(852, 1);
            this.materialDivider2.TabIndex = 32;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // header
            // 
            this.header.AutoEllipsis = true;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Depth = 0;
            this.header.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.header.Location = new System.Drawing.Point(0, 31);
            this.header.MouseState = MaterialSkin.MouseState.HOVER;
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(195, 26);
            this.header.TabIndex = 33;
            this.header.Text = "سیستم مدیریت بیمه وسایل نقلیه";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionLabel.Location = new System.Drawing.Point(0, 0);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(65, 26);
            this.versionLabel.TabIndex = 33;
            this.versionLabel.Text = "2 : نسخه ";
            // 
            // showListButton
            // 
            this.showListButton.AutoSize = true;
            this.showListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showListButton.Depth = 0;
            this.showListButton.Icon = null;
            this.showListButton.Location = new System.Drawing.Point(429, 81);
            this.showListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showListButton.Name = "showListButton";
            this.showListButton.Primary = true;
            this.showListButton.Size = new System.Drawing.Size(100, 36);
            this.showListButton.TabIndex = 34;
            this.showListButton.Text = "مشاهده لیست";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // helpLink
            // 
            this.helpLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.helpLink.AutoSize = true;
            this.helpLink.BackColor = System.Drawing.Color.Transparent;
            this.helpLink.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.helpLink.LinkColor = System.Drawing.Color.Blue;
            this.helpLink.Location = new System.Drawing.Point(69, 0);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(22, 28);
            this.helpLink.TabIndex = 22;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "?";
            this.helpLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.helpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(857, 516);
            this.Controls.Add(this.showListButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.themeCheckBox);
            this.Controls.Add(this.explainValue);
            this.Controls.Add(this.insuranceEntryValue);
            this.Controls.Add(this.fuelEntryValue);
            this.Controls.Add(this.carNumberValue);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.carNumberSearchValue);
            this.Controls.Add(this.nameSearchValue);
            this.Controls.Add(this.helpLink);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.ListGW);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ListGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton addButton;
        private System.Windows.Forms.DataGridView ListGW;
        private MaterialSkin.Controls.MaterialFlatButton cancelButton;
        private MaterialSkin.Controls.MaterialFlatButton updateButton;
        private MaterialSkin.Controls.MaterialCheckBox statusValue;
        private MaterialSkin.Controls.MaterialFlatButton deleteButton;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.Timer timerChecker;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameSearchValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField carNumberSearchValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField carNumberValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField fuelEntryValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField insuranceEntryValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField explainValue;
        private MaterialSkin.Controls.MaterialCheckBox themeCheckBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumberGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelEntryGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelExpierGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceEntryGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceExpierGW;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SituationGW;
        private MaterialSkin.Controls.MaterialLabel header;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
        private MaterialSkin.Controls.MaterialRaisedButton showListButton;
        private System.Windows.Forms.LinkLabel helpLink;
    }
}
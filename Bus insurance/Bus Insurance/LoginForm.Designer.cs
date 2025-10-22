namespace Bus_Insurance
{
    partial class LoginForm
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
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.connectButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl.Location = new System.Drawing.Point(109, 97);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(178, 52);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "در حال بررسی سطح دسترسی\r\nلطفا منتظر بمانید";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(144, 177);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Primary = false;
            this.connectButton.Size = new System.Drawing.Size(95, 36);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "ورود به برنامه";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 244);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                      مدیریت بیمه وسایل نقلیه نسخه 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialFlatButton connectButton;
    }
}
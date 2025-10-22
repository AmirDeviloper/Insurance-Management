namespace Bus_Insurance
{
    partial class MsgBox_YN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox_YN));
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNo = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(10, 65);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(430, 154);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "تست";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Icon = null;
            this.btnYes.Location = new System.Drawing.Point(240, 223);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(57, 36);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "موافقم";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Icon = null;
            this.btnNo.Location = new System.Drawing.Point(134, 223);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = false;
            this.btnNo.Size = new System.Drawing.Size(60, 36);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "مخالفم";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // MsgBox_YN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MsgBox_YN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialFlatButton btnYes;
        private MaterialSkin.Controls.MaterialFlatButton btnNo;
    }
}
namespace DatGridDemoInCSharp
{
    partial class EditAccountForm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Ylbl = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.StrengthLbl = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.yTxt = new System.Windows.Forms.TextBox();
            this.xTxt = new System.Windows.Forms.TextBox();
            this.Strengthtxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(81, 194);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Ylbl
            // 
            this.Ylbl.AutoSize = true;
            this.Ylbl.Location = new System.Drawing.Point(152, 118);
            this.Ylbl.Name = "Ylbl";
            this.Ylbl.Size = new System.Drawing.Size(17, 17);
            this.Ylbl.TabIndex = 7;
            this.Ylbl.Text = "Y";
            this.Ylbl.UseWaitCursor = true;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(32, 118);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            // 
            // StrengthLbl
            // 
            this.StrengthLbl.AutoSize = true;
            this.StrengthLbl.Location = new System.Drawing.Point(32, 66);
            this.StrengthLbl.Name = "StrengthLbl";
            this.StrengthLbl.Size = new System.Drawing.Size(62, 17);
            this.StrengthLbl.TabIndex = 9;
            this.StrengthLbl.Text = "Strength";
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Location = new System.Drawing.Point(32, 20);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(79, 17);
            this.UserNamelbl.TabIndex = 10;
            this.UserNamelbl.Text = "User Name";
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(155, 138);
            this.yTxt.Name = "yTxt";
            this.yTxt.Size = new System.Drawing.Size(59, 22);
            this.yTxt.TabIndex = 3;
            this.yTxt.Text = "Y";
            // 
            // xTxt
            // 
            this.xTxt.Location = new System.Drawing.Point(33, 138);
            this.xTxt.Name = "xTxt";
            this.xTxt.Size = new System.Drawing.Size(61, 22);
            this.xTxt.TabIndex = 4;
            this.xTxt.Text = "X";
            // 
            // Strengthtxt
            // 
            this.Strengthtxt.Location = new System.Drawing.Point(33, 86);
            this.Strengthtxt.Name = "Strengthtxt";
            this.Strengthtxt.Size = new System.Drawing.Size(181, 22);
            this.Strengthtxt.TabIndex = 5;
            this.Strengthtxt.Text = "Strength";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Enabled = false;
            this.UserNameTxt.Location = new System.Drawing.Point(33, 40);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(181, 22);
            this.UserNameTxt.TabIndex = 6;
            this.UserNameTxt.Text = "UserName";
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 257);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Ylbl);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.StrengthLbl);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.yTxt);
            this.Controls.Add(this.xTxt);
            this.Controls.Add(this.Strengthtxt);
            this.Controls.Add(this.UserNameTxt);
            this.Name = "EditAccountForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button SaveBtn;
        internal System.Windows.Forms.Label Ylbl;
        internal System.Windows.Forms.Label lblX;
        internal System.Windows.Forms.Label StrengthLbl;
        internal System.Windows.Forms.Label UserNamelbl;
        internal System.Windows.Forms.TextBox yTxt;
        internal System.Windows.Forms.TextBox xTxt;
        internal System.Windows.Forms.TextBox Strengthtxt;
        internal System.Windows.Forms.TextBox UserNameTxt;
    }
}
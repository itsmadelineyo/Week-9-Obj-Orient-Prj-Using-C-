namespace CheckDigitVerificationPrjct
{
    partial class frmCheckDigit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAccount = new Label();
            lblConfirm = new Label();
            txtAccount = new TextBox();
            txtConfirm = new TextBox();
            lblAmount = new Label();
            btnProcess = new Button();
            btnExit = new Button();
            btnReset = new Button();
            rtbMessages = new RichTextBox();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.ForeColor = SystemColors.Control;
            lblAccount.Location = new Point(48, 20);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(181, 38);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account Number:";
            lblAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirm
            // 
            lblConfirm.ForeColor = SystemColors.ButtonFace;
            lblConfirm.Location = new Point(460, 20);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(165, 38);
            lblConfirm.TabIndex = 1;
            lblConfirm.Text = "Confirm Account:";
            lblConfirm.TextAlign = ContentAlignment.MiddleCenter;
            lblConfirm.Click += label2_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(48, 61);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(165, 31);
            txtAccount.TabIndex = 2;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(460, 61);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(165, 31);
            txtConfirm.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.ForeColor = SystemColors.Control;
            lblAmount.Location = new Point(253, 111);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(165, 38);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Payment Amount:";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(81, 234);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(112, 34);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "&Process";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(422, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(253, 234);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 8;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(48, 328);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(577, 229);
            rtbMessages.TabIndex = 9;
            rtbMessages.Text = "";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(253, 162);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(165, 31);
            txtAmount.TabIndex = 11;
            Controls.Add(txtAmount);
            // 
            // frmCheckDigit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(681, 711);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(rtbMessages);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnProcess);
            Controls.Add(txtConfirm);
            Controls.Add(txtAccount);
            Controls.Add(lblConfirm);
            Controls.Add(lblAccount);
            Name = "frmCheckDigit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Digit Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Label lblConfirm;
        private TextBox txtAccount;
        private TextBox txtConfirm;
        private Label lblAmount;
        private Button btnProcess;
        private Button btnExit;
        private Button btnReset;
        private RichTextBox rtbMessages;
        private System.Windows.Forms.TextBox txtAmount;

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}

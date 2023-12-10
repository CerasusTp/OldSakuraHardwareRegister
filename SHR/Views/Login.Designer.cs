namespace SHR.Views
{
    partial class Login
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
            btnLogin = new Button();
            txtPw = new TextBox();
            lblPw = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(175, 211, 226);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Meiryo UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnLogin.Location = new Point(80, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 40);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPw
            // 
            txtPw.Anchor = AnchorStyles.Top;
            txtPw.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            txtPw.Location = new Point(161, 187);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(160, 35);
            txtPw.TabIndex = 16;
            txtPw.KeyDown += txtPw_KeyDown;
            // 
            // lblPw
            // 
            lblPw.Anchor = AnchorStyles.Top;
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            lblPw.Location = new Point(80, 190);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(45, 30);
            lblPw.TabIndex = 15;
            lblPw.Text = "PW";
            lblPw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top;
            txtId.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            txtId.Location = new Point(161, 127);
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 35);
            txtId.TabIndex = 14;
            txtId.KeyDown += txtId_KeyDown;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top;
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            lblId.Location = new Point(80, 130);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 30);
            lblId.TabIndex = 13;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(54, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 32);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "さくらハードウェア台帳システム";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(lblPw);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Login";
            Padding = new Padding(3, 0, 3, 3);
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(lblPw, 0);
            Controls.SetChildIndex(txtPw, 0);
            Controls.SetChildIndex(btnLogin, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPw;
        private Label lblPw;
        private TextBox txtId;
        private Label lblId;
        private Label lblTitle;
    }
}
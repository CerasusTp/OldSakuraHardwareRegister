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
            lblTitle = new Label();
            lblId = new Label();
            txtId = new TextBox();
            txtPw = new TextBox();
            lblPw = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(46, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "さくらハードウェア台帳システム";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            lblId.Location = new Point(72, 100);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 30);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            txtId.Location = new Point(153, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 35);
            txtId.TabIndex = 2;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            txtPw.Location = new Point(153, 157);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(160, 35);
            txtPw.TabIndex = 4;
            // 
            // lblPw
            // 
            lblPw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            lblPw.Location = new Point(72, 160);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(45, 30);
            lblPw.TabIndex = 3;
            lblPw.Text = "PW";
            lblPw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Meiryo UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnLogin.Location = new Point(72, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(384, 291);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(lblPw);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Indigo;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtPw;
        private Label lblPw;
        private Button btnLogin;
    }
}
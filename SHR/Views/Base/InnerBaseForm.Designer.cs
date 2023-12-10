namespace SHR.Views.Base
{
    partial class InnerBaseForm
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
            btnInnerClose = new Button();
            SuspendLayout();
            // 
            // btnInnerClose
            // 
            btnInnerClose.Anchor = AnchorStyles.Top;
            btnInnerClose.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnInnerClose.Location = new Point(929, 0);
            btnInnerClose.Margin = new Padding(2);
            btnInnerClose.Name = "btnInnerClose";
            btnInnerClose.Size = new Size(58, 54);
            btnInnerClose.TabIndex = 0;
            btnInnerClose.Text = "✕";
            btnInnerClose.UseVisualStyleBackColor = true;
            btnInnerClose.Click += btnInnerClose_Click;
            // 
            // InnerBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 241, 241);
            ClientSize = new Size(1008, 450);
            ControlBox = false;
            Controls.Add(btnInnerClose);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ForeColor = Color.FromArgb(23, 108, 148);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "InnerBaseForm";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInnerClose;
    }
}
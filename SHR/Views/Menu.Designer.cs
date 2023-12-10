namespace SHR.Views
{
    partial class Menu
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
            cmbLocation = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cmbLocation
            // 
            cmbLocation.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(12, 12);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(200, 38);
            cmbLocation.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(353, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 289);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbLocation);
            Font = new Font("Yu Gothic UI", 9F);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Menu";
            Padding = new Padding(3, 0, 3, 3);
            Load += Menu_Load;
            Controls.SetChildIndex(cmbLocation, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLocation;
        private Button button1;
        private Button button2;
    }
}
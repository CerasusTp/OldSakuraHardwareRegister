namespace SHR.Views
{
    partial class BaseForm
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
            MenuStrip = new MenuStrip();
            toolSettings = new ToolStripMenuItem();
            toolHelp = new ToolStripMenuItem();
            toolitemVersion = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { toolSettings, toolHelp });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1008, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // toolSettings
            // 
            toolSettings.Name = "toolSettings";
            toolSettings.Size = new Size(43, 20);
            toolSettings.Text = "設定";
            // 
            // toolHelp
            // 
            toolHelp.DropDownItems.AddRange(new ToolStripItem[] { toolitemVersion });
            toolHelp.Name = "toolHelp";
            toolHelp.Size = new Size(48, 20);
            toolHelp.Text = "ヘルプ";
            // 
            // toolitemVersion
            // 
            toolitemVersion.Name = "toolitemVersion";
            toolitemVersion.Size = new Size(249, 22);
            toolitemVersion.Text = "さくらハードウェア台帳システム について";
            toolitemVersion.Click += toolitemVersion_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 241, 241);
            ClientSize = new Size(1008, 537);
            Controls.Add(MenuStrip);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ForeColor = Color.FromArgb(23, 108, 148);
            MainMenuStrip = MenuStrip;
            Name = "BaseForm";
            Text = "さくらハードウェア台帳システム";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem toolSettings;
        private ToolStripMenuItem toolHelp;
        private ToolStripMenuItem toolitemVersion;
    }
}
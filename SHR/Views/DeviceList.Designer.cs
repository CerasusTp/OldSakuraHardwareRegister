namespace SHR.Views
{
    partial class DeviceList
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
            viewList = new Library.CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)viewList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "デバイスリスト";
            // 
            // viewList
            // 
            viewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewList.Location = new Point(12, 79);
            viewList.Name = "viewList";
            viewList.Size = new Size(990, 365);
            viewList.TabIndex = 2;
            // 
            // DeviceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(viewList);
            Controls.Add(lblTitle);
            Name = "DeviceList";
            Text = "DeviceList";
            Load += DeviceList_Load;
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(viewList, 0);
            ((System.ComponentModel.ISupportInitialize)viewList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Library.CustomDataGridView viewList;
    }
}
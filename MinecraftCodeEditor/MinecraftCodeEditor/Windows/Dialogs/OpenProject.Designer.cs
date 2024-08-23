namespace CodeEditor.Windows.Dialogs
{
    partial class OpenProject
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
            statusStrip1 = new StatusStrip();
            ToolBarLabel1 = new ToolStripStatusLabel();
            selectFolderBtn = new Button();
            okBtn = new Button();
            locationTxt = new TextBox();
            locationLbl = new Label();
            nameTxt = new TextBox();
            nameLbl = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolBarLabel1 });
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1258, 32);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // ToolBarLabel1
            // 
            ToolBarLabel1.Name = "ToolBarLabel1";
            ToolBarLabel1.Size = new Size(179, 25);
            ToolBarLabel1.Text = "toolStripStatusLabel1";
            // 
            // selectFolderBtn
            // 
            selectFolderBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            selectFolderBtn.Location = new Point(1208, 97);
            selectFolderBtn.Name = "selectFolderBtn";
            selectFolderBtn.Size = new Size(38, 39);
            selectFolderBtn.TabIndex = 14;
            selectFolderBtn.Text = "...";
            selectFolderBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            okBtn.Location = new Point(1125, 570);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(121, 45);
            okBtn.TabIndex = 13;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // locationTxt
            // 
            locationTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationTxt.Location = new Point(345, 97);
            locationTxt.Name = "locationTxt";
            locationTxt.PlaceholderText = "testing";
            locationTxt.Size = new Size(901, 39);
            locationTxt.TabIndex = 12;
            // 
            // locationLbl
            // 
            locationLbl.AutoSize = true;
            locationLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationLbl.Location = new Point(29, 97);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(184, 32);
            locationLbl.TabIndex = 11;
            locationLbl.Text = "Project Location";
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.Location = new Point(345, 18);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(901, 39);
            nameTxt.TabIndex = 10;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLbl.Location = new Point(29, 15);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(158, 32);
            nameLbl.TabIndex = 9;
            nameLbl.Text = "Project Name";
            // 
            // OpenProject
            // 
            AcceptButton = okBtn;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(statusStrip1);
            Controls.Add(selectFolderBtn);
            Controls.Add(okBtn);
            Controls.Add(locationTxt);
            Controls.Add(locationLbl);
            Controls.Add(nameTxt);
            Controls.Add(nameLbl);
            Name = "OpenProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpenProject";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        public ToolStripStatusLabel ToolBarLabel1;
        private Button selectFolderBtn;
        private Button okBtn;
        private Label locationLbl;
        private TextBox nameTxt;
        private Label nameLbl;
        public TextBox locationTxt;
    }
}
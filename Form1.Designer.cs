namespace $safeprojectname$
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelArea = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.newTabButton = new System.Windows.Forms.Button();
            this.closeTabButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(13, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(43, 36);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseHover);
            // 
            // forwardButton
            // 
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.Location = new System.Drawing.Point(62, 12);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(43, 36);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            this.forwardButton.MouseHover += new System.EventHandler(this.forwardButton_MouseHover);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(111, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(43, 36);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            this.refreshButton.MouseHover += new System.EventHandler(this.refreshButton_MouseHover);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(204, 19);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(601, 22);
            this.urlBox.TabIndex = 3;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            this.urlBox.Enter += new System.EventHandler(this.urlBoxEnterPressed);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.Location = new System.Drawing.Point(821, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(43, 36);
            this.goButton.TabIndex = 4;
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButtonClick);
            this.goButton.MouseHover += new System.EventHandler(this.goButton_MouseHover);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(2, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1118, 580);
            this.tabControl.TabIndex = 5;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelArea);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelArea
            // 
            this.panelArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArea.Location = new System.Drawing.Point(0, 0);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(1107, 548);
            this.panelArea.TabIndex = 0;
            this.panelArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArea_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // newTabButton
            // 
            this.newTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            this.newTabButton.Location = new System.Drawing.Point(870, 12);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(106, 36);
            this.newTabButton.TabIndex = 6;
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            this.newTabButton.MouseHover += new System.EventHandler(this.newTabButton_MouseHover);
            // 
            // closeTabButton
            // 
            this.closeTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.Location = new System.Drawing.Point(982, 13);
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(106, 36);
            this.closeTabButton.TabIndex = 7;
            this.closeTabButton.UseVisualStyleBackColor = true;
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(155, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(43, 36);
            this.stopButton.TabIndex = 8;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.MouseHover += new System.EventHandler(this.stopButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 636);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.closeTabButton);
            this.Controls.Add(this.newTabButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button closeTabButton;
        private System.Windows.Forms.Button newTabButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.Button stopButton;
    }
}


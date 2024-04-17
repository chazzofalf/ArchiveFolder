namespace ArchiveFolderExeLib
{
    partial class ArchiveFolderForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveFolderForm));
            label1 = new Label();
            folderLocationTextbox = new TextBox();
            browseButton = new Button();
            goButton = new Button();
            progressBar = new ProgressBar();
            pictureBoxInfo = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "&Folder To Archive:";
            // 
            // folderLocationTextbox
            // 
            folderLocationTextbox.Location = new Point(133, 9);
            folderLocationTextbox.Margin = new Padding(3, 2, 3, 2);
            folderLocationTextbox.Name = "folderLocationTextbox";
            folderLocationTextbox.ReadOnly = true;
            folderLocationTextbox.Size = new Size(303, 23);
            folderLocationTextbox.TabIndex = 1;
            folderLocationTextbox.TabStop = false;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(441, 9);
            browseButton.Margin = new Padding(3, 2, 3, 2);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(31, 22);
            browseButton.TabIndex = 2;
            browseButton.Text = "...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // goButton
            // 
            goButton.Enabled = false;
            goButton.Location = new Point(441, 34);
            goButton.Margin = new Padding(3, 2, 3, 2);
            goButton.Name = "goButton";
            goButton.Size = new Size(43, 22);
            goButton.TabIndex = 4;
            goButton.Text = "&Go!";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(133, 34);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(303, 22);
            progressBar.TabIndex = 3;
            // 
            // pictureBoxInfo
            // 
            pictureBoxInfo.Image = Properties.Resources.info;
            pictureBoxInfo.Location = new Point(12, 40);
            pictureBoxInfo.Name = "pictureBoxInfo";
            pictureBoxInfo.Size = new Size(16, 16);
            pictureBoxInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInfo.TabIndex = 5;
            pictureBoxInfo.TabStop = false;
            // 
            // ArchiveFolderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 68);
            Controls.Add(pictureBoxInfo);
            Controls.Add(progressBar);
            Controls.Add(goButton);
            Controls.Add(browseButton);
            Controls.Add(folderLocationTextbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ArchiveFolderForm";
            Text = "ArchiveFolder";
            Load += ArchiveFolderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox folderLocationTextbox;
        private Button browseButton;
        private Button goButton;
        private ProgressBar progressBar;
        private PictureBox pictureBoxInfo;
        private ToolTip toolTip1;
    }
}

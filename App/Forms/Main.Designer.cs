namespace App.Forms
{
    partial class Main
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
            FbdLocation = new FolderBrowserDialog();
            GbOptions = new GroupBox();
            RbAsset = new RadioButton();
            RbCharacter = new RadioButton();
            RbProject = new RadioButton();
            GbImage = new GroupBox();
            PbTemplate = new PictureBox();
            GbCreate = new GroupBox();
            textBox1 = new TextBox();
            BtnFolder = new Button();
            BtnCreate = new Button();
            GbOptions.SuspendLayout();
            GbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbTemplate).BeginInit();
            GbCreate.SuspendLayout();
            SuspendLayout();
            // 
            // GbOptions
            // 
            GbOptions.AutoSize = true;
            GbOptions.Controls.Add(RbAsset);
            GbOptions.Controls.Add(RbCharacter);
            GbOptions.Controls.Add(RbProject);
            GbOptions.Dock = DockStyle.Left;
            GbOptions.ForeColor = Color.DarkRed;
            GbOptions.Location = new Point(0, 0);
            GbOptions.Name = "GbOptions";
            GbOptions.Size = new Size(166, 729);
            GbOptions.TabIndex = 0;
            GbOptions.TabStop = false;
            GbOptions.Text = "Options";
            // 
            // RbAsset
            // 
            RbAsset.AutoSize = true;
            RbAsset.FlatAppearance.BorderColor = Color.Black;
            RbAsset.FlatAppearance.BorderSize = 2;
            RbAsset.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RbAsset.ForeColor = Color.DarkRed;
            RbAsset.Location = new Point(23, 150);
            RbAsset.Margin = new Padding(20);
            RbAsset.Name = "RbAsset";
            RbAsset.Size = new Size(81, 34);
            RbAsset.TabIndex = 0;
            RbAsset.TabStop = true;
            RbAsset.Text = "Asset";
            RbAsset.UseVisualStyleBackColor = true;
            RbAsset.CheckedChanged += RbAsset_CheckedChanged;
            // 
            // RbCharacter
            // 
            RbCharacter.AutoSize = true;
            RbCharacter.FlatAppearance.BorderColor = Color.Black;
            RbCharacter.FlatAppearance.BorderSize = 2;
            RbCharacter.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RbCharacter.ForeColor = Color.DarkRed;
            RbCharacter.Location = new Point(23, 100);
            RbCharacter.Margin = new Padding(20);
            RbCharacter.Name = "RbCharacter";
            RbCharacter.Size = new Size(120, 34);
            RbCharacter.TabIndex = 0;
            RbCharacter.TabStop = true;
            RbCharacter.Text = "Character";
            RbCharacter.UseVisualStyleBackColor = true;
            RbCharacter.CheckedChanged += RbCharacter_CheckedChanged;
            // 
            // RbProject
            // 
            RbProject.AutoSize = true;
            RbProject.FlatAppearance.BorderColor = Color.Black;
            RbProject.FlatAppearance.BorderSize = 2;
            RbProject.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RbProject.ForeColor = Color.DarkRed;
            RbProject.Location = new Point(23, 50);
            RbProject.Margin = new Padding(20);
            RbProject.Name = "RbProject";
            RbProject.Size = new Size(95, 34);
            RbProject.TabIndex = 0;
            RbProject.TabStop = true;
            RbProject.Text = "Project";
            RbProject.UseVisualStyleBackColor = true;
            RbProject.CheckedChanged += RbProject_CheckedChanged;
            // 
            // GbImage
            // 
            GbImage.AutoSize = true;
            GbImage.Controls.Add(PbTemplate);
            GbImage.Controls.Add(GbCreate);
            GbImage.Dock = DockStyle.Fill;
            GbImage.ForeColor = Color.DarkRed;
            GbImage.Location = new Point(166, 0);
            GbImage.Name = "GbImage";
            GbImage.Size = new Size(842, 729);
            GbImage.TabIndex = 1;
            GbImage.TabStop = false;
            GbImage.Text = "Template";
            // 
            // PbTemplate
            // 
            PbTemplate.InitialImage = null;
            PbTemplate.Location = new Point(13, 28);
            PbTemplate.Name = "PbTemplate";
            PbTemplate.Size = new Size(800, 480);
            PbTemplate.SizeMode = PictureBoxSizeMode.StretchImage;
            PbTemplate.TabIndex = 1;
            PbTemplate.TabStop = false;
            // 
            // GbCreate
            // 
            GbCreate.Controls.Add(textBox1);
            GbCreate.Controls.Add(BtnFolder);
            GbCreate.Controls.Add(BtnCreate);
            GbCreate.Dock = DockStyle.Bottom;
            GbCreate.ForeColor = Color.DarkRed;
            GbCreate.Location = new Point(3, 517);
            GbCreate.Name = "GbCreate";
            GbCreate.Size = new Size(836, 209);
            GbCreate.TabIndex = 0;
            GbCreate.TabStop = false;
            GbCreate.Text = "Action";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(26, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 51);
            textBox1.TabIndex = 2;
            // 
            // BtnFolder
            // 
            BtnFolder.BackColor = Color.White;
            BtnFolder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFolder.ForeColor = Color.Firebrick;
            BtnFolder.Location = new Point(411, 79);
            BtnFolder.Name = "BtnFolder";
            BtnFolder.Size = new Size(174, 51);
            BtnFolder.TabIndex = 1;
            BtnFolder.Text = "Folder";
            BtnFolder.UseVisualStyleBackColor = false;
            // 
            // BtnCreate
            // 
            BtnCreate.BackColor = Color.White;
            BtnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCreate.ForeColor = Color.Red;
            BtnCreate.Location = new Point(26, 149);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(558, 51);
            BtnCreate.TabIndex = 0;
            BtnCreate.Text = "Create";
            BtnCreate.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1008, 729);
            Controls.Add(GbImage);
            Controls.Add(GbOptions);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            GbOptions.ResumeLayout(false);
            GbOptions.PerformLayout();
            GbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbTemplate).EndInit();
            GbCreate.ResumeLayout(false);
            GbCreate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog FbdLocation;
        private GroupBox GbOptions;
        private RadioButton RbProject;
        private GroupBox GbImage;
        private RadioButton RbAsset;
        private RadioButton RbCharacter;
        private PictureBox PbTemplate;
        private GroupBox GbCreate;
        private Button BtnCreate;
        private TextBox textBox1;
        private Button BtnFolder;
    }
}
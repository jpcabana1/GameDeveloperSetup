namespace App.Forms
{
    partial class ProjectSetup
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
            GbRepositoryUrl = new GroupBox();
            TxtRepositoryUrl = new TextBox();
            GbRepositoryName = new GroupBox();
            TxtRepositoryName = new TextBox();
            GbButton = new GroupBox();
            BtnOk = new Button();
            GbRepositoryUrl.SuspendLayout();
            GbRepositoryName.SuspendLayout();
            GbButton.SuspendLayout();
            SuspendLayout();
            // 
            // GbRepositoryUrl
            // 
            GbRepositoryUrl.Controls.Add(TxtRepositoryUrl);
            GbRepositoryUrl.Dock = DockStyle.Top;
            GbRepositoryUrl.Location = new Point(0, 0);
            GbRepositoryUrl.Name = "GbRepositoryUrl";
            GbRepositoryUrl.Size = new Size(800, 60);
            GbRepositoryUrl.TabIndex = 0;
            GbRepositoryUrl.TabStop = false;
            GbRepositoryUrl.Text = "Repository Url";
            // 
            // TxtRepositoryUrl
            // 
            TxtRepositoryUrl.Dock = DockStyle.Top;
            TxtRepositoryUrl.Location = new Point(3, 19);
            TxtRepositoryUrl.Name = "TxtRepositoryUrl";
            TxtRepositoryUrl.Size = new Size(794, 23);
            TxtRepositoryUrl.TabIndex = 0;
            // 
            // GbRepositoryName
            // 
            GbRepositoryName.Controls.Add(TxtRepositoryName);
            GbRepositoryName.Dock = DockStyle.Top;
            GbRepositoryName.Location = new Point(0, 60);
            GbRepositoryName.Name = "GbRepositoryName";
            GbRepositoryName.Size = new Size(800, 68);
            GbRepositoryName.TabIndex = 1;
            GbRepositoryName.TabStop = false;
            GbRepositoryName.Text = "Repository Name";
            // 
            // TxtRepositoryName
            // 
            TxtRepositoryName.Dock = DockStyle.Top;
            TxtRepositoryName.Location = new Point(3, 19);
            TxtRepositoryName.Name = "TxtRepositoryName";
            TxtRepositoryName.Size = new Size(794, 23);
            TxtRepositoryName.TabIndex = 0;
            // 
            // GbButton
            // 
            GbButton.Controls.Add(BtnOk);
            GbButton.Dock = DockStyle.Fill;
            GbButton.Location = new Point(0, 128);
            GbButton.Name = "GbButton";
            GbButton.Size = new Size(800, 140);
            GbButton.TabIndex = 2;
            GbButton.TabStop = false;
            // 
            // BtnOk
            // 
            BtnOk.Dock = DockStyle.Fill;
            BtnOk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOk.Location = new Point(3, 19);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(794, 118);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // ProjectSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 268);
            Controls.Add(GbButton);
            Controls.Add(GbRepositoryName);
            Controls.Add(GbRepositoryUrl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProjectSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProjectSetup";
            GbRepositoryUrl.ResumeLayout(false);
            GbRepositoryUrl.PerformLayout();
            GbRepositoryName.ResumeLayout(false);
            GbRepositoryName.PerformLayout();
            GbButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbRepositoryUrl;
        public TextBox TxtRepositoryUrl;
        private GroupBox GbRepositoryName;
        public TextBox TxtRepositoryName;
        private GroupBox GbButton;
        private Button BtnOk;
    }
}
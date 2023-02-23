namespace App.Forms
{
    partial class NamePrompt
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
            groupBox1 = new GroupBox();
            BtnOk = new Button();
            groupBox2 = new GroupBox();
            TxtName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnOk);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnOk
            // 
            BtnOk.Dock = DockStyle.Fill;
            BtnOk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOk.Location = new Point(3, 19);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(908, 78);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtName);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(914, 83);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // TxtName
            // 
            TxtName.Dock = DockStyle.Fill;
            TxtName.Location = new Point(3, 19);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(908, 61);
            TxtName.TabIndex = 0;
            // 
            // NamePrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 183);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NamePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Name Selection";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnOk;
        private GroupBox groupBox2;
        public TextBox TxtName;
    }
}
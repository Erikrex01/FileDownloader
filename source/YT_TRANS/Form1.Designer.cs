namespace YT_TRANS
{
    partial class Form1
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
            Install = new Button();
            text_url = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            path_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Find_Path = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // Install
            // 
            Install.Location = new Point(125, 108);
            Install.Name = "Install";
            Install.Size = new Size(492, 41);
            Install.TabIndex = 0;
            Install.Text = "Install";
            Install.UseVisualStyleBackColor = true;
            Install.Click += Install_Click;
            // 
            // text_url
            // 
            text_url.Location = new Point(125, 32);
            text_url.Name = "text_url";
            text_url.Size = new Size(492, 23);
            text_url.TabIndex = 1;
            text_url.TextChanged += URL_TextChanged;
            // 
            // path_text
            // 
            path_text.Location = new Point(125, 61);
            path_text.Name = "path_text";
            path_text.Size = new Size(492, 23);
            path_text.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 3;
            label1.Text = "Url:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Path:";
            label2.Click += label2_Click;
            // 
            // Find_Path
            // 
            Find_Path.Location = new Point(632, 61);
            Find_Path.Name = "Find_Path";
            Find_Path.Size = new Size(75, 23);
            Find_Path.TabIndex = 5;
            Find_Path.Text = "Browse";
            Find_Path.UseVisualStyleBackColor = true;
            Find_Path.Click += Find_Path_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(125, 173);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(492, 23);
            progressBar.TabIndex = 6;
            progressBar.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 201);
            Controls.Add(progressBar);
            Controls.Add(Find_Path);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(path_text);
            Controls.Add(text_url);
            Controls.Add(Install);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Install;
        private TextBox text_url;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox path_text;
        private Label label1;
        private Label label2;
        private Button Find_Path;
        private ProgressBar progressBar;
    }
}
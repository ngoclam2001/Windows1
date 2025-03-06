namespace Windows1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.web_1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.web_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRun.Location = new System.Drawing.Point(37, 54);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 36);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run/Reload";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(216, 61);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(579, 22);
            this.txtLink.TabIndex = 1;
            this.txtLink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // web_1
            // 
            this.web_1.AllowExternalDrop = true;
            this.web_1.CreationProperties = null;
            this.web_1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.web_1.Location = new System.Drawing.Point(37, 109);
            this.web_1.Name = "web_1";
            this.web_1.Size = new System.Drawing.Size(895, 453);
            this.web_1.TabIndex = 2;
            this.web_1.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 905);
            this.Controls.Add(this.web_1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.web_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtLink;
        private Microsoft.Web.WebView2.WinForms.WebView2 web_1;
    }
}


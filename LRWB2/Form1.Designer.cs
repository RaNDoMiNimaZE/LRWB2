
namespace LRWB2
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
            this.addressBar = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.goButton = new System.Windows.Forms.Button();
            this.AddTabButton = new System.Windows.Forms.Button();
            this.RamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(0, 12);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(666, 20);
            this.addressBar.TabIndex = 0;
            this.addressBar.Text = "https://www.google.com/";
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.BackColor = System.Drawing.SystemColors.Control;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 38);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(799, 412);
            this.webView.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webView.TabIndex = 1;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.CoreWebView2_NavigationCompleted);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(749, 10);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(50, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // AddTabButton
            // 
            this.AddTabButton.Location = new System.Drawing.Point(672, 10);
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Size = new System.Drawing.Size(71, 23);
            this.AddTabButton.TabIndex = 3;
            this.AddTabButton.Text = "Add Tab";
            this.AddTabButton.UseVisualStyleBackColor = true;
            this.AddTabButton.Click += new System.EventHandler(this.AddTabButton_Click);
            // 
            // RamLabel
            // 
            this.RamLabel.AutoSize = true;
            this.RamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RamLabel.Location = new System.Drawing.Point(538, 12);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(107, 20);
            this.RamLabel.TabIndex = 4;
            this.RamLabel.Text = "RAM USAGE";
            this.RamLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RamLabel);
            this.Controls.Add(this.AddTabButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.addressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Low Ram Web Viewer";
            this.Load += new System.EventHandler(this.Form_Resize);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.SystemColorsChanged += new System.EventHandler(this.Form1_SystemColorsChanged);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressBar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button AddTabButton;
        private System.Windows.Forms.Label RamLabel;
    }
}


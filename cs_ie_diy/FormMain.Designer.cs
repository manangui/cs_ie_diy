namespace cs_ie_diy
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolForward = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolSet = new System.Windows.Forms.ToolStripDropDownButton();
            this.iE11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iE10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iE9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iE8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iE7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBaidu = new System.Windows.Forms.ToolStripButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBack,
            this.toolForward,
            this.toolRefresh,
            this.toolSet,
            this.toolStripButton1,
            this.toolBaidu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBack
            // 
            this.toolBack.Image = ((System.Drawing.Image)(resources.GetObject("toolBack.Image")));
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(52, 22);
            this.toolBack.Text = "后退";
            this.toolBack.Click += new System.EventHandler(this.toolBack_Click);
            // 
            // toolForward
            // 
            this.toolForward.Image = ((System.Drawing.Image)(resources.GetObject("toolForward.Image")));
            this.toolForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolForward.Name = "toolForward";
            this.toolForward.Size = new System.Drawing.Size(52, 22);
            this.toolForward.Text = "前进";
            this.toolForward.Click += new System.EventHandler(this.toolForward_Click);
            // 
            // toolRefresh
            // 
            this.toolRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolRefresh.Image")));
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(52, 22);
            this.toolRefresh.Text = "刷新";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolSet
            // 
            this.toolSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iE11ToolStripMenuItem,
            this.iE10ToolStripMenuItem,
            this.iE9ToolStripMenuItem,
            this.iE8ToolStripMenuItem,
            this.iE7ToolStripMenuItem});
            this.toolSet.Image = ((System.Drawing.Image)(resources.GetObject("toolSet.Image")));
            this.toolSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSet.Name = "toolSet";
            this.toolSet.Size = new System.Drawing.Size(45, 22);
            this.toolSet.Text = "设置";
            // 
            // iE11ToolStripMenuItem
            // 
            this.iE11ToolStripMenuItem.Name = "iE11ToolStripMenuItem";
            this.iE11ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iE11ToolStripMenuItem.Text = "IE11";
            this.iE11ToolStripMenuItem.Click += new System.EventHandler(this.iE11ToolStripMenuItem_Click);
            // 
            // iE10ToolStripMenuItem
            // 
            this.iE10ToolStripMenuItem.Name = "iE10ToolStripMenuItem";
            this.iE10ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iE10ToolStripMenuItem.Text = "IE10";
            this.iE10ToolStripMenuItem.Click += new System.EventHandler(this.iE10ToolStripMenuItem_Click);
            // 
            // iE9ToolStripMenuItem
            // 
            this.iE9ToolStripMenuItem.Name = "iE9ToolStripMenuItem";
            this.iE9ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iE9ToolStripMenuItem.Text = "IE9";
            this.iE9ToolStripMenuItem.Click += new System.EventHandler(this.iE9ToolStripMenuItem_Click);
            // 
            // iE8ToolStripMenuItem
            // 
            this.iE8ToolStripMenuItem.Name = "iE8ToolStripMenuItem";
            this.iE8ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iE8ToolStripMenuItem.Text = "IE8";
            this.iE8ToolStripMenuItem.Click += new System.EventHandler(this.iE8ToolStripMenuItem_Click);
            // 
            // iE7ToolStripMenuItem
            // 
            this.iE7ToolStripMenuItem.Name = "iE7ToolStripMenuItem";
            this.iE7ToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iE7ToolStripMenuItem.Text = "IE7";
            this.iE7ToolStripMenuItem.Click += new System.EventHandler(this.iE7ToolStripMenuItem_Click);
            // 
            // toolBaidu
            // 
            this.toolBaidu.Image = ((System.Drawing.Image)(resources.GetObject("toolBaidu.Image")));
            this.toolBaidu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBaidu.Name = "toolBaidu";
            this.toolBaidu.Size = new System.Drawing.Size(52, 22);
            this.toolBaidu.Text = "百度";
            this.toolBaidu.Click += new System.EventHandler(this.toolBaidu_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 25);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(775, 497);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.Url = new System.Uri("http://www.hnhcyy.com/", System.UriKind.Absolute);
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "首页";
            this.toolStripButton1.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(312, 1);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(463, 21);
            this.textBoxUrl.TabIndex = 4;
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrl_KeyDown);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 522);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的IE浏览器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolForward;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.ToolStripDropDownButton toolSet;
        private System.Windows.Forms.ToolStripMenuItem iE11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iE10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iE9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iE8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iE7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolBaidu;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBoxUrl;
    }
}


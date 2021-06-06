
namespace DigitalClock
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.種類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アナログ時計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.デジタル時計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.砂時計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.機能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ストップウォッチToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タイマーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.種類ToolStripMenuItem,
            this.機能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 種類ToolStripMenuItem
            // 
            this.種類ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.アナログ時計ToolStripMenuItem,
            this.デジタル時計ToolStripMenuItem,
            this.砂時計ToolStripMenuItem});
            this.種類ToolStripMenuItem.Name = "種類ToolStripMenuItem";
            this.種類ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.種類ToolStripMenuItem.Text = "種類";
            // 
            // アナログ時計ToolStripMenuItem
            // 
            this.アナログ時計ToolStripMenuItem.Name = "アナログ時計ToolStripMenuItem";
            this.アナログ時計ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.アナログ時計ToolStripMenuItem.Text = "アナログ時計";
            this.アナログ時計ToolStripMenuItem.Click += new System.EventHandler(this.アナログ時計ToolStripMenuItem_Click_1);
            // 
            // デジタル時計ToolStripMenuItem
            // 
            this.デジタル時計ToolStripMenuItem.Name = "デジタル時計ToolStripMenuItem";
            this.デジタル時計ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.デジタル時計ToolStripMenuItem.Text = "デジタル時計";
            this.デジタル時計ToolStripMenuItem.Click += new System.EventHandler(this.デジタル時計ToolStripMenuItem_Click_1);
            // 
            // 砂時計ToolStripMenuItem
            // 
            this.砂時計ToolStripMenuItem.Name = "砂時計ToolStripMenuItem";
            this.砂時計ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.砂時計ToolStripMenuItem.Text = "砂時計";
            this.砂時計ToolStripMenuItem.Click += new System.EventHandler(this.砂時計ToolStripMenuItem_Click_1);
            // 
            // 機能ToolStripMenuItem
            // 
            this.機能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.時計ToolStripMenuItem,
            this.ストップウォッチToolStripMenuItem,
            this.タイマーToolStripMenuItem});
            this.機能ToolStripMenuItem.Name = "機能ToolStripMenuItem";
            this.機能ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.機能ToolStripMenuItem.Text = "機能";
            // 
            // 時計ToolStripMenuItem
            // 
            this.時計ToolStripMenuItem.Name = "時計ToolStripMenuItem";
            this.時計ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.時計ToolStripMenuItem.Text = "時計";
            this.時計ToolStripMenuItem.Click += new System.EventHandler(this.時計ToolStripMenuItem_Click_1);
            // 
            // ストップウォッチToolStripMenuItem
            // 
            this.ストップウォッチToolStripMenuItem.Name = "ストップウォッチToolStripMenuItem";
            this.ストップウォッチToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ストップウォッチToolStripMenuItem.Text = "ストップウォッチ";
            this.ストップウォッチToolStripMenuItem.Click += new System.EventHandler(this.ストップウォッチToolStripMenuItem_Click_1);
            // 
            // タイマーToolStripMenuItem
            // 
            this.タイマーToolStripMenuItem.Name = "タイマーToolStripMenuItem";
            this.タイマーToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.タイマーToolStripMenuItem.Text = "タイマー";
            this.タイマーToolStripMenuItem.Click += new System.EventHandler(this.タイマーToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawClocks);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 種類ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アナログ時計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem デジタル時計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 砂時計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 機能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 時計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ストップウォッチToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem タイマーToolStripMenuItem;
    }
}


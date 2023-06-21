namespace lgsCallWebApiHttpClient01
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
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.textBoxWebApiKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWebApiUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox最短距離Km = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox主要距離Km = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox終点 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox起点 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.httpClient呼び出しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(106, 260);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(524, 19);
            this.textBoxError.TabIndex = 96;
            // 
            // textBoxWebApiKey
            // 
            this.textBoxWebApiKey.Location = new System.Drawing.Point(108, 57);
            this.textBoxWebApiKey.Name = "textBoxWebApiKey";
            this.textBoxWebApiKey.Size = new System.Drawing.Size(376, 19);
            this.textBoxWebApiKey.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 94;
            this.label7.Text = "WebApiKey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 93;
            this.label6.Text = "Error";
            // 
            // textBoxWebApiUrl
            // 
            this.textBoxWebApiUrl.Location = new System.Drawing.Point(111, 26);
            this.textBoxWebApiUrl.Name = "textBoxWebApiUrl";
            this.textBoxWebApiUrl.Size = new System.Drawing.Size(376, 19);
            this.textBoxWebApiUrl.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "WebApiURL";
            // 
            // textBox最短距離Km
            // 
            this.textBox最短距離Km.Location = new System.Drawing.Point(108, 215);
            this.textBox最短距離Km.Name = "textBox最短距離Km";
            this.textBox最短距離Km.Size = new System.Drawing.Size(97, 19);
            this.textBox最短距離Km.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 89;
            this.label4.Text = "最短距離Km";
            // 
            // textBox主要距離Km
            // 
            this.textBox主要距離Km.Location = new System.Drawing.Point(106, 173);
            this.textBox主要距離Km.Name = "textBox主要距離Km";
            this.textBox主要距離Km.Size = new System.Drawing.Size(100, 19);
            this.textBox主要距離Km.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 87;
            this.label3.Text = "主要距離Km";
            // 
            // textBox終点
            // 
            this.textBox終点.Location = new System.Drawing.Point(108, 133);
            this.textBox終点.Name = "textBox終点";
            this.textBox終点.Size = new System.Drawing.Size(105, 19);
            this.textBox終点.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 85;
            this.label2.Text = "終点";
            // 
            // textBox起点
            // 
            this.textBox起点.Location = new System.Drawing.Point(108, 88);
            this.textBox起点.Name = "textBox起点";
            this.textBox起点.Size = new System.Drawing.Size(106, 19);
            this.textBox起点.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 83;
            this.label1.Text = "起点";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpClient呼び出しToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // httpClient呼び出しToolStripMenuItem
            // 
            this.httpClient呼び出しToolStripMenuItem.Name = "httpClient呼び出しToolStripMenuItem";
            this.httpClient呼び出しToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.httpClient呼び出しToolStripMenuItem.Text = "HttpClient呼び出し";
            this.httpClient呼び出しToolStripMenuItem.Click += new System.EventHandler(this.httpClient呼び出しToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.textBoxWebApiKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWebApiUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox最短距離Km);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox主要距離Km);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox終点);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox起点);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TextBox textBoxWebApiKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWebApiUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox最短距離Km;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox主要距離Km;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox終点;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox起点;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem httpClient呼び出しToolStripMenuItem;
    }
}


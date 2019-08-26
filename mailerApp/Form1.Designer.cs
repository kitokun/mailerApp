namespace mailerApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.contain = new System.Windows.Forms.TextBox();
            this.toAddress = new System.Windows.Forms.TextBox();
            this.fromAddress = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(34, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(151, 22);
            this.title.TabIndex = 1;
            this.title.Text = "title";
            // 
            // contain
            // 
            this.contain.Location = new System.Drawing.Point(34, 113);
            this.contain.Multiline = true;
            this.contain.Name = "contain";
            this.contain.Size = new System.Drawing.Size(754, 325);
            this.contain.TabIndex = 2;
            this.contain.Text = "contain";
            // 
            // toAddress
            // 
            this.toAddress.Location = new System.Drawing.Point(191, 85);
            this.toAddress.Name = "toAddress";
            this.toAddress.Size = new System.Drawing.Size(213, 22);
            this.toAddress.TabIndex = 3;
            this.toAddress.Text = "to";
            // 
            // fromAddress
            // 
            this.fromAddress.Location = new System.Drawing.Point(410, 85);
            this.fromAddress.Name = "fromAddress";
            this.fromAddress.Size = new System.Drawing.Size(209, 22);
            this.fromAddress.TabIndex = 4;
            this.fromAddress.Text = "mine";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(625, 85);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(163, 22);
            this.password.TabIndex = 5;
            this.password.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.fromAddress);
            this.Controls.Add(this.toAddress);
            this.Controls.Add(this.contain);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox contain;
        private System.Windows.Forms.TextBox toAddress;
        private System.Windows.Forms.TextBox fromAddress;
        private System.Windows.Forms.TextBox password;
    }
}


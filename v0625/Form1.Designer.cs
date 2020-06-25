namespace v0625
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.mybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mybutton
            // 
            this.mybutton.BackColor = System.Drawing.Color.Aqua;
            this.mybutton.Font = new System.Drawing.Font("Minion Pro Cond", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mybutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mybutton.Location = new System.Drawing.Point(-10, 44);
            this.mybutton.Name = "mybutton";
            this.mybutton.Size = new System.Drawing.Size(298, 247);
            this.mybutton.TabIndex = 0;
            this.mybutton.Text = "10÷２＝";
            this.mybutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mybutton.UseVisualStyleBackColor = false;
            this.mybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.mybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mybutton;
    }
}


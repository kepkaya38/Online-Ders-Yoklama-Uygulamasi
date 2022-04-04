
namespace chatnumara
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbgelen = new System.Windows.Forms.RichTextBox();
            this.btnchat = new System.Windows.Forms.Button();
            this.btnisle = new System.Windows.Forms.Button();
            this.btnkay = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstyok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbgelen
            // 
            this.rtbgelen.Location = new System.Drawing.Point(24, 36);
            this.rtbgelen.Name = "rtbgelen";
            this.rtbgelen.Size = new System.Drawing.Size(264, 332);
            this.rtbgelen.TabIndex = 0;
            this.rtbgelen.Text = "";
            // 
            // btnchat
            // 
            this.btnchat.Location = new System.Drawing.Point(330, 73);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(143, 67);
            this.btnchat.TabIndex = 4;
            this.btnchat.Text = "Chat Dosyası";
            this.btnchat.UseVisualStyleBackColor = true;
            this.btnchat.Click += new System.EventHandler(this.btnchat_Click);
            // 
            // btnisle
            // 
            this.btnisle.Location = new System.Drawing.Point(330, 172);
            this.btnisle.Name = "btnisle";
            this.btnisle.Size = new System.Drawing.Size(143, 66);
            this.btnisle.TabIndex = 5;
            this.btnisle.Text = "Çevir";
            this.btnisle.UseVisualStyleBackColor = true;
            this.btnisle.Click += new System.EventHandler(this.btnisle_Click);
            // 
            // btnkay
            // 
            this.btnkay.Location = new System.Drawing.Point(330, 264);
            this.btnkay.Name = "btnkay";
            this.btnkay.Size = new System.Drawing.Size(143, 68);
            this.btnkay.TabIndex = 6;
            this.btnkay.Text = "Kaydet";
            this.btnkay.UseVisualStyleBackColor = true;
            this.btnkay.Click += new System.EventHandler(this.btnkay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 7;
            // 
            // lstyok
            // 
            this.lstyok.FormattingEnabled = true;
            this.lstyok.ItemHeight = 16;
            this.lstyok.Location = new System.Drawing.Point(542, 36);
            this.lstyok.Name = "lstyok";
            this.lstyok.Size = new System.Drawing.Size(246, 340);
            this.lstyok.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstyok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnkay);
            this.Controls.Add(this.btnisle);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.rtbgelen);
            this.Name = "Form1";
            this.Text = "Yoklama Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbgelen;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.Button btnisle;
        private System.Windows.Forms.Button btnkay;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstyok;
    }
}


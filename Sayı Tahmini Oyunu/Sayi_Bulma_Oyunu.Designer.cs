namespace Sayi_Tahmini_Oyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Sayını Gir (1-100)";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(269, 176);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahmin_KeyDown);
            // 
            // btnTahminet
            // 
            this.btnTahminet.Location = new System.Drawing.Point(284, 234);
            this.btnTahminet.Name = "btnTahminet";
            this.btnTahminet.Size = new System.Drawing.Size(75, 23);
            this.btnTahminet.TabIndex = 2;
            this.btnTahminet.Text = "Tahmin Et";
            this.btnTahminet.UseVisualStyleBackColor = true;
            this.btnTahminet.Click += new System.EventHandler(this.btnTahminet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTahminet);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahminet;
    }
}


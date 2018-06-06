namespace CSharpAES
{
    partial class FormAESTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAESKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAESIV = new System.Windows.Forms.TextBox();
            this.BtnGenIV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecrpt = new System.Windows.Forms.TextBox();
            this.BtnDecrpt = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(79, 181);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(409, 81);
            this.BtnEncrypt.TabIndex = 0;
            this.BtnEncrypt.Text = "加密";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "欲加密字串";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(167, 49);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(321, 25);
            this.txtSource.TabIndex = 2;
            this.txtSource.Text = "這是一個AES加解密測試程式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "加密KEY";
            // 
            // txtAESKEY
            // 
            this.txtAESKEY.Location = new System.Drawing.Point(167, 99);
            this.txtAESKEY.Name = "txtAESKEY";
            this.txtAESKEY.Size = new System.Drawing.Size(321, 25);
            this.txtAESKEY.TabIndex = 4;
            this.txtAESKEY.Text = "superlevin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "加密IV";
            // 
            // txtAESIV
            // 
            this.txtAESIV.Location = new System.Drawing.Point(167, 144);
            this.txtAESIV.Name = "txtAESIV";
            this.txtAESIV.Size = new System.Drawing.Size(321, 25);
            this.txtAESIV.TabIndex = 6;
            // 
            // BtnGenIV
            // 
            this.BtnGenIV.Location = new System.Drawing.Point(513, 135);
            this.BtnGenIV.Name = "BtnGenIV";
            this.BtnGenIV.Size = new System.Drawing.Size(170, 33);
            this.BtnGenIV.TabIndex = 7;
            this.BtnGenIV.Text = "自動產生IV";
            this.BtnGenIV.UseVisualStyleBackColor = true;
            this.BtnGenIV.Click += new System.EventHandler(this.BtnGenIV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "加密後字串";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "解密字串";
            // 
            // txtDecrpt
            // 
            this.txtDecrpt.Location = new System.Drawing.Point(173, 376);
            this.txtDecrpt.Name = "txtDecrpt";
            this.txtDecrpt.Size = new System.Drawing.Size(315, 25);
            this.txtDecrpt.TabIndex = 10;
            // 
            // BtnDecrpt
            // 
            this.BtnDecrpt.Location = new System.Drawing.Point(79, 310);
            this.BtnDecrpt.Name = "BtnDecrpt";
            this.BtnDecrpt.Size = new System.Drawing.Size(409, 60);
            this.BtnDecrpt.TabIndex = 11;
            this.BtnDecrpt.Text = "解密";
            this.BtnDecrpt.UseVisualStyleBackColor = true;
            this.BtnDecrpt.Click += new System.EventHandler(this.BtnDecrpt_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(173, 279);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(321, 25);
            this.txtEncrypted.TabIndex = 12;
            // 
            // FormAESTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 468);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.BtnDecrpt);
            this.Controls.Add(this.txtDecrpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGenIV);
            this.Controls.Add(this.txtAESIV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAESKEY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEncrypt);
            this.Name = "FormAESTest";
            this.Text = "AES加解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAESKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAESIV;
        private System.Windows.Forms.Button BtnGenIV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecrpt;
        private System.Windows.Forms.Button BtnDecrpt;
        private System.Windows.Forms.TextBox txtEncrypted;
    }
}


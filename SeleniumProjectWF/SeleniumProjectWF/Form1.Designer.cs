namespace SeleniumProjectWF
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
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textExpQ = new System.Windows.Forms.TextBox();
            this.buttBrowser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textRealQ = new System.Windows.Forms.TextBox();
            this.buttExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(172, 52);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(179, 20);
            this.textUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exp Qnt. Vacancies";
            // 
            // textExpQ
            // 
            this.textExpQ.Location = new System.Drawing.Point(39, 245);
            this.textExpQ.Name = "textExpQ";
            this.textExpQ.Size = new System.Drawing.Size(141, 20);
            this.textExpQ.TabIndex = 6;
            // 
            // buttBrowser
            // 
            this.buttBrowser.BackColor = System.Drawing.Color.LimeGreen;
            this.buttBrowser.FlatAppearance.BorderSize = 0;
            this.buttBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttBrowser.Location = new System.Drawing.Point(213, 173);
            this.buttBrowser.Name = "buttBrowser";
            this.buttBrowser.Size = new System.Drawing.Size(100, 21);
            this.buttBrowser.TabIndex = 8;
            this.buttBrowser.Text = "Run";
            this.buttBrowser.UseVisualStyleBackColor = false;
            this.buttBrowser.Click += new System.EventHandler(this.buttBrowser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Real Qnt. Vacancies";
            // 
            // textRealQ
            // 
            this.textRealQ.Location = new System.Drawing.Point(351, 109);
            this.textRealQ.Name = "textRealQ";
            this.textRealQ.Size = new System.Drawing.Size(141, 20);
            this.textRealQ.TabIndex = 9;
            // 
            // buttExit
            // 
            this.buttExit.Location = new System.Drawing.Point(213, 240);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(100, 25);
            this.buttExit.TabIndex = 11;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(351, 176);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(141, 89);
            this.textResult.TabIndex = 12;
            // 
            // comboCountry
            // 
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(39, 108);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(141, 21);
            this.comboCountry.TabIndex = 15;
            // 
            // comboLang
            // 
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(39, 174);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(141, 21);
            this.comboLang.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 322);
            this.Controls.Add(this.comboLang);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textRealQ);
            this.Controls.Add(this.buttBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textExpQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUrl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test veem.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textExpQ;
        private System.Windows.Forms.Button buttBrowser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRealQ;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.ComboBox comboLang;
    }
}


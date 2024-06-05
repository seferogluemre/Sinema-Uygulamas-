
namespace Sinema_Uygulaması
{
    partial class ÜYE_GİRİŞİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜYE_GİRİŞİ));
            this.textADSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butonGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxŞİFRE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textADSOYAD
            // 
            this.textADSOYAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textADSOYAD.Location = new System.Drawing.Point(242, 81);
            this.textADSOYAD.Margin = new System.Windows.Forms.Padding(5);
            this.textADSOYAD.Name = "textADSOYAD";
            this.textADSOYAD.Size = new System.Drawing.Size(310, 29);
            this.textADSOYAD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(172, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(108, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "İSİM SOYİSİM";
            // 
            // butonGiris
            // 
            this.butonGiris.BackColor = System.Drawing.Color.Peru;
            this.butonGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonGiris.ForeColor = System.Drawing.Color.White;
            this.butonGiris.Location = new System.Drawing.Point(279, 199);
            this.butonGiris.Margin = new System.Windows.Forms.Padding(5);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(154, 47);
            this.butonGiris.TabIndex = 3;
            this.butonGiris.Text = "GİRİŞ YAP";
            this.butonGiris.UseVisualStyleBackColor = false;
            this.butonGiris.Click += new System.EventHandler(this.butonGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÜYE GİRİŞ PANELİ";
            // 
            // textBoxŞİFRE
            // 
            this.textBoxŞİFRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxŞİFRE.Location = new System.Drawing.Point(242, 147);
            this.textBoxŞİFRE.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxŞİFRE.Name = "textBoxŞİFRE";
            this.textBoxŞİFRE.Size = new System.Drawing.Size(310, 29);
            this.textBoxŞİFRE.TabIndex = 2;
            // 
            // ÜYE_GİRİŞİ
            // 
            this.AcceptButton = this.butonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 318);
            this.Controls.Add(this.textBoxŞİFRE);
            this.Controls.Add(this.textADSOYAD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butonGiris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ÜYE_GİRİŞİ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYE GİRİŞİ";
            this.Load += new System.EventHandler(this.ÜYE_GİRİŞİ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textADSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxŞİFRE;
    }
}
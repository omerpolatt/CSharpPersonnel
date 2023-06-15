namespace PersonelUygulaması
{
    partial class GirişFormuPersonel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullanıcıadı = new System.Windows.Forms.TextBox();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.btngiriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞİFRE:";
            // 
            // txtkullanıcıadı
            // 
            this.txtkullanıcıadı.Location = new System.Drawing.Point(358, 87);
            this.txtkullanıcıadı.Name = "txtkullanıcıadı";
            this.txtkullanıcıadı.Size = new System.Drawing.Size(223, 29);
            this.txtkullanıcıadı.TabIndex = 1;
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(358, 136);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(223, 29);
            this.txtşifre.TabIndex = 1;
            this.txtşifre.UseSystemPasswordChar = true;
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(384, 184);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(150, 42);
            this.btngiriş.TabIndex = 2;
            this.btngiriş.Text = "GİRİŞ YAP";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(57, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "PERSONEL TAKİP  GİRİŞ PANELİ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(600, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 27);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Görünürlük";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GirişFormuPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(762, 292);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.txtkullanıcıadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GirişFormuPersonel";
            this.Text = "GirişFormuPersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullanıcıadı;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
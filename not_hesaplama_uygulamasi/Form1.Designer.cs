namespace not_hesaplama_uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gecme_notu_txt = new TextBox();
            vize_etkisi_txt = new TextBox();
            final_etkisi_txt = new TextBox();
            vize_notu_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            odev1_Etkisi_txt = new TextBox();
            odev2_etkisi_txt = new TextBox();
            odev3_etkisi_txt = new TextBox();
            odev1_notu_txt = new TextBox();
            odev2_notu_txt = new TextBox();
            odev3_notu_Txt = new TextBox();
            final_min_not = new Label();
            hesapla_btn = new Button();
            SuspendLayout();
            // 
            // gecme_notu_txt
            // 
            gecme_notu_txt.Location = new Point(47, 59);
            gecme_notu_txt.Name = "gecme_notu_txt";
            gecme_notu_txt.Size = new Size(125, 27);
            gecme_notu_txt.TabIndex = 0;
            gecme_notu_txt.TextChanged += gecme_notu_txt_TextChanged;
            // 
            // vize_etkisi_txt
            // 
            vize_etkisi_txt.Location = new Point(47, 147);
            vize_etkisi_txt.Name = "vize_etkisi_txt";
            vize_etkisi_txt.Size = new Size(125, 27);
            vize_etkisi_txt.TabIndex = 1;
            vize_etkisi_txt.TextChanged += vize_etkisi_txt_TextChanged;
            // 
            // final_etkisi_txt
            // 
            final_etkisi_txt.Location = new Point(47, 235);
            final_etkisi_txt.Name = "final_etkisi_txt";
            final_etkisi_txt.Size = new Size(125, 27);
            final_etkisi_txt.TabIndex = 2;
            final_etkisi_txt.TextChanged += final_etkisi_txt_TextChanged;
            // 
            // vize_notu_txt
            // 
            vize_notu_txt.Location = new Point(151, 361);
            vize_notu_txt.Name = "vize_notu_txt";
            vize_notu_txt.Size = new Size(125, 27);
            vize_notu_txt.TabIndex = 3;
            vize_notu_txt.TextChanged += vize_notu_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 124);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 4;
            label1.Text = "Vize Etkisi (%)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 212);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Final Etkisi (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 36);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 6;
            label3.Text = "Geçme Notu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 364);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 7;
            label4.Text = "Vize Notunuz : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 383);
            label5.Name = "label5";
            label5.Size = new Size(288, 20);
            label5.TabIndex = 8;
            label5.Text = "Finalden Almanız Gereken Minimum Not : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 36);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 9;
            label6.Text = "Ödev 1 Etkisi (%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 124);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 10;
            label7.Text = "Ödev 2 Etkisi (%)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 212);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 11;
            label8.Text = "Ödev 3 Etkisi (%)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 36);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 12;
            label9.Text = "Ödev 1 Notunuz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(551, 124);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 13;
            label10.Text = "Ödev 2 Notunuz";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(551, 212);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 14;
            label11.Text = "Ödev 3 Notunuz";
            // 
            // odev1_Etkisi_txt
            // 
            odev1_Etkisi_txt.Location = new Point(303, 59);
            odev1_Etkisi_txt.Name = "odev1_Etkisi_txt";
            odev1_Etkisi_txt.Size = new Size(125, 27);
            odev1_Etkisi_txt.TabIndex = 15;
            odev1_Etkisi_txt.TextChanged += odev1_Etkisi_txt_TextChanged;
            // 
            // odev2_etkisi_txt
            // 
            odev2_etkisi_txt.Location = new Point(303, 147);
            odev2_etkisi_txt.Name = "odev2_etkisi_txt";
            odev2_etkisi_txt.Size = new Size(125, 27);
            odev2_etkisi_txt.TabIndex = 16;
            odev2_etkisi_txt.TextChanged += odev2_etkisi_txt_TextChanged;
            // 
            // odev3_etkisi_txt
            // 
            odev3_etkisi_txt.Location = new Point(303, 235);
            odev3_etkisi_txt.Name = "odev3_etkisi_txt";
            odev3_etkisi_txt.Size = new Size(125, 27);
            odev3_etkisi_txt.TabIndex = 17;
            odev3_etkisi_txt.TextChanged += odev3_etkisi_txt_TextChanged;
            // 
            // odev1_notu_txt
            // 
            odev1_notu_txt.Location = new Point(542, 59);
            odev1_notu_txt.Name = "odev1_notu_txt";
            odev1_notu_txt.Size = new Size(125, 27);
            odev1_notu_txt.TabIndex = 18;
            odev1_notu_txt.TextChanged += odev1_notu_txt_TextChanged;
            // 
            // odev2_notu_txt
            // 
            odev2_notu_txt.Location = new Point(542, 147);
            odev2_notu_txt.Name = "odev2_notu_txt";
            odev2_notu_txt.Size = new Size(125, 27);
            odev2_notu_txt.TabIndex = 19;
            odev2_notu_txt.TextChanged += odev2_notu_txt_TextChanged;
            // 
            // odev3_notu_Txt
            // 
            odev3_notu_Txt.Location = new Point(542, 235);
            odev3_notu_Txt.Name = "odev3_notu_Txt";
            odev3_notu_Txt.Size = new Size(125, 27);
            odev3_notu_Txt.TabIndex = 20;
            odev3_notu_Txt.TextChanged += odev3_notu_Txt_TextChanged;
            // 
            // final_min_not
            // 
            final_min_not.AutoSize = true;
            final_min_not.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            final_min_not.Location = new Point(502, 416);
            final_min_not.Name = "final_min_not";
            final_min_not.Size = new Size(27, 31);
            final_min_not.TabIndex = 21;
            final_min_not.Text = "0";
            final_min_not.TextAlign = ContentAlignment.TopCenter;
            // 
            // hesapla_btn
            // 
            hesapla_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hesapla_btn.Location = new Point(454, 309);
            hesapla_btn.Name = "hesapla_btn";
            hesapla_btn.Size = new Size(123, 45);
            hesapla_btn.TabIndex = 22;
            hesapla_btn.Text = "HESAPLA";
            hesapla_btn.UseVisualStyleBackColor = true;
            hesapla_btn.Click += hesapla_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 478);
            Controls.Add(hesapla_btn);
            Controls.Add(final_min_not);
            Controls.Add(odev3_notu_Txt);
            Controls.Add(odev2_notu_txt);
            Controls.Add(odev1_notu_txt);
            Controls.Add(odev3_etkisi_txt);
            Controls.Add(odev2_etkisi_txt);
            Controls.Add(odev1_Etkisi_txt);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vize_notu_txt);
            Controls.Add(final_etkisi_txt);
            Controls.Add(vize_etkisi_txt);
            Controls.Add(gecme_notu_txt);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Not Hesaplama Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gecme_notu_txt;
        private TextBox vize_etkisi_txt;
        private TextBox final_etkisi_txt;
        private TextBox vize_notu_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox odev1_Etkisi_txt;
        private TextBox odev2_etkisi_txt;
        private TextBox odev3_etkisi_txt;
        private TextBox odev1_notu_txt;
        private TextBox odev2_notu_txt;
        private TextBox odev3_notu_Txt;
        private Label final_min_not;
        private Button hesapla_btn;
    }
}

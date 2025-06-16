using System.Windows.Forms.VisualStyles;

namespace not_hesaplama_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gecme_notu_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void vize_etkisi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void final_etkisi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev1_Etkisi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev2_etkisi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev3_etkisi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev1_notu_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev2_notu_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void odev3_notu_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void vize_notu_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            //TextBox'lardan deðerleri alalým
            double gecmeNotu = double.Parse(gecme_notu_txt.Text);
            double vizeEtkisi = double.Parse(vize_etkisi_txt.Text);
            double finalEtkisi = double.Parse(final_etkisi_txt.Text);
            double odev1Etkisi = string.IsNullOrWhiteSpace(odev1_Etkisi_txt.Text) ? 0 : double.Parse(odev1_Etkisi_txt.Text);
            double odev2Etkisi = string.IsNullOrWhiteSpace(odev2_etkisi_txt.Text) ? 0 : double.Parse(odev2_etkisi_txt.Text);
            double odev3Etkisi = string.IsNullOrWhiteSpace(odev3_etkisi_txt.Text) ? 0 : double.Parse(odev3_etkisi_txt.Text);
            double odev1Not = string.IsNullOrWhiteSpace(odev1_notu_txt.Text) ? 0 : double.Parse(odev1_notu_txt.Text);
            double odev2Not = string.IsNullOrWhiteSpace(odev2_notu_txt.Text) ? 0 : double.Parse(odev2_notu_txt.Text);
            double odev3Not = string.IsNullOrWhiteSpace(odev3_notu_Txt.Text) ? 0 : double.Parse(odev3_notu_Txt.Text);
            double vizeNot = double.Parse(vize_notu_txt.Text);

            //Yüzde hesabý
            double toplam = vizeNot * (vizeEtkisi / 100)
            + odev1Not * (odev1Etkisi / 100)
            + odev2Not * (odev2Etkisi / 100)
            + odev3Not * (odev3Etkisi / 100);

            //Finalde minimum kaç almalý hesabý
            double final = (gecmeNotu - toplam) / (finalEtkisi / 100);

            //Sonucu yazdýr
            if (final < 0)
            {
                final_min_not.Text = $"Zaten geçmiþsiniz!";
            }
            else if (final > 100) 
            {
                final_min_not.Text = $"100";
            }
            else
            {
                final_min_not.Text = $"{final:F2}";
            }
            
            
        }
    }
}

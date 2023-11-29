namespace KitapForm
{
    public partial class Form1 : Form
    {
        string secilenKategori = "";
        string secilenYayinevi = "";
        List<Kitap> kitapListesi = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Add("Roman");
            cmbKategori.Items.Add("Öykü");
            cmbKategori.Items.Add("Bilim Kurgu");

            cmbYayinevi.Items.Add("Ýthaki");
            cmbYayinevi.Items.Add("Can");
            cmbYayinevi.Items.Add("YKY");
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(secilenKategori, txtKitapAdi.Text, txtYazar.Text, secilenYayinevi, Convert.ToInt32(txtSayfa.Text), Convert.ToInt32(txtFiyat.Text));
            kitapListesi.Add(kitap);
            ListeyeEkle();
        }

        public void ListeyeEkle()
        {
            Kitaplar.Items.Clear();
            int toplamFiyat = 0;
            foreach (Kitap kitap in kitapListesi)
            {
                Kitaplar.Items.Add("Kitabýn kategorisi: " + kitap.Kategori + " Kitabýn adý: " + kitap.yazari + " Yazarý: " + kitap.yazari + " Yayýnevi: " + kitap.yayinevi + " Sayfa Sayýsý" + kitap.sayfaSayisi + " Fiyatý: " + kitap.fiyat);
                toplamFiyat += kitap.fiyat;
            }
            lblToplam.Text = "Toplam Fiyat: " + toplamFiyat;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategori = cmbKategori.SelectedItem.ToString();
        }

        private void cmbYayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYayinevi = cmbKategori.SelectedItem.ToString();
        }
    }
}
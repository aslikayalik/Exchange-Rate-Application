using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Jsonkurgu_Click(object sender, EventArgs e)
        {
           // Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
           // BLL.KurBilgileriniGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Formumuz load olduğunda ilk olarak ne yapmalıyız :
            // core ın içerisindeki BusinessLogicLayer ı yine BLL olarak örnekleyelim ve para birimlerini
            // çekelim.
            Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer(); // önce businessLogicLayer a bir instance oluşturdum.
            BLL.KurBilgileriniGuncelle(); // KurGeçmiş tarafına benim bir önceki değerlerimin kayıtlı olması gerekiyor.
            List<Entities.ParaBirimi> ParaBirimleri = BLL.ParaBirimiListesi(); // ParaBirimlerini bir list genreic üstüne aldım.
            List<Entities.Kur> KurBilgileri = BLL.KurListe(); // o an geçerli olan kurlarımın listesini çektim.
             // KurBilgileri içerisinde paraBirim id si var, id yi bilemeyeceğime göre çünkü guid, paraBiriminin koduna göre 
             // select atmam gerekiyor.
            Entities.Kur Dolar = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(x => x.Code == "USD").ID);
            // Her bir kaydı I olarak isimlendiriyorum, her bir kaydın içeriisndeki ParaBirimiID eşit ise ParaBirimleri
            // listemin içeriisnde yine bir arama yapıyorum FirstOrDefault ile, Parabirimleri içerisinde code u USD olan datanın 
            // ID sine eşit ise Dolar ın tiplerinin verileri bu Dolar içinde duracak.
            lbl_dolar_alis.Text = Dolar.Alis.ToString(); // Dolar değerini decimal ın N2 formatına göre ekrana yazdırdım.
            lbl_dolar_satis.Text = Dolar.Satis.ToString(); // Burada parantez içinde N2 vardı onları sildik yuvarlamaya sebep
            // oluyor diye.


            Entities.Kur Euro = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(x => x.Code == "EUR").ID);
            lbl_euro_alis.Text = Euro.Alis.ToString();
            lbl_euro_satis.Text = Euro.Satis.ToString();


            Entities.Kur Sterlin = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(x => x.Code == "STR").ID);
            lbl_sterlin_alis.Text = Sterlin.Alis.ToString();
            lbl_sterlin_satis.Text = Sterlin.Satis.ToString();

            grd_kurgecmis.DataSource = BLL.KurGecmisGoruntule();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void grd_kurgecmis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

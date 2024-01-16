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
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            Core.BusinessLogicLayer BLL = new Core.BusinessLogicLayer();
            BLL.KurBilgileriniGuncelle();
            List<Entities.ParaBirimi> ParaBirimleri = BLL.ParaBirimiListesi(); 
            List<Entities.Kur> KurBilgileri = BLL.KurListe(); .
         
            Entities.Kur Dolar = KurBilgileri.FirstOrDefault(I => I.ParaBirimiID == ParaBirimleri.FirstOrDefault(x => x.Code == "USD").ID);
    
            lbl_dolar_alis.Text = Dolar.Alis.ToString(); 
            lbl_dolar_satis.Text = Dolar.Satis.ToString(); 

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

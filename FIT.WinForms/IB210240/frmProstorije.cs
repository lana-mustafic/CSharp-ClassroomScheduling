using FIT.Data.IB210240;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB210240
{
    public partial class frmProstorije : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prostorija> podaciProstorije=new List<Prostorija>();   
        public frmProstorije()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            podaciProstorije = db.Prostorije.ToList();

            DataTable dt=new DataTable();
            dt.Columns.Add("Logo", typeof(Image));
            dt.Columns.Add("Naziv");
            dt.Columns.Add("Oznaka");
            dt.Columns.Add("Kapacitet");
            dt.Columns.Add("BrojPredmeta");

            for (int i = 0; i < podaciProstorije.Count; i++)
            {
                var red = dt.NewRow();
                var prostorija=podaciProstorije[i];

                red["Logo"] = Helpers.Ekstenzije.ToImage(prostorija.Logo);
                red["Naziv"] = prostorija.ToString();
                red["Oznaka"] = prostorija.Oznaka.ToString();
                red["Kapacitet"] = prostorija.Kapacitet.ToString();
                red["BrojPredmeta"]=db.Nastava.Count(x=>x.ProstorijaId==prostorija.Id);

                dt.Rows.Add(red);
            }
            dgvProstorije.DataSource = dt;
        }

        private void frmProstorije_Load(object sender, EventArgs e)
        {
            this.Text = $"Prostorije";
            dgvProstorije.AutoGenerateColumns = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Cetak_Data : Form
    {
        SqlConnection conn = new SqlConnection(DAL.GetConnectionString());
        SqlDataAdapter da;
        DataTable dtMahasiswa;


        string prodi { get; set; }

        DateTime tglmasuk { get; set; }


        public Cetak_Data(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();

            

        }
    }
}

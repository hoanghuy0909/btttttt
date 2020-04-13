using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace baitapnhom
{
    public partial class frmbaocaosachtruyen : Form
    {
        public frmbaocaosachtruyen()
        {
            InitializeComponent();
        }

        private void frmbaocaosachtruyen_Load(object sender, EventArgs e)
        {
            DAO.connect();
            string sql = "select masach,tensach,maloaisach from sachtruyen   where exists (select masach from chitietthuesach where chitietthuesach.masach = sachtruyen.masach)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

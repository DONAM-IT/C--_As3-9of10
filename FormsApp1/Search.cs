using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public void AddEmployeeInfo(params String[] values)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(tblSearchPage);
            for (int i = 0; i < r.Cells.Count; i++)
            {
                //DataGridViewRow r = new DataGridViewRow();
                //r.CreateCells(tblSearchPage);
                r.Cells[i].Value = values[i];
            }
            tblSearchPage.Rows.Add(r);
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}

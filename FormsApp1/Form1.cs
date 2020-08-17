using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ValidateInput()
        {
            string name = txtMaSP.Text.Trim();
            bool bError = false;
            if (name.Length == 0)
            {
                errorProvider1.SetError(txtMaSP, "Please enter your Ma SP!");
                bError = true;
            }
            if (radChai.Checked == false && radThung.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "Please select Đơn Vị!");
                bError = true;
            }
            if (cbNoiSanXuat.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbNoiSanXuat,
                    "please select Nơi sản xuất!");
                bError = true;
            }
            if (bError == true)
            {
                return false;
            }
            else
                errorProvider1.Clear();
            return true;
        }
        void AddNewSanPham()
        {
            String donVi = "";
            if (radThung.Checked == true)
                donVi = "Thùng";
            else if (radChai.Checked == true) donVi = "Chai";
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgEmployees);
            r.SetValues(txtMaSP.Text, txtTenSP.Text,
               txtSoLuong.Text,
                donVi, dTPDOB.Value.ToShortDateString(), cbNoiSanXuat.Text,
                txtGia.Text);
            dgEmployees.Rows.Add(r);
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            //reset
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            dTPDOB.Value = DateTime.Now;
            radChai.Checked = false;
            radThung.Checked = false;
            cbNoiSanXuat.SelectedIndex = -1;
            
            //Active/Deactive
            BtnAdd.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false)
                return;
            AddNewSanPham();
            BtnAdd.Enabled = false;
        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
            //?????
            //reset
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            dTPDOB.Value = DateTime.Now;
            radChai.Checked = false;
            radThung.Checked = false;
            cbNoiSanXuat.SelectedIndex = -1;

            //Active/Deactive
            BtnAdd.Enabled = true;
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn dừng chương trình này? Nếu đúng, cảm ơn bạn đã sử dụng phần mềm ^^ !", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit(); // đóng toàn bộ chương trình          
            }
        }

        private void BtnLoadfromFile_Click_1(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "Data files|*.dat|Text files|*.txt||*.dBoth filesat;*.txt";
            openFileDialog1.Filter = "Data files|*.dat|Text files|*.txt|Both files|*.dat;*.txt|All files|*.*";
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult rs = openFileDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fileName);
                string Line = sr.ReadLine();
                while ((Line != null) && (Line != " "))
                {
                    string[] array = Line.Split(';');
                    dgEmployees.Rows.Add(array);
                    Line = sr.ReadLine();
                }
                sr.Close();
            }
        }

        private void BtnSavetoFile_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // saveFileDialog1.Filter = "Data files|*.dat|Text files|*.txt|Both files|*.dat;*.txt";
            DialogResult rs = saveFileDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fileName);
                string Line = "";
                for (int i = 0; i < dgEmployees.Rows.Count - 0; ++i)
                {
                    if (i == dgEmployees.NewRowIndex)
                    {
                        break;
                    }
                    Line = "";
                    for (int j = 0; j < dgEmployees.Columns.Count; ++j)
                    {
                        Line += dgEmployees[j, i].Value + ";";
                    }
                    //sw.WriteLine();
                    sw.WriteLine(Line);
                }
                sw.Close();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
         
                Search frm = new Search();
                for (int i = 0; i < dgEmployees.Rows.Count; i++)
                {
                    DataGridViewRow r = dgEmployees.Rows[i];
                    if (r.Cells[1].Value.ToString().ToUpper().Contains(txtTenSP.Text.ToUpper()))
                    {
                    frm.AddEmployeeInfo(r.Cells[0].Value.ToString(),
                    r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(),
                    r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(),
                    r.Cells[5].Value.ToString(), r.Cells[6].Value.ToString());
             
                    }
                }
            frm.ShowDialog();


        }


        private void dgEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            else
            {
                String donVi = "";
                txtMaSP.Text = dgEmployees.Rows[index].Cells[0].Value.ToString();
                txtTenSP.Text = dgEmployees.Rows[index].Cells[1].Value.ToString();
                txtSoLuong.Text = dgEmployees.Rows[index].Cells[2].Value.ToString();
                //if (radThung.Checked == true)
                //    donVi = "Thùng";
                //else if (radChai.Checked == true) donVi = "Chai";
                //ấy, cái này khoai ;v
                dTPDOB.Text = dgEmployees.Rows[index].Cells[4].Value.ToString();
                cbNoiSanXuat.Text = dgEmployees.Rows[index].Cells[5].Value.ToString();
                txtGia.Text = dgEmployees.Rows[index].Cells[6].Value.ToString();
                if (dgEmployees.Rows[index].Cells[3].Value.ToString().Equals("Chai"))
                {
                    radChai.Select();
                }
                else
                {
                    radThung.Select();
                }
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gui
{
    public partial class San_Pham : Form
    {
        SanphamServices sv = new SanphamServices();
        private int idOfedit;

        public San_Pham()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            dtagrv.ColumnCount = 7;
            dtagrv.Columns[0].Name = "Stt";
            dtagrv.Columns[1].Name = "Ten";
            dtagrv.Columns[2].Name = "Mo ta";
            dtagrv.Columns[3].Name = "So luong ton";
            dtagrv.Columns[4].Name = "gia tien";
            dtagrv.Columns[5].Name = "ten Ncc";
            dtagrv.Columns[6].Name = "Id";
            dtagrv.Columns[6].Visible = false;
            dtagrv.Rows.Clear();
            int stt = 0;
            foreach (var item in sv.GetSanphams())
            {
                stt++;
                var ncc = sv.GetNhacungcap().Where(a => a.Id == item.IdNcc).Select(b => b.Ten).FirstOrDefault();
                dtagrv.Rows.Add(stt, item.Ten, item.Mota, item.Soluongtonkho, item.Giatien, ncc, item.Id);
            }
            CbbNcc.Items.Clear();
            foreach (var item in sv.GetNhacungcap())
            {
                CbbNcc.Items.Add(item.Ten);
            }
        }
        public void Clear()
        {
            txtSp.Clear();
            txtMota.Clear();
            TxtSoluongton.Clear();
            TxtSotien.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Ncc = sv.GetNhacungcap().Where(a => a.Ten == CbbNcc.Text).Select(b => b.Id).FirstOrDefault();
                sv.Add(txtSp.Text, txtMota.Text, Convert.ToInt32(TxtSoluongton.Text), Convert.ToInt32(TxtSotien.Text), Ncc);
                Load();
                Clear();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtagrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < sv.GetNhacungcap().Count)
            {
                DataGridViewRow r = dtagrv.Rows[e.RowIndex];
                txtSp.Text = r.Cells[1].Value.ToString();
                txtMota.Text = r.Cells[2].Value.ToString();
                TxtSoluongton.Text = r.Cells[3].Value.ToString();
                TxtSotien.Text = r.Cells[4].Value.ToString();
                CbbNcc.Text = r.Cells[5].Value.ToString();
                idOfedit = int.Parse(r.Cells[6].Value.ToString());

            }
            else
            {
                Clear();
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                int Ncc = sv.GetNhacungcap().Where(a => a.Ten == CbbNcc.Text).Select(b => b.Id).FirstOrDefault();
                sv.Update(idOfedit, txtSp.Text, txtMota.Text, Convert.ToInt32(TxtSoluongton.Text), Convert.ToInt32(TxtSotien.Text), Ncc);
                Load();
                Clear();
                MessageBox.Show("UpDate thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn chắc chắn muốn xóa?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                sv.Delete(idOfedit);
                MessageBox.Show("xóa r nha");
                Load();
                Clear();
            }
        }

        private void txtSe_TextChanged(object sender, EventArgs e)
        {

            var seach = sv.GetSanphams().Where(a => a.Ten.Contains(txtSe.Text) || sv.GetNhacungcap()
            .Any(b => b.Id == a.IdNcc && b.Diachi.Contains(txtSe.Text))).ToList();
            dtagrv.Rows.Clear();
            int stt = 0;
            foreach (var item in seach)
            {
                stt++;
                var ncc = sv.GetNhacungcap().Where(a => a.Id == item.IdNcc).Select(b => b.Ten).FirstOrDefault();
                dtagrv.Rows.Add(stt, item.Ten, item.Mota, item.Soluongtonkho, item.Giatien, ncc, item.Id);
            }
        }      
    }
}

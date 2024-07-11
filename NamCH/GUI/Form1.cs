using BUS.IService;
using BUS.Service;
using DAL.DomainClass;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Devices;

namespace GUI
{
    public partial class Form1 : Form
    {
        int IdCell = -1;
        private readonly ITrungTamService _TTService;
        private readonly ICuaHangService _CHService;
        public Form1(ITrungTamService TTService, ICuaHangService CHService)
        {
            InitializeComponent();
            _TTService = TTService;
            _CHService = CHService;
            LoadGrid();
            LoadCbb();
            LoadCbbtt();
        }
        void LoadCbb()
        {
            foreach (var item in _TTService.GetTrungTam())
            {
                cbbDiaChi.Items.Add(item.Diachi);
            }
        }
        void LoadCbbtt()
        {
            foreach (var item in _TTService.GetTrungTam())
            {
                cbbTrungTam.Items.Add(item.Ten);
            }
        }
        void LoadGrid()
        {
            dtgDanhSach.ColumnCount = 8;
            dtgDanhSach.Columns[0].Name = "STT";
            dtgDanhSach.Columns[1].Name = "Tên";
            dtgDanhSach.Columns[2].Name = "Mô Tả";
            dtgDanhSach.Columns[3].Name = "Loại Hàng";
            dtgDanhSach.Columns[4].Name = "Ngày Đăng Ký";
            dtgDanhSach.Columns[5].Name = "Địa Chỉ";
            dtgDanhSach.Columns[6].Name = "Id";
            dtgDanhSach.Columns[7].Name = "Tên Trung Tâm";
            dtgDanhSach.Columns[6].Visible = false;
            dtgDanhSach.Rows.Clear();
            int count = 0;
            foreach (var item in _CHService.GetLstCuaHang())
            {
                count++;
                dtgDanhSach.Rows.Add(count, item.Ten, item.Mota
                    , item.Loaihang, item.Ngaydangky, _TTService.GetTrungTam()
                    .Where(x => x.Id == item.IdCn).Select(x => x.Diachi).FirstOrDefault(), item.Id,
                    _TTService.GetTrungTam()
                    .Where(x => x.Id == item.IdCn).Select(x => x.Ten).FirstOrDefault());
            }

        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txtLoaiHang.Clear();
            txtMoTa.Clear();
            txtTen.Clear();
            dtNgayDangKy.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn Có Muốn Add Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                var CuaHang = new Cuahang()
                {
                    Ten = txtTen.Text,
                    Mota = txtMoTa.Text,
                    Loaihang = txtLoaiHang.Text,
                    Ngaydangky = DateOnly.Parse(dtNgayDangKy.Text),
                    IdCn = _TTService.GetTrungTam().Where(x => x.Diachi == cbbDiaChi.Text).Select(x => x.Id).FirstOrDefault()
                };
                _CHService.Add(CuaHang);
                MessageBox.Show("Add Thành Công", "Thông Báo");
                LoadGrid();
                Clear();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void dtgDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selected = dtgDanhSach.SelectedRows[0];
                txtTen.Text = selected.Cells[1].Value?.ToString() ?? "";
                txtMoTa.Text = selected.Cells[2].Value?.ToString() ?? "";
                txtLoaiHang.Text = selected.Cells[3].Value?.ToString() ?? "";
                dtNgayDangKy.Text = selected.Cells[4].Value?.ToString() ?? "";
                cbbDiaChi.Text = selected.Cells[5].Value?.ToString() ?? "";
                cbbTrungTam.Text = selected.Cells[7].Value?.ToString() ?? "";
                IdCell = Convert.ToInt32(selected.Cells[6].Value?.ToString() ?? "");
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Xóa Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            var exists = _CHService.GetLstCuaHang().Any(x => x.Id == IdCell);
            if (!exists)
            {
                MessageBox.Show("ID Không Tồn Tại");
                return;
            }
            _CHService.Remove(IdCell);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            LoadGrid();
            Clear();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn Có Muốn Update Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                var exists = _CHService.GetLstCuaHang().Any(x => x.Id == IdCell);
                if (!exists)
                {
                    MessageBox.Show("ID Không Tồn Tại");
                    return;
                }
                var CuaHang = new Cuahang()
                {
                    Id = IdCell,
                    Ten = txtTen.Text,
                    Mota = txtMoTa.Text,
                    Loaihang = txtLoaiHang.Text,
                    Ngaydangky = DateOnly.Parse(dtNgayDangKy.Text),
                    IdCn = _TTService.GetTrungTam().Where(x => x.Diachi == cbbDiaChi.Text).Select(x => x.Id).FirstOrDefault()
                };
                _CHService.Update(CuaHang);
                MessageBox.Show("Update Thành Công", "Thông Báo");
                LoadGrid();
                Clear();
            }
            catch (Exception)
            {

                return;
            }
        }
        void LoadGrid(string KeyWord)
        {
            dtgDanhSach.ColumnCount = 8;
            dtgDanhSach.Columns[0].Name = "STT";
            dtgDanhSach.Columns[1].Name = "Tên";
            dtgDanhSach.Columns[2].Name = "Mô Tả";
            dtgDanhSach.Columns[3].Name = "Loại Hàng";
            dtgDanhSach.Columns[4].Name = "Ngày Đăng Ký";
            dtgDanhSach.Columns[5].Name = "Địa Chỉ";
            dtgDanhSach.Columns[6].Name = "Id";
            dtgDanhSach.Columns[7].Name = "Tên Trung Tâm";
            dtgDanhSach.Columns[6].Visible = false;
            dtgDanhSach.Rows.Clear();
            int count = 0;
            foreach (var item in _CHService.Search(KeyWord))
            {
                count++;
                dtgDanhSach.Rows.Add(count, item.Ten, item.Mota
                    , item.Loaihang, item.Ngaydangky, _TTService.GetTrungTam()
                    .Where(x => x.Id == item.IdCn).Select(x => x.Diachi).FirstOrDefault(), item.Id,
                    _TTService.GetTrungTam()
                    .Where(x => x.Id == item.IdCn).Select(x => x.Ten).FirstOrDefault());
            }

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtSearch.Text);
        }

        private void txtLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
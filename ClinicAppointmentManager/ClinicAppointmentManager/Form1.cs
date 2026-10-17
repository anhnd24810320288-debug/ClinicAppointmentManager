using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace ClinicAppointmentManager
{
    public partial class Form1 : Form
    {
        private readonly BindingList<LichHen> danhSach = new();
        private readonly BindingSource bindingSource = new();

        public Form1()
        {
            InitializeComponent();

            cboBacSi.Items.AddRange(new object[]
            {
                "BS. Nguyễn Văn An",
                "BS. Trần Thị Bình",
                "BS. Lê Minh Tuấn",
                "BS. Phạm Thu Hà"
            });

            cboTrangThai.Items.AddRange(new object[]
            {
                "Chờ khám",
                "Đang khám",
                "Hoàn tất",
                "Đã hủy"
            });

            cboLocTrangThai.Items.AddRange(new object[]
            {
                "Tất cả",
                "Chờ khám",
                "Đang khám",
                "Hoàn tất",
                "Đã hủy"
            });

            cboLocTrangThai.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            cboBacSi.SelectedIndex = 0;

            dtpNgayGioHen.Value = DateTime.Now.AddHours(1);
            dtpLocNgay.Value = DateTime.Today;

            bindingSource.DataSource = danhSach;
            dgvLichHen.DataSource = bindingSource;

            txtTimKiem.TextChanged += (s, e) => LocDanhSach();
            cboLocTrangThai.SelectedIndexChanged += (s, e) => LocDanhSach();
            dtpLocNgay.ValueChanged += (s, e) => LocDanhSach();
            chkLocNgay.CheckedChanged += (s, e) => LocDanhSach();

            btnThem.Click += btnThem_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            mnuXuatCsv.Click += mnuXuatCsv_Click;

            dgvLichHen.SelectionChanged += dgvLichHen_SelectionChanged;

            LamMoi();
            LocDanhSach();
        }

        private void LocDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string trangThai = cboLocTrangThai.Text;
            DateTime ngayLoc = dtpLocNgay.Value.Date;

            List<LichHen> ketQua = danhSach
                .Where(x =>
                    (x.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || x.SoDienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase))
                    && (trangThai == "Tất cả" || x.TrangThai == trangThai)
                    && (!chkLocNgay.Checked || x.NgayGioHen.Date == ngayLoc))
                .ToList();

            bindingSource.DataSource = new BindingList<LichHen>(ketQua);
            dgvLichHen.ClearSelection();

            lblSoLuong.Text = $"Số lịch hẹn đang hiển thị: {ketQua.Count}";
        }

        private bool KiemTraDuLieu(LichHen? dangSua)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            string ma = txtMaLichHen.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string dienThoai = txtSoDienThoai.Text.Trim();
            string lyDo = txtLyDoKham.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                errorProvider1.SetError(txtMaLichHen, "Vui lòng nhập mã lịch hẹn.");
                hopLe = false;
            }
            else if (danhSach.Any(x =>
                x.MaLichHen.Equals(ma, StringComparison.OrdinalIgnoreCase)
                && !ReferenceEquals(x, dangSua)))
            {
                errorProvider1.SetError(txtMaLichHen, "Mã lịch hẹn đã tồn tại.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên bệnh nhân.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(dienThoai))
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại.");
                hopLe = false;
            }
            else if (!Regex.IsMatch(dienThoai, @"^(0[35789]\d{8}|\+84[35789]\d{8})$"))
            {
                errorProvider1.SetError(
                    txtSoDienThoai,
                    "Số điện thoại phải có dạng 0xxxxxxxxx hoặc +84xxxxxxxxx.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(lyDo))
            {
                errorProvider1.SetError(txtLyDoKham, "Vui lòng nhập lý do khám.");
                hopLe = false;
            }

            if (dtpNgayGioHen.Value < DateTime.Now)
            {
                errorProvider1.SetError(
                    dtpNgayGioHen,
                    "Ngày giờ hẹn không được nằm trong quá khứ.");
                hopLe = false;
            }

            if (cboBacSi.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboBacSi, "Vui lòng chọn bác sĩ.");
                hopLe = false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboTrangThai, "Vui lòng chọn trạng thái.");
                hopLe = false;
            }

            return hopLe;
        }

        private LichHen TaoLichHen()
        {
            return new LichHen
            {
                MaLichHen = txtMaLichHen.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayGioHen = dtpNgayGioHen.Value,
                BacSi = cboBacSi.Text,
                LyDoKham = txtLyDoKham.Text.Trim(),
                TrangThai = cboTrangThai.Text
            };
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraDuLieu(null))
                return;

            LichHen lichHen = TaoLichHen();
            danhSach.Add(lichHen);

            LocDanhSach();
            LamMoi();

            MessageBox.Show(
                "Thêm lịch hẹn thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow?.DataBoundItem is not LichHen lichHen)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần cập nhật.");
                return;
            }

            if (!KiemTraDuLieu(lichHen))
                return;

            if (MessageBox.Show(
                "Bạn có chắc muốn cập nhật lịch hẹn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            lichHen.MaLichHen = txtMaLichHen.Text.Trim();
            lichHen.HoTen = txtHoTen.Text.Trim();
            lichHen.SoDienThoai = txtSoDienThoai.Text.Trim();
            lichHen.NgayGioHen = dtpNgayGioHen.Value;
            lichHen.BacSi = cboBacSi.Text;
            lichHen.LyDoKham = txtLyDoKham.Text.Trim();
            lichHen.TrangThai = cboTrangThai.Text;

            LocDanhSach();
            LamMoi();

            MessageBox.Show("Cập nhật lịch hẹn thành công.");
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow?.DataBoundItem is not LichHen lichHen)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa.");
                return;
            }

            if (MessageBox.Show(
                $"Bạn có chắc muốn xóa lịch hẹn của {lichHen.HoTen}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            danhSach.Remove(lichHen);

            LocDanhSach();
            LamMoi();

            MessageBox.Show("Đã xóa lịch hẹn.");
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            errorProvider1.Clear();

            txtMaLichHen.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtLyDoKham.Clear();

            dtpNgayGioHen.Value = DateTime.Now.AddHours(1);

            if (cboBacSi.Items.Count > 0)
                cboBacSi.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            dgvLichHen.ClearSelection();
            txtMaLichHen.Focus();
        }

        private void dgvLichHen_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvLichHen.CurrentRow?.DataBoundItem is not LichHen lichHen)
                return;

            txtMaLichHen.Text = lichHen.MaLichHen;
            txtHoTen.Text = lichHen.HoTen;
            txtSoDienThoai.Text = lichHen.SoDienThoai;
            dtpNgayGioHen.Value = lichHen.NgayGioHen;
            cboBacSi.Text = lichHen.BacSi;
            txtLyDoKham.Text = lichHen.LyDoKham;
            cboTrangThai.Text = lichHen.TrangThai;

            errorProvider1.Clear();
        }

        private void mnuXuatCsv_Click(object? sender, EventArgs e)
        {
            List<LichHen> ketQua = bindingSource
                .Cast<LichHen>()
                .ToList();

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách lịch hẹn",
                Filter = "CSV (*.csv)|*.csv",
                FileName = "DanhSachLichHen.csv",
                DefaultExt = "csv",
                AddExtension = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using StreamWriter writer = new StreamWriter(
                    dialog.FileName,
                    false,
                    new UTF8Encoding(true));

                writer.WriteLine(
                    "Mã lịch hẹn,Họ tên,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");

                foreach (LichHen x in ketQua)
                {
                    writer.WriteLine(string.Join(",",
                        Csv(x.MaLichHen),
                        Csv(x.HoTen),
                        Csv(x.SoDienThoai),
                        Csv(x.NgayGioHen.ToString("dd/MM/yyyy HH:mm")),
                        Csv(x.BacSi),
                        Csv(x.LyDoKham),
                        Csv(x.TrangThai)));
                }

                MessageBox.Show(
                    $"Đã xuất {ketQua.Count} lịch hẹn.",
                    "Xuất CSV",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất file CSV.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string Csv(string? value)
        {
            value ??= "";
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
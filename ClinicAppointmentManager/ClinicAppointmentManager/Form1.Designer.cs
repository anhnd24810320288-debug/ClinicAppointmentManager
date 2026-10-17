
namespace ClinicAppointmentManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain = null!;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInput = null!;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDanhSach = null!;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNut = null!;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutLoc = null!;

        private System.Windows.Forms.Label lblTieuDe = null!;
        private System.Windows.Forms.Label lblMaLichHen = null!;
        private System.Windows.Forms.Label lblHoTen = null!;
        private System.Windows.Forms.Label lblSoDienThoai = null!;
        private System.Windows.Forms.Label lblNgayGioHen = null!;
        private System.Windows.Forms.Label lblBacSi = null!;
        private System.Windows.Forms.Label lblLyDoKham = null!;
        private System.Windows.Forms.Label lblTrangThai = null!;
        private System.Windows.Forms.Label lblTimKiem = null!;
        private System.Windows.Forms.Label lblLocTrangThai = null!;

        private System.Windows.Forms.TextBox txtMaLichHen = null!;
        private System.Windows.Forms.TextBox txtHoTen = null!;
        private System.Windows.Forms.TextBox txtSoDienThoai = null!;
        private System.Windows.Forms.TextBox txtLyDoKham = null!;
        private System.Windows.Forms.TextBox txtTimKiem = null!;

        private System.Windows.Forms.DateTimePicker dtpNgayGioHen = null!;
        private System.Windows.Forms.DateTimePicker dtpLocNgay = null!;

        private System.Windows.Forms.ComboBox cboBacSi = null!;
        private System.Windows.Forms.ComboBox cboTrangThai = null!;
        private System.Windows.Forms.ComboBox cboLocTrangThai = null!;

        private System.Windows.Forms.CheckBox chkLocNgay = null!;

        private System.Windows.Forms.Button btnThem = null!;
        private System.Windows.Forms.Button btnCapNhat = null!;
        private System.Windows.Forms.Button btnXoa = null!;
        private System.Windows.Forms.Button btnLamMoi = null!;

        private System.Windows.Forms.DataGridView dgvLichHen = null!;
        private System.Windows.Forms.ErrorProvider errorProvider1 = null!;

        private System.Windows.Forms.MenuStrip menuStrip1 = null!;
        private System.Windows.Forms.ToolStripMenuItem mnuTep = null!;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatCsv = null!;
        private System.Windows.Forms.StatusStrip statusStrip1 = null!;
        private System.Windows.Forms.ToolStripStatusLabel lblSoLuong = null!;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLichHen = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGioHen = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDoKham = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutMain = new TableLayoutPanel();
            lblTieuDe = new Label();
            tableLayoutInput = new TableLayoutPanel();
            lblMaLichHen = new Label();
            txtMaLichHen = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblNgayGioHen = new Label();
            dtpNgayGioHen = new DateTimePicker();
            lblBacSi = new Label();
            cboBacSi = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblLyDoKham = new Label();
            txtLyDoKham = new TextBox();
            flowLayoutNut = new FlowLayoutPanel();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            tableLayoutDanhSach = new TableLayoutPanel();
            flowLayoutLoc = new FlowLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            chkLocNgay = new CheckBox();
            dtpLocNgay = new DateTimePicker();
            lblLocTrangThai = new Label();
            cboLocTrangThai = new ComboBox();
            dgvLichHen = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuXuatCsv = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoLuong = new ToolStripStatusLabel();
            tableLayoutMain.SuspendLayout();
            tableLayoutInput.SuspendLayout();
            flowLayoutNut.SuspendLayout();
            tableLayoutDanhSach.SuspendLayout();
            flowLayoutLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(lblTieuDe, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutInput, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutDanhSach, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 28);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.Padding = new Padding(8);
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutMain.Size = new Size(1150, 706);
            tableLayoutMain.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(11, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1128, 42);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ LỊCH HẸN PHÒNG KHÁM";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutInput
            // 
            tableLayoutInput.ColumnCount = 4;
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutInput.Controls.Add(lblMaLichHen, 0, 0);
            tableLayoutInput.Controls.Add(txtMaLichHen, 1, 0);
            tableLayoutInput.Controls.Add(lblHoTen, 2, 0);
            tableLayoutInput.Controls.Add(txtHoTen, 3, 0);
            tableLayoutInput.Controls.Add(lblSoDienThoai, 0, 1);
            tableLayoutInput.Controls.Add(txtSoDienThoai, 1, 1);
            tableLayoutInput.Controls.Add(lblNgayGioHen, 2, 1);
            tableLayoutInput.Controls.Add(dtpNgayGioHen, 3, 1);
            tableLayoutInput.Controls.Add(lblBacSi, 0, 2);
            tableLayoutInput.Controls.Add(cboBacSi, 1, 2);
            tableLayoutInput.Controls.Add(lblTrangThai, 2, 2);
            tableLayoutInput.Controls.Add(cboTrangThai, 3, 2);
            tableLayoutInput.Controls.Add(lblLyDoKham, 0, 3);
            tableLayoutInput.Controls.Add(txtLyDoKham, 1, 3);
            tableLayoutInput.Controls.Add(flowLayoutNut, 0, 4);
            tableLayoutInput.Dock = DockStyle.Fill;
            tableLayoutInput.Location = new Point(11, 53);
            tableLayoutInput.Name = "tableLayoutInput";
            tableLayoutInput.Padding = new Padding(8);
            tableLayoutInput.RowCount = 5;
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutInput.Size = new Size(1128, 305);
            tableLayoutInput.TabIndex = 1;
            // 
            // lblMaLichHen
            // 
            lblMaLichHen.Dock = DockStyle.Fill;
            lblMaLichHen.Location = new Point(11, 8);
            lblMaLichHen.Name = "lblMaLichHen";
            lblMaLichHen.Size = new Size(119, 40);
            lblMaLichHen.TabIndex = 0;
            lblMaLichHen.Text = "Mã lịch hẹn:";
            lblMaLichHen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaLichHen
            // 
            txtMaLichHen.Dock = DockStyle.Fill;
            txtMaLichHen.Location = new Point(137, 13);
            txtMaLichHen.Margin = new Padding(4, 5, 10, 5);
            txtMaLichHen.Name = "txtMaLichHen";
            txtMaLichHen.Size = new Size(417, 27);
            txtMaLichHen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.Dock = DockStyle.Fill;
            lblHoTen.Location = new Point(567, 8);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(119, 40);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên bệnh nhân:";
            lblHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(693, 13);
            txtHoTen.Margin = new Padding(4, 5, 10, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(417, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Dock = DockStyle.Fill;
            lblSoDienThoai.Location = new Point(11, 48);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(119, 40);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại:";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Dock = DockStyle.Fill;
            txtSoDienThoai.Location = new Point(137, 53);
            txtSoDienThoai.Margin = new Padding(4, 5, 10, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(417, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblNgayGioHen
            // 
            lblNgayGioHen.Dock = DockStyle.Fill;
            lblNgayGioHen.Location = new Point(567, 48);
            lblNgayGioHen.Name = "lblNgayGioHen";
            lblNgayGioHen.Size = new Size(119, 40);
            lblNgayGioHen.TabIndex = 6;
            lblNgayGioHen.Text = "Ngày giờ hẹn:";
            lblNgayGioHen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGioHen.Dock = DockStyle.Fill;
            dtpNgayGioHen.Format = DateTimePickerFormat.Custom;
            dtpNgayGioHen.Location = new Point(693, 53);
            dtpNgayGioHen.Margin = new Padding(4, 5, 10, 5);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.ShowUpDown = true;
            dtpNgayGioHen.Size = new Size(417, 27);
            dtpNgayGioHen.TabIndex = 7;
            // 
            // lblBacSi
            // 
            lblBacSi.Dock = DockStyle.Fill;
            lblBacSi.Location = new Point(11, 88);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(119, 40);
            lblBacSi.TabIndex = 8;
            lblBacSi.Text = "Bác sĩ:";
            lblBacSi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboBacSi
            // 
            cboBacSi.Dock = DockStyle.Fill;
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Location = new Point(137, 93);
            cboBacSi.Margin = new Padding(4, 5, 10, 5);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(417, 28);
            cboBacSi.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Location = new Point(567, 88);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(119, 40);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái:";
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Fill;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(693, 93);
            cboTrangThai.Margin = new Padding(4, 5, 10, 5);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(417, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // lblLyDoKham
            // 
            lblLyDoKham.Dock = DockStyle.Fill;
            lblLyDoKham.Location = new Point(11, 128);
            lblLyDoKham.Name = "lblLyDoKham";
            lblLyDoKham.Size = new Size(119, 121);
            lblLyDoKham.TabIndex = 12;
            lblLyDoKham.Text = "Lý do khám:";
            lblLyDoKham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLyDoKham
            // 
            tableLayoutInput.SetColumnSpan(txtLyDoKham, 3);
            txtLyDoKham.Dock = DockStyle.Fill;
            txtLyDoKham.Location = new Point(137, 133);
            txtLyDoKham.Margin = new Padding(4, 5, 10, 5);
            txtLyDoKham.Multiline = true;
            txtLyDoKham.Name = "txtLyDoKham";
            txtLyDoKham.ScrollBars = ScrollBars.Vertical;
            txtLyDoKham.Size = new Size(973, 111);
            txtLyDoKham.TabIndex = 13;
            // 
            // flowLayoutNut
            // 
            tableLayoutInput.SetColumnSpan(flowLayoutNut, 4);
            flowLayoutNut.Controls.Add(btnThem);
            flowLayoutNut.Controls.Add(btnCapNhat);
            flowLayoutNut.Controls.Add(btnXoa);
            flowLayoutNut.Controls.Add(btnLamMoi);
            flowLayoutNut.Dock = DockStyle.Fill;
            flowLayoutNut.Location = new Point(11, 252);
            flowLayoutNut.Name = "flowLayoutNut";
            flowLayoutNut.Padding = new Padding(0, 5, 0, 0);
            flowLayoutNut.Size = new Size(1106, 42);
            flowLayoutNut.TabIndex = 14;
            flowLayoutNut.WrapContents = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(4, 7);
            btnThem.Margin = new Padding(4, 2, 8, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(121, 7);
            btnCapNhat.Margin = new Padding(4, 2, 8, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(105, 34);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(238, 7);
            btnXoa.Margin = new Padding(4, 2, 8, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(355, 7);
            btnLamMoi.Margin = new Padding(4, 2, 8, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 34);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            // 
            // tableLayoutDanhSach
            // 
            tableLayoutDanhSach.ColumnCount = 1;
            tableLayoutDanhSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDanhSach.Controls.Add(flowLayoutLoc, 0, 0);
            tableLayoutDanhSach.Controls.Add(dgvLichHen, 0, 1);
            tableLayoutDanhSach.Dock = DockStyle.Fill;
            tableLayoutDanhSach.Location = new Point(11, 364);
            tableLayoutDanhSach.Name = "tableLayoutDanhSach";
            tableLayoutDanhSach.RowCount = 2;
            tableLayoutDanhSach.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDanhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDanhSach.Size = new Size(1128, 331);
            tableLayoutDanhSach.TabIndex = 2;
            // 
            // flowLayoutLoc
            // 
            flowLayoutLoc.AutoScroll = true;
            flowLayoutLoc.Controls.Add(lblTimKiem);
            flowLayoutLoc.Controls.Add(txtTimKiem);
            flowLayoutLoc.Controls.Add(chkLocNgay);
            flowLayoutLoc.Controls.Add(dtpLocNgay);
            flowLayoutLoc.Controls.Add(lblLocTrangThai);
            flowLayoutLoc.Controls.Add(cboLocTrangThai);
            flowLayoutLoc.Dock = DockStyle.Fill;
            flowLayoutLoc.Location = new Point(3, 3);
            flowLayoutLoc.Name = "flowLayoutLoc";
            flowLayoutLoc.Padding = new Padding(2, 7, 2, 2);
            flowLayoutLoc.Size = new Size(1122, 42);
            flowLayoutLoc.TabIndex = 0;
            flowLayoutLoc.WrapContents = false;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(5, 14);
            lblTimKiem.Margin = new Padding(3, 7, 3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(84, 10);
            txtTimKiem.Margin = new Padding(3, 3, 12, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tên hoặc số điện thoại";
            txtTimKiem.Size = new Size(180, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // chkLocNgay
            // 
            chkLocNgay.AutoSize = true;
            chkLocNgay.Location = new Point(279, 14);
            chkLocNgay.Margin = new Padding(3, 7, 3, 0);
            chkLocNgay.Name = "chkLocNgay";
            chkLocNgay.Size = new Size(93, 24);
            chkLocNgay.TabIndex = 2;
            chkLocNgay.Text = "Lọc ngày:";
            // 
            // dtpLocNgay
            // 
            dtpLocNgay.Format = DateTimePickerFormat.Short;
            dtpLocNgay.Location = new Point(378, 10);
            dtpLocNgay.Margin = new Padding(3, 3, 12, 3);
            dtpLocNgay.Name = "dtpLocNgay";
            dtpLocNgay.Size = new Size(110, 27);
            dtpLocNgay.TabIndex = 3;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Location = new Point(503, 14);
            lblLocTrangThai.Margin = new Padding(3, 7, 3, 0);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(78, 20);
            lblLocTrangThai.TabIndex = 4;
            lblLocTrangThai.Text = "Trạng thái:";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.Location = new Point(587, 10);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(130, 28);
            cboLocTrangThai.TabIndex = 5;
            // 
            // dgvLichHen
            // 
            dgvLichHen.AllowUserToAddRows = false;
            dgvLichHen.AllowUserToDeleteRows = false;
            dgvLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichHen.BackgroundColor = Color.White;
            dgvLichHen.ColumnHeadersHeight = 29;
            dgvLichHen.Dock = DockStyle.Fill;
            dgvLichHen.Location = new Point(3, 51);
            dgvLichHen.MultiSelect = false;
            dgvLichHen.Name = "dgvLichHen";
            dgvLichHen.ReadOnly = true;
            dgvLichHen.RowHeadersVisible = false;
            dgvLichHen.RowHeadersWidth = 51;
            dgvLichHen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichHen.Size = new Size(1122, 277);
            dgvLichHen.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1150, 28);
            menuStrip1.TabIndex = 2;
            // 
            // mnuTep
            // 
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuXuatCsv });
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(48, 24);
            mnuTep.Text = "Tệp";
            // 
            // mnuXuatCsv
            // 
            mnuXuatCsv.Name = "mnuXuatCsv";
            mnuXuatCsv.Size = new Size(32, 19);
            mnuXuatCsv.Text = "Xuất danh sách ra CSV...";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoLuong });
            statusStrip1.Location = new Point(0, 734);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1150, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(187, 20);
            lblSoLuong.Text = "Số lịch hẹn đang hiển thị: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 760);
            Controls.Add(tableLayoutMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(950, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutInput.ResumeLayout(false);
            tableLayoutInput.PerformLayout();
            flowLayoutNut.ResumeLayout(false);
            tableLayoutDanhSach.ResumeLayout(false);
            flowLayoutLoc.ResumeLayout(false);
            flowLayoutLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

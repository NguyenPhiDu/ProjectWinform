	create database QLBenXe
	go
	use QLBenXe
	go
	set dateformat dmy
	go
	--tạo bảng chủ xe
	create table CHU_XE(
		mscx char(10) not null primary key
		,tencx nvarchar(30) not null
		,cmnd int
		,diachi nvarchar(30)
		,soDT int
	)
	go
	--tạo bảng nhân viên
	create table NHAN_VIEN(
		msnv char(10) not null primary key
		,tennv nvarchar(30) not null
		,ngaySinh date
		,diachi nvarchar(30)
		,soDT int
		,hesoluong int not null
		,luongCB float not null
		,tienluong float
		,mscv char(10)
	)
	go
	--tạo bảng xe
	create table XE(
		msx char(10) not null primary key
		,bienso char(10) not null
		,soghe int not null
		,mscx char(10)
		,mst char(10)
	)
	go

	
	--tạo bảng tuyến
	create table TUYEN(
		mst char(10) not null primary key
		,tuyen nvarchar(30) not null
		,benDi nvarchar(30) not null
		,doDaiTuyen int
	)
	go
	--tạo bảng phiếu đăng tài
	create table PHIEU_DANG_TAI(
		mspdt char(10) not null primary key
		,thoigian date not null
		,msx char(10)
		,mst char(10)
	)
	go
	--tạo bảng vé
	create table VE(
		msv char(10) not null primary key
		,ghe int not null
		,msx char(10)
		,msnv char(10)
	)
	go
	--tạo bảng chức vụ
	create table CHUC_VU(
		mscv char(10) not null primary key
		,tencv nvarchar(30) not null
	)
	go
	--tạo bảng lệnh xuất bến
	create table LENH_XUAT_BEN(
		mslxb char(10) not null primary key
		,msx char(10)
		,mshd char(10)
	)
	go

	
	--tạo bảng hóa đơn
	create table HOA_DON(
		mshd char(10) not null primary key
		,ngaylapHD date not null
		,nguoilapHD nvarchar(30) not null
		,tien int
		,msx char(10)
	)
	go
	---------------------------------------------------------------------------------------
	--------								TẠO KHÓA NGOẠI							-------
	---------------------------------------------------------------------------------------
	--tạo khóa ngoại bảng xe
	ALTER TABLE XE ADD CONSTRAINT fk_XE_mscx FOREIGN KEY (mscx) REFERENCES CHU_XE (mscx)
	ALTER TABLE XE ADD CONSTRAINT fk_XE_mst FOREIGN KEY (mst) REFERENCES TUYEN (mst)
	--tạo khóa ngoại bảng phiếu đăng tài
	ALTER TABLE PHIEU_DANG_TAI ADD CONSTRAINT fk_DANG_TAI_msx FOREIGN KEY (msx) REFERENCES XE (msx)
	ALTER TABLE PHIEU_DANG_TAI ADD CONSTRAINT fk_DANG_TAI_mst FOREIGN KEY (mst) REFERENCES TUYEN (mst)
	--tạo khóa ngoại bảng vé
	ALTER TABLE VE ADD CONSTRAINT fk_VE_msx FOREIGN KEY (msx) REFERENCES XE (msx)
	ALTER TABLE VE ADD CONSTRAINT fk_VE_msnv FOREIGN KEY (msnv) REFERENCES NHAN_VIEN (msnv)
	--tạo khóa ngoại bảng lệnh xuất bếnh
	ALTER TABLE LENH_XUAT_BEN ADD CONSTRAINT fk_XUAT_BEN_msx FOREIGN KEY (msx) REFERENCES XE (msx)
	ALTER TABLE LENH_XUAT_BEN ADD CONSTRAINT fk_XUAT_BEN_mshd FOREIGN KEY (mshd) REFERENCES HOA_DON (mshd)
	--tạo khóa ngoại bảng nhân viên
	ALTER TABLE NHAN_VIEN ADD CONSTRAINT fk_NHAN_VIEN_mscv FOREIGN KEY (mscv) REFERENCES CHUC_VU (mscv)
	----tạo khóa ngoại bảng hóa đơn
	ALTER TABLE HOA_DON ADD CONSTRAINT fk_HOA_DON_msx FOREIGN KEY (msx) REFERENCES XE (msx)
	go

	---------------------------------------------------------------------------------------
	--------								THÊM_XÓA_SỬA							-------
	---------------------------------------------------------------------------------------
	----------------------------------------1. Nhân Viên-----------------------------------
	--tao SP_ThemNhanVien
	create proc SP_ThemNhanVien(
		@msnv char(10)
		,@tennv nvarchar(30)
		,@ngaySinh date
		,@diachi nvarchar(30)
		,@soDT int
		,@hesoluong int 
		,@luongCB float 
		,@tienluong float
		,@mscv char(10)
	)
	as 
		insert into NHAN_VIEN(msnv,tennv,ngaySinh ,diachi ,soDT, hesoluong, luongCB, tienluong, mscv)
		values ( @msnv ,@tennv ,@ngaySinh ,@diachi ,@soDT, @hesoluong, @luongCB, @tienluong, @mscv)
	go
	--xóa nhân viên
	create proc SP_XoaNhanVien(@msnv char(10))
	as
		begin
		 delete from NHAN_VIEN where msnv = @msnv
		end
	go
	--sửa nhân viên
	create proc SP_UpDateNhanVien(
		@msnv char(10)
		,@tennv nvarchar(30)
		,@ngaySinh date
		,@diachi nvarchar(30)
		,@soDT int
		,@hesoluong int 
		,@luongCB float 
		,@tienluong float
		,@mscv char(10)
	)
	as
		begin
			update NHAN_VIEN set
			msnv = @msnv
			,tennv = @tennv
			,ngaysinh = @ngaySinh
			,diachi = @diachi
			,soDT = @soDT
			,hesoluong = @hesoluong
			,luongCB = @luongCB
			,tienluong = @tienluong
			,mscv = @mscv
			where msnv = @msnv
		end
	go
	-----------------------------------------2. Xe-----------------------------------------
	--tao SP_ThemXe
	create proc SP_ThemXe(
		@msx char(10)
		,@bienso char(10)
		,@soghe int
		,@mscx char(10)
		,@mst char(10)
	)
	as 
		insert into XE(msx, bienso, soghe, mscx, mst)
		values (@msx, @bienso, @soghe ,@mscx, @mst)
	go
	--xóa Xe
	create proc SP_XoaXe(@msx char(10))
	as
		begin
		 delete from XE where msx = @msx
		end
	go
	--sửa xe
	create proc SP_UpDateXe(
		@msx char(10)
		,@bienso char(10)
		,@soghe int
		,@mscx char(10)
		,@mst char(10)
	)
	as
		begin
			update XE set
			msx = @msx
			,bienso = @bienso
			,soghe = @soghe
			,mscx = @mscx
			,mst = @mst
			where msx = @msx
		end
	go
	-----------------------------------------3. Hóa Đơn------------------------------------
	--tao SP_Them hóa đơn
	create proc SP_ThemHoaDon(
		@mshd char(10) 
		,@ngaylapHD date 
		,@nguoilapHD nvarchar(30) 
		,@tien int
		,@msx char(10)
	)
	as 
		insert into HOA_DON(mshd, ngaylapHD, nguoilapHD, tien, msx)
		values (@mshd, @ngaylapHD, @nguoilapHD, @tien, @msx)
	go
	--tao SP_Xóa hóa đơn
	create proc SP_XoaHoaDon(@mshd char(10))
	as
		begin
		 delete from HOA_DON where mshd = @mshd
		end
	go
	--sửa SP_UpDate Hóa Đơn
	create proc SP_UpDateHoaDon(
		@mshd char(10) 
		,@ngaylapHD date 
		,@nguoilapHD nvarchar(30) 
		,@tien int
		,@msx char(10)
	)
	as
		begin
			update HOA_DON set mshd = @mshd
			,ngaylapHD = @ngaylapHD
			,nguoilapHD = @nguoilapHD
			,tien = @tien
			,msx = @msx
			where mshd = @mshd
		end
	go
	-----------------------------------------4. Chủ xe-------------------------------------
	--tao SP_Them Chủ xe
	create proc SP_ThemChuXe(
		@mscx char(10)
		,@tencx nvarchar(30)
		,@cmnd int
		,@diachi nvarchar(30)
		,@soDT int
	)
	as 
		insert into CHU_XE(mscx, tencx, cmnd, diachi, soDT)
		values (@mscx, @tencx, @cmnd, @diachi, @soDT)
	go
	--tao SP_Xóa Chủ xe
	create proc SP_XoaChuXe(@mscx char(10))
	as
		begin
		 delete from CHU_XE where mscx = @mscx
		end
	go
	--sửa SP_UpDate Chủ xe
	create proc SP_UpDateChuXe(
		@mscx char(10)
		,@tencx nvarchar(30)
		,@cmnd int
		,@diachi nvarchar(30)
		,@soDT int
	)
	as
		begin
			update CHU_XE set 
			mscx = @mscx
			,tencx = @tencx
			,cmnd = @cmnd
			,diachi = @diachi
			,soDT = @soDT
			where mscx = @mscx
		end
	go
	-----------------------------------------5. Chức vụ------------------------------------
	--tao SP_Them  Chức vụ
	create proc SP_ThemChucVu(
		@mscv char(10)
		,@tencv nvarchar(30)
	)
	as 
		insert into CHUC_VU(mscv, tencv)
		values (@mscv, @tencv)
	go
	--tao SP_Xóa  Chức vụ
	create proc SP_XoaChucVu(@mscv char(10))
	as
		begin
		 delete from CHUC_VU where mscv = @mscv
		end
	go
	--sửa SP_UpDate  Chức vụ
	create proc SP_UpDateChucVu(
		@mscv char(10)
		,@tencv nvarchar(30)
	)
	as
		begin
			update CHUC_VU set 
			mscv = @mscv
			,tencv = @tencv
			where mscv = @mscv
		end
	go
	-----------------------------------------6. Tuyến--------------------------------------
	--tao SP_Them  Tuyến
	create proc SP_ThemTuyen(
		@mst char(10)
		,@tuyen nvarchar(30)
		,@benDi nvarchar(30)
		,@doDaiTuyen int
	)
	as 
		insert into TUYEN(mst, tuyen, benDi, doDaiTuyen)
		values (@mst, @tuyen, @benDi, @doDaiTuyen)
	go
	--tao SP_Xóa  Tuyến
	create proc SP_XoaTuyen(@mst char(10))
	as
		begin
		 delete from TUYEN where mst = @mst
		end
	go
	--sửa SP_UpDate  Tuyến
	create proc SP_UpDateTuyen(
		@mst char(10)
		,@tuyen nvarchar(30)
		,@benDi nvarchar(30)
		,@doDaiTuyen int
	)
	as
		begin
			update TUYEN set 
			mst = @mst
			,tuyen = @tuyen
			,benDi = @benDi
			,doDaiTuyen = @doDaiTuyen
			where mst = @mst
		end
	go
	-----------------------------------------7. Vé-----------------------------------------
	--tao SP_Them  Vé
	create proc SP_ThemVe(
		@msv char(10)
		,@ghe int
		,@msx char(10)
		,@msnv char(10)
	)
	as 
		insert into VE(msv, ghe, msx, msnv)
		values (@msv, @ghe, @msx, @msnv)
	go
	--tao SP_Xóa  Vé
	create proc SP_XoaVe(@msv char(10))
	as
		begin
		 delete from VE where msv = @msv
		end
	go
	--sửa SP_UpDate  Vé
	create proc SP_UpDateVe(
		@msv char(10)
		,@ghe int
		,@msx char(10)
		,@msnv char(10)
	)
	as
		begin
			update VE set 
			msv = @msv
			,ghe = @ghe
			,msx = @msx
			,msnv = @msnv
			where msv = @msv
		end
	go
	-----------------------------------------8. lệnh xuất bến------------------------------
	--tao SP_Them lệnh xuất bến
	create proc SP_ThemLenhXuatBen(
		@mslxb char(10)
		,@msx char(10)
		,@mshd char(10)
	)
	as 
		insert into LENH_XUAT_BEN(mslxb, msx, mshd)
		values (@mslxb, @msx, @mshd)
	go
	--tao SP_Xóa lệnh xuất bến
	create proc SP_XoaLenhXuatBen(@mslxb char(10))
	as
		begin
		 delete from LENH_XUAT_BEN where mslxb = @mslxb
		end
	go
	--sửa SP_UpDate lệnh xuất bến
	create proc SP_UpDateLenhXuatBen(
		@mslxb char(10)
		,@msx char(10)
		,@mshd char(10)
	)
	as
		begin
			update LENH_XUAT_BEN set 
			mslxb = @mslxb
			,msx = @msx
			,mshd = @mshd
			where mslxb = @mslxb
		end
	go
	-----------------------------------------9. Phiếu đăng tài-----------------------------
	--tao SP_Them Phiếu đăng tài
	create proc SP_ThemPhieuDangTai(
		@mspdt char(10)
		,@thoigian date
		,@msx char(10)
		,@mst char(10)
	)
	as 
		insert into PHIEU_DANG_TAI(mspdt, thoigian, msx, mst)
		values (@mspdt, @thoigian, @msx, @mst)
	go
	--tao SP_Xóa Phiếu đăng tài
	create proc SP_XoaPhieuDangTai(@mspdt char(10))
	as
		begin
		 delete from PHIEU_DANG_TAI where mspdt = @mspdt
		end
	go
	--sửa SP_UpDate Phiếu đăng tài
	create proc SP_UpDatePhieuDangTai(
		@mspdt char(10)
		,@thoigian date
		,@msx char(10)
		,@mst char(10)
	)
	as
		begin
			update PHIEU_DANG_TAI set 
			mspdt = @mspdt
			,thoigian = @thoigian
			,msx = @msx
			,mst = @mst
			where mspdt = @mspdt
		end
	go
	---------------------------------------------------------------------------------------
	--------								TRUY_VẤN							 ----------
	---------------------------------------------------------------------------------------
	----------------------------------------1. Nhân Viên-----------------------------------
	create proc SP_DanhSachNhanVien
	as
		Select * from NHAN_VIEN
	go

	-----------Danh sach ma so nhan vien ban ve --------------
	create proc SP_DanhSachMaSoNhanVien
	as
		Select * from NHAN_VIEN where msnv='nv01'
	go


	-----------tính lương----------------
	create proc SP_TinhLuong
	as
		Select hesoluong * luongCB as[tien luong] from NHAN_VIEN
	go
	-----------------------------------------2. Xe-----------------------------------------
	create proc SP_DanhSachXe
	as
		Select * from XE
	go
	-----------Danh sach ma so xe --------------
	create proc SP_DanhSachMaSoXe
	as
		Select msx from XE
	go
	-----------------------------------------3. Hóa Đơn------------------------------------
	create proc SP_DanhSachHoaDon
	as
		Select * from HOA_DON
	go
	-----------------------------------------4. Chủ xe-------------------------------------
	create proc SP_DanhSachChuXe
	as
		Select * from CHU_XE
	go
	-----danh sach ma so chu xe------------

	create proc SP_DanhSachMaSoChuXe
	as
		Select mscx from CHU_XE
	go
	-----------------------------------------5. Chức vụ------------------------------------
	create proc SP_DanhSachChucVu
	as
		Select * from CHUC_VU
	go
	-----------------------------------------6. Tuyến--------------------------------------
	create proc SP_DanhSachTuyen
	as
		Select * from TUYEN
	go

	-----danh sach ma so tuyen------------
	create proc SP_DanhSachMaSoTuyen
	as
		Select mst from TUYEN
	go
	-----------------------------------------7. Vé-----------------------------------------
	create proc SP_DanhSachVe
	as
		Select * from VE
	go
	-----------------------------------------8. lệnh xuất bến------------------------------
	create proc SP_DanhSachLenhXuatBen
	as
		Select * from LENH_XUAT_BEN
	go
	-----------------------------------------9. Phiếu đăng tài-----------------------------
	create proc SP_DanhSachPieuDangTai
	as
		Select * from PHIEU_DANG_TAI
	go
	---------------------------------------------------------------------------------------
	--------								THỰC_THI							 ----------
	---------------------------------------------------------------------------------------
	exec SP_ThemChucVu'CV01',N'Nhân viên bán vé'
	exec SP_ThemChucVu'CV02',N'Nhân viên lao công'
	exec SP_ThemChucVu'CV03',N'Nhân viên bảo vệ'
	exec SP_ThemChucVu'CV04',N'Tài xế'
	exec SP_ThemChucVu'CV05',N'Nhân viên Bảo trì hệ thống'
	exec SP_ThemChucVu'CV06',N'Kế toán'
	exec SP_ThemChucVu'CVQT',N'Admin quản trị hệ thống'
	exec SP_DanhSachChucVu
	go
	exec SP_ThemNhanVien 'nv01', N'Huynh Chau Thanh Truc', '20/12/2000', N'Ba Tri-Ben Tre'
							, 0900000, 2, 2000000, 4000000, 'CV02'
	exec SP_ThemNhanVien 'nv02' , N'Nguyen Phi Du','20000128',N'Long An',334224,3,4000,12000,'CV01'
	exec SP_ThemNhanVien 'nv03' , N'Nguyen Du Phi','20000119',N'Long An',213232,3,5000,12000,'CV03'
	exec SP_ThemNhanVien 'nv04' , N'Nguyen Tri Teo','2000107',N'Long An',232453,3,6000,12000,'CV04'
	exec SP_ThemNhanVien 'nv05' , N'Nguyen Quoc Huy','20001006',N'Long An',43452,3,7000,12000,'CVQT'
	exec SP_ThemNhanVien 'nv06',N'Nguyễn Ngọc Trinh','19990506',N'Long Xuyên',226733,3,4000,12000,'CV06'
	exec SP_DanhSachNhanVien
	go 
	exec SP_TinhLuong
	go

	exec SP_ThemVe '01',3,'03','nv02'
	exec SP_ThemVe '03',10,'03','nv02'
	exec SP_ThemVe '02',13,'03','nv02'
	exec SP_ThemVe '04',3,'01','nv02'
	exec SP_ThemVe '05',10,'01','nv02'
	exec SP_ThemVe '06',13,'02','nv02'
	exec SP_ThemChuXe '03', N'Phuong Trang' ,1235223 ,N'Sai Gon' , 76546738
	exec SP_ThemXe '01','68-01',45,'01','01'
	exec SP_ThemXe '02','71-16',29,'02','02'
	exec SP_ThemXe '03','60-20',16,'03','03'
	exec SP_ThemVe '02',3,'01','01'

	go
	exec  SP_ThemLenhXuatBen 'LXB01','01','HD01'
	exec  SP_ThemLenhXuatBen 'LXB02','02','HD02'
	exec  SP_ThemLenhXuatBen 'LXB03','03','HD03'
	exec  SP_ThemLenhXuatBen 'LXB04','04','HD04'
	exec  SP_ThemLenhXuatBen 'LXB05','05','HD05'
	exec SP_ThemLenhXuatBen 'LXB06','01','HD2'


	exec SP_ThemHoaDon 'HD01','20201214', N'Nguyen Phi Du',10000,'01'
	exec SP_ThemHoaDon 'HD02','20201214', N'Nguyễn Ngọc Trinh',10000,'01'
	exec SP_ThemHoaDon 'HD03','20201214', N'Nguyễn Ngọc Trinh',10000,'01'
	exec SP_ThemHoaDon 'HD04','20201214', N'Nguyễn Ngọc Trinh',10000,'01'
	exec SP_ThemHoaDon 'HD05','20201214', N'Nguyễn Ngọc Trinh',10000,'01'

	exec SP_ThemPhieuDangTai 'PDT01','20201214','01','01'
	exec SP_ThemPhieuDangTai 'PDT02','20201214','02','02'
	exec SP_ThemPhieuDangTai 'PDT03','20201214','03','03'
	exec SP_ThemPhieuDangTai 'PDT04','20201214','02','02'
	exec SP_ThemPhieuDangTai 'PDT05','20201214','03','03'
	select * from XE
	select * from TUYEN
	select * from CHU_XE
	select * from VE
	select * from NHAN_VIEN
	select * from HOA_DON
	select * from CHUC_VU
	select * from LENH_XUAT_BEN
	select * from PHIEU_DANG_TAI

	exec SP_DanhSachMaSoNhanVien

	
	

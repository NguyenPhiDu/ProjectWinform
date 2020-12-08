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
		,bienxo char(10) not null
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
			update NHAN_VIEN set msnv = @msnv
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
	--truy van danh sach nhan vien	
	create proc SP_DanhSachNhanVien
	as 
		Select * from NHAN_VIEN
	go

	--tao SP_ThemXe
	create proc SP_ThemXe(
		@msx char(10)
		,@bienxo char(10)
		,@soghe int
		,@mscx char(10)
		,@mst char(10)
	)
	as 
		insert into XE(msx, bienxo, soghe, mscx, mst)
		values (@msx, @bienxo, @soghe ,@mscx, @mst)
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
		,@bienxo char(10)
		,@soghe int
		,@mscx char(10)
		,@mst char(10)
	)
	as
		begin
			update XE set msx = @msx
		,bienxo = @bienxo
		,soghe = @soghe
		,mscx = @mscx
		,mst = @mst
			where msx = @msx
		end
	go



	--Vinh--
	--create store procedure for table chuc vu
	--get table chuc vu
	create proc SP_DanhSachChucVu
	as
		select * from CHUC_VU
	go
	--insert chuc vu
	create proc SP_InsertChucVu( @MSCV char(10) ,@TENCV nvarchar(30))
	as
		insert into CHUC_VU (mscv,tencv)
		values (@MSCV  ,@TENCV )
	go
	--delete chuc vu
	create proc SP_DeleteChucVu(@MSCV char(10))
	as
		begin 
			delete from CHUC_VU where mscv =@MSCV
		end
	go
	--update chuc vu
	create proc SP_UpdateChucVu(@MSCV char(10) ,@TENCV nvarchar(30))
		as
			begin
				update CHUC_VU set mscv = @MSCV,
					tencv=@TENCV
				where mscv = @MSCV
			end
	go



	--thuc thi 
	insert into CHUC_VU(mscv,tencv)  values('01','Nhan Vien Ban Ve')
	exec SP_DanhSachNhanVien
	exec SP_ThemNhanVien N'01',N'Teo thi test','19991013',N'Sai Gon','182234512',3,5000,15000,'01'
	exec SP_UpdateChucVu 'ad', 'admin1'
	exec SP_DanhSachChucVu

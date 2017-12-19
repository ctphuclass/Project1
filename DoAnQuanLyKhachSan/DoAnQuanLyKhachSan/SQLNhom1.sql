USE [QuanLyKhachSan010]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddKH]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[usp_AddKH]
@MaKhachHang nvarchar(50) ,
@TenKhachHang nvarchar(50),
@SoCMND nvarchar(50),
@DiaChi nvarchar(50),
@DienThoai nvarchar(50),
@GioiTinh nvarchar(50),
@QuocTich nvarchar(50)
as
begin
	if not exists(select * from KHACH_HANG where MaKhachHang=@MaKhachHang)
	insert into KHACH_HANG (MaKhachHang, TenKhachHang, SoCMND, DiaChi, DienThoai, GioiTinh, QuocTich) values (@MaKhachHang, @TenKhachHang, @SoCMND,  @DiaChi, @DienThoai, @GioiTinh, @QuocTich)
	else
	update Khach_Hang set TenKhachHang=@TenKhachHang,SoCMND=@SoCMND,DiaChi=@DiaChi,DienThoai=@DienThoai,GioiTinh =@GioiTinh,QuocTich=@QuocTich
end
GO
/****** Object:  StoredProcedure [dbo].[usp_AddNV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_AddNV]
@MA_NHAN_VIEN varchar (50),
@TEN_NHAN_VIEN nvarchar (50),
@NAM_SINH date,
@CHUC_VU nvarchar (50),
@GIOI_TINH nvarchar (5)
as
begin
	if exists (select MA_NHAN_VIEN from NHAN_VIEN where MA_NHAN_VIEN = @MA_NHAN_VIEN)
	print N'Đã tồn tại'
	else
		INSERT INTO NHAN_VIEN (MA_NHAN_VIEN, TEN_NHAN_VIEN, NAM_SINH, GIOI_TINH, CHUC_VU) VALUES (@MA_NHAN_VIEN, @TEN_NHAN_VIEN, @NAM_SINH, @GIOI_TINH, @CHUC_VU)

end



GO
/****** Object:  StoredProcedure [dbo].[usp_ChonDichVu]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ChonDichVu]
@maloai nvarchar(50)
as
begin
select *from DICH_VU where MaLoaiDichVu = @maloai
end

GO
/****** Object:  StoredProcedure [dbo].[usp_DatPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_DatPhong]  @maphong nvarchar(50)
as
	begin
	 if Exists (select PDP.TinhTrang from PHIEU_DAT_PHONG PDP where PDP.TinhTrang=N'Chưa' and PDP.MaPhong = @maphong)
		Update PHONG set TinhTrang =N'Đặt Phòng'
		where MaPhong =@maphong
		else
		print 'ssasssa'	
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteKH]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteKH]
@MaKhachHang varchar (50)
as
begin
	delete from KHACH_HANG where MaKhachHang = @MaKhachHang
end



GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteNV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteNV]
@MA_NHAN_VIEN NVARCHAR (50)

AS
BEGIN
	DELETE FROM NHAN_VIEN  WHERE MA_NHAN_VIEN = @MA_NHAN_VIEN
END



GO
/****** Object:  StoredProcedure [dbo].[usp_doanhthu]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_doanhthu] 
as
begin
select CP.MaChiPhi as N'Mã Hóa Đơn', P.MaPhong ,NgayLap ,CP.TinhTrang as N'Thanh Toán Dịch Vụ',sum(DV.DonGia*CTCP.SoLuong)as N'Tiền Chi Phí Phát Sinh',LP.DonGia as 'Giá Phòng',sum(LP.DonGia+DV.DonGia*CTCP.SoLuong) as N'Tổng Tiền Hóa Đơn'
from LOAI_PHONG LP join Phong P on P.MaLoaiPhong=LP.MaLoaiPhong 
							join ChiPhi CP on CP.MaPhong =P.MaPhong
							join ChiTietChiPhi CTCP on CTCP.MaChiPhi=CP.MaChiPhi
							join DICH_VU DV on DV.MaDichVu=CTCP.MaDV
							join LOAI_DICH_VU LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
							where CP.TinhTrang ='Roi'
group by P.MaPhong,LP.DonGia,NgayLap,CP.TinhTrang,P.TinhTrang,CP.MaChiPhi
order by CP.MaChiPhi desc
end
GO
/****** Object:  StoredProcedure [dbo].[usp_doanhthutheophong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[usp_doanhthutheophong]  @maphong nvarchar(50)
as
begin
select CP.MaChiPhi as N'Mã Hóa Đơn', P.MaPhong ,NgayLap ,CP.TinhTrang as N'Thanh Toán Dịch Vụ',sum(DV.DonGia*CTCP.SoLuong)as N'Tiền Chi Phí Phát Sinh',LP.DonGia as 'Giá Phòng',sum(LP.DonGia+DV.DonGia*CTCP.SoLuong) as N'Tổng Tiền Hóa Đơn'
from LOAI_PHONG LP join Phong P on P.MaLoaiPhong=LP.MaLoaiPhong 
							join ChiPhi CP on CP.MaPhong =P.MaPhong
							join ChiTietChiPhi CTCP on CTCP.MaChiPhi=CP.MaChiPhi
							join DICH_VU DV on DV.MaDichVu=CTCP.MaDV
							join LOAI_DICH_VU LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
							where CP.TinhTrang ='Roi' and CP.MaPhong like @maphong
group by P.MaPhong,LP.DonGia,NgayLap,CP.TinhTrang,P.TinhTrang,CP.MaChiPhi
order by CP.MaChiPhi desc
end

GO
/****** Object:  StoredProcedure [dbo].[usp_DoiMK]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DoiMK]
@psUsername varchar(50),
@psPassword varchar(50),
@psChangePasword varchar(50),
@pResultCode int output,
@pResultMessage varchar(50) output
AS
BEGIN
 --Chuyen Password Ma Hoa
 DECLARE @lPasswordHash varchar(32)
 DECLARE @lChangePasswordHash varchar(32)
 SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
 SET @lChangePasswordHash = HASHBYTES('SHA2_256', @psChangePasword)
 --KT User, Pass
 IF Exists(Select id from NGUOI_DUNG where TaiKhoan = @psUsername and MatKhau = @lPasswordHash)
 --Neu Ton Tai
 BEGIN
  --Doi MK
  Update NGUOI_DUNG SET MatKhau = @lChangePasswordHash WHERE TaiKhoan = @psUsername 
  SELECT @pResultCode = id, @pResultMessage = N'Đổi Mật Khẩu Thành Công Rồi Đó =]]' from NGUOI_DUNG where TaiKhoan = @psUsername and MatKhau = @lChangePasswordHash
  RETURN
 END
 --Khong Ton Tai
 ELSE
 BEGIN
  SELECT @pResultCode = -1 , @pResultMessage = N'Thất bại nhá ,Nhập lại đi' 
  RETURN
 END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_EditNV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_EditNV]
@MA_NHAN_VIEN varchar (50),
@TEN_NHAN_VIEN nvarchar (50),
@NAM_SINH date,
@CHUC_VU nvarchar (50),
@GIOI_TINH nvarchar (5)
as
begin
	if exists (select* from NHAN_VIEN)
	update NHAN_VIEN set TEN_NHAN_VIEN = @TEN_NHAN_VIEN, NAM_SINH= @NAM_SINH, CHUC_VU = @CHUC_VU, GIOI_TINH = @GIOI_TINH
	where MA_NHAN_VIEN = @MA_NHAN_VIEN
end



GO
/****** Object:  StoredProcedure [dbo].[usp_HuyDatPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_HuyDatPhong] @maphong nvarchar(50)
as
	begin
		if exists (select PDP.TinhTrang,P.TinhTrang from PHIEU_DAT_PHONG PDP join PHONG P on P.MaPhong=PDP.MaPhong
		where PDP.TinhTrang =N'Chưa' and P.TinhTrang =N'Đặt Phòng' and P.MaPhong=@maphong)
		Update PHONG set TinhTrang =N'Trống'
				where MaPhong =@maphong
		else
		Print 'Sai roi pa'
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_insert]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_insert] @MaChiPhi int , @MaDV nvarchar(50), @SL int 
As
Begin
	declare @CTCP int, @Dem int
	select @CTCP = MaChiTiet,@Dem = SoLuong from ChiTietChiPhi where  MaChiPhi = @MaChiPhi and MaDV = @MaDV
	if(@CTCP > 0)
	begin
			Update ChiTietChiPhi set SoLuong = @SL +  @Dem where MaDV = @MaDV and MaChiPhi = @MaChiPhi
	end 
	else
	begin
		Insert into ChiTietChiPhi(MaChiPhi,MaDV,SoLuong)
		values (@MaChiPhi,@MaDV,@SL)
	end
End

GO
/****** Object:  StoredProcedure [dbo].[usp_insert0]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_insert0] @Maphong nvarchar(50)
As
Begin
	Insert into ChiPhi(MaPhong, NgayLap, TinhTrang)
	Values(@Maphong,GETDATE(),'C')
End

GO
/****** Object:  StoredProcedure [dbo].[usp_insertChiPhi]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_insertChiPhi] @maphong nvarchar(50)
as
begin
insert into ChiPhi(MaPhong,NgayLap,TinhTrang)
	Values (@maphong,GETDATE(),'Chua')
end

GO
/****** Object:  StoredProcedure [dbo].[USP_InsertChiTiet]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertChiTiet] @MaChiPhi int , @MaDV char(10), @SL int 
AS
	BEGIN 
				Insert into ChiTietChiPhi(MaChiPhi,MaDV,SoLuong)
		values (@MaChiPhi,@MaDV,@SL)
		END

GO
/****** Object:  StoredProcedure [dbo].[usp_insertPhieuDatPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_insertPhieuDatPhong] @maphong nvarchar(50)
as
	begin
		insert into PHIEU_DAT_PHONG (TinhTrang,MaPhong)
		values(N'Chưa',@maphong)
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_insertPhieuDatPhongChiTiet]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_insertPhieuDatPhongChiTiet] @maphieu int,
@makh nvarchar(50),
@ngaynhan nvarchar(50),
@ngaytradukien nvarchar(50),
@ngaytrathucte nvarchar(50)
	as
		begin
			insert into Chi_Tiet_Phieu_Dat_Phong(MaPhieu,MaKhachHang,NgayDat,NgayNhan,NgayTraDuKien,NgayTraThucTe)values (@maphieu,@makh,getdate(),@ngaynhan,@ngaytradukien,@ngaytrathucte)
		end

GO
/****** Object:  StoredProcedure [dbo].[usp_KiemTraPhongDat]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_KiemTraPhongDat] 
as
begin
select * from Phong join Loai_Phong LP on LP.MaLoaiPhong =PHONG.MaLoaiPhong
where TinhTrang = N'Trống' 
end
GO
/****** Object:  StoredProcedure [dbo].[usp_KiemTraRoiNhanPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_KiemTraRoiNhanPhong] @maphong nvarchar(50)
as
	begin
	if exists (select PDP.TinhTrang,P.TinhTrang from PHIEU_DAT_PHONG PDP join PHONG P on P.MaPhong=PDP.MaPhong
		where PDP.TinhTrang =N'Đã Nhận' and P.TinhTrang =N'Đặt Phòng' and PDP.MaPhong=@maphong)
		Update PHONG set TinhTrang =N'Hoạt Động'
				where MaPhong =@maphong
		else
		Print 'Sai roi pa'
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_LayMaxPhieuDatPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_LayMaxPhieuDatPhong] 
as
begin
	select max(MaPhieu) from PHIEU_DAT_PHONG
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ListCPP]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_ListCPP] @machitiet int
as
begin
					select * from ChiTietChiPhi where MaChiTiet=@machitiet
					end		

GO
/****** Object:  StoredProcedure [dbo].[usp_listPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_listPhong]
as
begin
select MaPhong,TenLoaiPhong,TinhTrang from PHONG  P join LOAI_PHONG LP on LP.MaLoaiPhong=P.MaLoaiPhong
end

GO
/****** Object:  StoredProcedure [dbo].[usp_LoadKH]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LoadKH]
as
begin
	select * from KHACH_HANG
end



GO
/****** Object:  StoredProcedure [dbo].[usp_LoadNV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_LoadNV]
as
begin
	select * from NHAN_VIEN 
end



GO
/****** Object:  StoredProcedure [dbo].[usp_LoadPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_LoadPhong]
as
begin
	select * from PHONG where MaPhong = 'PH1'
end



GO
/****** Object:  StoredProcedure [dbo].[usp_lsvDV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
				CREATE proc [dbo].[usp_lsvDV] @maphong nvarchar(50),
@MaChiPhi int
		as				
select t.MaChiPhi,t.TenDichVu ,t.DonGia,t.Soluong,t.ThanhTien,t.MaDichVu						
	from			(select ChiPhi.MaChiPhi,TenDichVu,DonGia,CT.Soluong,sum(DV.DonGia*CT.SoLuong) as ThanhTien,TinhTrang,MaPhong,MaDichVu
					from ChiPhi join ChiTietChiPhi CT on CT.MaChiPhi=ChiPhi.MaChiPhi
								join Dich_Vu DV on DV.MaDichVu=CT.MaDV 
								join LOAI_DICH_VU LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
								group by TenDichVu,CT.Soluong ,ChiPhi.MaChiPhi,TinhTrang,MaPhong,DonGia,MaDichVu) as t
					where t.TinhTrang like N'Chua'and MaPhong=@maphong and t.MaChiPhi=@MaChiPhi
GO
/****** Object:  StoredProcedure [dbo].[usp_MaChiPhi]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
					CREATE proc [dbo].[usp_MaChiPhi]
					@maphong nvarchar(50)
					as
					begin
					Select  MaChiPhi ,TinhTrang From ChiPhi where  TinhTrang = N'Chua' and MaPhong=@maphong
					end
GO
/****** Object:  StoredProcedure [dbo].[usp_maxchiphi]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_maxchiphi]
as
begin
select max(machiphi) From ChiPhi
end
GO
/****** Object:  StoredProcedure [dbo].[usp_maxPhieuThue]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_maxPhieuThue] 
as
begin 
select max(MaPhieuThue) from PHIEU_THUE_PHONG
end
GO
/****** Object:  StoredProcedure [dbo].[usp_menudv]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_menudv]
as
begin
select MaDichVu as N'Mã Dịch Vụ',TenDichVu as N'Tên',DonGia as N'Giá' 
from Dich_Vu

end

GO
/****** Object:  StoredProcedure [dbo].[usp_menudv1]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_menudv1]
as
begin
select MaDichVu as N'Mã Dịch Vụ',TenLoaiDichVu AS N'Loại',TenDichVu as N'Tên',DonGia as N'Giá',DV.MaLoaiDichVu from Dich_Vu DV join Loai_Dich_Vu LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu

end
GO
/****** Object:  StoredProcedure [dbo].[usp_menudvsearch]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_menudvsearch] @maloai int
as
begin
select MaDichVu as N'Mã Dịch Vụ',TenLoaiDichVu AS N'Loại',TenDichVu as N'Tên',DonGia as N'Giá' from Dich_Vu DV join Loai_Dich_Vu LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
	Where DV.MaLoaiDichVu = @maloai
	
end

GO
/****** Object:  StoredProcedure [dbo].[usp_NhanPhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_NhanPhong]
@maphong nvarchar(50)
as
	begin
	if exists (select PDP.TinhTrang,P.TinhTrang from PHIEU_DAT_PHONG PDP join PHONG P on P.MaPhong=PDP.MaPhong
		where PDP.TinhTrang =N'Chưa' and P.TinhTrang =N'Đặt Phòng' and PDP.MaPhong=@maphong)
		Update PHIEU_DAT_PHONG set TinhTrang =N'Đã Nhận'
				where MaPhong =@maphong
		else
		Print 'Long đúng mà sao cứ không vào là sao'
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_SuaP]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_SuaP] as
select * from Phong
GO
/****** Object:  StoredProcedure [dbo].[usp_tdoanhthu]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_tdoanhthu] 
as
begin
select sum(t.TongTien) as tongdoanhthu from(
select CP.MaChiPhi as N'Mã Hóa Đơn', P.MaPhong ,NgayLap ,CP.TinhTrang as N'Thanh Toán Dịch Vụ',sum(DV.DonGia*CTCP.SoLuong)as N'Tiền Chi Phí Phát Sinh',LP.DonGia as 'Giá Phòng',sum(LP.DonGia+DV.DonGia*CTCP.SoLuong) as TongTien
from LOAI_PHONG LP join Phong P on P.MaLoaiPhong=LP.MaLoaiPhong 
							join ChiPhi CP on CP.MaPhong =P.MaPhong
							join ChiTietChiPhi CTCP on CTCP.MaChiPhi=CP.MaChiPhi
							join DICH_VU DV on DV.MaDichVu=CTCP.MaDV
							join LOAI_DICH_VU LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
							where CP.TinhTrang ='Roi'
group by P.MaPhong,LP.DonGia,NgayLap,CP.TinhTrang,P.TinhTrang,CP.MaChiPhi)as t 
end
GO
/****** Object:  StoredProcedure [dbo].[usp_tdoanhthutheophong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_tdoanhthutheophong] @maphong nvarchar(50)
as
begin
select sum(t.TongTien) as tongdoanhthu from(
select CP.MaChiPhi as N'Mã Hóa Đơn', P.MaPhong ,NgayLap ,CP.TinhTrang as N'Thanh Toán Dịch Vụ',sum(DV.DonGia*CTCP.SoLuong)as N'Tiền Chi Phí Phát Sinh',LP.DonGia as 'Giá Phòng',sum(LP.DonGia+DV.DonGia*CTCP.SoLuong) as TongTien
from LOAI_PHONG LP join Phong P on P.MaLoaiPhong=LP.MaLoaiPhong 
							join ChiPhi CP on CP.MaPhong =P.MaPhong
							join ChiTietChiPhi CTCP on CTCP.MaChiPhi=CP.MaChiPhi
							join DICH_VU DV on DV.MaDichVu=CTCP.MaDV
							join LOAI_DICH_VU LDV on LDV.MaLoaiDichVu=DV.MaLoaiDichVu
							where CP.TinhTrang ='Roi'
group by P.MaPhong,LP.DonGia,NgayLap,CP.TinhTrang,P.TinhTrang,CP.MaChiPhi)as t
where t.MaPhong like @maphong
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Themdv]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_Themdv] @madv nvarchar(50),
@tendv nvarchar(50),
@g nvarchar(50),
@l nvarchar(50)
as
begin 

insert into DICH_VU (MaDichVu,TenDichVu,DonGia,MaLoaiDichVu) values (@madv,@tendv,@g,@l)
end


GO
/****** Object:  StoredProcedure [dbo].[usp_ThemKhachHang]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    proc [dbo].[usp_ThemKhachHang]
@MaKhachHang nvarchar(50) ,
@TenKhachHang nvarchar(50),
@SoCMND nvarchar(50),
@DiaChi nvarchar(50),
@DienThoai nvarchar(50),
@GioiTinh nvarchar(50),
@QuocTich nvarchar(50)
as
begin
	if not exists(select * from KHACH_HANG where MaKhachHang=@MaKhachHang)
	insert into KHACH_HANG (MaKhachHang, TenKhachHang, SoCMND, DiaChi, DienThoai, GioiTinh, QuocTich) values (@MaKhachHang, @TenKhachHang, @SoCMND,  @DiaChi, @DienThoai, @GioiTinh, @QuocTich)
	else
	Print 'sađá'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemKHvaophieu]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_ThemKHvaophieu] @makh nvarchar(50)
as
begin
insert into PHIEU_THUE_PHONG (MaKhachHang) values (@makh)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemMaPhongVaoPhieuThue]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ThemMaPhongVaoPhieuThue] @map nvarchar(50),@ngaytra nvarchar(50),@maphieuthue int
as
begin
insert into CHI_TIET_PHIEU_THUE_PHONG (MaPhong,NgayDatPhong,NgayTraPhong,MaPhieuThue) values(@map,GETDATE(),@ngaytra,@maphieuthue)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThuePhong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ThuePhong] @map nvarchar(50)
as
select CTPT.MaPhong,NgayDatPhong,NgayTraPhong,TenKhachHang 
from CHI_TIET_PHIEU_THUE_PHONG CTPT join PHIEU_THUE_PHONG PTP on PTP.MaPhieuThue= CTPT.MaPhieuThue 
									join Phong P on P.maphong=CTPT.MaPhong 
									join KHACH_HANG KH on KH.MaKhachHang = PTP.makhachhang
GO
/****** Object:  StoredProcedure [dbo].[usp_ThuePhongMoi]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThuePhongMoi] @map nvarchar(50)
as
begin
	update Phong set TinhTrang =N'Hoạt Động' where MaPhong=@map
end
GO
/****** Object:  StoredProcedure [dbo].[usp_timkh]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_timkh] @tk nvarchar(50)
as
begin
select * from Khach_Hang where MaKhachHang like '%' +@tk +'%' or TenKhachHang like '%' +@tk +'%'or SoCMND like '%' +@tk +'%' or DienThoai like '%' +@tk +'%' or QuocTich like '%' +@tk +'%'
end

GO
/****** Object:  StoredProcedure [dbo].[usp_traphong]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_traphong] @map nvarchar(50)
as
begin
update PHONG set TinhTrang=N'Trống' where Maphong=@map
end
GO
/****** Object:  StoredProcedure [dbo].[usp_updatechiphi]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
					CREATE proc [dbo].[usp_updatechiphi] @machiphi int
					as
					begin
					update ChiPhi Set TinhTrang = 'Roi'where MaChiPhi=@machiphi
					end

GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateDV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_UpdateDV]
@Madv varchar(50) ,
@tendv nvarchar(50),
@g nvarchar (50),
@l nvarchar(50)

,@pResultCode_DV varchar(50) output
,@pResultMessage_DV nvarchar(100) output

AS
BEGIN
 IF NOT EXISTS(SELECT   MaDichVu  from Dich_Vu WHERE MaDichVu = @Madv)
 BEGIN
  SELECT @pResultCode_DV = '-1', @pResultMessage_DV = N'Không tồn tại Mã Dịch Vụ! 
Vui lòng thêm mới Nhân Viên trước khi sửa thông tin của Nhân Viên'
 END
 ELSE
 BEGIN
  UPDATE Dich_Vu 
  SET TenDichVu = @tendv,DonGia = @g,MaLoaiDichVu = @l

  WHERE MaDichVu = @Madv
  SELECT @pResultCode_DV = MaDichVu , @pResultMessage_DV = N'Sửa thông tin thành công' FROM Dich_Vu WHERE MaDichVu = @Madv
 END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateKH]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_UpdateKH]
@MaKhachHang varchar(50) ,
@TenKhachHang nvarchar(50),
@GioiTinh nvarchar(50) ,
@QuocTich nvarchar(50),
@SoCMND nvarchar(50),
@DiaChi nvarchar(50),
@DienThoai varchar(50)
,@pResultCode_KH varchar(50) output
,@pResultMessage_KH nvarchar(100) output
AS
BEGIN
 IF NOT EXISTS(SELECT MaKhachHang from KHACH_HANG WHERE MaKhachHang = @MaKhachHang)
 BEGIN
  SELECT @pResultCode_KH = '-1', @pResultMessage_KH = N'Không tồn tại Mã Nhân Viên! 
Vui lòng thêm mới Nhân Viên trước khi sửa thông tin của Nhân Viên'
 END
 ELSE
 BEGIN
  UPDATE KHACH_HANG 
  SET TenKhachHang = @TenKhachHang,QuocTich = @QuocTich,GioiTinh = @GioiTinh,
  SoCMND=@SoCMND, DiaChi = @DiaChi,DienThoai = @DienThoai
  WHERE MaKhachHang = @MaKhachHang
  SELECT @pResultCode_KH = MaKhachHang , @pResultMessage_KH = N'Sửa thông tin thành công' FROM KHACH_HANG WHERE MaKhachHang = @MaKhachHang
 END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_CheckUser]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_CheckUser]
@psUsername varchar(50),
@psPassword varchar(50),
@pResultCode int output,
@pResultMessage nvarchar(50) output
AS
BEGIN
 DECLARE @lPasswordHash varchar(32)
 SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
 IF Not Exists(Select ID from NGUOI_DUNG where TaiKhoan = @psUsername and MatKhau = @lPasswordHash)
 BEGIN
  SELECT @pResultCode = -1, @pResultMessage = N'Đăng Nhập Thất Bại! Xin Vui Lòng Thử Lại'
  RETURN
 END
 ELSE
 BEGIN
  SELECT @pResultCode = ID , @pResultMessage = N'Đăng Nhập Thành Công'  from NGUOI_DUNG where TaiKhoan = @psUsername and MatKhau = @lPasswordHash
  RETURN
 END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_User_CreateUser]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_User_CreateUser]
 @psUsername varchar(50)
 ,@psPassword varchar(255)
 ,@pResultCode int output
 ,@pResultMessage varchar(50) output
AS
BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;
 DECLARE @lPasswordHash varchar(32)

 IF Exists(Select ID from NGUOI_DUNG WHERE TaiKhoan = @psUsername)
 BEGIN
  SELECT @pResultCode = -1, @pResultMessage = N'Tài Khoản Đã Tồn Tại'
  RETURN
 END

 SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)

 INSERT INTO NGUOI_DUNG(TaiKhoan, MatKhau) Values(@psUsername, @lPasswordHash)
 
 SELECT @pResultCode = SCOPE_IDENTITY(), @pResultMessage = N'Đăng Ký Thành Công'
 RETURN
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_GetUserListPermision]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_GetUserListPermision]
@UserName varchar(50)
AS
BEGIN
 SELECT TaiKhoan,ChucVu FROM NGUOI_DUNG WHERE  TaiKhoan = @UserName 
END

GO
/****** Object:  StoredProcedure [dbo].[usp_xemphieudat]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_xemphieudat] as
select P.MaPhong,P.TinhTrang,MaKhachHang,NgayDat,NgayNhan,NgayTraDuKien,NgayTraThucTe from Phieu_Dat_phong PDP join CHI_TIET_PHIEU_DAT_PHONG CTPD on CTPD.MaPhieu=PDP.MaPhieu join PHONG P on P.MaPhong=PDP.MaPhong
where PDP.tinhtrang =N'Chưa' and P.TinhTrang=N'Đặt Phòng'

GO
/****** Object:  StoredProcedure [dbo].[usp_xemvalocPhieuDat]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_xemvalocPhieuDat] @maphong nvarchar(50)
as
select P.MaPhong,P.TinhTrang,MaKhachHang,NgayDat,NgayNhan,NgayTraDuKien,NgayTraThucTe from Phieu_Dat_phong PDP join CHI_TIET_PHIEU_DAT_PHONG CTPD on CTPD.MaPhieu=PDP.MaPhieu join PHONG P on P.MaPhong=PDP.MaPhong
where PDP.tinhtrang =N'Chưa' and P.TinhTrang=N'Đặt Phòng' and P.MaPhong=@maphong
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaDV]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_XoaDV] @madv nvarchar(50)
as
begin
	Delete from DICH_VU  where MaDichVu = @madv
end
GO
/****** Object:  StoredProcedure [dbo].[usp_xoap]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_xoap]
@map varchar (50)
as
begin
	delete from PHONG where MaPhong = @map
end


GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_DAT_PHONG]    Script Date: 12/19/2017 10:38:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_DAT_PHONG](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [int] NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[NgayDat] [date] NULL,
	[NgayNhan] [date] NULL,
	[NgayTraDuKien] [date] NULL,
	[NgayTraThucTe] [date] NULL,
 CONSTRAINT [PK_CHI_TIET_PHIEU_DAT_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_THUE_PHONG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[NgayDatPhong] [date] NULL,
	[NgayTraPhong] [date] NULL,
	[MaPhieuThue] [int] NULL,
 CONSTRAINT [PK__CHI_TIET__AA39FDF3813247CE] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiPhi]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiPhi](
	[MaChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_ChiPhi] PRIMARY KEY CLUSTERED 
(
	[MaChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietChiPhi]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChiPhi](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaChiPhi] [int] NULL,
	[MaDV] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietChiPhi] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICH_VU]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DICH_VU](
	[MaDichVu] [nvarchar](50) NOT NULL,
	[MaLoaiDichVu] [varchar](10) NOT NULL,
	[DonGia] [numeric](10, 0) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
 CONSTRAINT [PK__DICH_VU__C0E6DE8FA6A9F959] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[SoCMND] [int] NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [int] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QuocTich] [nvarchar](50) NULL,
 CONSTRAINT [PK__KHACH_HA__88D2F0E5411B3438] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAI_DICH_VU]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAI_DICH_VU](
	[MaLoaiDichVu] [varchar](10) NOT NULL,
	[TenLoaiDichVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[MaLoaiPhong] [varchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[DonGia] [numeric](10, 0) NOT NULL,
	[SucChua] [int] NOT NULL,
 CONSTRAINT [PK__LOAI_PHO__23021217CF4A6085] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
	[ChucVu] [bit] NULL,
 CONSTRAINT [PK__NGUOI_DU__6A6A1F9A7A862B9C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MA_NHAN_VIEN] [varchar](50) NOT NULL,
	[TEN_NHAN_VIEN] [nvarchar](50) NULL,
	[NAM_SINH] [date] NULL,
	[CHUC_VU] [nvarchar](50) NULL,
	[GIOI_TINH] [nvarchar](5) NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[MA_NHAN_VIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_DAT_PHONG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_DAT_PHONG](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__PHIEU_NH__74A2EA3EB4672615] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEU_THUE_PHONG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_THUE_PHONG](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__PHIEU_TH__083228162C489362] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 12/19/2017 10:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [varchar](10) NOT NULL,
	[MaLoaiPhong] [varchar](10) NOT NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__PHONG__20BD5E5BB0A0653E] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHONG_PHIEU_THUE_PHONG] FOREIGN KEY([MaChiTiet])
REFERENCES [dbo].[PHIEU_THUE_PHONG] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG] CHECK CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHONG_PHIEU_THUE_PHONG]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHONG_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG] CHECK CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHONG_PHONG]
GO
ALTER TABLE [dbo].[ChiTietChiPhi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietChiPhi_ChiPhi] FOREIGN KEY([MaChiPhi])
REFERENCES [dbo].[ChiPhi] ([MaChiPhi])
GO
ALTER TABLE [dbo].[ChiTietChiPhi] CHECK CONSTRAINT [FK_ChiTietChiPhi_ChiPhi]
GO
ALTER TABLE [dbo].[ChiTietChiPhi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietChiPhi_DICH_VU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICH_VU] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietChiPhi] CHECK CONSTRAINT [FK_ChiTietChiPhi_DICH_VU]
GO
ALTER TABLE [dbo].[DICH_VU]  WITH CHECK ADD  CONSTRAINT [FK_DICH_VU_LOAI_DICH_VU] FOREIGN KEY([MaLoaiDichVu])
REFERENCES [dbo].[LOAI_DICH_VU] ([MaLoaiDichVu])
GO
ALTER TABLE [dbo].[DICH_VU] CHECK CONSTRAINT [FK_DICH_VU_LOAI_DICH_VU]
GO

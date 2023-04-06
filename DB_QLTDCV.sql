

create database QLTDVC
use QLTDVC
create table TaiKhoan(
	email nvarchar(50),
	_user nvarchar(50),
	pass nvarchar(50)
)


CREATE PROC Login_Server
@user nvarchar(50),
@pass nvarchar(50)
as
BEGIN
	SELECT * FROM TaiKhoan WHERE _user = @user AND pass = @pass
END

exec Login_Server @user = admin, @pass = 1
CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo
--Tạo bảng bàn ăn
CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

--tạo bảng tài khoản
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'out',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Department
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	countStaff int default 0
)
GO

create TABLE Staff
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	dateBirth datetime,
	dateWorkIn datetime default getDate(),
	idDepartment INT NOT NULL,
	salary FLOAT NOT NULL DEFAULT 0,
	address NVARCHAR(100),
	phonenumber NVARCHAR(100)
	
	FOREIGN KEY (idDepartment) REFERENCES dbo.Department(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO


CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'K9' , -- UserName - nvarchar(100)
          N'RongK9' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
EXEC dbo.USP_GetAccountByUserName @userName = N'K9' -- nvarchar(100)
go

Create PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
-- them ban`
deCLARE @i INT = 1

WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
select * from TableFood
go
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood 
go

go
EXec USP_GetTableList
go
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Cà phê'  -- name - nvarchar(100)
          )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Trà' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Trà sữa' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Sinh tố' )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước ngọt' )
GO
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Đồ ăn nhanh' )
GO
-- thêm món ăn
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Mực một nắng nước sa tế', -- name - nvarchar(100)
          1, -- idCategory - int
          120000)

-- thêm bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          0  -- status - int
        )
        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )

-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          6, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )         
          
GO
-- thêm bộ phận
INSERT dbo.Department
        ( name )
VALUES  ( N'Chạy bàn' )

INSERT dbo.Department
        ( name )
VALUES  ( N'Pha chế' )

INSERT dbo.Department
        ( name )
VALUES  ( N'Bếp' )

INSERT dbo.Department
        ( name )
VALUES  ( N'Thu ngân' )

INSERT dbo.Department
        ( name )
VALUES  ( N'Bảo vệ' )
go


-- proc thêm hóa đơn
create proc USP_InsertBill
@idTable INT
as
BEGIN INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          @idTable , -- idTable - int
          0  -- status - int
        )
END
GO
--Proc thêm chi tiết hóa đơn
Alter PROc USP_InsertBillInfo
@idBill int, @idFood int, @count int
AS
BEGIN

 DECLARE @isExitsBillInfo int
 DECLARE @foodCount int =1
 Select @isExitsBillInfo = id,@foodCount =bi.count
 from dbo.BillInfo as bi 
 where idBill=@idBill and idFood=@idFood
	if(@isExitsBillInfo >0)
		begin
			declare @newCount int =@foodCount + @count
		 if( @newCount>0)
	 		 update dbo.BillInfo set count = @foodCount + @count where idFood=@idFood and idBill=@idBill
			 
		 else
		 delete dbo.BillInfo where idBill=@idBill and idFood =@idFood
		 end
	else
	begin
	INSERT	dbo.BillInfo
			( idBill, idFood, count )
	VALUES  ( @idBill, -- idBill - int
			  @idFood, -- idFood - int
			  @count  -- count - int
			  )

	END

end
GO


CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
		BEGIN
	
			PRINT @idTable
			PRINT @idBill
			PRINT @count
			
			UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
		END		
	ELSE
		BEGIN
		PRINT @idTable
			PRINT @idBill
			PRINT @count
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
		end
	
END
GO
ALTER TABLE dbo.Food ADD status nvarchar (50)
GO
ALTER TABLE dbo.FoodCategory ADD status nvarchar (50)
GO
Create TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @idFood INT
	
	SELECT @idFood = idFood FROM dbo.BillInfo WHERE idBill = @idBill

	DECLARE @idCategory INT
	
	SELECT @idCategory = idCategory FROM dbo.Food WHERE id = @idFood
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
	--
	DECLARE @count1 int = 0
	
	SELECT @count1 = COUNT(*) FROM dbo.BillInfo bi, dbo.Bill b WHERE b.id=bi.idBill  and bi.idFood = @idFood and status = 1
		IF (@count1 >0)
		update dbo.Food set status = N'Đã lưu hành'  where id= @idFood
	DECLARE @count2 int = 0
	--
	SELECT @count2 = COUNT(*) FROM dbo.BillInfo bi, dbo.Bill b,dbo.Food f  WHERE b.id=bi.idBill  and f.id=bi.idFood and f.idCategory=@idCategory and bi.idFood = @idFood and b.status = 1
		IF (@count2 >0)
		update dbo.FoodCategory set status = N'Đã lưu hành'  where id= @idCategory
END
GO
--
ALTER TABLE dbo.Bill ADD discount INT
GO

UPDATE dbo.Bill SET discount = 0
GO

ALTER TABLE dbo.Bill ADD totalPrice FLOAT
GO
-- chuyen ban
Alter PROC USP_SwitchTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO
select * from Bill where status =0
select * from BillInfo 

Create PROC USP_MergeTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	SELECT id INTO IDBill1 FROM dbo.BillInfo WHERE idBill = @idFirstBill and idFood in (select idFood from dbo.BillInfo where idBill=@idSeconrdBill) 

	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill

	;with billnew as (select idBill,idFood,SUM(count) as sl  from BillInfo where idBill=@idSeconrdBill group by idFood,idBill)
	
	update BillInfo set count=billnew.sl from BillInfo bi,billnew where bi.idFood=billnew.idFood and bi.idBill=@idSeconrdBill

	delete BillInfo where id in(select * from Idbill1)

	drop table IDBill1

	delete Bill where status =0 and idTable= @idTable1

	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
	
	END
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO


CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO


GO
-- in hóa đơn theo ngày
create PROC USP_GetListBillByDate
@checkIn datetime, @checkOut datetime
AS 
BEGIN
	SELECT b.id as[Mã hóa đơn],t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá(%)]
	FROM dbo.Bill b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
go
-- in hóa đơn theo ngày và trang
alter PROC USP_GetListBillByDateAndPage
@checkIn datetime, @checkOut datetime, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.id as[Mã hóa đơn],t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá(%)]
	FROM dbo.Bill b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE [Mã hóa đơn] NOT IN (SELECT TOP (@exceptRows) [Mã hóa đơn] FROM BillShow)
END
GO

alter PROC USP_GetNumBillByDate
@checkIn datetime, @checkOut datetime
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
--exec USP_GetNumBillByDate '2023-04-14' , '2023-04-14'

/*SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE Month(DateCheckIn) ='04' AND Month(DateCheckIn) <='04'  AND b.status = 1
	AND t.id = b.idTable
	*/
	--

create Trigger UTG_AddStaff
ON dbo.Staff FOR INSERT
AS
BEGIN
	DECLARE @idDepartment int
	select  @idDepartment = idDepartment from inserted

	Declare @idDpm int
	select @idDpm = id from Department where id=@idDepartment

	;with StaffCount as (select idDepartment,count(idDepartment)as countDpm from Staff group by idDepartment) 

	update dbo.Department set countStaff=sc.countDpm from StaffCount sc,dbo.Department d where id=@idDpm and sc.idDepartment=d.id
END
GO

create Trigger UTG_EditStaff
ON dbo.Staff FOR Update
AS
BEGIN
	
	select idDepartment,count(idDepartment)as countDpm into StaffCount1 from Staff group by idDepartment
	update dbo.Department set countStaff=sc.countDpm from StaffCount1 sc,dbo.Department d where sc.idDepartment=d.id
	update dbo.Department set countStaff=0 where id not in(select idDepartment from dbo.StaffCount1)
	drop table StaffCount1
END
GO

create Trigger UTG_DeleteStaff
ON dbo.Staff FOR Delete
AS
BEGIN
	DECLARE @idDepartment int
	select  @idDepartment = idDepartment from Deleted

	Declare @idDpm int
	select @idDpm = id from Department where id=@idDepartment

	;with StaffCount as (select idDepartment,count(idDepartment)as countDpm from Staff group by idDepartment) 

	update dbo.Department set countStaff=sc.countDpm from StaffCount sc,dbo.Department d where id=@idDpm and sc.idDepartment=d.id
END
GO
drop Trigger UTG_DeleteBill 
on dbo.Bill For Delete
as
begin
	DECLARE @idBilldel INT
	DECLARE @idBill INT
	select @idBill= id from deleted
	select @idBilldel=idBill from BillInfo where idBill=@idBill
	delete BillInfo where idBill=@idBilldel
end
select * from Bill where status = 1
select * from BillInfo

Alter PROC USP_GetBillInfoToPrintBill
@idBill int
AS 
BEGIN
	select bi.idBill,t.name,b.DateCheckIn,b.DateCheckOut,b.discount,b.totalPrice,f.name as foodname ,bi.count,f.price,f.price*bi.count as total from TableFood t ,Bill b ,BillInfo bi , Food f
    where b.status=0 and b.id=@idBill and b.id=bi.idBill and b.idTable=t.id and bi.idFood=f.id 
END
GO
select count(id)as totalBill,sum(totalPrice) as revenue  from Bill where status =1
create PROC USP_GetTotalBillByDate
@checkIn datetime, @checkOut datetime
AS 
BEGIN
	SELECT COUNT(id)
	FROM dbo.Bill 
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND status = 1
END
GO

create PROC USP_GetRevenueByDate
@checkIn datetime, @checkOut datetime
AS 
BEGIN

	SELECT sum(totalPrice)
	FROM dbo.Bill 
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND status = 1
END
GO
create PROC USP_GetRevenueListbyMonth
@checkOut datetime
AS 
BEGIN
	select day(DateCheckOut) as dayre,count(id)as totalBill,sum(totalPrice) as revenue  from Bill where status =1 and MONTH(DateCheckOut)=MONTH(@checkOut) group by day(DateCheckOut) 
END
GO
select * from Bill
	--select Month(DateCheckIn) as [Tháng],SUM(totalPrice)as[Doanh thu] from Bill where status=1
	--group by month(DateCheckIn)
	select day(DateCheckOut) as dayre,count(id)as totalBill,sum(totalPrice) as revenue  from Bill where status =1 and MONTH(DateCheckOut)=5 group by day(DateCheckOut)
Alter PROC USP_GetTop5Food
@checkIn datetime, @checkOut datetime
AS 
BEGIN
	select top 5 count(bi.idFood) as countFood, f.name as foodName from BillInfo bi,Bill b ,Food f
	where b.id=bi.idBill and f.id=bi.idFood and b.DateCheckIn >= @checkIn AND b.DateCheckOut <= @checkOut AND b.status = 1
	group by f.name
	order by count(bi.idFood) desc
end
go

create TABLE Report
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	dateCreate datetime default getDate(),
	dateIn datetime ,
	dateOut datetime,
)
GO
select * from Report
Alter PROC USP_GetRevenueListbyDate
@checkIn datetime, @checkOut datetime
AS 
BEGIN
	   ; with ReTest as (select day(DateCheckOut) AS ngay, MONTH(DateCheckOut) AS thang,count(id)as totalBill,sum(totalPrice) as revenue  from Bill 
		where status=1 and DateCheckIn>= @checkIn and DateCheckOut <= @checkOut group by day(DateCheckOut), month(DateCheckOut))
		select concat (rt.ngay,'/',rt.thang) as [dayre], rt.totalBill,rt.revenue
		from ReTest rt	
		group by concat (rt.ngay,'/',rt.thang),rt.thang,rt.totalBill,rt.revenue
		order by rt.thang
END
GO
exec USP_GetRevenueListbyDate '2023-04-01 00:00:00', '2023-05-31 23:59:59'

Create PROC USP_GetRepotByID
@idRe int
AS 
BEGIN
	    select * from Report where id=@idRe
END
GO
--Drop PROC USP_GetInfoReportbyTimeandId
--@checkIn datetime, @checkOut datetime
--AS 
--BEGIN
--		declare @idRe int
--		select @idRe=max(id) from Report
--		select day(b.DateCheckOut) as dayre,count(b.id)as totalBill,sum(totalPrice) as revenue,r.name,r.dateIn,r.dateOut,r.dateCreate
--		from Bill b, Report r
--		where b.status =1 and b.DateCheckIn>= @checkIn AND b.DateCheckOut <= @checkOut
--		and r.id=@idRe
--		--and r.dateIn=b.DateCheckIn and r.dateOut=b.DateCheckOut
--		group by day(DateCheckOut),r.name,r.dateIn,r.dateOut,r.dateCreate
--END
--GO

select day(b.DateCheckOut) as dayre,count(b.id)as totalBill,sum(totalPrice) as revenue
--r.name,r.dateIn,r.dateOut,r.dateCreate
		from Bill b
		where b.status =1 and b.DateCheckIn >= '2023-05-01 00:00:00' AND b.DateCheckOut <= '2023-05-31 23:59:59'
		--and r.id=13
		--and r.dateIn=b.DateCheckIn and r.dateOut=b.DateCheckOut
		group by day(DateCheckOut)
		,r.name,r.dateIn,r.dateOut,r.dateCreate

	

Alter PROC USP_GetInfoReportbyTime
@checkIn datetime, @checkOut datetime
AS 
BEGIN
		declare @idRe int
		select @idRe=max(id) from Report
		; with ReTest as (select day(DateCheckOut) AS ngay, MONTH(DateCheckOut) AS thang,count(id)as totalBill,sum(totalPrice) as revenue  from Bill 
		where status=1 and DateCheckIn>= @checkIn and DateCheckOut <= @checkOut group by day(DateCheckOut), month(DateCheckOut))
		select concat (rt.ngay,'/',rt.thang) as [dayre], rt.totalBill,rt.revenue,r.name,r.dateCreate,r.dateIn,r.dateOut
		from ReTest rt,Report r where r.id=@idRe
		group by concat (rt.ngay,'/',rt.thang),rt.thang,rt.totalBill,rt.revenue,r.name,r.dateCreate,r.dateIn,r.dateOut
		order by rt.thang
		--
END
GO





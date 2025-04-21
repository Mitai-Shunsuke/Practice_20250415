DROP TABLE IM_STAFF

--■社員	
CREATE TABLE IM_STAFF(
StaffCD INT PRIMARY KEY IDENTITY(1000,1),	--担当者CD(1000開始、1増加)(主キー)
"Password" VARCHAR(8),	--パスワード(8文字)
StaffName NVARCHAR(30)	--担当者名
)
--■社員マスタ
CREATE TABLE IM_STAFF(
StaffID INT PRIMARY KEY IDENTITY(1,1),--担当者ID
"Password" VARCHAR(4), --パスワード
StaffName NVARCHAR(50)--担当者名
)
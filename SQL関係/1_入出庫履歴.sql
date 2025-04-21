DROP TABLE ID_IO_HISTORY

--■入出庫履歴	
CREATE TABLE ID_IO_HISTORY( 
HistoryCD INT PRIMARY KEY IDENTITY(1,1),   --主キー
IODate DATE,	--日付
ItemCD INT, 	--商品CD
IsReceived BIT,	--入庫or出庫フラグ
Moving INT,	--移動数
StaffCD INT 	--担当者CD
)


ALTER TABLE ID_IO_HISTORY
ADD Remarks NVARCHAR(50)
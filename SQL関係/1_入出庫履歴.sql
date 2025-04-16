--■入出庫履歴	
CREATE TABLE ID_IO_HISTORY( 
HistoryCD INT PRIMARY KEY IDENTITY(1,1),   --主キー
"Date" DATE,	--日付
ItemCD INT, 	--商品CD
IOflg BIT,	--入庫or出庫フラグ
Moving INT,	--移動数
StaffCD INT 	--担当者CD
)
DROP TABLE ID_IO_HISTORY

--�����o�ɗ���	
CREATE TABLE ID_IO_HISTORY( 
HistoryCD INT PRIMARY KEY IDENTITY(1,1),   --��L�[
IODate DATE,	--���t
ItemCD INT, 	--���iCD
IsReceived BIT,	--����or�o�Ƀt���O
Moving INT,	--�ړ���
StaffCD INT 	--�S����CD
)


ALTER TABLE ID_IO_HISTORY
ADD Remarks NVARCHAR(50)
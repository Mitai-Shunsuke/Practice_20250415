DROP TABLE ID_IO_HISTORY

--¡üoÉð	
CREATE TABLE ID_IO_HISTORY( 
HistoryCD INT PRIMARY KEY IDENTITY(1,1),   --åL[
IODate DATE,	--út
ItemCD INT, 	--¤iCD
IsReceived BIT,	--üÉoroÉtO
Moving INT,	--Ú®
StaffCD INT 	--SÒCD
)


ALTER TABLE ID_IO_HISTORY
ADD Remarks NVARCHAR(50)
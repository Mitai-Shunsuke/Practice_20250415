--¡üoÉð
CREATE TABLE ID_IO_HISTORY(
ItemClassID INT REFERENCES IM_ITEM_CLASS(ItemClassID),--¤iªÞID
ItemClassName NVARCHAR(50),--¤iªÞ¼
ItemID INT REFERENCES IM_ITEM(ItemID),--¤iID
ItemName NVARCHAR(50) ,--¤i¼
Stocks INT --ÝÉ
)
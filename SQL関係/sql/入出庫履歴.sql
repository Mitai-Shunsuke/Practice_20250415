--■入出庫履歴
CREATE TABLE ID_IO_HISTORY(
ItemClassID INT REFERENCES IM_ITEM_CLASS(ItemClassID),--商品分類ID
ItemClassName NVARCHAR(50),--商品分類名
ItemID INT REFERENCES IM_ITEM(ItemID),--商品ID
ItemName NVARCHAR(50) ,--商品名
Stocks INT --在庫数
)
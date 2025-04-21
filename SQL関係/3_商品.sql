DROP TABLE IM_ITEM

--■商品	
CREATE TABLE IM_ITEM(
ItemClassCD INT,	--商品分類CD
ItemCD INT PRIMARY KEY,	--商品CD(主キー)
ItemName NVARCHAR(30)   --商品名
)
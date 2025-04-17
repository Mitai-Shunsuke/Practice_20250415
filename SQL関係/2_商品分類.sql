DROP TABLE IM_ITEM_CLASS

--■商品分類	
CREATE TABLE IM_ITEM_CLASS(
ItemClassCD INT PRIMARY KEY,	--商品分類CD(主キー)
ItemClassName NVARCHAR(30),	--分類名
Stocks INT 	--維持費
)
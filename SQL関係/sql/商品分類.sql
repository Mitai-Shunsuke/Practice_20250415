--■商品分類マスタ
CREATE TABLE IM_ITEM_CLASS(
ItemClassID INT PRIMARY KEY, --商品分類CD
ClassName NVARCHAR(50),--分類名
KeepMoney int --維持費
)
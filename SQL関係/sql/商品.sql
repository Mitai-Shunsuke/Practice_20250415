--¡¤i}X^
CREATE TABLE IM_ITEM(
ItemClassID INT REFERENCES IM_ITEM_CLASS(ItemClassID),--¤iªÞID(OQÆ)
ItemID INT PRIMARY KEY,--¤iID
ItemName NVARCHAR(50) --¤i¼
)
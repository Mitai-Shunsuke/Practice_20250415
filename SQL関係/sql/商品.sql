--�����i�}�X�^
CREATE TABLE IM_ITEM(
ItemClassID INT REFERENCES IM_ITEM_CLASS(ItemClassID),--���i����ID(�O���Q��)
ItemID INT PRIMARY KEY,--���iID
ItemName NVARCHAR(50) --���i��
)
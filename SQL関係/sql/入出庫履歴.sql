--�����o�ɗ���
CREATE TABLE ID_IO_HISTORY(
ItemClassID INT REFERENCES IM_ITEM_CLASS(ItemClassID),--���i����ID
ItemClassName NVARCHAR(50),--���i���ޖ�
ItemID INT REFERENCES IM_ITEM(ItemID),--���iID
ItemName NVARCHAR(50) ,--���i��
Stocks INT --�݌ɐ�
)
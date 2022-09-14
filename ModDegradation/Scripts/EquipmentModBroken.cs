using System;
using System.Xml;
public class EquipmentModBroken : TargetedCompareRequirementBase
{
	private string item;
	private FastTags tagsToCompare;
	public override bool ParseXmlAttribute(XmlAttribute _attribute)
	{
		bool flag = base.ParseXmlAttribute(_attribute);
		if (!flag)
		{
			string name = _attribute.Name;
			if (name != null)
			{
				if (name == "item")
				{
					item = _attribute.Value;
					return true;
				}
				if (name == "tags")
				{
					tagsToCompare = FastTags.Parse(_attribute.Value);
					return true;
				}
			}
		}
		return flag;
	}
	public override bool IsValid(MinEventParams _params)
	{
		if (!base.IsValid(_params))
		{
			return false;
		}
		if (target == null)
		{
			return false;
		}
		bool flag = IsItemBroken(target);
		if (!invert)
		{
			return flag;
		}
		return !flag;
	}
	public bool IsItemBroken(EntityAlive target)
	{
		ItemValue equipmentItem = GetItem(target);
		if (equipmentItem != null)
		{
			for (int j = 0; j < equipmentItem.Modifications.Length; j++)
			{
				if (equipmentItem.Modifications[j] != null)
				{
					if (equipmentItem.Modifications[j].ItemClass != null)
					{
						if (equipmentItem.Modifications[j].ItemClass.Name == item)
						{
							return (equipmentItem.Modifications[j].PercentUsesLeft <= 0f);
						}
					}
				}
			}
		}
		return true;
	}
	public ItemValue GetItem(EntityAlive target)
	{
		int slots = target.equipment.GetSlotCount();
		for (int i = 0; i < slots; i++)
		{
			ItemValue item = target.equipment.GetSlotItem(i);
			if (item.ItemClass != null)
			{
				if (item.ItemClass.HasAllTags(tagsToCompare))
				{
					return item;
				}
			}
		}
		return null;
	}
}
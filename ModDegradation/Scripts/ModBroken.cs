using System;
using System.Xml;
public class ModBroken : TargetedCompareRequirementBase
{
	private string item;
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
		ItemValue holdingItem = this.target.inventory.holdingItemItemValue;
		if (holdingItem != null)
		{
			for (int j = 0; j < holdingItem.Modifications.Length; j++)
			{
				if (holdingItem.Modifications[j] != null)
				{
					if (holdingItem.Modifications[j].ItemClass != null)
					{
						if (holdingItem.Modifications[j].ItemClass.Name == item)
						{
							return (holdingItem.Modifications[j].PercentUsesLeft <= 0f);
						}
					}
				}
			}
		}
		return true;
	}
}
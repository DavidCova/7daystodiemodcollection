using System.Xml;
using UnityEngine;

public class MinEventActionChangeEquipmentDurability : MinEventActionTargetedBase
{
    private FastTags tagsToCompare;
    float value;
    public override bool ParseXmlAttribute(XmlAttribute _attribute)
    {
        bool flag = base.ParseXmlAttribute(_attribute);
        bool flag2 = !flag;
        if (flag2)
        {
            string name = _attribute.Name;
            if (name != null)
            {
                if (name == "tags")
                {
                    tagsToCompare = FastTags.Parse(_attribute.Value);
                    return true;
                }
                if (name == "value")
                {
                    value = StringParsers.ParseFloat(_attribute.Value);
                    return true;
                }
            }
        }
        return flag;
    }
    public override void Execute(MinEventParams _params)
    {
        if (_params.Self == null)
        {
            return;
        }
        for (int i = 0; i < targets.Count; i++)
        {
            if (!tagsToCompare.IsEmpty)
            {
                ItemValue item = GetItem(targets[i]);
                if (item != null)
                {
                    ChangeDurability(item);
                }
            }
        }
        return;
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
    public void ChangeDurability(ItemValue item)
    {
        item.UseTimes -= value;
        if (item.UseTimes >= item.MaxUseTimes)
        {
            item.UseTimes = item.MaxUseTimes;
        }
        else if (item.UseTimes <= 0)
        {
            item.UseTimes = 0;
        }
    }
}
using System.Xml;
using Audio;

public class MinEventActionChangeEquipmentModDurability : MinEventActionTargetedBase
{
    private string item;
    float value;
    private FastTags tagsToCompare;
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
                if (name == "item")
                {
                    item = _attribute.Value;
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
            if (item == null)
            {
                return;
            }
            else
            {
                ItemValue equipmentItem = null;
                if (!tagsToCompare.IsEmpty)
                {
                    equipmentItem = GetItem(targets[i]);
                }
                if (equipmentItem != null)
                {
                    for (int j = 0; j < equipmentItem.Modifications.Length; j++)
                    {
                        ItemValue mod = equipmentItem.Modifications[j];
                        if (mod != null)
                        {
                            if (mod.ItemClass != null)
                            {
                                if (mod.ItemClass.Name == item)
                                {
                                    mod.UseTimes -= value;
                                    if (mod.UseTimes >= mod.MaxUseTimes)
                                    {
                                        if (mod.ItemClass.RepairTools == null)
                                        {
                                            if ((mod.ItemClass.Properties.Values.ContainsKey(ItemClass.PropSoundDestroy)))
                                            {
                                                Manager.BroadcastPlay(targets[i], mod.ItemClass.Properties.Values[ItemClass.PropSoundDestroy]);
                                            }
                                            mod.FireEvent(MinEventTypes.onSelfItemDeactivate, MinEventParams.CachedEventParam);
                                            mod.Clear();
                                            targets[i].equipment.InitializeEquipmentTransforms();
                                        }
                                        else
                                        {
                                            mod.UseTimes = mod.MaxUseTimes;
                                            mod.FireEvent(MinEventTypes.onSelfItemDeactivate, MinEventParams.CachedEventParam);
                                            targets[i].equipment.InitializeEquipmentTransforms();
                                        }
                                    }
                                    else if (mod.UseTimes <= 0)
                                    {
                                        mod.UseTimes = 0;
                                    }
                                }
                            }
                        }
                    }
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
}
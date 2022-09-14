using System.Xml;
using Audio;

public class MinEventActionChangeModDurability : MinEventActionTargetedBase
{
    private string item;
    float value;
    bool destroy;
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
                if (name == "value")
                {
                    value = StringParsers.ParseFloat(_attribute.Value);
                    return true;
                }
                if (name == "destroy")
                {
                    destroy = StringParsers.ParseBool(_attribute.Value);
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
            if (item == null && tagsToCompare.IsEmpty)
            {
                return;
            }
            else
            {
                ItemValue holdingItem = targets[i].inventory.holdingItemItemValue;
                if (holdingItem != null)
                {
                    for (int j = 0; j < holdingItem.Modifications.Length; j++)
                    {
                        ItemValue mod = holdingItem.Modifications[j];
                        if (mod != null)
                        {
                            if (mod.ItemClass != null)
                            {
                                if ((!tagsToCompare.IsEmpty && mod.ItemClass.HasAnyTags(tagsToCompare)) || ((mod.ItemClass.Name != null) && (mod.ItemClass.Name == item)))
                                {
                                    mod.UseTimes -= value;
                                    targets[i].inventory.CallOnToolbeltChangedInternal();
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
                                            targets[i].inventory.ForceHoldingItemUpdate();
                                        }
                                        else
                                        {
                                            mod.UseTimes = mod.MaxUseTimes;
                                            targets[i].inventory.CallOnToolbeltChangedInternal();
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
}
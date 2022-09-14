using System.Xml;
using Audio;

public class MinEventActionChangeHoldingItemDurability : MinEventActionTargetedBase
{
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
            ItemValue holdingItem = targets[i].inventory.holdingItemItemValue;
            if (holdingItem != null)
            {
                holdingItem.UseTimes -= value;
                targets[i].inventory.CallOnToolbeltChangedInternal();
                if (holdingItem.UseTimes >= holdingItem.MaxUseTimes)
                {
                    if (holdingItem.ItemClass.RepairTools == null)
                    {
                        if ((holdingItem.ItemClass.Properties.Values.ContainsKey(ItemClass.PropSoundDestroy)))
                        {
                            Manager.BroadcastPlay(targets[i], holdingItem.ItemClass.Properties.Values[ItemClass.PropSoundDestroy]);
                        }
                        holdingItem.FireEvent(MinEventTypes.onSelfItemDeactivate, MinEventParams.CachedEventParam);
                        holdingItem.Clear();
                        targets[i].inventory.ForceHoldingItemUpdate();
                        targets[i].inventory.CallOnToolbeltChangedInternal();
                    }
                    else
                    {
                        holdingItem.UseTimes = holdingItem.MaxUseTimes;
                        targets[i].inventory.ForceHoldingItemUpdate();
                        targets[i].inventory.CallOnToolbeltChangedInternal();
                    }
                }
                else if (holdingItem.UseTimes <= 0)
                {
                    holdingItem.UseTimes = 0;
                }
            }
        }
        return;
    }
}
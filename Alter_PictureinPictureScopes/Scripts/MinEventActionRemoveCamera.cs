using System.Xml;
using UnityEngine;

public class MinEventActionRemoveCamera : MinEventActionTargetedBase
{
    Transform scopeCameraTransform;
    public override bool ParseXmlAttribute(XmlAttribute _attribute)
    {
        bool flag = base.ParseXmlAttribute(_attribute);
        if (!flag)
        {
            string name = _attribute.Name;
            if (name != null)
            {
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
        for (int i = 0; i < this.targets.Count; i++)
        {
            EntityPlayerLocal entityPlayer = this.targets[i] as EntityPlayerLocal;
            if (entityPlayer != null)
            {
                scopeCameraTransform = entityPlayer.transform.FindInChilds("CameraCloneWeapon");
                if (scopeCameraTransform!=null)
                {
                    GameObject.Destroy(scopeCameraTransform);
                }
            }
        }
    }
}
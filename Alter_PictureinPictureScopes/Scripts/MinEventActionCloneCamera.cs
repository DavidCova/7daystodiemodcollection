using System.Xml;
using UnityEngine;

public class MinEventActionCloneCamera : MinEventActionTargetedBase
{
    GameObject newScopeCameraGO;
    Transform scopeCameraTransform;
    float fov, rot;
    public override bool ParseXmlAttribute(XmlAttribute _attribute)
    {
        bool flag = base.ParseXmlAttribute(_attribute);
        if (!flag)
        {
            string name = _attribute.Name;
            if (name != null)
            {
                if (name == "fov")
                {
                    this.fov = StringParsers.ParseFloat(_attribute.Value, 0, -1);
                    return true;
                }
                if (name == "rot")
                {
                    this.rot = StringParsers.ParseFloat(_attribute.Value, 0, -1);
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
        for (int i = 0; i < this.targets.Count; i++)
        {
            EntityPlayerLocal entityPlayer = this.targets[i] as EntityPlayerLocal;
            if (entityPlayer != null)
            {
                Transform cameraClonePlayer = entityPlayer.transform.FindInChilds("CameraCloneParent");
                if (cameraClonePlayer == null)
                {
                    return;
                }
                Transform oldScopeCameraTransform = entityPlayer.transform.FindInChilds("CameraCloneWeapon");
                if (oldScopeCameraTransform != null)
                {
                    oldScopeCameraTransform.gameObject.SetActive(false);
                    GameObject.Destroy(oldScopeCameraTransform.gameObject);
                }
                GameObject newScopeCameraParent = GameObject.Instantiate(cameraClonePlayer.gameObject);
                foreach (Transform child in newScopeCameraParent.transform)
                {
                    child.gameObject.SetActive(true);
                    newScopeCameraGO = child.gameObject;
                }

                scopeCameraTransform = entityPlayer.transform.FindInChilds("scopeCamera");
                Camera scopeCamera = scopeCameraTransform.GetComponent<Camera>();

                newScopeCameraGO.transform.parent = scopeCameraTransform.parent;
                newScopeCameraGO.transform.position = scopeCameraTransform.position;
                newScopeCameraGO.transform.rotation = scopeCameraTransform.rotation;
                newScopeCameraGO.name = "CameraCloneWeapon";

                Camera newScopeCamera = newScopeCameraGO.GetComponentInChildren<Camera>();
                newScopeCamera.targetTexture = scopeCamera.targetTexture;
                if (rot != 0)
                {
                    newScopeCameraGO.transform.localRotation = Quaternion.Euler(rot, 0, 0);
                }
                if (fov != 0)
                {
                    newScopeCamera.fieldOfView = fov;
                }
                else
                {
                    newScopeCamera.fieldOfView = scopeCamera.fieldOfView;
                }
                if (oldScopeCameraTransform != null)
                {
                    GameObject.Destroy(oldScopeCameraTransform.gameObject);
                }
            }
        }
    }
}
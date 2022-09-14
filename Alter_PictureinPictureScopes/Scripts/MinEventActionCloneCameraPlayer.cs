using System.Xml;
using UnityEngine;

public class MinEventActionCloneCameraPlayer : MinEventActionTargetedBase
{
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
                Transform oldScopeCameraTransform = entityPlayer.transform.FindInChilds("CameraClonePlayer");
                if (oldScopeCameraTransform != null)
                {
                    return;
                }
                GameObject newScopeCameraGO = GameObject.Instantiate(entityPlayer.playerCamera.gameObject);
                Component.Destroy(newScopeCameraGO.GetComponent<vp_FPWeapon>());
                Component.Destroy(newScopeCameraGO.GetComponent<vp_FPCamera>());
                Component.Destroy(newScopeCameraGO.GetComponent<AudioListener>());
                Component.Destroy(newScopeCameraGO.GetComponent<AudioSource>());
                Component.Destroy(newScopeCameraGO.GetComponent<LocalPlayerCamera>());
                foreach (Transform child in newScopeCameraGO.transform)
                {
                    GameObject.Destroy(child.gameObject);
                }
                newScopeCameraGO.name = "CameraClonePlayer";
                GameObject CameraCloneParent = new GameObject("CameraCloneParent");
                CameraCloneParent.transform.parent = entityPlayer.transform;
                newScopeCameraGO.transform.parent = CameraCloneParent.transform;
                newScopeCameraGO.SetActive(false);
            }
        }
    }
}
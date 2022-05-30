using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportAndAttach : TeleportationAnchor
{

    [SerializeField]
    string Task;
    [SerializeField]
    XRControllerManager LeftXRController;

    public void TeleportAttach()
    {
        switch (base.name)
        {
            case "TeleportAnchor8":
                LeftXRController.TeleportAnchor = "Washing";
                break;
            default:
                LeftXRController.TeleportAnchor = "Base";
                break;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NurstingTeleportAttach : TeleportationAnchor
{
    private AudioSource audioSource;
    private Liquid script_liquid;
    [SerializeField]
    string Task;
    [SerializeField]
    XRControllerManager LeftXRController;
    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        script_liquid = GameObject.Find("Liquid").GetComponent<Liquid>();

    }

    private void Update()
    {
        if (script_liquid.b_nursingfinish == true & GV.StageState == "Nursing_9")
        {
            GV.StageState = "Nursing_10";
            LeftXRController.TeleportAnchor = "Base";
        }
    }

    public void TeleportAttach()
    {
        switch (base.name)
        {
            case "TeleportAnchor4":
                if (GV.StageState == "Nursing_6")
                {
                    //audioSource.Play();
                    GV.StageState = "Nursing_7";
                }
                if (GV.StageState == "Nursing_12")
                {
                    //audioSource.Play();
                    GV.StageState = "Nursing_13";
                }
                
                break;
            case "TeleportAnchor6":
                LeftXRController.TeleportAnchor = "Nursing";
                if (GV.StageState == "Nursing_7")
                {
                    //audioSource.Play();
                    GV.StageState = "Nursing_8";
                }
                break;
            case "TeleportAnchor5":
                if (GV.StageState == "Nursing_2")
                {
                    //audioSource.Play();
                    GV.StageState = "Nursing_3";
                }
                break;
            default:
                LeftXRController.TeleportAnchor = "Base";
                break;
        }
    }

}


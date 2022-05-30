using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class StartStage : MonoBehaviour
{
    [SerializeField]
    GameObject Baby;

    [SerializeField]
    TwoRayInteractorController twoRayInteractorController;

    /*[SerializeField]
    XRControllerManager device;*/

    [SerializeField]
    GameObject Arrow;

    [SerializeField]
    GameObject CheckStartObjectBedRoom;

    [SerializeField]
    GameObject CheckStartObjectKitchen;

    [SerializeField]
    GameObject CheckStartObjectBathRoom;



    // Start is called before the first frame update
    void Start()
    {
        GV.StageState = "Start_1";
        twoRayInteractorController.BabyInVisible();

    }

    // Update is called once per frame
    void Update()
    {
        switch (GV.StageState)
        {
            case "Start_1":
                SetStart_2();
                break;
            case "Start_5":
                SetStart_6();
                break;
            case "Start_10":
                CheckStartObjectBedRoom.active = false;
                break;
            case "Start_16":
                GV.BabyState = GV.State.Cry;
                break;
        }
    }

    void SetStart_2()
    {
        if (twoRayInteractorController.WarningVisibleTrigger)
        {
            GV.StageState = "Start_2";
        }
    }

    public void SetStart_3()
    {
        
        if (GV.StageState == "Start_2")
            GV.StageState = "Start_3";
    }

    public void SetStart_4()
    {
        if (GV.StageState == "Start_3")
        {
            Arrow.active = true;
            GV.StageState = "Start_4";

        }
    }
    
    public void SetStart_5()
    {
        if (GV.StageState == "Start_4")
        {
            GV.StageState = "Start_5";
            Arrow.active = false;
        }
    }

    public void SetStart_6()
    {
        if (!Baby.GetComponent<ParentConstraint>().enabled)
        {
            GV.StageState = "Start_6";
            CheckStartObjectBedRoom.active = true;
        }
    }

    public void SetStart_9()
    {
        if (GV.StageState == "Start_9")
        {
            GV.StageState = "Start_10";
            CheckStartObjectKitchen.active = true;
        }
    }

    public void SetStart_13()
    {
        if (GV.StageState == "Start_12")
        {
            CheckStartObjectKitchen.active = false;
            GV.StageState = "Start_13";
            CheckStartObjectBathRoom.active = true;
        }
    }

    public void SetStart_17()
    {
        if (GV.StageState == "Start_16")
        {
            GV.StageState = "Start_17";
        }
    }

    /*
    public void SetStart_7()
    {
        GV.StageState = "Start_7";
    }
    */

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoControllerManage : MonoBehaviour
{
    [SerializeField]
    GameObject RightController;

    [SerializeField]
    bool RightControllerVisible;
    
    [SerializeField]
    bool RightJoystickPointerVisible;
    
    [SerializeField]
    bool RightGrabPoinerVisible;

    [SerializeField]
    bool RightTriggerPoinerVisible;


    [SerializeField]
    GameObject LeftController;

    [SerializeField]
    bool LeftControllerVisible;

    [SerializeField]
    bool LeftJoystickPointerVisible;

    [SerializeField]
    bool LeftGrabPoinerVisible;


    [SerializeField]
    bool LeftTriggerPoinerVisible;

   private Vector3 RRotScale = new Vector3(2.7f, -3.4f, -74.3f);
   private Vector3 LRotScale = new Vector3(-10.3f, -5.77f, 106.44f);

    private void Start()
    {

        RightController.transform.rotation = Quaternion.Euler(InfoManager.OrgRotate);
        LeftController.transform.rotation = Quaternion.Euler(InfoManager.OrgRotate);


    }
    // Update is called once per frame
    private void Update()
    {

        // Debug.Log(InfoManager.OrgRotate);
        VisibleState(RightController, RightControllerVisible, RightJoystickPointerVisible, RightGrabPoinerVisible, RightTriggerPoinerVisible);
        VisibleState(LeftController, LeftControllerVisible, LeftJoystickPointerVisible, LeftGrabPoinerVisible, LeftTriggerPoinerVisible);

    }

    private void VisibleState(GameObject controller,bool active, bool joystick, bool grab, bool trigger)
    {
       
        if (active)
        {
            controller.active = true;
            
            controller.transform.GetChild(0).gameObject.active = joystick;
            controller.transform.GetChild(1).gameObject.active = grab;
            controller.transform.GetChild(2).gameObject.active = trigger;

            if (trigger)
            {

                if (controller == RightController)
                    //controller.transform.rotation = Quaternion.Euler(InfoManager.OrgRotate + RRotScale);
                    //controller.transform.Rotate(0, 0, 80);
                    controller.transform.rotation = Quaternion.Euler(InfoManager.R_Rotate);
                if (controller == LeftController)
                    //controller.transform.rotation = Quaternion.Euler(InfoManager.OrgRotate + LRotScale);
                    //controller.transform.Rotate(0, 0, 80);
                    controller.transform.rotation = Quaternion.Euler(InfoManager.L_Rotate);
                //Debug.Log(controller + "" + controller.transform.rotation.eulerAngles);
            }

            else
            {
                controller.transform.rotation = Quaternion.Euler(InfoManager.OrgRotate);
            }
           
        }
        else
        {
            controller.active = false;
        }
       
    }
}

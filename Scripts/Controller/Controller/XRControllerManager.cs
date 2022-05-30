using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
using UnityEngine.SceneManagement;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class XRControllerManager : XRController
    {
        [SerializeField]
        Vector3 positionOffset;
        [SerializeField]
        Quaternion rotationOffset;

        [SerializeField]
        Vector3 WashPositionOffset;
        [SerializeField]
        Quaternion WashRotationOffset;

        [SerializeField]
        Vector3 NursingPositionOffset;
        [SerializeField]
        Quaternion NursingRotationOffset;

        [SerializeField]
        GameObject Baby;
        [SerializeField]
        GameObject TeleportationController;

        RayInteracterManager RayInteractor;

        [SerializeField]
        XRGrabInteractable interactable;

        [SerializeField]
        GameObject AttachPoint;

        public string TeleportAnchor;
        bool primary2DAxisValue;

        // Start is called before the first frame update
        void Start()
        {
            
            RayInteractor = GetComponent<RayInteracterManager>();
            TeleportAnchor = "Base";
        }



        protected override void UpdateTrackingInput(XRControllerState controllerState)
        {
            base.UpdateTrackingInput(controllerState);
            
            if(gameObject.name == "LeftBaseController")
                CheckInteractor(controllerState);   
        }

        private void CheckInteractor(XRControllerState controllerState)
        {
            if (RayInteractor.isSelectActive == true)
            {
                if (RayInteractor.selectTarget == Baby.GetComponent<XRGrabInteractable>())
                {
                    //Baby.GetComponent<PositionConstraint>().constraintActive = true;
                    PositionState(controllerState);
                    //TeleportationController.active = false;

                    if (base.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool buttonValue))
                    {
                        if (buttonValue == true)
                        {
                            Debug.Log("primary button");
                            // Button was pressed or released this frame
                            // Do something with it here...
                            // ... then make sure to set the last known state of it for reference next Update()
                            //rightHandLastState = buttonValue;
                        }
                    }
                }
            }
            else
            {
                //TeleportationController.active = true;
            }
        }


        private void PositionState(XRControllerState controllerState)
        {
            string SceneName = SceneManager.GetActiveScene().name;
            // Teleport 앵커 위치에 따라서 아기를 잡는 Position 변경
            switch (TeleportAnchor)
            {
                case "Base":
                     controllerState.position = positionOffset;
                     controllerState.rotation = rotationOffset;
                     interactable.attachTransform = AttachPoint.transform.GetChild(0).gameObject.transform;
                     break;
                case "Washing":
                    controllerState.position = WashPositionOffset;
                    controllerState.rotation = WashRotationOffset;
                    interactable.attachTransform = AttachPoint.transform.GetChild(1).gameObject.transform;
                    break;
                case "Nursing":
                    controllerState.position = NursingPositionOffset;
                    controllerState.rotation = NursingRotationOffset;
                    interactable.attachTransform = AttachPoint.transform.GetChild(2).gameObject.transform;
                    break;
            }
        }
    }
}


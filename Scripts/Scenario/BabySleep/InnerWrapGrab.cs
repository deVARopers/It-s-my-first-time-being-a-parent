using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InnerWrapGrab : MonoBehaviour
{
    [SerializeField]
    RayInteracterManager RightInteractor;
    
    [SerializeField]
    RayInteracterManager LeftInteractor;

    private Transform OriginAttachPoint;

    public bool Grip = false;

    void Start()
    {
        OriginAttachPoint = gameObject.GetComponent<XRGrabInteractable>().attachTransform;
    }

    public void InnerWrapGrabActive()
    {
        if (RightInteractor.selectTarget == gameObject.GetComponent<XRGrabInteractable>() ||
            LeftInteractor.selectTarget == gameObject.GetComponent<XRGrabInteractable>())
        {
            gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<XRGrabInteractable>().attachTransform = null;
            //GV.StageState = "SleepBaby_2";
            Grip = true;
        }
    }

    public void InnerWrapGrabInactive()
    {
        gameObject.GetComponent<XRGrabInteractable>().attachTransform = OriginAttachPoint;
    }
}

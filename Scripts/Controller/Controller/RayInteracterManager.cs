using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RayInteracterManager : XRRayInteractor
{
    /*
    [SerializeField]
    XRGrabInteractable BabyGrabInteractableSerializeField;
    [SerializeField]
    XRGrabInteractable BabyGrabInteractable;
    */

    public List<XRBaseInteractable> xRBaseInteractables;
    // Update is called once per frame

    void Start()
    {
        // BabyGrabInteractable = BabyGrabInteractableSerializeField;
    }

   /* public List<IXRSelectInteractable> interactablesSelected
    {
        get;
    } = new List<IXRSelectInteractable>() { BabyGrabInteractable };

    */
    public bool HoverXRSimpleInteractableObject(XRSimpleInteractable interactable)
    {
        bool check = false;
        xRBaseInteractables = base.hoverTargets;
        
        for (int i = 0; i < xRBaseInteractables.Count; i++)
        {
            if (xRBaseInteractables[i] == interactable)
                check = true;
            //Debug.Log("xRBaseInteractables[i] : " + xRBaseInteractables[i] + "   XRSimpleInteractable : " + interactable);
        }
        return check;
    }

    public bool HoverXRGrabInteractableObject(XRGrabInteractable interactable)
    {
        bool check = false;
        xRBaseInteractables = base.hoverTargets;
        for (int i = 0; i < xRBaseInteractables.Count; i++)
        {
            if (xRBaseInteractables[i] == interactable)
                check = true;
            //Debug.Log("xRBaseInteractables[i] : " + xRBaseInteractables[i] + "   XRGrabInteractable : " + interactable);
        }
        return check;
    }
}
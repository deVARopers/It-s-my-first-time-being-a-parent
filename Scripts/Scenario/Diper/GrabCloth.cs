using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabCloth : MonoBehaviour
{
    [SerializeField]
    RayInteracterManager RightInteractor;

    [SerializeField]
    RayInteracterManager LeftInteractor;

    [SerializeField]
    GameObject babyCloth;

    private Transform OriginAttachPoint;
    private GameObject diaper;
    private GameObject cloth;
    private GameObject flatdiaper;
    void Start()
    {
        GV.StageState = "diaper_1";
        OriginAttachPoint = gameObject.GetComponent<XRGrabInteractable>().attachTransform;
        diaper = GameObject.FindGameObjectWithTag("diaper");
        cloth = GameObject.FindGameObjectWithTag("used cloth");
        flatdiaper = GameObject.FindGameObjectWithTag("flatdiaper");
    }

    public void InnerWrapGrabActive() 
    {
        gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
        babyCloth.GetComponent<SkinnedMeshRenderer>().enabled = false;

        diaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
        diaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = true;
        cloth.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    public void InnerWrapGrabInactive()
    {
        cloth.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material = gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().material;
        gameObject.SetActive(false);
        GV.StageState = "diaper_2";
    }
    public void grabcloth()
    {
        GV.StageState = "diaper_13";

    }
    public void ungrabcloth()
    {
        flatdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = false;
        flatdiaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
        babyCloth.GetComponent<SkinnedMeshRenderer>().enabled = true;
        cloth.SetActive(false);
        GV.StageState = "diaper_14";
    }
}

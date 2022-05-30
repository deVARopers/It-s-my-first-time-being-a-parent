using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class TwoRayInteractorController : MonoBehaviour
{

    [SerializeField]
    RayInteracterManager RightHandRayInteractor;

    [SerializeField]
    RayInteracterManager LeftHandRayInteractor;

    [SerializeField]
    Transform TargetPoint;

    [SerializeField]
    GameObject Baby;

    [SerializeField]
    string[] StopInteractableState;

    [SerializeField]
    GameObject Warning;

    [SerializeField]
    bool VisibleWarningState;

    [SerializeField]
    XRGrabInteractable interactable;


    private float time = 0f;

    public bool WarningVisibleTrigger = false;
    public string hand;

    //private RayInteractor Right;
    //private RayInteractor Left;

    private bool grabState = true;

    private AudioSource audioSource;

 
    
    //손 위치 설정 -> 다른 스크립트에서 제어할 변수
    public int AttachTargetNum;


    [SerializeField]
    public bool isWarningActive;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // BabyInVisible();
        // Right = new RayInteractor(RightHandRayInteractor, RightHandBaby);
        // Left = new RayInteractor(LeftHandRayInteractor, LeftHandBaby);
    }
    void Update()
    {
        BabyGrab();
    }

    protected void BabyGrab()
    {
        for (int i = 0; i < StopInteractableState.Length; i++)
        {
            if (StopInteractableState[i] == GV.StageState)
            {
                grabState = false;
                break;
            }
            else if (i == StopInteractableState.Length - 1)
                grabState = true;
        }

        if (grabState)
        {
            interactable.enabled = true;
            CheckInteractor();
        }
    }

   

    protected void CheckInteractor()
    {
        if (RightHandRayInteractor.isSelectActive == true || LeftHandRayInteractor.isSelectActive == true)
        {
            if (LeftHandRayInteractor.selectTarget == interactable)
            {
                BabyVisible();

                WarningVisibleTrigger = true;
                hand = "left";
            }
        }
        else
        {
            if (VisibleWarningState)
                VisibleWarning();
            interactable.attachTransform = TargetPoint;
        }
    }

    private void VisibleWarning()
    {
        if (WarningVisibleTrigger && isWarningActive)
        {
            if (Baby.GetComponent<ParentConstraint>().enabled)
            {
                BabyInVisible();
                Warning.active = true;
            }
            else
            {
                
                BabyVisible();
                Warning.active = false;
            }
               
            /*if (audioSource.isPlaying)
            {
                audioSource.Play();
            }*/
        }
        else
        {
            
            //audioSource.Stop();
            Warning.active = false;
        }
        
    }

    public void BabyVisible()
    {
        for (int i = 0; i < 5; i++)
        {
            Baby.transform.GetChild(i).GetComponent<Renderer>().enabled = true;
        }
        
        Warning.active = false;
    }

    public void BabyInVisible()
    {
        for (int i = 0; i < 5; i++)
        {
            Baby.transform.GetChild(i).GetComponent<Renderer>().enabled = false;
        }
       
    }
}


/*
 
 class RayInteractor
    {
        private ControllerBaby interactor;
        private GameObject grabedbaby;
        private bool checkBabyGrab = false;
        public RayInteractor(ControllerBaby interactor, GameObject grabedbaby)
        {

            this.interactor = interactor;
            this.grabedbaby = grabedbaby;
        }

        public ControllerBaby Interactor
        {
            get { return interactor; }
            set { interactor = value; }
        }

        public GameObject Grabedbaby
        {
            get { return grabedbaby; }
        }

        public bool CheckBabyGrab
        {
            get { return checkBabyGrab; }
            set { checkBabyGrab = value; }
        }


    }
    private void HideControllerManager(RayInteractor rayinteractor)
    {
        if (!CheckInteractor(rayinteractor))
        {
            rayinteractor.Grabedbaby.SetActive(false);

            if (rayinteractor.CheckBabyGrab && rayinteractor.Interactor.hideControllerOnSelect)
            //if (rayinteractor.Interactor.hideControllerOnSelect)
            {
                for (int i = 0; i < Baby.transform.childCount - 4; i++)
                {
                    Baby.transform.GetChild(i).GetComponent<Renderer>().enabled = true;
                }

                rayinteractor.Interactor.hideControllerOnSelect = false;
            }
            rayinteractor.CheckBabyGrab = false;
        }
    }

    private bool CheckInteractor(RayInteractor rayinteractor)
    {
        if (rayinteractor.Interactor.isSelectActive == true)
        {
            if (rayinteractor.Interactor.selectTarget == Baby.GetComponent<XRGrabInteractable>())
            {
                BaseGrabBay(rayinteractor);
                return true;
            }
        }
        return false;
    }

    private void BaseGrabBay(RayInteractor rayinteractor)
    {
        Debug.Log("CheckInteractor");
        rayinteractor.Interactor.hideControllerOnSelect = true;
        rayinteractor.Grabedbaby.SetActive(true);
        for (int i = 0; i < Baby.transform.childCount - 4; i++)
        {
            Baby.transform.GetChild(i).GetComponent<Renderer>().enabled = false;
        }
        rayinteractor.CheckBabyGrab = true;
    }

 
 */
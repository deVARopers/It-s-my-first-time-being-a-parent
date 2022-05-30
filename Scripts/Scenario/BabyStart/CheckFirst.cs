using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class CheckFirst : MonoBehaviour
{
    [SerializeField]
    Material HoverMat;

    
    [SerializeField]
    Material CheckMat;
    
    [SerializeField]
    string CurrentState;

    [SerializeField]
    string SerializeState;

    public InputActionReference ObjectCheckActionReference;

    [SerializeField]
    RayInteracterManager RightRayInteractor;

    [SerializeField]
    RayInteracterManager LeftRayInteractor;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    CheckFirst checkFirst;


    private bool trigger = false;

    [SerializeField]
    private XRSimpleInteractable XRSimpleInteractable;

    [SerializeField]
    private XRGrabInteractable XRGrabInteractable;

    private GameObject Line;
    private GameObject Check;


    [SerializeField]
    SkinnedMeshRenderer[] skinnedMesh;

    [SerializeField]
    MeshRenderer[] meshRenderer;


    //[SerializeField]
    //GameObject[] CheckGameObject;

    [SerializeField]
    Material[] OriginMat;




    // Start is called before the first frame update
    void Start()
    {
        SetOrgMat();
    }

    // Update is called once per frame
    void Update()
    {
        if(GV.StageState == CurrentState)
        {
            ChangeSelectMat();
        }
        Debug.Log("GV.StageState : " + GV.StageState);
    }

    void Awake()
    {

        ObjectCheckActionReference.action.started += Toggle;
        // SetRendererInteractable();
       
        Check = gameObject.transform.GetChild(2).gameObject;
        Line = gameObject.transform.GetChild(3).gameObject;

    }

    void OnDestroy()
    {
        ObjectCheckActionReference.action.started -= Toggle;
    }


    public void Toggle(InputAction.CallbackContext cnt)
    {
        
        //Trigger를 누르면 StageState값 바뀜
        //if (GV.StageState == CurrentState && RightRayInteractor.HoverObject(XRSimpleInteractable))
        if (GV.StageState == CurrentState && RightRayInteractor.HoverXRSimpleInteractableObject(XRSimpleInteractable) 
            || GV.StageState == CurrentState && LeftRayInteractor.HoverXRSimpleInteractableObject(XRSimpleInteractable)
            || GV.StageState == CurrentState && RightRayInteractor.HoverXRGrabInteractableObject(XRGrabInteractable)
            || GV.StageState == CurrentState && LeftRayInteractor.HoverXRGrabInteractableObject(XRGrabInteractable))
        {
            GV.StageState = SerializeState;

            ChangeOrgMat();

            Check.active = true;
            Line.active = true;
            audioSource.Play();
            if (checkFirst != null)
            {
                checkFirst.enabled = true;
                //XRSimpleInteractable.enabled = false;
                gameObject.GetComponent<CheckFirst>().enabled = false;
                
            }
        }
    }

    private void SetOrgMat()
    {
       
        if (skinnedMesh != null)
        {
            //OriginMat = new Material[skinnedMesh.Length];
            for (int i = 0; i < skinnedMesh.Length; i++)
            {
                OriginMat[i] = skinnedMesh[i].sharedMaterial;
                //Debug.Log(gameObject.name + "   " + "OriginMat[i] : " + OriginMat[i] + " OriginMat.Length: " + OriginMat.Length);
            }
        }
        if (meshRenderer != null)
        {
            //OriginMat = new Material[meshRenderer.Length];
            for (int i = 0; i < meshRenderer.Length; i++)
            {
                OriginMat[i] = meshRenderer[i].sharedMaterial;
                //Debug.Log(gameObject.name + "   " + "OriginMat[i] : " + OriginMat[i] + " OriginMat.Length: " + OriginMat.Length);
            }
        }
       
    }


    public void ChangeSelectMat()
    {
        if (skinnedMesh != null)
        {
            for (int i = 0; i < skinnedMesh.Length; i++)
            {;
                skinnedMesh[i].sharedMaterial = HoverMat;
                //Debug.Log("name : " + gameObject.name + " skinnedMesh[i].sharedMaterial : " + skinnedMesh[i].sharedMaterial);
            }
        }
        if (meshRenderer != null)
        {
            for (int i = 0; i < meshRenderer.Length; i++)
            {
                meshRenderer[i].sharedMaterial = HoverMat;
            }
        }
    }

    public void ChangeHovertMat()
    {
        if (skinnedMesh != null)
        {
            for (int i = 0; i < skinnedMesh.Length; i++)
            {
                ;
                skinnedMesh[i].sharedMaterial = CheckMat;
                //Debug.Log("name : " + gameObject.name + " skinnedMesh[i].sharedMaterial : " + skinnedMesh[i].sharedMaterial);
            }
        }
        if (meshRenderer != null)
        {
            for (int i = 0; i < meshRenderer.Length; i++)
            {
                meshRenderer[i].sharedMaterial = CheckMat;
            }
        }


    }

    public void ChangeOrgMat()
    {
        if (skinnedMesh != null)
        {
            for (int i = 0; i < skinnedMesh.Length; i++)
            {
                //Debug.Log(gameObject.name + "   " + "OriginMat[i] : " + OriginMat[i] + " OriginMat.Length: " + OriginMat.Length);
                skinnedMesh[i].sharedMaterial = OriginMat[i];
            }
        }
        if (meshRenderer != null)
        {
            for (int i = 0; i < meshRenderer.Length; i++)
            {
                meshRenderer[i].sharedMaterial = OriginMat[i];
                //Debug.Log(gameObject.name + "   " + "OriginMat[i] : " + OriginMat[i] + " OriginMat.Length: " + OriginMat.Length);
            }
        }
    }

    /*
    private void SetRendererInteractable()
    {
        if (CheckGameObject.GetComponent<MeshRenderer>() != null)
        {
            meshRenderer = CheckGameObject.GetComponent<MeshRenderer>();
            OriginMat = meshRenderer.sharedMaterial;

        }
        else if (CheckGameObject.GetComponent<SkinnedMeshRenderer>() != null)
        {
            skinnedMesh = CheckGameObject.GetComponent<SkinnedMeshRenderer>();
            OriginMat = skinnedMesh.sharedMaterial;
        }


        if (CheckGameObject.transform.GetComponent<XRSimpleInteractable>() != null)
        {
            Debug.Log("CheckGameObject : " + CheckGameObject);
            XRSimpleInteractable = CheckGameObject.transform.GetComponent<XRSimpleInteractable>();
        }
        else if (CheckGameObject.transform.GetComponent<XRGrabInteractable>() != null)
        {
            XRGrabInteractable = CheckGameObject.transform.GetComponent<XRGrabInteractable>();
        }
    }*/

    /*
    public void CheckHover()
    {
        if (GV.StageState == CurrentState)
        {
            meshRenderer.sharedMaterial = HoverMat;
            Debug.Log(meshRenderer.sharedMaterial);
        }
    }

    public void CheckExit()
    {
        if (GV.StageState == CurrentState)
            meshRenderer.sharedMaterial = CheckMat;
    }
    */

}

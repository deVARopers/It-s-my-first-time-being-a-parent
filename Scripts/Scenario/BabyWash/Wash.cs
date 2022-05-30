using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Animations.Rigging;
using UnityEngine.Animations;
public class Wash : MonoBehaviour
{
    [SerializeField]
    public GameObject diaperBaby;
    [SerializeField]
    public GameObject waterBaby;
    [SerializeField]
    public GameObject moveBaby;
    [SerializeField]
    public GameObject xr_origin;
    [SerializeField]
    public GameObject sign_warn;
    [SerializeField]
    RayInteracterManager LeftHandRayInteractor;
    [SerializeField]
    AudioSource AudioSource;

    public InputActionReference diaperReference = null;
    private GameObject diaper;
    private GameObject image;
    private GameObject grabBaby;
    private GameObject butt;
    private GameObject grabpoint;
    private GameObject usedpaper;
    private GameObject useddiaper;
    private GameObject newdiaper;
    private GameObject flatdiaper;
    private GameObject cloth;
    private bool isWash7;
    private bool isWash8;
    private bool isWash10;

    private float speed;
    private GrabLeg script_GrabLeg;
    private AudioSource audio_tmp;
    private bool b_audio = false;

    // Start is called before the first frame update
    void Start()
    {
        diaper = GameObject.FindGameObjectWithTag("diaper");
        image = GameObject.FindGameObjectWithTag("UIimage");
        grabBaby = GameObject.FindGameObjectWithTag("legBaby");
        butt = GameObject.FindGameObjectWithTag("butt");
        grabpoint= GameObject.FindGameObjectWithTag("grabpoint");
        usedpaper= GameObject.FindGameObjectWithTag("used");
        useddiaper = GameObject.FindGameObjectWithTag("used diaper");
        newdiaper = GameObject.FindGameObjectWithTag("new diaper");
        flatdiaper = GameObject.FindGameObjectWithTag("flatdiaper");
        cloth = GameObject.FindGameObjectWithTag("used cloth");

        isWash7 = false;
        isWash8 = false;
        isWash10 = false;
        script_GrabLeg = GameObject.Find("GrabLeg").GetComponent<GrabLeg>();
        audio_tmp = GameObject.Find("AudioTMP").GetComponent<AudioSource>();
    }
    
    void Awake()
    {
        diaperReference.action.started += Toggle;

    }

    void OnDestroy()
    {
        diaperReference.action.started -= Toggle;
    }
    
    private void Update()
    {
        Debug.Log(GV.StageState);
        /*
        if (GV.StageState == "diaper_3")
            speed += Time.deltaTime;

        if (GV.StageState == "diaper_7")
            speed += Time.deltaTime;
        */

        if (butt.activeSelf == false )
        {
            usedpaper.GetComponent<MeshRenderer>().enabled = true;
            if(b_audio == false)
            {
                audio_tmp.Play();
                b_audio = true;
            }
            
            // diaperBaby.GetComponent<XRGrabInteractable>().enabled = true;
            if (GV.StageState == "Wash_6" & script_GrabLeg.grabByRight == false & script_GrabLeg.grabByRight == false)
            {
                GV.StageState = "Wash_7"; // -> 화장실로 감 ( 사실은 7임 )
                GV.BabyState = GV.State.Cry;
                switchBaby();
                // diaperBaby.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (GV.StageState == "Wash_17")
        {
            newdiaper.GetComponent<XRGrabInteractable>().enabled = true;
        }
        /*
        if (isWash10)
        {
            if (GV.StageState == "Wash_10")
            {
                isWash10 = false;
                GV.StageState = "Wash_11";
            }
        }

        if (isWash11)
        {
            if (GV.StageState == "Wash_11")
            {
                isWash11 = false;
                GV.StageState = "Wash_12";
            }
        }
        */

    }

    public void switchBaby()
    {
        if (GV.StageState == "Wash_7")
        {
            diaperBaby.SetActive(false);
            toggleGrabBaby(true);
        }
        
    }

    public void hideBaby ()
    {
        if (GV.StageState == "Wash_7")  GV.StageState = "Wash_8";
        // diaperBaby.SetActive(false);
        // xr_origin.transform.GetChild(1).GetComponent<TwoRayInteractorController>().enabled = true;
    }

    public void showWaterBaby()
    {
        if (GV.StageState == "Wash_8")
        {
            GV.StageState = "Wash_9";
            waterBaby.SetActive(true);
            toggleGrabBaby(false);
           
        }
        // diaperBaby.SetActive(false);
        // xr_origin.transform.GetChild(1).GetComponent<TwoRayInteractorController>().enabled = false;
    }

    public void hideWaterBaby()
    {
        if (GV.StageState == "Wash_14")
        {
            waterBaby.SetActive(false);
            GV.StageState = "Wash_15";
        }
    }

    public void showBaby ()
    {
        if (GV.StageState == "Wash_15")
        {
            diaperBaby.SetActive(true);
            GV.StageState = "Wash_16";
        }
    }

    public void changeMateriai()
    {
        if (GV.StageState == "Wash_2") // 기저귀의 띠를 change
        {
         gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].color = Color.yellow;
         gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].color = Color.yellow;

        }
    }

    public void normalMateriai() // 기저귀 normalmap으로 변환
    {
        gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].color = Color.white;
        gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].color = Color.white;
        gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].color = Color.white;
    }


    public void Toggle(InputAction.CallbackContext cnt)
    {

        if (GV.StageState == "Wash_2") // 기저귀 띠를 hover하면서 trigger 누르면 애니메이션
        {
            gameObject.GetComponent<Animator>().Play("diaper");
            grabpoint.GetComponent<XRGrabInteractable>().enabled = true;
            GV.StageState = "Wash_3";
            grabBaby.transform.GetChild(0).GetComponent<RigBuilder>().enabled = true;
            flatdiaper.GetComponent<Animator>().Play("diaper 0");
            diaper.GetComponent<XRSimpleInteractable>().enabled = false;
            AudioSource.Play();
        }
        else if (GV.StageState == "Wash_19")
        {
            //flatdiaper.GetComponent<Animator>().SetFloat("reverse", -1.0f);
            flatdiaper.GetComponent<Animator>().Play("diaper");
            GV.StageState = "Wash_20";
            cloth.GetComponent<XRGrabInteractable>().enabled = true;
            AudioSource.Play();
        }
    }


    public void grabReg()
    {
        if (GV.StageState == "Wash_3") GV.StageState = "Wash_4";
        diaper.GetComponent<XRGrabInteractable>().enabled = true;
    }

    public void grabanim() // 사용한 기저귀를 들었을 때
    {
        gameObject.GetComponent<Animator>().Play("usedDiaper");
        useddiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    public void ungrab() // 사용한 기저귀를 놓았을 때
    {
        if (GV.StageState == "Wash_4") GV.StageState = "Wash_5";
        useddiaper.SetActive(false);
        gameObject.transform.position = useddiaper.GetComponent<Transform>().position;
        gameObject.transform.rotation = useddiaper.GetComponent<Transform>().rotation;
    }

    public void grabdiaper() // 새 기저귀를 잡았을 때
    {
        flatdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
        flatdiaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    public void ungrabdiaper() // 새 기저귀를 놓았을 때
    {
        if (GV.StageState == "Wash_17")
        {
            GV.StageState = "Wash_18";
            flatdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials = newdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials;
            flatdiaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = diaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material;
            newdiaper.SetActive(false);
        }
    }

    public void ungrabReg()
    {
        if (GV.StageState == "Wash_18")
        {
            grabBaby.transform.GetChild(0).GetComponent<RigBuilder>().enabled = false;
            grabpoint.GetComponent<PositionConstraint>().enabled = false;
            grabpoint.GetComponent<RotationConstraint>().enabled = false;
            GV.StageState = "Wash_19";
        }
    }

    public void grabcloth()
    {
        GV.StageState = "Wash_21";
    }

    public void waterGrabbed () // 물을 처음 잡았을 때
    {
        // if (GV.StageState == "Wash_10") GV.StageState = "Wash_11";
        isWash10 = true;
    }

    public void waterUngrabbed() // 물을 처음 놓았을 때 
    {
        if (GV.StageState == "Wash_11") GV.StageState = "Wash_12";
    }

    public void repeatWash () // 엉덩이를 다 씻었을 때 
    {
        if (GV.StageState == "Wash_12") GV.StageState = "Wash_13";
    }

    public void towelGrabbed () // 손수건을 잡았을 때
    {
        if (GV.StageState == "Wash_13") GV.StageState = "Wash_14";
    }

    public void towelWipe () // 물기를 다 닦았을 때 
    {
        if (GV.StageState == "Wash_14") GV.StageState = "Wash_15";
    }

    public void grapBaby () // 아기를 안았을 때 
    {
        if (GV.StageState == "Wash_15")
        {
            GV.StageState = "Wash_16";
            waterBaby.SetActive(false);
            toggleGrabBaby(true);
            GV.BabyState = GV.State.Cry;
        }
    }

    public void ungrapBaby () // 아기를 눕혔을 때
    {
        if (GV.StageState == "Wash_16")
        {
            GV.StageState = "Wash_17";
            diaperBaby.SetActive(true);
            toggleGrabBaby(false);
        }
    }
    
    // 17 -> 18 까지 없고
    // 22 부터 없음

    public void toggleGrabBaby (bool babyToggle)
    {
        xr_origin.transform.GetChild(1).GetComponent<TwoRayInteractorController>().enabled = babyToggle;
        moveBaby.SetActive(babyToggle);
        if (sign_warn.activeSelf) sign_warn.SetActive(false);
    }
}


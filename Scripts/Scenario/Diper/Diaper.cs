using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Animations.Rigging;
using UnityEngine.Animations;

public class Diaper : MonoBehaviour
{
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

    private float speed;

    [SerializeField]
    AudioSource AudioSource;

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
    }

    void Awake()
    {
        diaperReference.action.started += Toggle;
        if (speed >= 10f)
        {
            image.SetActive(false);
        }
        GV.BabyState = GV.State.Cry;
    }

    void OnDestroy()
    {
        diaperReference.action.started -= Toggle;
    }
    
    private void Update()
    {
        Debug.Log(GV.StageState);

        if (GV.StageState == "diaper_3")
        {
            speed += Time.deltaTime;
            if (speed >= 8f)
            {
                image.SetActive(false);
                speed = 0;
            }
        }
        if (GV.StageState == "diaper_4")
        {
            image.SetActive(false);
            speed = 0;
        }

        if (GV.StageState == "diaper_7")
            speed += Time.deltaTime;

        if (GV.StageState == "diaper_8")
        {
            speed += Time.deltaTime;
            if (speed >= 11f)
            {
                newdiaper.GetComponent<XRGrabInteractable>().enabled = true;
                GV.StageState = "diaper_9";
                speed = 0;
            }
        }

        if (butt.activeSelf == false )
        {
            if (GV.StageState == "diaper_7")
            {
                usedpaper.GetComponent<MeshRenderer>().enabled = true;
                if (speed >= 14f)
                {
                    GV.StageState = "diaper_8";
                    speed = 0;
                }
            }   
        }
    }

    public void changeMateriai()
    {
        if (GV.StageState == "diaper_2") // image UI 띄우기
        {
            gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].color = Color.yellow;
            gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].color = Color.yellow;
            gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].color = Color.yellow;
            GV.StageState = "diaper_3";

        }

        if (GV.StageState == "diaper_3") // 기저귀의 띠를 change
        {
            image.transform.GetChild(0).GetComponent<Canvas>().enabled = true;
            image.transform.GetChild(1).GetComponent<Canvas>().enabled = true;
            grabpoint.GetComponent<XRGrabInteractable>().enabled = true;
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

        if (GV.StageState == "diaper_3") // 기저귀 띠를 hover하면서 trigger 누르면 애니메이션
        {
            gameObject.GetComponent<Animator>().Play("diaper");
            GV.StageState = "diaper_4";
            grabBaby.transform.GetChild(0).GetComponent<RigBuilder>().enabled = true;
            flatdiaper.GetComponent<Animator>().Play("diaper 0");
            diaper.GetComponent<XRSimpleInteractable>().enabled = false;
            AudioSource.Play();
        }
        else if (GV.StageState == "diaper_11")
        {
            //flatdiaper.GetComponent<Animator>().SetFloat("reverse", -1.0f);
            flatdiaper.GetComponent<Animator>().Play("diaper");
            GV.StageState = "diaper_12";
            cloth.GetComponent<XRGrabInteractable>().enabled = true;
            AudioSource.Play();
        }
    }


    public void grabReg()
    {
        if (GV.StageState == "diaper_4") 
            GV.StageState = "diaper_5";
        diaper.GetComponent<XRGrabInteractable>().enabled = true;
    }

    public void grabanim() // 사용한 기저귀를 들었을 때
    {
        gameObject.GetComponent<Animator>().Play("usedDiaper");
        useddiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    public void ungrab() // 사용한 기저귀를 놓았을 때
    {
        GV.StageState = "diaper_6";
        useddiaper.SetActive(false);
        gameObject.transform.position = useddiaper.GetComponent<Transform>().position;
        gameObject.transform.rotation = useddiaper.GetComponent<Transform>().rotation;
        diaper.GetComponent<XRGrabInteractable>().enabled = false;

    }

    public void grabdiaper() // 새 기저귀를 잡았을 때
    {
        flatdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().enabled = true;
        flatdiaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    public void ungrabdiaper() // 새 기저귀를 놓았을 때
    {
        GV.StageState = "diaper_10";
        flatdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials = newdiaper.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials;
        flatdiaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = diaper.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material;
        newdiaper.SetActive(false);
    }

    public void ungrabReg()
    {
        if (GV.StageState == "diaper_10")
        {
            grabBaby.transform.GetChild(0).GetComponent<RigBuilder>().enabled = false;
            grabpoint.GetComponent<PositionConstraint>().enabled = false;
            grabpoint.GetComponent<RotationConstraint>().enabled = false;
            GV.StageState = "diaper_11";
        }
    }

   

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nursingstate : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArray;
    private AudioSource audioSource;
    private Animator animator;

    public bool timerStart = false;
    public bool timerStart_again = false;

    [SerializeField]
    TwoRayInteractorController TwoRayInteractorController;

    private MaterialOpacity script_matopacity;
    private ContinuousLiquid script_liquidchange;
    private Nursing script_nursing;
    private Liquid script_Liquid;

    private float time = 0f;
    private float time_again = 0f;
    private bool step = false;
    private bool once = false;

    private bool burp = false;

    private AudioSource burping;

    private Rigidbody hand_r;
    private Rigidbody hand_l;
    // Start is called before the first frame update
    void Start()
    {
        burping = GameObject.Find("audioburp").GetComponent<AudioSource>();

        script_matopacity = GameObject.Find("DryMilk").GetComponent<MaterialOpacity>();
        script_liquidchange = GameObject.Find("Liquid").GetComponent<ContinuousLiquid>();
        script_nursing = GameObject.Find("bb_cap").GetComponent<Nursing>();
        script_Liquid = GameObject.Find("Liquid").GetComponent<Liquid>();

        hand_r = GameObject.Find("RIghtBaseController").GetComponent<Rigidbody>();
        hand_l = GameObject.Find("LeftBaseController").GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        GV.BabyState = GV.State.Cry;
        GV.StageState = "Nursing_1";
        StateBehavior();
        //mo.b_once == false; -> 수저 안 분유 다 사라짐을 의미
        //lc.b_nursing == true; -> 막대로 다 섞었음을 의미 -> 분유통 table로 옮기기
        //n.b_startnursing == true; -> 수유 중
        //l.b_nursingfinish == true; -> 수유 끝남
    }

    // Update is called once per frame
    void Update()
    {
        SetStateChange();
        timer();
        timer_again();
        StateBehavior();
    }

    /*private void StateChannge()
    {
    }*/

    //아기 상태에 따른 Anamation & Audio
    private void StateBehavior()
    {
        switch (GV.BabyState)
        {
            case GV.State.Base:
                BabyAnimation("Base");
                BabyAudioChange(audioClipArray[4]);
                break;
            case GV.State.Cry:
                BabyAnimation("Cry");
                BabyAudioChange(audioClipArray[0]);
                break;
            case GV.State.InnerWrap:
                BabyAnimation("InnerWrap");
                BabyAudioChange(audioClipArray[2]);
                break;
            case GV.State.Eat:
                BabyAnimation("Base");
                audioSource.Stop();
                break;
            case GV.State.Sleep:
                BabyAnimation("Sleep");
                BabyAudioChange(audioClipArray[3]);
                break;
            case GV.State.DeepSleep:
                BabyAnimation("DeepSleep");
                audioSource.Stop();
                break;
            case GV.State.Wash:
                break;
            case GV.State.NursingBase:
                BabyAnimation("BabyNursingBase");
                BabyAudioChange(audioClipArray[4]);
                break;
        }
    }

    private void BabyAnimation(string anim)
    {
        animator.SetTrigger(anim);
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            animator.ResetTrigger(anim);
        }
    }

    private void BabyAudioChange(AudioClip otherClip)
    {

        if (audioSource.clip != otherClip)
        {
            audioSource.Stop();
            audioSource.clip = otherClip;
            audioSource.Play();
        }
    }

    /*public void BabyGrabbed()
    {
        if(GV.StageState == "Nursing_6")
        {
            GV.StageState = "Nursing_7";
            Debug.Log("BabyGrabbed");
            Debug.Log(GV.StageState);
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if(step == true)
        {
            //TwoRayInteractorController.hand  :  left  other.name  : RIghtBaseController
            Debug.Log("TwoRayInteractorController.hand  :  " + TwoRayInteractorController.hand + "  " + "other.name  : " + other.name);
            if ((TwoRayInteractorController.hand == "left" && other.name == "RIghtBaseController") & GV.StageState == "Nursing_11")
            {
                timerStart_again = true;
                
                Debug.Log("BBBBBBBBBBBBBBBBBBBBB");
            }
            else if ((TwoRayInteractorController.hand == "left" && other.name == "RIghtBaseController"))
            {
                timerStart = true;
                
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }
    private void SetStateChange()
    {
        switch (GV.StageState)
        {
            case "Nursing_10":
                DigestBaby();
                break;
            case "Nursing_11":
                DigestBaby_again();
                break;
        }
    }
    private void DigestBaby()
    {
        if (TwoRayInteractorController.WarningVisibleTrigger && time == 0f)
        {
            step = true;
            hand_r.detectCollisions = true;
            hand_l.detectCollisions = true;

            Debug.Log("time : " + time);
        }
        
        if(step == true & time > 3f & once == false)
        {
            once = true;
            time = 0f;
            step = false;
            timerStart = false;
            GV.StageState = "Nursing_11";
        }
    }

    private void DigestBaby_again()
    {
        if (TwoRayInteractorController.WarningVisibleTrigger && time_again == 0f)
        {
            step = true;
            Debug.Log("time : " + time);
        }
        if (step == true & time_again > 12f)
        {
            burping.Play();
            GV.StageState = "Nursing_12";
            timerStart_again = false;
            Debug.Log("end");
        }
    }
    private void timer()
    {
        if (timerStart)
            time += Time.deltaTime;
    }

    private void timer_again()
    {
        if (timerStart_again)
            time_again += Time.deltaTime;
    }
    private void OnTriggerStay(Collider other)
    {
        if( other.tag == "last" & GV.StageState == "Nursing_13")
        {
            GV.BabyState = GV.State.DeepSleep;
            GV.StageState = "Nursing_14";
            
        }
    }
}

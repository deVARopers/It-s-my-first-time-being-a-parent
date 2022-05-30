using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyStateManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArray;
    private AudioSource audioSource;
    private Animator animator;

    public bool timerStart = false;
    [SerializeField]
    TwoRayInteractorController TwoRayInteractorController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        GV.BabyState = GV.State.Base;
        //Debug.Log("audioSource.clip : " + audioSource.clip);

    }

    // Update is called once per frame
    void Update()
    {
        StateBehavior();
        //Debug.Log("GV.StageState : " + GV.StageState);
    }


    private void OnCollisionEnter(Collision collision)
    {
        ///Debug.Log("collision : " + collision.gameObject.name);
        //속싸개 입히는 Animation
        if (collision.gameObject.name == "InnerWrap" || collision.gameObject.name == "InnerWrapPlane")
        {
            if(GV.StageState == "SleepBaby_2")
            {
                GV.StageState = "SleepBaby_3";
            }
            collision.gameObject.SetActive(false);
            GV.BabyState = GV.State.InnerWrap;

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (GV.StageState == "SleepBaby_4")
        {
            //TwoRayInteractorController.hand  :  left  other.name  : RIghtBaseController
            Debug.Log("TwoRayInteractorController.hand  :  " + TwoRayInteractorController.hand + "  " + "other.name  : " + other.name);
            if((TwoRayInteractorController.hand == "left" && other.name == "RIghtBaseController"))
            {
                timerStart = true;
                ///Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }

    /*
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            if (other.name == "wwater") controller.modelPrefab.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().sharedMaterial = material;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name == "wwater") controller.modelPrefab.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().sharedMaterial = org;
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
       // Debug.Log("audioSource.isPlaying : " + audioSource.isPlaying);
    }

}

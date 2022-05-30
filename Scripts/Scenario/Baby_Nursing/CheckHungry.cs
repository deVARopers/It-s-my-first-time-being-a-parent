using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CheckHungry : MonoBehaviour
{
    private Rigidbody hand_r;
    private Rigidbody hand_l;
    private AudioSource audioSource;

    void Start()
    {
        hand_r = GameObject.Find("RIghtBaseController").GetComponent<Rigidbody>();
        hand_l = GameObject.Find("LeftBaseController").GetComponent<Rigidbody>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "finger" & GV.StageState == "Nursing_1")
        {
            GV.StageState = "Nursing_2";
            //audioSource.Play();
            //GV.BabyState = GV.State.DeepSleep;
            hand_r.detectCollisions = false;
            hand_l.detectCollisions = false;
        }
    }
}

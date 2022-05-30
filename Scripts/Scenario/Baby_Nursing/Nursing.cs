using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nursing : MonoBehaviour
{
    private ContinuousLiquid lcc;
    public AudioSource audioSource;
    public bool b_startnursing;
    // Start is called before the first frame update
    void Start()
    {
        StageTransfer.set = 1;
        lcc = GameObject.Find("Liquid").GetComponent<ContinuousLiquid>();
        audioSource = gameObject.GetComponent<AudioSource>();
        b_startnursing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        //Debug.Log(lcc.b_nursing);
        if (col.tag == "BabyMouth" & GV.StageState == "Nursing_9")
        {
            b_startnursing = true;
            if (GV.BabyState != GV.State.Eat) GV.BabyState = GV.State.Eat;
            Debug.Log("ready to nursing");
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "BabyMouth")
        {
            b_startnursing = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NursingSleep : MonoBehaviour
{
    /*[SerializeField]
    GameObject RightAttachPoint;
    
    [SerializeField]
    GameObject LeftAttachPoint;
    */
    [SerializeField]
    TwoRayInteractorController twoRayInteractorController;
    [SerializeField]
    nursingstate babyStateManager;
    private float time = 0f;

    private bool step = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        SetStateChange();
        timer();

    }

    private void SetStateChange()
    {
        Debug.Log("GV.StageState : " + GV.StageState);
        switch (GV.StageState)
        {
            case "Nursing_2":
                SetSleepBaby_4();
                break;
            case "SleepBaby_4":
                SetSleepBaby_5();
                break;
        }
    }


    private void SetSleepBaby_4()
    {
        if (twoRayInteractorController.WarningVisibleTrigger && time == 0f)
        {
            GV.StageState = "SleepBaby_4";

            Debug.Log("time : " + time);
        }
    }

    private void SetSleepBaby_5()
    {
        //sGetComponent<TwoRayInteractorController>().step;
        if (time > 15f)
        {
            Debug.Log("BabySleep");
            GV.BabyState = GV.State.Sleep;
            GV.StageState = "SleepBaby_5";
        }
    }

    //BabbySocket에 아기가 Active되었을때 진행
    //아기가 침대에 누웠을때 깊게 잠들도록 함
    public void BabyDeepSleep()
    {
        if (GV.StageState == "SleepBaby_5")
        {
            Debug.Log("BabyDeepSleep");
            GV.BabyState = GV.State.DeepSleep;
            //GetComponent<TwoRayInteractorController>().RightAttachPoint.transform.Rotate(0, .45f, 0);
            //GetComponent<TwoRayInteractorController>().LeftAttachPoint.transform.Rotate(0, .45f, 0);
        }

    }

    private void timer()
    {
        //if (GV.StageState == "SleepBaby_4" || GV.StageState == "SleepBaby_5")
        //Debug.Log("babyStateManager.timerStart :  " + babyStateManager.timerStart);
        if (babyStateManager.timerStart)
            time += Time.deltaTime;
    }

}
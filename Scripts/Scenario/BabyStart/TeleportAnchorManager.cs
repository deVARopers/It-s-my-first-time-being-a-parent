using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAnchorManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] TeleportAnchorArray;

    private string setTrigger;

    [SerializeField]
    Material BasicColor;
    
    [SerializeField]
    Material EmphasisColor;


    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < TeleportAnchorArray.Length; i++)
        {
            TeleportAnchorstateManager(i, false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        setTeleportManager();

        if(setTrigger == "Start")
            StartTeleportVisible();
        else if(setTrigger == "Sleep")
            BabySleepTeleportVisible();
    }

    private void setTeleportManager()
    {
        switch (GV.StageState)
        {
            case "Start_1":
                setTrigger = "Start";
                break;
            case "BabySleep_1":
                setTrigger = "Sleep";
                break;
        }
    }


    //시작부분 텔레포트 매니저
                                              
    private void StartTeleportVisible()
    {
         switch (GV.StageState)
        {
            case "Start_2":
                StateArrayManager(new bool[8] { true, false, false, false, false, false, false, false },3);
                //TeleportAnchorstateManager(0, true);
                break; 
            case "Start_3":
                StateArrayManager(new bool[8] { false, true, true, true, false, false, false, false }, 3);
                break;
            case "Start_9":
                StateArrayManager(new bool[8] { true, true, true, true, true, false, false, false },4);
                break;
            case "Start_12":
                StateArrayManager(new bool[8] { true, false, false, false, true, true, false, false },5);
                break;
            case "Start_16":
                StateArrayManager(new bool[8] { true, true, true, true, false, false, false, false }, 3);
                break;
        }
    }

    //시작부분 텔레포트 매니저
    private void BabySleepTeleportVisible()
    {
        switch (GV.StageState)
        {
            default:
                StateArrayManager(new bool[8] { false, false, false, true, false, false, false, false },0);
                break;
        }
    }

    private void TeleportAnchorstateManager(int num, bool state)
    {
        TeleportAnchorArray[num].active = state;
    }

    private void StateArrayManager(bool[] state, int emphasis)
    {
        for(int i = 0; i < state.Length; i++)
        {
            if (state[i])
                TeleportAnchorArray[i].active = true;
            else
                TeleportAnchorArray[i].active = false;

           if (i == emphasis)
                TeleportAnchorArray[i].transform.GetChild(0).gameObject.GetComponent<ParticleSystemRenderer>().material = EmphasisColor;
           else
                TeleportAnchorArray[i].transform.GetChild(0).gameObject.GetComponent<ParticleSystemRenderer>().material = BasicColor;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class InfoManagerClass
{
    public static Info.PublicInfo[] info;
    public static Info.PublicInfo[] SetInfoObject()
    {
        
        switch (GV.StageState)
        {
            case "SleepBaby_1":
                info = Info.BabySleep;
                break;
            case "Start_1":
                info = Info.Start;
                break;
            case "Wash_1":
                info = Info.Wash;
                break;
            case "diaper_1":
                info = Info.Pee;
                break;
            case "Transfer_1":
                info = Info.Transfer;
                break;
            case "TransferBath_1":
                info = Info.TransferToBath;
                break;

            case "Nursing_1":
                info = Info.Nursing;
                break;

        }
        return info;
    }

    public static void stageInfo(Text TextObj, GameObject gameObject, Transform[] Target)
    {
        if (info != null)
        {
            for (int i = 0; i < info.Length; i++)
            {
                if (GV.StageState == info[i].GVState)
                {
                    TextObj.text = "<b>" + info[i].InfoText + "</b>";
                    Target[i].gameObject.SetActive(true);
                    if(i > 0)
                        Target[i-1].gameObject.SetActive(false);
                    gameObject.transform.position = Target[i].position;
                    gameObject.transform.rotation = Target[i].rotation;
                    gameObject.GetComponent<ContentSizeFitter>().enabled = false;
                    gameObject.GetComponent<ContentSizeFitter>().enabled = true;
                }
            }
        }

    }


}

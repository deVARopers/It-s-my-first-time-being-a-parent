using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
   
    [SerializeField]
    Text TextObj;
    [SerializeField]
    Transform[] Target;

    [SerializeField]
    GameObject ToolTip;

    Info.PublicInfo[] info = null;

    static public Vector3 OrgRotate;
    static public Vector3 R_Rotate;
    static public Vector3 L_Rotate;

    

    private void Start()
    {
        //gameObject.transform.GetChild(1).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        //gameObject.transform.GetChild(1).Rotate(-90, 0, 0);
        //gameObject.transform.GetChild(2).Rotate(-90, 0, 0);
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        OrgRotate = gameObject.transform.GetChild(1).rotation.eulerAngles;

        gameObject.transform.GetChild(1).Rotate(5, 0, -90);
        R_Rotate= gameObject.transform.GetChild(1).rotation.eulerAngles;
        gameObject.transform.GetChild(2).Rotate(5, 0, 90);
        L_Rotate=gameObject.transform.GetChild(2).rotation.eulerAngles;

    }

    void Update()
    {
        info = InfoManagerClass.SetInfoObject();

        if (GV.StageState == "SleepBaby_6" || GV.StageState == "Nursing_14")
        {
            ToolTip.active = false;
        }
        else
        {
            ToolTip.active = true;
        }

        InfoManagerClass.stageInfo(TextObj, gameObject, Target);

        
    }

}

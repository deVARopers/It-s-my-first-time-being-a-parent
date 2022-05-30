using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager1 : MonoBehaviour
{
   
    [SerializeField]
    Text TextObj;
    [SerializeField]
    Transform[] Target;

    [SerializeField]
    GameObject ToolTip;

    Info.PublicInfo[] info = null;

    private void Start()
    {
        
    }

    void Update()
    {
        info = InfoManagerClass.SetInfoObject();
        InfoManagerClass.stageInfo(TextObj,gameObject,Target);
    }

}

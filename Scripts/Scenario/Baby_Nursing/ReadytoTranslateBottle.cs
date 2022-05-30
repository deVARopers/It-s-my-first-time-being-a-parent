using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadytoTranslateBottle : MonoBehaviour
{
    private CloseCap script_CloseCap;
    private ContinuousLiquid script_ContinuousLiquid;
    public bool IsBottleMoved;
    public bool IsBottleGrabbed;
    public bool IsStartNursing;

    public bool Is;

    private GameObject bottle;
    // Start is called before the first frame update
    void Start()
    {
        IsBottleMoved = false;
        IsBottleGrabbed = false;
        IsStartNursing = false;
        script_CloseCap = GameObject.Find("bottlecollider").GetComponent<CloseCap>();
        script_ContinuousLiquid = GameObject.Find("Liquid").GetComponent<ContinuousLiquid>();
        bottle = GameObject.Find("bb01_body");
    }

    // Update is called once per frame
    void Update()
    {
        if(IsBottleMoved == false)
        {
            MoveBottleTable();
        }
    }

    private void MoveBottleTable()
    {
        if (script_CloseCap.b_CaptoBody == true & script_ContinuousLiquid.b_nursing == true  & IsBottleGrabbed == false)
        {
            IsBottleMoved = true;
            bottle.transform.localPosition = new Vector3(-1.05f, -3.96f, -0.13f);
            bottle.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }

    }
    public void BottleGrabbed()
    {
        IsBottleGrabbed = true;
    }
    public void NursingGrabbed()
    {
        if (GV.StageState == "Nursing_8")
            IsStartNursing = true;
    }
    public void BottleGrabbedExit()
    {
        IsBottleGrabbed = false;
        Debug.Log(IsBottleGrabbed);
    }
    public void fStartNursing()
    {
        if(GV.StageState == "Nursing_8" & IsStartNursing == true)
        {
            GV.StageState = "Nursing_9";
        }
    }
}

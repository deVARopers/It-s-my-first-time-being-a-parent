using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class transter : MonoBehaviour
{
    [SerializeField]
    GameObject Baby;

    [SerializeField]
    TwoRayInteractorController twoRayInteractorController;

    [SerializeField]
    GameObject fade;

    private float time = 0f;
    public Material skyboxes;

    // Start is called before the first frame update
    void Start()
    {
        GV.StageState = "Transfer_1";
        if(StageTransfer.set==1)
            RenderSettings.skybox = skyboxes;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GV.StageState);
        Debug.Log(time);
        if (Baby.GetComponent<ParentConstraint>().enabled)
        {
            GV.StageState = "Transfer_2";
        }

        if (GV.StageState == "Transfer_4" && GV.BabyState == GV.State.InnerWrap)
        {
            GV.BabyState = GV.State.Sleep;
            GV.StageState = "Transfer_5";
        }

        if (GV.StageState == "Transfer_5")
        {
            time += Time.deltaTime;
            fade.transform.GetComponent<Fadeinout>().stopOut = false;
            if (time >= 10)
            {
                GV.StageState = "Transfer_6";
            }
        }
    }

    public void SetTrsnfer_2()
    {
        GV.StageState = "Transfer_3";
    }

    public void SetTrsnfer_3()
    {
        GV.StageState = "Transfer_4";
        
    }


}

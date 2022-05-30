using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class TramsferToBath : MonoBehaviour
{
    [SerializeField]
    GameObject Baby;

    [SerializeField]
    TwoRayInteractorController twoRayInteractorController;


    // Start is called before the first frame update
    void Start()
    {
        GV.BabyState = GV.State.Cry;
        GV.StageState = "TransferBath_1";
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GV.StageState);
        if (Baby.GetComponent<ParentConstraint>().enabled)
        {
            GV.StageState = "TransferBath_2";
        }
    }

    public void SetTrsnfer_3()
    {
        GV.StageState = "TransferBath_3";
    }



}

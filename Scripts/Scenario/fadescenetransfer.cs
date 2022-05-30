using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadescenetransfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        switch (GV.StageState)
        {

            case "SleepBaby_8":
                SceneManager.LoadScene("[KGY]Apartment_TransferTobath");
                break;


            case "Transfer_6":
                if (StageTransfer.set == 0)
                    SceneManager.LoadScene("KJH_Merging");
                else
                    SceneManager.LoadScene("Ending");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

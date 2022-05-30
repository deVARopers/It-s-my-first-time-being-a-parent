using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageTransfer : MonoBehaviour
{
    static public int set = 0;
    // Update is called once per frame
    void Update()
    { 
            switch (GV.StageState)
            {
                case "Start_17":
                    SceneManager.LoadScene("[KGY]Apartment_BabySleep");
                    break;

                case "SleepBaby_8":
                    SceneManager.LoadScene("fade");
                    break;

                case "TransferBath_3":
                    if(set ==0)
                        SceneManager.LoadScene("[CEY]Apartment_Test");
                    else
                        SceneManager.LoadScene("[LHB]Apartment_Wash2");
                    break;

                case "diaper_13":
                    SceneManager.LoadScene("[KGY]Apartment_TransferTobed");
                    break;

                case "Transfer_6":
                    SceneManager.LoadScene("fade");
  
                    break;

                case "Nursing_15":
                    SceneManager.LoadScene("[KGY]Apartment_TransferTobath");
                    set = 1;
                break;


                case "Wash_22":
                    SceneManager.LoadScene("[KGY]Apartment_TransferTobed");
                    break;



        }    
        
    }

}

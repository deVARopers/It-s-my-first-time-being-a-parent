using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneController : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch(this.gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("[KGY]Apartment_Start");
                break;
        }
        
    }
}

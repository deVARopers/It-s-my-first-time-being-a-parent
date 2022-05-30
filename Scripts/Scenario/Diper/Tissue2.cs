using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tissue2 : MonoBehaviour
{
    private GameObject butt;
    private GameObject usedpaper;
    public Material tissue_mat;
    // Start is called before the first frame update
    private void Start()
    {
        butt = GameObject.FindGameObjectWithTag("butt");
        usedpaper = GameObject.FindGameObjectWithTag("used");
    }

    public void setposition()
    {
        gameObject.transform.position = new Vector3(-1.2f, 44.1791f, -1.304f);
        if (butt.activeSelf == false)
        {
            gameObject.SetActive(false);
            usedpaper.GetComponent<MeshRenderer>().material = tissue_mat;
        }
    }
    public void gettissue()
    {
        if(GV.StageState == "diaper_6")
        GV.StageState = "diaper_7";
    }    
}

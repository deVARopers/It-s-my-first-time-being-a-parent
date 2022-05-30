using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MaterialOpacity : MonoBehaviour
{
    public bool b_once = false;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        //bool b_once = false;

        Color color = GetComponent<Renderer>().material.color;
        if (col.tag == "Baby Bottle")
        {
            Debug.Log("color_a ready");
            if (transform.eulerAngles.x > 0 & transform.eulerAngles.x < 90)
            {
                // Debug.Log(color);
                if(color.a > 0){
                    color.a -= 0.003f;
                    GetComponent<Renderer>().material.color = color;
                }
                else if (color.a < 0)
                {
                    if (b_once == false)
                    {
                        //play music
                        //audioSource.Play();
                        GV.StageState = "Nursing_4";
                        //Debug.Log("once");
                        b_once = true;
                    }
                }
            }
        }
    }
}

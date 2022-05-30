using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InnerWrapActive : MonoBehaviour
{
    private Animation InnerWrapAnim;
    // Start is called before the first frame update
    void Start()
    {
        InnerWrapAnim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //InnerWrapAnimation();
    }

    void InnerWrapAnimation()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "InnerWrap" || collision.gameObject.name == "InnerWrapPlane")
        {
            collision.gameObject.SetActive(false);
            InnerWrapAnim.Play("Baby_InnerWrap");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CloseCap : MonoBehaviour
{
    private ReadytoTranslateBottle scr;
    public bool b_CaptoBody;
    private bool b_CapTrigger;
    private GameObject obj;
    private GameObject obj_body;
    private GameObject obj_root;

    //private Interactable interactable;
    //public bool IsGrabbing;

    // Start is called before the first frame update
    void Start()
    {
        scr = GameObject.Find("bb01_body").GetComponent<ReadytoTranslateBottle>();
        b_CaptoBody = false;
        b_CapTrigger = false;
        //IsGrabbing = false;
        obj = GameObject.Find("bb_cap");
        obj_body = GameObject.Find("bb01_body");
        obj_root = GameObject.Find("BB01_fbx");
        //obj.GetComponent<Rigidbody>().useGravity = true;
        //interactable = obj.transform.GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (b_CaptoBody == true) 
        {
            obj.transform.localPosition = new Vector3(0, 0, -0.03f);
            obj.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }

        /*if(b_CaptoBody == true)
        {
            obj.transform.localPosition = new Vector3(obj_body.transform.localPosition.x, obj_body.transform.localPosition.y, obj_body.transform.localPosition.z - 0.075f);
            //obj.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            obj.transform.localRotation = Quaternion.Euler(obj_body.transform.localRotation.eulerAngles.x, obj_body.transform.localRotation.eulerAngles.y, obj_body.transform.localRotation.eulerAngles.z);
        }*/
        //gameObject.transform.localPosition = new Vector3(0, 0, 0);

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BBCap")
        {
            b_CapTrigger = true;
            /*obj.transform.parent = obj_body.transform;
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            obj.transform.localPosition = new Vector3(0, 0, -0.03f);
            obj.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            if (GV.StageState == "Nursing_5")
            {
                GV.StageState = "Nursing_6";
            }*/
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "BBCap")
        {
            b_CapTrigger = false;
            /*b_CaptoBody = false;
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            obj.transform.parent = obj_root.transform;
            */
            //Debug.Log("Exit");
        }
    }

    /*void OnTriggerStay(Collider col)
    {
        if (col.tag == "BBCap")
        {
            b_CaptoBody = true;
        }
        else
        {
            b_CaptoBody = false;
        }
    }*/
    public void fCapAttach()
    {
        if(b_CapTrigger == true)
        {
            obj.transform.parent = obj_body.transform;
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            obj.transform.localPosition = new Vector3(0, 0, -0.03f);
            obj.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            if (GV.StageState == "Nursing_5")
            {
                GV.StageState = "Nursing_6";
                scr.IsBottleGrabbed = false;
            }
            b_CaptoBody = true;
        }
        else if(b_CapTrigger == false)
        {
            b_CaptoBody = false;
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            obj.transform.parent = obj_root.transform;
        }
    }
}

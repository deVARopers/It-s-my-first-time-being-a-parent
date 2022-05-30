using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public RectTransform prefab;
    private RectTransform waypoint;
    private Vector3 selfPos;
    private Transform player;
    private Text distanceText;
    private Text Place;
    private Image img;
    private Vector3 offset = new Vector3(0, 0.25f, 0);
    private Rigidbody rb;

    private bool isTextImageOn;
    [SerializeField]
    private bool isOnOff;

    [SerializeField]
    string place_text;

    [SerializeField]
    string[] StageState;

    // Start is called before the first frame update
    void Start()
    {
        var canvas = GameObject.Find("Waypoints").transform;

        waypoint = Instantiate(prefab, canvas);

        distanceText = waypoint.GetComponentInChildren<Text>();

        img = waypoint.GetComponentInChildren<Image>();

        player = GameObject.Find("Main Camera").transform;

        selfPos = gameObject.transform.position;

        waypoint.position = selfPos;

        rb = GetComponent<Rigidbody>();

        isTextImageOn = true;

        Place = waypoint.transform.GetChild(3).GetComponent<Text>();
        Place.text = place_text;

        isOnOff = true;
    } 

    // Update is called once per frame
    void Update()
    {
        // StateAtVisible();
        SetStageVisible();
        var screenPos = Camera.main.WorldToScreenPoint(transform.position + offset);

        if (isOnOff)
        {
            waypoint.gameObject.SetActive(screenPos.z > 0 && isTextImageOn);
        } else
        {
            waypoint.gameObject.SetActive(false);
        }

        // waypoint.transform.eulerAngles = new Vector3(0, -90, 0);

        // waypoint.transform.rotation = Quaternion.Euler(player.rotation.x, player.rotation.y, player.rotation.z);

        waypoint.position = rb.transform.position;

        waypoint.transform.LookAt(player);

        waypoint.transform.eulerAngles = new Vector3(0, waypoint.transform.eulerAngles.y, waypoint.transform.eulerAngles.z);

        distanceText.text = Vector3.Distance(player.position, transform.position).ToString("0") + " m";


        // Debug.Log(player.position.x);
        // Debug.Log(player.position.y);
        // Debug.Log(player.position.z);
        // Debug.Log(waypoint.transform.position.x);
        // Debug.Log(waypoint.transform.position.y);
        // Debug.Log(waypoint.transform.position.z);
    }

    public void offWayPoint ()
    {
        if (isTextImageOn == true)
        {
            distanceText.enabled = false;
            img.enabled = false;
            isTextImageOn = false;
        }
        // waypoint.gameObject.SetActive(false);
    }

    private void onVisible()
    {
        isOnOff = true;
        
    }

    private void SetStageVisible()
    {
        for (int i = 0; i < StageState.Length; i++)
        {
            if (StageState[i] == GV.StageState)
            {
                isOnOff = true;
                break;
            }
            else
            {
                isOnOff = false;
            }
        }
    }

    private void offVisible()
    {
        isOnOff = false;

        Debug.Log("waypoint.gameObjec.name : " + waypoint.gameObject.name);
        waypoint.gameObject.SetActive(false);
        /*for (int i = 0; i < StageState.Length; i++)
        {
            if (StageState[i] == GV.StageState)
            {
                waypoint.gameObject.SetActive(true); ;

            }
            else
            {
                waypoint.gameObject.SetActive(false);  
            }
        }*/
        //Debug.Log("waypoint.gameObjec.name : " + waypoint.gameObject.name);
        waypoint.gameObject.SetActive(false);
        /*for (int i = 0; i < StageState.Length; i++)
        {
            if (StageState[i] == GV.StageState)
            {
                waypoint.gameObject.SetActive(true); ;
            }
            else
            {
                waypoint.gameObject.SetActive(false);  
            }
        }*/
    }

    /*
     for (int i = 0; i < StopInteractableState.Length; i++)
        {
            if (StopInteractableState[i] == GV.StageState)
            {
                grabState = false;
                break;
            }
            else if (i == StopInteractableState.Length - 1)
                grabState = true;
        }
     */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatscript : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, transform.position.z);
        
           // Camera.main.transform.position.z;
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
    }
}

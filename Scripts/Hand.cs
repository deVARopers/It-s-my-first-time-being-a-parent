using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //[SerializeField]
    //public bool state = false;
    //[SerializeField] 
    //private GameObject babyObject;

    [SerializeField] private GameObject followObject;
    [SerializeField] private float follwSpeed = 30f;
    [SerializeField] private float rotateSpeed = 100f;
    [SerializeField] private Vector3 positionOffset;
    [SerializeField] private Vector3 rotationOffset;
    private Transform _followTarget;
    private Rigidbody _body;

    // Start is called before the first frame update
    void Start()
    {
        //if (state)
        //{
            // Pyhsics Movement
            _followTarget = followObject.transform;
            _body = GetComponent<Rigidbody>();
            _body.collisionDetectionMode = CollisionDetectionMode.Continuous;
            _body.interpolation = RigidbodyInterpolation.Interpolate;
            _body.mass = 20f;

            // Teleport hands
            _body.position = _followTarget.position;
            _body.rotation = _followTarget.rotation;
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (state)
        //{
            PyhsicsMove();
        //}
        
    }

    private void PyhsicsMove()
    {
        // Position
        var positionWithOffset=_followTarget.TransformPoint(positionOffset);
        var distance=Vector3.Distance(positionWithOffset,transform.position);
        _body.velocity=(positionWithOffset-transform.position).normalized*(follwSpeed*distance);

        // Rotation
        var rotationWithOffset=_followTarget.rotation*Quaternion.Euler(rotationOffset);
        var q=rotationWithOffset*Quaternion.Inverse(_body.rotation);
        q.ToAngleAxis(out float angle, out Vector3 axis);
        _body.angularVelocity=axis*(angle*Mathf.Deg2Rad*rotateSpeed);
    }
}

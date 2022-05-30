using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class GrabbleObject : OVRGrabbable
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject HugBaby;

    [SerializeField]
    GameObject RightHandIK;

    TwoBoneIKConstraint constraint;

    Transform OriginTarget;
    
    protected override void Start()
    {
        base.Start();
        TwoBoneIKConstraint constraint = RightHandIK.GetComponent<TwoBoneIKConstraint>();

        OriginTarget = constraint.data.target;
        //OriginTarget -> player.transform.position(0.1, 44.7, -3.3)
        Debug.Log(OriginTarget);


    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        Debug.Log("GrabBegin");
        constraint.data.target = HugBaby.transform;
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        Debug.Log("GrabEnd");
        //constraint.data.target = OriginTarget;
    }
}

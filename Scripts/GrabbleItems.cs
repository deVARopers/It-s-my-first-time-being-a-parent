using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbleItems : OVRGrabbable
{
    [SerializeField]
    private Material Mat;

    private Material originMat;
    private Renderer renderer;

    protected override void Start()
    {
        base.Start();
        renderer = GetComponent<Renderer>();
        originMat = GetComponent<Material>();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        renderer.material = Mat;
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        renderer.material = originMat;
    }
}

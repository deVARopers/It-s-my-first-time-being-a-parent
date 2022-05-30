using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabLeg : MonoBehaviour
{
    [SerializeField]
    Transform IK_right_target;
    [SerializeField]
    Transform IK_left_target;
    [SerializeField]
    Transform original_Dummy;
    
    [SerializeField]
    Transform rightHandTransform;
    [SerializeField]
    Transform leftHandTransform;
 
    [SerializeField]
    RayInteracterManager rightRayInteractor;
    [SerializeField]
    RayInteracterManager leftRayInteractor;

    Transform origin_Right;
    Transform origin_Left;
    [SerializeField]
    Transform origin_pos;

    public bool grabByRight;
    public bool grabByLeft;

    public void Start()
    {
        // origin_Right = IK_right_target;
        // origin_Left = IK_left_target;

        grabByRight = false;
        grabByLeft = false;
    }

    public void grabbedEvent ()
    {
        if (rightRayInteractor.isSelectActive)
        {
            grabByRight = true;
        } else if (leftRayInteractor.isSelectActive)
        {
            grabByLeft = true;
        }
    }

    public void unGrabbedEvent ()
    {
        grabByRight = false;
        grabByLeft = false;
        IK_right_target.position = origin_pos.position;
        IK_left_target.position = origin_pos.position;
    }

    public void Update()
    {
        if (grabByRight)
        {
            IK_right_target.position = rightHandTransform.position;
            IK_left_target.position = rightHandTransform.position;
            //Debug.Log(rightHandTransform.position);
        }
        else if (grabByLeft)
        {
            IK_right_target.position = leftHandTransform.position;
            IK_left_target.position = leftHandTransform.position;
        }
        else
        {
            // IK_right_target.position = origin_pos.position;
            // IK_left_target.position = origin_pos.position;
            // IK_right_target.position = original_Dummy.position;
            // IK_left_target.position = original_Dummy.position;
        }
    }
}

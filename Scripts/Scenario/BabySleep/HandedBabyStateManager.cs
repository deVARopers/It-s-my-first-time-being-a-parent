using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandedBabyStateManager : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        StateBehavior();
    }
    private void StateBehavior()
    {
        switch (GV.BabyState)
        {
            case GV.State.Base:
                BabyAnimation("Base");
                break;
            case GV.State.Cry:
                BabyAnimation("Cry");
                break;
            case GV.State.InnerWrap:
                BabyAnimation("InnerWrap");
                break;
            case GV.State.Eat:
                break;
            case GV.State.Sleep:
                BabyAnimation("Sleep");
                break;
        }
    }
    private void BabyAnimation(string anim)
    {
        animator.SetTrigger(anim);
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            animator.ResetTrigger(anim);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GV 
{
    public enum State
    {
        Base,
        Cry,
        InnerWrap,
        Eat,
        Sleep,
        DeepSleep,
        Wash,
        NursingBase
    }

    public static State BabyState;

    public static string StageState ;

    public static string AttachState;

}

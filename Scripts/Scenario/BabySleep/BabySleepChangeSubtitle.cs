using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabySleepChangeSubtitle : MonoBehaviour
{


    [SerializeField]
    private AudioClip[] audioClipArr;
    [SerializeField]
    private Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private AudioClip[][] audioClipArray = new AudioClip[5][];

    private Subtitle SleepBaby_1;
    private Subtitle SleepBaby_2;
    private Subtitle SleepBaby_3;
    private Subtitle SleepBaby_4;
    private Subtitle SleepBaby_5;
    private Subtitle SleepBaby_6;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        makeAudioArray();
    }
    void Update()
    {
        SleepBaby();
    }

    private void makeAudioArray()
    {
        SleepBaby_1 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[0], audioClipArr[1], audioClipArr[2] }, SubtitleArray.BabySleepSubtitle[0]);
        SleepBaby_2 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[3] }, SubtitleArray.BabySleepSubtitle[1]);
        SleepBaby_3 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[4], audioClipArr[5] }, SubtitleArray.BabySleepSubtitle[2]);
        SleepBaby_4 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[6] }, SubtitleArray.BabySleepSubtitle[3]);
        SleepBaby_5 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[7], audioClipArr[8], audioClipArr[9], audioClipArr[10] }, SubtitleArray.BabySleepSubtitle[4]);
        SleepBaby_6 = new Subtitle(new AudioClip[] { audioClipArr[11], audioClipArr[12] }, SubtitleArray.BabySleepSubtitle[5]);
    }

    private void SleepBaby()
    {
        switch (GV.StageState)
        {
            case "SleepBaby_1":
                SleepBaby_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "SleepBaby_2":
                SleepBaby_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "SleepBaby_3":
                SleepBaby_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "SleepBaby_4":
                SleepBaby_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "SleepBaby_5":
                SleepBaby_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "SleepBaby_6":
                SleepBaby_6.PlaySubtitle(audioSource, gameObject, textObject,false);
                if (SleepBaby_6.isSubtitleEnded)
                    GV.StageState = "SleepBaby_7";
                break;
        }
    }
}
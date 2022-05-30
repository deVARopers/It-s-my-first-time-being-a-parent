using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyChangeText : MonoBehaviour
{
   

    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i=0;
    float delay=0.0f;

    private Subtitle Start_1;

    void Start()
    { 
        audioSource = GetComponent<AudioSource>();
        audioSource.loop=false;
        makeAudioArray();
    }

    // Update is called once per frame
    void Update()
    {
        StartBaby();
    }

    private void makeAudioArray()
    {
        Start_1 = new Subtitle(new AudioClip[] { audioClipArr[0], audioClipArr[1], audioClipArr[2], audioClipArr[3], audioClipArr[4], audioClipArr[5] }, SubtitleArray.StartSubtitle[0]);
        
    }

    private void StartBaby()
    {
        Start_1.PlaySubtitle(audioSource, gameObject, textObject);
    }

    /*
    private void SleepBaby()
    {
        switch(GV.StageState)
        {
            case "SleepBaby_1":
                SleepBaby_1.PlaySubtitle(audioSource, gameObject, textObject);
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
        }
        
    }
    */

}
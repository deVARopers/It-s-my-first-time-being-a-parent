using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyStartChangeSubtitle : MonoBehaviour
{


    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Start_1;
    private Subtitle Start_2;
    private Subtitle Start_3;
    private Subtitle Start_4;
    private Subtitle Start_5;
    private Subtitle Start_6;
    private Subtitle Start_9;
    private Subtitle Start_10;
    private Subtitle Start_12;
    private Subtitle Start_13;
    private Subtitle Start_16;

    [SerializeField]
    private AudioSource TaskComplete;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        makeAudioArray();
    }

    // Update is called once per frame
    void Update()
    {
        StartBaby();
    }

    private void makeAudioArray()
    {
        Start_1 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[0], audioClipArr[1], audioClipArr[2]}, SubtitleArray.StartSubtitle[0]);
        Start_2 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[3], audioClipArr[4], audioClipArr[5] }, SubtitleArray.StartSubtitle[1]);
        Start_3 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[6] }, SubtitleArray.StartSubtitle[2]);
        Start_4 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[7], audioClipArr[8],audioClipArr[9] }, SubtitleArray.StartSubtitle[3]);
        Start_5 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[10] }, SubtitleArray.StartSubtitle[4]);
        Start_6 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[11], audioClipArr[12]}, SubtitleArray.StartSubtitle[5]);
        Start_9 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[13]}, SubtitleArray.StartSubtitle[6]);
        Start_10 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[14], audioClipArr[15] }, SubtitleArray.StartSubtitle[7]);
        Start_12 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[16]}, SubtitleArray.StartSubtitle[8]);
        Start_13 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[17], audioClipArr[18] }, SubtitleArray.StartSubtitle[9]);
        Start_16 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[19], audioClipArr[20], audioClipArr[21], audioClipArr[22] }, SubtitleArray.StartSubtitle[10]);

    }

    private void StartBaby()
    {
        switch (GV.StageState)
        {
            case "Start_1":
                Start_1.PlaySubtitle(audioSource, gameObject, textObject,false);
                break;
            case "Start_2":
                Start_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_3":
                Start_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_4":
                Start_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_5":
                Start_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_6":
                Start_6.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_9":
                Start_9.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_10":
                Start_10.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_12":
                Start_12.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_13":
                Start_13.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Start_16":
                Start_16.PlaySubtitle(audioSource, gameObject, textObject);
                break;
        }
    }

}

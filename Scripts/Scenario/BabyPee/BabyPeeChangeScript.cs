using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BabyPeeChangeScript : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Pee_1;
    private Subtitle Pee_2;
    private Subtitle Pee_3;
    private Subtitle Pee_4;
    private Subtitle Pee_5;
    private Subtitle Pee_6;
    private Subtitle Pee_7;
    private Subtitle Pee_8;
    private Subtitle Pee_9;
    private Subtitle Pee_10;
    private Subtitle Pee_11;
    private Subtitle Pee_12;
    private Subtitle Pee_14;
    private Subtitle Pee_16;
    private Subtitle Pee_17;


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
        Pee_1 = new Subtitle(new AudioClip[] { audioClipArr[0], audioClipArr[1] }, SubtitleArray.StartSubtitle[0]);
        Pee_2 = new Subtitle(new AudioClip[] { audioClipArr[2], audioClipArr[3] }, SubtitleArray.StartSubtitle[1]);
        Pee_3 = new Subtitle(new AudioClip[] { audioClipArr[4], audioClipArr[5], audioClipArr[6] }, SubtitleArray.StartSubtitle[2]);
        Pee_4 = new Subtitle(new AudioClip[] { audioClipArr[7] }, SubtitleArray.StartSubtitle[3]);
        Pee_5 = new Subtitle(new AudioClip[] { audioClipArr[8] }, SubtitleArray.StartSubtitle[4]);
        Pee_6 = new Subtitle(new AudioClip[] { audioClipArr[9] }, SubtitleArray.StartSubtitle[5]);
        Pee_7 = new Subtitle(new AudioClip[] { audioClipArr[10], audioClipArr[11] }, SubtitleArray.StartSubtitle[6]);
        Pee_8 = new Subtitle(new AudioClip[] { audioClipArr[12], audioClipArr[13] }, SubtitleArray.StartSubtitle[7]);
        Pee_9 = new Subtitle(new AudioClip[] { audioClipArr[14], audioClipArr[15], audioClipArr[16] }, SubtitleArray.StartSubtitle[8]);
        Pee_10 = new Subtitle(new AudioClip[] { audioClipArr[17] }, SubtitleArray.StartSubtitle[9]);
        Pee_11 = new Subtitle(new AudioClip[] { audioClipArr[18] }, SubtitleArray.StartSubtitle[10]);
        Pee_12 = new Subtitle(new AudioClip[] { audioClipArr[19] }, SubtitleArray.StartSubtitle[11]);
        Pee_14 = new Subtitle(new AudioClip[] { audioClipArr[20] }, SubtitleArray.StartSubtitle[12]);
        Pee_16 = new Subtitle(new AudioClip[] { audioClipArr[21] }, SubtitleArray.StartSubtitle[13]);
        Pee_17 = new Subtitle(new AudioClip[] { audioClipArr[22] }, SubtitleArray.StartSubtitle[14]);
    }

    private void StartBaby()
    {
        switch (GV.StageState)
        {
            case "Pee_1":
                Pee_1.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_2":
                Pee_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_3":
                Pee_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_4":
                Pee_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_5":
                Pee_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_6":
                Pee_6.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_7":
                Pee_7.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_8":
                Pee_8.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_9":
                Pee_9.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_10":
                Pee_10.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_11":
                Pee_11.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_12":
                Pee_12.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_14":
                Pee_14.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_16":
                Pee_16.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Pee_17":
                Pee_17.PlaySubtitle(audioSource, gameObject, textObject);
                break;
        }
    }
}

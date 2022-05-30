using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyWashChangeSubtitle : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Wash_1;
    private Subtitle Wash_2;
    private Subtitle Wash_3;
    private Subtitle Wash_4;
    private Subtitle Wash_5;
    private Subtitle Wash_7;
    private Subtitle Wash_8;
    private Subtitle Wash_9;
    private Subtitle Wash_10;
    private Subtitle Wash_12;
    private Subtitle Wash_13;
    private Subtitle Wash_14;
    private Subtitle Wash_15;
    private Subtitle Wash_17;
    private Subtitle Wash_18;
    private Subtitle Wash_19;
    private Subtitle Wash_20;
    private Subtitle Wash_22;
    private Subtitle Wash_24;
    private Subtitle Wash_25;



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
        Wash_1 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[0], audioClipArr[1] }, SubtitleArray.BabyWashSubtitle[0]);
        Wash_2 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[2], audioClipArr[3], audioClipArr[4] }, SubtitleArray.BabyWashSubtitle[1]);
        Wash_3 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[5], audioClipArr[6], audioClipArr[7] }, SubtitleArray.BabyWashSubtitle[2]);
        Wash_4 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[8] }, SubtitleArray.BabyWashSubtitle[3]);
        Wash_5 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[9] }, SubtitleArray.BabyWashSubtitle[4]);
        Wash_7 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[10] }, SubtitleArray.BabyWashSubtitle[5]);
        Wash_8 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[11], audioClipArr[12] }, SubtitleArray.BabyWashSubtitle[6]);
        Wash_9 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[13], audioClipArr[14] }, SubtitleArray.BabyWashSubtitle[7]);
        Wash_10 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[15]}, SubtitleArray.BabyWashSubtitle[8]);
        Wash_12 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[16] }, SubtitleArray.BabyWashSubtitle[9]);
        Wash_13 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[17], audioClipArr[18] }, SubtitleArray.BabyWashSubtitle[10]);
        Wash_14 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[19] }, SubtitleArray.BabyWashSubtitle[11]);
        Wash_15 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[20], audioClipArr[21] }, SubtitleArray.BabyWashSubtitle[12]);
        Wash_17 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[22], audioClipArr[23], audioClipArr[24] }, SubtitleArray.BabyWashSubtitle[13]);
        Wash_18 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[25] }, SubtitleArray.BabyWashSubtitle[14]);
        Wash_19 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[26] }, SubtitleArray.BabyWashSubtitle[15]);
        Wash_20 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[27] }, SubtitleArray.BabyWashSubtitle[16]);
        Wash_22 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[28] }, SubtitleArray.BabyWashSubtitle[17]);
        Wash_24 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[29] }, SubtitleArray.BabyWashSubtitle[18]);
        Wash_25 = new Subtitle(new AudioClip[] { audioClipArr[31], audioClipArr[30] }, SubtitleArray.BabyWashSubtitle[19]);
    }

    private void StartBaby()
    {
        switch (GV.StageState)
        {
            case "Wash_1":
                Wash_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "Wash_2":
                Wash_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_3":
                Wash_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_4":
                Wash_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_5":
                Wash_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_7":
                Wash_7.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_8":
                Wash_8.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_9":
                Wash_9.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_10":
                Wash_10.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_12":
                Wash_12.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_13":
                Wash_13.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_14":
                Wash_14.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_15":
                Wash_15.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_17":
                Wash_17.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_18":
                Wash_18.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_19":
                Wash_19.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_20":
                Wash_20.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_22":
                Wash_22.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_24":
                Wash_24.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Wash_25":
                Wash_25.PlaySubtitle(audioSource, gameObject, textObject);
                break;
        }
    }
}

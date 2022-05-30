using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NursingSubtitle : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Nursing_1;
    private Subtitle Nursing_2;
    private Subtitle Nursing_3;
    private Subtitle Nursing_4;
    private Subtitle Nursing_5;
    private Subtitle Nursing_6;
    private Subtitle Nursing_7;
    private Subtitle Nursing_8;
    private Subtitle Nursing_9;
    private Subtitle Nursing_10;
    private Subtitle Nursing_11;
    private Subtitle Nursing_12;
    private Subtitle Nursing_13;
    private Subtitle Nursing_14;


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
        Nursing_1 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[0], audioClipArr[1] }, SubtitleArray.BabyNursingSubtitle[0]);
        Nursing_2 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[2], audioClipArr[3], audioClipArr[4] }, SubtitleArray.BabyNursingSubtitle[1]);
        Nursing_3 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[5], audioClipArr[6], audioClipArr[7] }, SubtitleArray.BabyNursingSubtitle[2]);
        Nursing_4 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[8], audioClipArr[9] }, SubtitleArray.BabyNursingSubtitle[3]);
        Nursing_5 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[10] }, SubtitleArray.BabyNursingSubtitle[4]);
        Nursing_6 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[11], audioClipArr[12] }, SubtitleArray.BabyNursingSubtitle[5]);
        Nursing_7 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[13], audioClipArr[14] }, SubtitleArray.BabyNursingSubtitle[6]);
        Nursing_8 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[15], audioClipArr[16], audioClipArr[17], audioClipArr[18] }, SubtitleArray.BabyNursingSubtitle[7]);
        Nursing_9 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[19], audioClipArr[20] }, SubtitleArray.BabyNursingSubtitle[8]);
        Nursing_10 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[21], audioClipArr[22] }, SubtitleArray.BabyNursingSubtitle[9]);
        Nursing_11 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[23], audioClipArr[24] }, SubtitleArray.BabyNursingSubtitle[10]);
        Nursing_12 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[25], audioClipArr[27] }, SubtitleArray.BabyNursingSubtitle[11]);
        Nursing_13 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[28], audioClipArr[29] }, SubtitleArray.BabyNursingSubtitle[12]);
        Nursing_14 = new Subtitle(new AudioClip[] { audioClipArr[26], audioClipArr[30], audioClipArr[31] }, SubtitleArray.BabyNursingSubtitle[13]);

    }

    private void StartBaby()
    {
        switch (GV.StageState)
        {
            case "Nursing_1":
                Nursing_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "Nursing_2":
                Nursing_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_3":
                Nursing_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_4":
                Nursing_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_5":
                Nursing_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_6":
                Nursing_6.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_7":
                Nursing_7.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_8":
                Nursing_8.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_9":
                Nursing_9.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "Nursing_10":
                Nursing_10.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_11":
                Nursing_11.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_12":
                Nursing_12.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_13":
                Nursing_13.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Nursing_14":
                Nursing_14.PlaySubtitle(audioSource, gameObject, textObject);
                if (Nursing_14.isSubtitleEnded)
                    GV.StageState = "Nursing_15";
                break;
        }
    }
}
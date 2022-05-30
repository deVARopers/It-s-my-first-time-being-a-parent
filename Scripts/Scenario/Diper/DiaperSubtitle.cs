using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaperSubtitle : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Diaper_1;
    private Subtitle Diaper_2;
    private Subtitle Diaper_3;
    private Subtitle Diaper_4;
    private Subtitle Diaper_5;
    private Subtitle Diaper_6;
    private Subtitle Diaper_7;
    private Subtitle Diaper_8;
    private Subtitle Diaper_9;
    private Subtitle Diaper_10;
    private Subtitle Diaper_11;
    private Subtitle Diaper_12;
    private Subtitle Diaper_13;
    private Subtitle Diaper_14;
    private Subtitle Diaper_15;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        makeAudioArray();
    }

    // Update is called once per frame
    void Update()
    {
        DiaperBaby();
    }

    private void makeAudioArray()
    {
        Diaper_1 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[0], audioClipArr[1] }, SubtitleArray.BabyPeeSubtitle[0]);
        Diaper_2 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[2] }, SubtitleArray.BabyPeeSubtitle[1]);
        Diaper_3 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[3], audioClipArr[4], audioClipArr[5], audioClipArr[6] }, SubtitleArray.BabyPeeSubtitle[2]);
        Diaper_4 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[7] }, SubtitleArray.BabyPeeSubtitle[3]);
        Diaper_5 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[8] }, SubtitleArray.BabyPeeSubtitle[4]);
        Diaper_6 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[9] }, SubtitleArray.BabyPeeSubtitle[5]);
        Diaper_7 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[10], audioClipArr[11] }, SubtitleArray.BabyPeeSubtitle[6]);
        Diaper_8 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[12], audioClipArr[13] }, SubtitleArray.BabyPeeSubtitle[7]);
        Diaper_9 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[14], audioClipArr[15], audioClipArr[16] }, SubtitleArray.BabyPeeSubtitle[8]);
        Diaper_10 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[17] }, SubtitleArray.BabyPeeSubtitle[9]);
        Diaper_11 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[18] }, SubtitleArray.BabyPeeSubtitle[10]);
        Diaper_12 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[19] }, SubtitleArray.BabyPeeSubtitle[11]);
        Diaper_13 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[20] }, SubtitleArray.BabyPeeSubtitle[12]);
        Diaper_14 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[21] }, SubtitleArray.BabyPeeSubtitle[13]);
        Diaper_15 = new Subtitle(new AudioClip[] { audioClipArr[23], audioClipArr[22] }, SubtitleArray.BabyPeeSubtitle[14]);
    }

    private void DiaperBaby()
    {
        switch (GV.StageState)
        {
            case "diaper_1":
                Diaper_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "diaper_2":
                Diaper_2.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_3":
                Diaper_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_4":
                Diaper_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_5":
                Diaper_5.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_6":
                Diaper_6.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_7":
                Diaper_7.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_8":
                Diaper_8.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_9":
                Diaper_9.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_10":
                Diaper_10.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_11":
                Diaper_11.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "diaper_12":
                Diaper_12.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            
        }
    }



}

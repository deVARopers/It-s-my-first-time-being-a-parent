using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferSubtitle : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClipArr;
    public Text textObject;
    private AudioSource audioSource;

    private int i = 0;
    float delay = 0.0f;

    private Subtitle Transfer_1;
    private Subtitle Transfer_3;
    private Subtitle Transfer_4;

    private Subtitle TransferToBath_1;


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
        Transfer_1 = new Subtitle(new AudioClip[] { audioClipArr[3], audioClipArr[0] }, SubtitleArray.Transfer[0]);
        Transfer_3 = new Subtitle(new AudioClip[] { audioClipArr[3], audioClipArr[1] }, SubtitleArray.Transfer[1]);
        Transfer_4 = new Subtitle(new AudioClip[] { audioClipArr[3], audioClipArr[2] }, SubtitleArray.Transfer[2]);

        TransferToBath_1 = new Subtitle(new AudioClip[] { audioClipArr[3], audioClipArr[0], audioClipArr[1], audioClipArr[2] }, SubtitleArray.TransferToBath[0]);
    }

    private void StartBaby()
    {
        switch (GV.StageState)
        {
            case "Transfer_1":
                Transfer_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
            case "Transfer_3":
                Transfer_3.PlaySubtitle(audioSource, gameObject, textObject);
                break;
            case "Transfer_4":
                Transfer_4.PlaySubtitle(audioSource, gameObject, textObject);
                break;

            case "TransferBath_1":
                TransferToBath_1.PlaySubtitle(audioSource, gameObject, textObject, false);
                break;
        }
    }

}

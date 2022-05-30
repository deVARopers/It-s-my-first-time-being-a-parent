using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completeAudio : MonoBehaviour
{
    private AudioSource AudioSource;

    [SerializeField]
    string[] Stage;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        startAudio();
    }

    private void startAudio()
    {
        for(int i = 0; i < Stage.Length; i++)
        {
            if(GV.StageState == Stage[i])
            {
                Debug.Log(AudioSource.isPlaying);
                AudioSource.Play();
            }
        }
    }
}

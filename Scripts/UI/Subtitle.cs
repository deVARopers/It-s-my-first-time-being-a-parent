using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitle 
{
    int i;
    float delay = 0.0f;
    private AudioClip[] audioClip;
    private string[] subtitle;
    public bool isSubtitleEnded = false;

    public Subtitle(AudioClip[] audio, string[] subtitle)
    {
        this.audioClip = audio;
        this.subtitle = subtitle;
    }
    AudioClip[] AudioClipArray
    {
        get { return audioClip; }
        set { audioClip = value; }
    }

    public string[] SubtittleArray
    {
        get { return subtitle; }
    }

    public void PlaySubtitle(AudioSource audioSource, GameObject gameObject, Text textObject, bool trigger = true)
    {
        if (!audioSource.isPlaying)
        {
          
            if (i > subtitle.Length)
            {
                audioSource.Pause();
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
                isSubtitleEnded = true;
                //i = 0;
            }
            else
            {
                if (delay >= 3.0f)
                {
                    if (i > 0)
                    {
                        gameObject.transform.GetChild(0).gameObject.SetActive(true);
                        gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);

                        textObject.text = "<b>" + subtitle[i-1] + "</b>";
                        audioSource.clip = audioClip[i];
                        audioSource.Play();
                        i++;

                    }
                   
                    delay = 0.0f;
                   
                }
                else if (i == 0)
                {

                    if (trigger)
                    {
                        audioSource.clip = audioClip[i];
                        audioSource.Play();
                    }
                    i++;

                }
                
            }
        }
        delay += Time.deltaTime;
        //Debug.Log(delay);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    public float animTime = 2f;         // Fade �ִϸ��̼� ��� �ð� (����:��).  
    private Image fadeImage;            // UGUI�� Image������Ʈ ���� ����.  

    private float start = 1f;           // Mathf.Lerp �޼ҵ��� ù��° ��.  
    private float end = 0f;             // Mathf.Lerp �޼ҵ��� �ι�° ��.  
    private float time = 0f;            // Mathf.Lerp �޼ҵ��� �ð� ��.  


    public bool stopIn = true; //false�϶� ����Ǵ°ǵ�, �ʱⰪ�� false�� �� ������ ���� �����Ҷ� ���̵������� ������...�װ� ������ true�� �ϸ��.
    public bool stopOut = false;

    void Awake()
    {
        // Image ������Ʈ�� �˻��ؼ� ���� ���� �� ����.  
        fadeImage = GetComponent<Image>();
    }

    void Start()
    {

    }

    void Update()
    {

        PlayFadeIn();
        PlayFadeOut();


        // ���������� = FadeIn �ִϸ��̼� ���.  
        if (stopIn == true && time <= 2)
        {
            PlayFadeIn();
        }
        if (stopOut == true && time <= 2)
        {
            PlayFadeOut();
        }



        if (time >= 2 && stopIn == true)
        {
            Debug.Log("StopIn");
            stopOut = true;
            stopIn = false;
            time = 0;

        }
        if (time >= 2 && stopIn == true)
        {
            Debug.Log("StopIn");
            stopOut = false;
            stopIn = true;
            time = 0;
        }


        /*
      // ���������� = FadeIn �ִϸ��̼� ���.  
      if (stopIn == false && time <= 2)
      {
          PlayFadeIn();
      }
      if (stopOut == false && time <= 2)
      {
          PlayFadeOut();
      }

      if (time >= 2 && stopIn == false)
      {
          stopIn = true;
          time = 0;
          Debug.Log("StopIn");
      }
      if (time >= 2 && stopOut == false)
      {
          stopIn = false; //�Ͼ�� ��ȯ�ǰ� ���� �� ��ȯ �� �ٽ� Ǯ�Ŷ� �־���. �׳� ���� �����Ÿ� ���� �ʿ� ����.
          stopOut = true;
          time = 0;
          Debug.Log("StopOut");
      }*/

    }

    // ���->����
    void PlayFadeIn()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
        // Debug.Log(time);
    }

    // ����->���
    void PlayFadeOut()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(end, start, time);  //FadeIn���� �޸� start, end�� �ݴ��.
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
    }

 }
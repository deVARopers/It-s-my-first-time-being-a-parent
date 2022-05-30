using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shine : MonoBehaviour
{
    [SerializeField]
    Material HoverMat;

    [SerializeField]
    Material CheckMat;

    MeshRenderer meshRenderer;
    int i = 0;
    private void Update()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        /*OriginMat = meshRenderer.sharedMaterial;*/
        i++;
        if(i == 1)
        {
            StartCoroutine("FadeIn");
        }
    }

    IEnumerator FadeOut()
    {
        for (int i = 10; i >= 0; i--)
        {
            float f = i / 10.0f;
            Color c = meshRenderer.sharedMaterial.color;
            c.a = f;
            meshRenderer.sharedMaterial.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }


}

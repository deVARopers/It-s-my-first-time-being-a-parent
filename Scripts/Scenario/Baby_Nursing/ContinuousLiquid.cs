using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousLiquid : MonoBehaviour
{
    //private bool b_once;
    private AudioSource audioSource;

    private bool b_changeliquidcolor;
    public bool b_nursing;
    public bool b_liquidheight;

    private Material material;
    private Material mesh_material;

    private Color defaultColor;
    private Color targetColor;

    private Vector4 position_current;
    private Vector4 position_fixed;

    private float timeLeft;

    private MaterialOpacity mat_opa;
    //private Nursing nur;
    // private Color targetColor = new Color.Lerp()

    //(0.627, 0.974, 1.000, 0.745)

    //b_once = GameObJect.Find("DryMilk").GetComponent<MaterialOpacity>().b_once;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        timeLeft = 2.0f;
        b_changeliquidcolor = false;
        b_nursing = false;
        b_liquidheight = false;

        material = GetComponent<Renderer>().material;
        mesh_material = GetComponent<MeshRenderer>().material;

        defaultColor = material.GetColor("_LiquidColor");
        targetColor = new Color(0.98F, 1.0F, 0.39F, 0.745F);

        //position_current = mesh_material.GetVector("_PlanePos");
        //position_fixed = new Vector3(position_current.x, position_current.y, position_current.z);

        mat_opa = GameObject.Find("DryMilk").GetComponent<MaterialOpacity>();
        //nur = GameObject.Find("bb_cap").GetComponent<Nursing>();




    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {

        //material.shader = Shader.Find("Liquid/Liquid");
        //Debug.Log(mat_opa.b_once);
        Debug.Log(material.GetColor("_LiquidColor"));
        Debug.Log(mesh_material.GetVector("_Plane"));
        position_current = mesh_material.GetVector("_PlanePos");
        //position_fixed = new Vector4(position_current.x, position_current.y - 0.1f, position_current.z, position_current.w);
        position_fixed = new Vector4(0f, 0f, 0f, 0f);
        mesh_material.SetVector("_PlanePos", position_fixed);

        if (col.name == "Stick" & mat_opa.b_once == true)
        {
            //Debug.Log(material.shader);
            //material.SetColor("_LiquidColor", Color.red);
            b_changeliquidcolor = true;
            //Debug.Log(b_changeliquidcolor);

            if (b_changeliquidcolor == true)
            {
                if (timeLeft > Time.deltaTime)
                {
                    material.SetColor("_LiquidColor", Color.Lerp(material.GetColor("_LiquidColor"), targetColor, Time.deltaTime / timeLeft));
                    material.SetColor("_TopColor", Color.Lerp(material.GetColor("_LiquidColor"), targetColor, Time.deltaTime / timeLeft));
                    timeLeft -= Time.deltaTime;
                    if(!audioSource.isPlaying) audioSource.Play();
                }
                else if(GV.StageState == "Nursing_4")
                {
                    GV.StageState = "Nursing_5";
                    material.SetColor("_LiquidColor", targetColor);
                    material.SetColor("_TopColor", targetColor);
                    timeLeft = 1.0f;

                    b_nursing = true;
                }

            }

            //liquid_color.SetColor("_LiquidColor", UnityEngine.Random.ColorHSV());
            /*if (liquid_color.a > 0){
                liquid_color.a -= 0.003f;
                GetComponent<Renderer>().material.color = liquid_color;
                }*/
        }

        /*if (nur.b_startnursing == true)
        {
            //mesh_material.SetVector("_PlanePos", planePosition);
            b_liquidheight = true;


        }*/
    }
}

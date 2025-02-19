using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_Changing_Cube : MonoBehaviour
{

    public Material[] material;
    public Renderer ren;
    public GameObject Line_Up;
    public GameObject Line_Down;
    public GameObject Line_Left;
    public GameObject Line_Right;

    public int condition = 0;

    void Start ()
    {
        ren = GetComponent<Renderer>();
        ren.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Line_Up.tag == "Last_Coloured" && Line_Down.tag == "Coloured" && Line_Left.tag == "Coloured" && Line_Right.tag == "Coloured")
        {
            ren.sharedMaterial = Line_Up.GetComponentInChildren<Renderer>().material;
            ren.tag = "Last_Coloured_Cube";
            condition = 1;
        }

        else if (Line_Up.tag == "Coloured" && Line_Down.tag == "Last_Coloured" && Line_Left.tag == "Coloured" && Line_Right.tag == "Coloured")
        {
            ren.sharedMaterial = Line_Down.GetComponentInChildren<Renderer>().material;
            condition = 1;
            ren.tag = "Last_Coloured_Cube";
        }

        else if (Line_Up.tag == "Coloured" && Line_Down.tag == "Coloured" && Line_Left.tag == "Last_Coloured" && Line_Right.tag == "Coloured")
        {
            ren.sharedMaterial = Line_Left.GetComponentInChildren<Renderer>().material;
            condition = 1;
            ren.tag = "Last_Coloured_Cube";
        }

        else if (Line_Up.tag == "Coloured" && Line_Down.tag == "Coloured" && Line_Left.tag == "Coloured" && Line_Right.tag == "Last_Coloured")
        {
            ren.sharedMaterial = Line_Right.GetComponentInChildren<Renderer>().material;
            condition = 1;
            ren.tag = "Last_Coloured_Cube";
        }
    }
}
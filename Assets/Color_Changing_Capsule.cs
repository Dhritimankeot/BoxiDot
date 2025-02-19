using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changing_Capsule : MonoBehaviour
{

    public Material[] materials;
    public Renderer rend;
    GameObject Last;
    GameObject cube;
    /*
    GameObject result;
    GameObject game;
    GameObject player1;
    GameObject player2;
    */

    static private int counter = 0;
    int store;
    int cnd = 0;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnMouseDown ()
    {
        if (Input.GetMouseButtonDown(0) && cnd == 0)
        {
            if (counter != 0)
            {
                Last = GameObject.FindWithTag("Last_Coloured");
                Last.tag = "Coloured";
            }
            store = counter;
            if (counter % 2 == 0)
            {
                rend.sharedMaterial = materials[0];
                counter += 1;
                rend.tag = "Last_Coloured";
                cnd = 1;
            }
            else
            {
                rend.sharedMaterial = materials[1];
                counter += 1;
                rend.tag = "Last_Coloured";
                cnd = 1;
            }

            cube = GameObject.FindWithTag("Last_Coloured_Cube");
            if (cube.GetComponentInChildren<Color_Changing_Cube>().condition == 1)
            {
                /*
                result = GameObject.FindWithTag("Finish");
                game = GameObject.FindWithTag("Game");
                player1 = GameObject.FindWithTag("Player_1");
                player2 = GameObject.FindWithTag("Player_2");
                result.SetActive(true);
                game.SetActive(false);

                if (cube.GetComponent<Renderer>.material == materials[0])
                    player1.SetActive(true);
                else if (cube.GetComponent<Renderer>.material == materials[1])
                    player2.SetActive(true);
                */
                cube.tag = "Coloured_Cube";
                counter = store;
                rend.sharedMaterial = cube.GetComponentInChildren<Renderer>().material;
            }
        }
    }
}
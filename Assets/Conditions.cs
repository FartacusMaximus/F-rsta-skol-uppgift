using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    public bool ifBool;
    public int value;

    // Use this for initialization
    void Start()
    {
        if (ifBool == true)
        {
            print("ja");
        }
        else
        {
            print("NEIN");
        }
        // == lika med
        // != inte lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med 
        // && och
        // || eller


        if (value != 5)
        {
            if (ifBool == true)
            {
                print("YOU ARE NOT PREPARED");
            }
        }
        else if (value == 4)
        {
            print("Thralls Balls");
        }
        else if (value == 3)
        {
            print("Arthas did nothing wrong");
        }
        else if (value == 2)
        {
            print("Zappy boi");
        }
        else if (value == 1)
        {
            print("MAJS ÄR NAJS");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))

        {
            print("U DO DA E MÖH BÖHJ");
        }

    }
}

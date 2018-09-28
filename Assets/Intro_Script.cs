using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Script : MonoBehaviour
{
    //int = Heltal
    //public = syns i unity
    //Hejsan = namnet
    public int jumpForceWhileNotGrounded;

    // Float = decimaltal med 7 percision.
    public float george;

    // double = decimaltal med 15 percision.
    public double bush;

    // string = text.
    public string meincraft;

    // bool = något som är true/false (ja/nej)
    public bool John;

    /*"Multi-line comment"
    * hejsan
    * svejsan
    */

    //char = ett tecken.
    public char dennis;

    // Use this for initialization
    void Start()
    {
        //string.Format= Good stuff
        //PrintText();
        //Calculate();
        Debug.Log("Hej" + "då" + John + " " + meincraft);
        Debug.Log(string.Format("Hej då! {0} {1}", John, meincraft));
    }

    //ALTGR + 7
    //CTRL + ALT 7
    void PrintText()
    {
        Debug.Log(meincraft);
        Debug.Log(jumpForceWhileNotGrounded + george);
        Calculate();

        //Debug.LogError(
        //    Mathf.Sqrt(54839885) +
        //    Mathf.Sqrt(54839885));

    }

    void Calculate()
    {
        Debug.Log(5 + 5);
        Debug.Log(13 / 7f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

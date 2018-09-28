using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{

    // public = syns i unity
    // int = heltal
    // hejdå = namnet.
    public int hejdå;

    // float = decimaltal med 7 precision.
    public float george;

    // double = decimaltal med 15 precision.
    public double bush;

    // string = text
    public string minecraft;

    /* Multi-line comment
     * Låååååå
     * ååååång
     * kommentar!
     */
    // bool = något som är true/false (ja/nej)
    public bool john;

    //char = ett tecken.
    public char dennis;


    // Use this for initialization
    void Start()
    {
        //PrintText();
        //Calculate();
        Debug.Log("Hej då" + john + " " + minecraft);
        
    }

    // ALT-GR + 7
    void PrintText()
    {
        Debug.Log(minecraft);
        Debug.Log(hejdå + george);
        Calculate();
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

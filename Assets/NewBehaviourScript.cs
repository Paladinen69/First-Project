using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float Tal;
    public float Bas;
    public float Vinkel;
    public float Delar;
    public string namn;
    public float radius;
    public int minDamage;
    public int maxDamage;
    public int life;
    public int demons;
    public float count = 2;
    public float countMulti = 5;
    public float playerMaxLife;
    public float playerResist;
    public float enemyDamage;
    public bool ifBool;
  
    
   
    
	// Use this for initialization
	void Start () {
        
        if (ifBool == true)
        {
            print("ja");     }




       //Debug.Log(playerMaxLife - (enemyDamage * playerResist) + " Life left");
        //Debug.Log(playerMaxLife + (enemyDamage * playerResist) + " Life kvar");
    }
	

    void Calculate()
    {
       Debug.Log("Uppgift 1: ");
        Debug.Log((963f * 421f) - (175463f / 87f));
        Debug.Log("Uppgift 2: ");
        Debug.Log(sentence1);
        Debug.Log(sentence2);
        Debug.Log(sentence3);
        Debug.Log("Uppgift 3: ");
        Debug.Log(Mathf.Pow(Tal, 2));
        Debug.Log(Mathf.Sqrt(Tal));
        Debug.Log("Uppgift 4: ");
        Debug.Log(((Bas * 2) / 2) + " m^2");
        Debug.Log("Uppgift 5: ");
        Debug.Log(360 / Vinkel + " tårtbitar");
        Debug.Log(360 / Delar + " grader");
        Debug.Log("Uppgift 6: ");
        Debug.Log("Boss " + namn + " of doom");
        Debug.Log("Uppgift 7: ");
        Debug.Log(2978 * 4 * Mathf.PI * radius * radius * radius / 3 + " m^3");
        Debug.Log("Uppgift 8: ");
        Debug.Log(life * demons / minDamage + " mest antal attacker");
        Debug.Log(life * demons / maxDamage + " minst antal attacker");
        Debug.Log((life * demons / minDamage + life * demons / maxDamage) / 2 + " antal attacker i snitt");
        Debug.Log("Uppgift 9: Finns i koden ");
        Debug.Log("Uppgift 10: Finns i koden");
        Debug.Log("Uppgift 11: ");
    }

    // Update is called once per frame
    void Update () {
        //count = count * 2;
        // Debug.Log(count);

        // countMulti = countMulti * 3 / 2;
        //  Debug.Log(countMulti);

        
        //Debug.Log(playerMaxLife  + " Life kvar");
    }
}

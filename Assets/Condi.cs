using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condi : MonoBehaviour
{
    int Highscore;
    int streak;
    public float userValue;
    int Dice1;
    int Dice2;
    public int Score;
    public int Startscore = 10;
    //public bool ifBool;
    // public int value;

    int Dragon1HP;
    int Dragon2HP;
    int PlayerHP;
    int Dragon1HitChance;
    int Dragon2HitChance;
    int Dragon1DMG;
    int Dragon2DMG;
    public int CurrentPlayerHP;
    int PlayerDMG;
    int BadChance;
    int MinDMG;
    int MaxDMG;
    int PlayerCritChance;
    public int Value;
    public int GameValue;



    int Dragons;

    public bool RandomPlayerDMG;

    public bool GameIsPlaying;


    // Use this for initialization
    void Start()
    {

        print("Guess if the value is lower or higher than 50");
        print("Press Y to guess higher, press H to guess lower.");


        //if (ifBool == true)
        //{
        //Score = Startscore;
        //    print("ja");
        //}
        //else
        //{
        //    print("nej");
        //}

        
        




        //Dragon1HP = Random.Range(100, 151);
        //PlayerHP = 100;
        //BadChance = Random.Range(1, 11);
        //if (BadChance == 1)
        //{

        //    print("Ayy lmao there's 2 dragons now nub ");
        //    Dragons = 2;
        //    Dragon2HP = Random.Range(100, 151);

        //}
        //print("The dragon has " + Dragon1HP + " hp");
        //if (Dragons == 2)
        //{
        //    print(" The second dragon has " + Dragon2HP + " hp");
        //}




    }

    // Update is called once per frame
    void Update() {



        if (GameIsPlaying == false)
        {
            GameValue = 50;
            GameIsPlaying = true;
            streak = 0;
            print("Last streak was " + streak);
            print("Your highest streak is " + Highscore);
        }
        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.H))
        {
            Value = Random.Range(0, 101);
        }
        if (Input.GetKeyDown(KeyCode.Y) && GameValue <= Value)
        {
            print("You guessed right");
            streak = streak + 1;
            GameValue = Value;
            print("Your streak is " + streak);
            print("The Value was " + Value);
        }
       else if (Input.GetKeyDown(KeyCode.Y) && GameValue >= Value)
        {
           print("You guess wrong noob");
           print("Your streak was " + streak);
            print("The Value was " + Value);
            GameIsPlaying = false;
        }
        if (Input.GetKeyDown(KeyCode.H) && GameValue >= Value)
        {
            print("You guessed right");
            streak = streak + 1;
            GameValue = Value;
            print("Your streak is " + streak);
            print("The Value was " + Value);
        }
        else if (Input.GetKeyDown(KeyCode.H) && GameValue <= Value)
        {
            print("You guess wrong noob");
            print("Your streak was " + streak);
            print("The Value was " + Value);
            GameIsPlaying = false;
        }
        if (streak > Highscore) 
        {
            Highscore = streak;
        }





        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och (shift 6)
        // || eller (altgr <)

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    userValue = (userValue + 2);
        //    print(userValue);
        //}

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    userValue = (userValue / 2);
        //    print(userValue);
        //}

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{

        //    print(userValue);
        //}

        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Dice1 = Random.Range(1, 6);
        //    Dice2 = Random.Range(1, 6);
        //    Score = Score + (Dice1 - Dice2);
        //    if(Score >= 20)
        //    {
        //        print("you win");
        //    }
        //    if(Score <= 0)
        //    {
        //        print("you lose");

        //    }
        //    else
        //    {
        //        print(Score);
        //    }
        //}


        ///if (value != 5)
        //{

        //    print("vet inte");
        //}
        //else if (value == 4)
        //{
        //    print("kanske");
        //}
        //else if (value == 3)
        //{
        //    print("oklart");
        //}


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (Dragons == 2)
        //    {
        //        print("The first dragon attacks");
        //        Dragon1HitChance = Random.Range(1, 3);
        //        if (Dragon1HitChance == 1)
        //        {
        //            print(" The first Dragon misses");
        //        }
        //        if (Dragon1HitChance == 2)
        //        {
        //            Dragon1DMG = Random.Range(10, 21);
        //            print("The Dragon hits for " + Dragon1DMG + "damage");
        //            PlayerHP = PlayerHP - Dragon1DMG;
        //            print("You have " + PlayerHP + " HP left");
        //        }
        //        print("The second dragon attacks");
        //        Dragon2HitChance = Random.Range(1, 3);
        //        if (Dragon2HitChance == 1)
        //        {
        //            print(" The first Dragon misses");
        //        }
        //        if (Dragon2HitChance == 2)
        //        {
        //            Dragon2DMG = Random.Range(10, 21);
        //            print("The Dragon hits for " + Dragon2DMG + "damage");
        //            PlayerHP = PlayerHP - Dragon2DMG;
        //            print("You have " + PlayerHP + " HP left");
        //        }
        //    }

        //    print("You attack");
        //    if (RandomPlayerDMG == false)
        //    {
        //        MinDMG = 5;
        //        MaxDMG = 25;
        //        PlayerDMG = Random.Range(MinDMG, MaxDMG);
        //    }


        //    if (Dragon1HP >= 0)
        //    {
        //        print("You hit the first dragon for " + PlayerDMG + " hp");
        //        Dragon1HP = (Dragon1HP - PlayerDMG);
        //        print("The dragon has " + Dragon1HP + " hp left");
        //        if (PlayerCritChance == 1)
        //        {
        //            Dragon1HP = 0;
        //            print("You did a critical strike");
        //        }
        //    }
        //    if (Dragon1HP <= 0)
        //    {
        //        print("You hit the second dragon for " + PlayerDMG + " hp");
        //        Dragon2HP = (Dragon2HP - PlayerDMG);
        //        print("The dragon has " + Dragon2HP + " hp left");
        //        if (PlayerCritChance == 1)
        //        {
        //            Dragon2HP = 0;
        //            print("You did a critical strike");
        //        }
        //        if (Dragons > 1)
        //        {
        //            print("The dragon attacks");
        //            Dragon1HitChance = Random.Range(1, 3);
        //            if (Dragon1HitChance == 1)
        //            {
        //                print("The dragon missed");
        //            }
        //            if (Dragon1HitChance == 2)
        //            {
        //                print("The dragon hit you for " + Dragon1DMG + " damage");
        //                PlayerHP = PlayerHP - Dragon1DMG;
        //                print("You have " + PlayerHP + " hp left");
        //            }
        //        }
        //        if (PlayerHP <= 0)
        //        {
        //            print("You got slayed");
        //        }
        //    }
    }
} 
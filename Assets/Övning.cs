using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Övning : MonoBehaviour
{
    public float userValue;
    public int dieOne;
    public int dieTwo;
    public int score;
    public int startScore = 10;
    public int dragon1Hp;
    public int dragon2Hp;
    public int playerHp;
    public int hitChance1;
    public int hitChance2;
    public int dragon1Dmg;
    public int dragon2Dmg;
    public int playerDmg;
    public int playerCritChance;
    public int badEncounterChance;
    public bool randomPlayerDmg;
    public int minDmg;
    public int maxDmg;
    int dragons;
    public int gameValue;
    public int streak;
    public int highscore;
    public int guessValue;
    public bool gameIsPlaying;
    // Use this for initialization
    void Start()
    {

        print("The value manipulation game is using the buttons");
        print("UpArrow/LeftArrow/RightArrow");
        print("The dice game is using the button");
        print("R");
        print("The dragon game is using the button");
        print("Space");

        score = startScore;
        dragon1Hp = Random.Range(100, 151);
        playerHp = 100;
        badEncounterChance = Random.Range(1, 11);
        if (badEncounterChance == 1)
        {
            dragons = 2;
            print("OH SHIT THERE IS TWO OF THEM");
            dragon2Hp = Random.Range(100, 151);
        }
        print("The Dragon Has " + dragon1Hp + " hp");
        if (dragons == 2)
        {
            print("The second dragon has " + dragon2Hp + " Hp");
        }
        Debug.ClearDeveloperConsole();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsPlaying == false)
        {
            gameValue = 50;
            gameIsPlaying = true;
            print("Last games streak was " + streak);
            streak = 0;
            print("Your Highscore is " + highscore);
        }

        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.H))
        {
            guessValue = Random.Range(0, 101);
        }
        if (Input.GetKeyDown(KeyCode.Y) && gameValue <= guessValue)
        {
            print("You guessed right");
            streak = streak + 1;
            gameValue = guessValue;
            print("Your streak is " + streak);
            print("Your current value is " + gameValue);
            print("guess again");
        }
        else if (Input.GetKeyDown(KeyCode.Y) && gameValue >= guessValue)
        {
            print("You guessed wrong... try again");
            print("Your current value of " + gameValue + " is higher than " + guessValue);
            gameIsPlaying = false;
        }
        if (Input.GetKeyDown(KeyCode.H) && gameValue >= guessValue)
        {
            print("You guessed right");
            streak = streak + 1;
            gameValue = guessValue;
            print("Your streak is " + streak);
            print("Your current value is " + gameValue);
            print("Guess again");
        }
         else if (Input.GetKeyDown(KeyCode.H) && gameValue <= guessValue)
        {
            print("You guessed wrong... try again");
            print("Your current value of " + gameValue + " is lower than " + guessValue);
            gameIsPlaying = false;
        }
        if (streak > highscore)
        {
            highscore = streak;
        }



        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = (userValue + 2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = (userValue / 2);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            dieOne = Random.Range(1, 7);
            dieTwo = Random.Range(1, 7);
            score = score + (dieOne - dieTwo);
            if (score >= 20)
            {
                print("You win your score is equal or higher than 20 ");
            }
            if (score <= 0)
            {
                print("You lose your score is below or equal to zero");
            }
            else
            {
                print(score);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dragons == 2)
            {
                print("The first dragon attacks");
                hitChance2 = Random.Range(1, 3);
                if (hitChance2 == 1)
                {
                    print("The first Dragon misses");
                }
                if (hitChance2 == 2)
                {
                    dragon1Dmg = Random.Range(10, 21);
                    print("The first dragon hits for " + dragon1Dmg + " damage");
                }
                playerHp = playerHp - dragon1Dmg;
                print("You have " + playerHp + "Hp left");
                print("The Second dragon attacks");
                hitChance2 = Random.Range(1, 3);
                if (hitChance2 == 1)
                {
                    print("The Second Dragon misses");
                }
                if (hitChance2 == 2)
                {
                    dragon1Dmg = Random.Range(10, 21);
                    print("The Second dragon hits for " + dragon2Dmg + " damage");
                }
                playerHp = playerHp - dragon2Dmg;
                print("You have " + playerHp + "Hp left");


                print("You attack");
                if (randomPlayerDmg == false)
                {
                    minDmg = 5;
                    maxDmg = 25;
                    playerDmg = Random.Range(minDmg, maxDmg);
                }
                if (randomPlayerDmg == true)
                {
                    minDmg = Random.Range(1, 11);
                    maxDmg = Random.Range(20, 31);
                    playerDmg = Random.Range(minDmg, maxDmg);
                }
                if (dragon1Hp > 0)
                {

                    print("You Hit the first dragon for " + playerDmg + "Damage");
                    playerCritChance = Random.Range(1, 21);
                    if (playerCritChance == 1)
                    {
                        dragon1Hp = 0;
                        print("You criticaly hit the dragon killing it");
                    }
                    dragon1Hp = dragon1Hp - playerDmg;
                    if (dragon1Hp > 0)
                    {
                        print("The first dragon has " + dragon1Hp + " Hp left");
                    }

                }
                if (dragon1Hp <= 0)
                {
                    print("You Hit the second dragon for " + playerDmg + "Damage");
                    playerCritChance = Random.Range(1, 21);
                    if (playerCritChance == 1)
                    {
                        dragon1Hp = 0;
                        print("You criticaly hit the dragon killing it");
                    }

                    dragon2Hp = dragon2Hp - playerDmg;
                    if (dragon2Hp > 0)
                    {
                        print("The dragon has " + dragon2Hp + " Hp left");
                    }
                }

                if (playerHp <= 0)
                {
                    print("you dieded");
                }
                if (dragon1Hp <= 0)
                {
                    print("You have slayed the first dragon");
                }
                if (dragon2Hp <= 0)
                {
                    print("The second dragon is dead");
                }

            }
            else
            {
                print("The Dragon attacks");
                hitChance1 = Random.Range(1, 3);
                if (hitChance1 == 1)
                {
                    print("The Dragon misses");
                }
                if (hitChance1 == 2)
                {
                    dragon1Dmg = Random.Range(10, 21);
                    print("The Dragon hits for " + dragon1Dmg + " damage");
                    playerHp = playerHp - dragon1Dmg;
                    print("You have" + playerHp + " Hp Left");
                }
                print("You attack");
                if (randomPlayerDmg == false)
                {
                    minDmg = 5;
                    maxDmg = 25;
                    playerDmg = Random.Range(minDmg, maxDmg);
                }
                if (randomPlayerDmg == true)
                {
                    minDmg = Random.Range(1, 11);
                    maxDmg = Random.Range(20, 31);
                    playerDmg = Random.Range(minDmg, maxDmg);
                }
                print("You Hit for " + playerDmg + "Damage");
                dragon1Hp = dragon1Hp - playerDmg;
                playerCritChance = Random.Range(1, 21);
                if (playerCritChance == 1)
                {
                    dragon1Hp = 0;
                    print("You criticaly hit the dragon killing it");
                }
                dragon1Hp = dragon1Hp - playerDmg;
                if (dragon1Hp > 0)
                {
                    print("The dragon has " + dragon1Hp + " Hp left");
                }
                if (playerHp <= 0)
                {
                    print("you dieded");
                }
                if (dragon1Hp <= 0)
                {
                    print("You have slayed the dragon");
                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForstaUppgift : MonoBehaviour
{
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float tal;
    public float bas;
    public float vinkel;
    public float delar;
    public string namn;
    public float radie;
    public int damage;
    public int minDmg;
    public int maxDmg;
    public int demonHp = 890000 ;
    public int demoner;
    public int count;
    public float countMulti;
    public int playerMaxLife;
    public float playerResist;
    public int enemyDamage;



    //Random.Range() = rng mellan nummer
    // Use this for initialization
    void Start()
    {
        uppgift1();
        uppgift2();
        uppgift3();
        uppgift4();
        uppgift5();
        uppgift6();
        uppgift7();
        uppgift8();
        uppgift10();
        uppgift11();
        Debug.Log("Detta är uppgift 9");
    }

    void uppgift1()
    {
        Debug.Log("Detta är uppgift 1");
        Debug.Log((963f * 421f) - (175463f / 87f));
    }

    void uppgift2()
    {
        Debug.Log("Detta är uppgift 2");
        Debug.Log(sentence1);
        Debug.Log(sentence2);
        Debug.Log(sentence3);
    }

    void uppgift3()
    {
        Debug.Log("Detta är uppgift 3");
        Debug.Log(Mathf.Pow(tal, 2));
        Debug.Log(Mathf.Sqrt(tal));
    }

    void uppgift4()
    {
        Debug.Log("Detta är uppgift 4");
        Debug.Log(((bas * 8) / 2) + " m^2");
    }

    void uppgift5()
    {
        Debug.Log("Detta är uppgift 5");
        Debug.Log((360 / vinkel) + " tårtbitar");
        Debug.Log((360 / delar) + " grader");
    }

    void uppgift6()
    {
        Debug.Log("Detta är uppgift 6");
        Debug.Log("Boss " + namn + " of DOOM");
    }

    void uppgift7()
    {
        Debug.Log("Detta är uppgift 7");
        Debug.Log((2978 * 4 * Mathf.PI * (Mathf.Pow(radie, 3))) / 3 + " volymenhet^3");
    }

    void uppgift8()
    {
        Debug.Log("Detta är uppgift 8");
        Debug.Log(((demonHp * demoner) / damage) + " slag");
        Debug.Log(((demonHp * demoner) / minDmg) + " slag minDmg");
        Debug.Log(((demonHp * demoner) / maxDmg) + " slag maxDmg");
        Debug.Log(((demonHp * demoner) / maxDmg) + ((demonHp * demoner) / minDmg) / 2 + " snitt slag");
        Debug.Log(demonHp * demoner / (Random.Range(minDmg, maxDmg)) + " slag randomDmg");
    }

    void uppgift9()
    {
        count = count * 2;
        Debug.Log(count);
    }

    void uppgift10()
    {
        Debug.Log("Detta är uppgift 10");
        Debug.Log((countMulti * 3) / 2);
    }

    void uppgift11()
    {
        Debug.Log("Detta är uppgift 11");
        Debug.Log(playerMaxLife - (enemyDamage * playerResist)+" Current Player Life");
    }

    // Update is called once per frame
    void Update()
    {
        uppgift9();
    }
}

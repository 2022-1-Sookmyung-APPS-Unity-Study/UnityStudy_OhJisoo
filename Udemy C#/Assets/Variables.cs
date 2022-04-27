using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public string name = "Liam";
    public string weapon = "Wdoden Sword";
    public int health = 10;
    public float speed = 5.5f;
    public int enemyDamage = 2;

    void Start()
    {
        print("Welcome " + name);
        print("the enemy found you and you " +
            "were too slow to run away from him " +
            "becase your speed is only " + speed.ToString());
        //.Tostring() : string으로 변환

        health -= enemyDamage;

        print("The enemy delt you " + enemyDamage.ToString() +
            "damage so you have got " + health.ToString() + "health left.");
        print("After much struggle, you were finally able to kill " +
            "the enemy with you" + weapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{

    int randomNumber;
    [Range(0,100)]
    public int guess;
    int numberOfAttempts;

    void Start()
    {
        randomNumber = Random.Range(0, 101); //0���� 100���� ��������
        print("Welcome Guessing Game");
        print("���� ���ڸ� ����ٶ�");
        print("�߸��� ���ڸ� �Է��ϰ� �����̽���ư�� ������ good luck!");


    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            numberOfAttempts += 1;

            if(guess == randomNumber)
            {
                print("You Won. ������ Ƚ�� : " + numberOfAttempts.ToString());
            } else if(Mathf.Abs(randomNumber - guess) <= 10)
            {
                //Mathf.Abs >> ���밪���� �������
                print("Boiling.");
            } else if (Mathf.Abs(randomNumber - guess) <= 20)
            {
                print("Very Hot.");
            } else if (Mathf.Abs(randomNumber - guess) <= 30)
            {
                print("Hot.");
            } else if (Mathf.Abs(randomNumber - guess) <= 40)
            {
                print("Quite Hot.");
            } else if (Mathf.Abs(randomNumber - guess) <= 50)
            {
                print("Neutral.");
            } else if (Mathf.Abs(randomNumber - guess) <= 60)
            {
                print("Quite cold.");
            } else if (Mathf.Abs(randomNumber - guess) <= 70)
            {
                print("cold.");
            } else if (Mathf.Abs(randomNumber - guess) <= 80)
            {
                print("Very cold.");
            } else if (Mathf.Abs(randomNumber - guess) <= 100)
            {
                print("Freezing.");
            } 


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WelcomePlayer("Sam");
        WelcomePlayer("Charlie");

        int functionResult = Add(5, 3);
        print(functionResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WelcomePlayer(string playerName)
    {
        print("Welcome" + playerName);
        print("Good Luck!");
    }

    int Add(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
}

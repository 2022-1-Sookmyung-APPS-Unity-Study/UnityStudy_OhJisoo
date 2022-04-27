using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int number1;
    public int number2;

    public string action;

    void Start()
    {
        if (action == "add")
        {
            print(number1 + number2);
        } else if (action == "subtract")
        {
            print(number1 - number2);
        } else if(action == "multiply")
        {
            print(number1 * number2);
        } else if (action == "divide")
        {
            if (number2 != 0)
            {
                print(number1 / number2);
            } else
            {
                print("You can not divide by 0");
            }
        }
        else
        {
            print("The action does not exist.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

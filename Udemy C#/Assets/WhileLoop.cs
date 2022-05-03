using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int number = 1;

    // Start is called before the first frame update
    void Start()
    {
        while (number <= 10)
        {
            print(number);
            number += 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

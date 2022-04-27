using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanLogic : MonoBehaviour
{

    void Start()
    {
        bool complexStatement = 5 < 10 && 5 != 5;
        print(complexStatement);

        bool complexStatement2 = 5 < 10 || 5 != 5;
        print(complexStatement2);
    }

    void Update()
    {
        
    }
}

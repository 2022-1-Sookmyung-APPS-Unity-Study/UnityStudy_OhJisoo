using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    int[] randomNumbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = Random.Range(0, 100);
            print(randomNumbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

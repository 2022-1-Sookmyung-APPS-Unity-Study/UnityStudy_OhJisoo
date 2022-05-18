using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints; // spawnPoint의 위치에 접근하기위해 Transform 사용함.
    public GameObject[] hazards;    // 세 종류의 적을 배열에 저장함.

    private float timeBtwSpawns;
    public float startTimeBtSpawns;

    public float minTimeBetweenSpawns;
    public float decrease;

    public GameObject player;

    // 코드를 계속 호출하기 위해서 Update 를 사용해줌.
    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (timeBtwSpawns <= 0)
            {
                // SPAWN HAZARD
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

                // Spawn random hazard at random spawn point
                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

                if (startTimeBtSpawns > minTimeBetweenSpawns)
                {
                    startTimeBtSpawns -= decrease;
                }

                timeBtwSpawns = startTimeBtSpawns; //reset the counter back to his starting value each time

            }
            else
            {
                // 시간 카운트용. 시간이 지나서 계속 timeBtnSpawns가 0 이하로 떨어지면(if문의 조건이 참이되어) HAZARD가 spawn됨.
                timeBtwSpawns -= Time.deltaTime;
            }
        }
        
    }
}

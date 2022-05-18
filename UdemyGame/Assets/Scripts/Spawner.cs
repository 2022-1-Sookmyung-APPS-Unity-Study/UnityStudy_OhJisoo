using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints; // spawnPoint�� ��ġ�� �����ϱ����� Transform �����.
    public GameObject[] hazards;    // �� ������ ���� �迭�� ������.

    private float timeBtwSpawns;
    public float startTimeBtSpawns;

    public float minTimeBetweenSpawns;
    public float decrease;

    public GameObject player;

    // �ڵ带 ��� ȣ���ϱ� ���ؼ� Update �� �������.
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
                // �ð� ī��Ʈ��. �ð��� ������ ��� timeBtnSpawns�� 0 ���Ϸ� ��������(if���� ������ ���̵Ǿ�) HAZARD�� spawn��.
                timeBtwSpawns -= Time.deltaTime;
            }
        }
        
    }
}

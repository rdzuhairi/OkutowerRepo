using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public int maxEnemies = 10;
    public int enemyCount = 0;
    public float timeBetweenSpawn = 5f;
    public float countdown = 2f;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    void Update()
    {
        //if(countdown <= 0 && enemyCount < maxEnemies){
        //    StartCoroutine(SpawnWave());
        //    if (enemyCount >= maxEnemies)
        //    {
        //        StopCoroutine(SpawnWave());
        //    }
        //    countdown = timeBetweenSpawn;
        //}
        //countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave(){
        Debug.Log("Spawning");

        while(enemyCount < maxEnemies)
        {
            SpawnEnemy1();
            yield return new WaitForSeconds(5f);
            SpawnEnemy2();
            yield return new WaitForSeconds(3f);
            SpawnEnemy1();
            yield return new WaitForSeconds(2f);
            SpawnEnemy1();
            SpawnEnemy2();
            yield return new WaitForSeconds(1.5f);

        }


    }

    void SpawnEnemy1(){

        Vector3 spawnPos = spawnPoint1.position;
        spawnPos.z = spawnPos.z - Random.value * 10;
        Debug.Log("Spawning at " + spawnPos);
        Instantiate(enemyPrefab, spawnPos, spawnPoint1.rotation);
        enemyCount++;
    }

    void SpawnEnemy2()
    {

        Vector3 spawnPos = spawnPoint2.position;
        spawnPos.z = spawnPos.z - Random.value * 10;
        Debug.Log("Spawning at " + spawnPos);
        Instantiate(enemyPrefab, spawnPos, spawnPoint2.rotation);
        enemyCount++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnArea;
    public GameObject coinPrefab;
    public GameObject heartPrefab;
    
    // to keep track of how many
    ArrayList coins;
    ArrayList hearts;

    int spawnInterval = 5;
    float timeLeft;
    string toSpawnNext = "coins";

    void Start()
    {
        timeLeft = spawnInterval;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0){
            SpawnNew(5, toSpawnNext);
            timeLeft = spawnInterval;
        }
    }

    void SpawnNew(int amt, string toSpawn){
        if (toSpawn == "coins"){
            for (int i = 0; i < amt; i++){
                GameObject.Instantiate(coinPrefab, Randomizer(), transform.rotation);
            }
            toSpawnNext = "hearts";
        }
        if (toSpawn == "hearts"){
            for (int i = 0; i < amt; i++){
                GameObject.Instantiate(heartPrefab, Randomizer(), transform.rotation);
            }
            toSpawnNext = "coins";            
        }
    }

    Vector3 Randomizer(){
        float rndX = Random.Range(spawnArea.transform.position.x - 5, spawnArea.transform.position.x +5);
        float rndY = Random.Range(spawnArea.transform.position.y - 5, spawnArea.transform.position.y +5);
        return new Vector3(rndX, rndY, 0);
    }

}

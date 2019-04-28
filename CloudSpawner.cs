using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    // Screen size:
    private Vector2 myScreen;
    public int startAmount = 10;
    private int maxAmount = 10;
    public List<GameObject> cloudPrefab;
    // Start is called before the first frame update

    private int spawnInterval = 5;
    private float timeLeft;

    public Statistics stats;

    void Start()
    {   
        timeLeft = spawnInterval;
        myScreen = new Vector3(Screen.width/100, Screen.height/100, 0);
        
        SpawnNew(startAmount, true);
        
    }

    // Update is called once per frame
    void Update()
    {
        // Every 10 seconds
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SpawnNew(20, false);
            timeLeft = spawnInterval;
        }
    }

    void SpawnNew(int amt, bool start){
        for (int i = 0; i < amt; i++){
            int updAmt = stats.CloudAmount();
            if(updAmt < maxAmount){
                stats.IncCloud(1);
                GameObject.Instantiate(cloudPrefab[Random.Range(0, cloudPrefab.Count)], Randomizer(myScreen, start), transform.rotation);
            }
        }
    }
    Vector3 Randomizer(Vector3 limits, bool start){
        float rndX = Random.Range(1-limits.x, limits.x);
        float rndY;
        if (!start){
            //Debug.Log("Shold spawn low!");
            rndY = Random.Range(1-limits.y*2, -10 - limits.y);
        }else {
            rndY = Random.Range(1-limits.y,limits.y);
        }
        return new Vector3(rndX, rndY, 0);
    }
}

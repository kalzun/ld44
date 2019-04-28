using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : FlyingThings
{
    // Random scale
    private float maxScale = 1;
    private float minScale = 0.3f;

    private float rndSpeed;
    private float minSpeed = 0.8f;
    private float maxSpeed = 6f;
    
    public Transform cloudTransform;
    

    void Start()
    {
        cloudTransform = GetComponent<Transform>();        
        Randomizer();
        

    }


    // Update is called once per frame
    void Update()
    {
        base.FloatUpwards(cloudTransform, rndSpeed);  
    }

    void Randomizer(){
        rndSpeed = Random.Range(minSpeed, maxSpeed);
        float rndScale = Random.Range(minScale, maxScale);
        cloudTransform.localScale = new Vector2 (rndScale, rndScale);
        // rndSpeed = Random.Range(minSpeed, maxSpeed);
    }
}

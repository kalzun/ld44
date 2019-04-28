using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingThings: MonoBehaviour
{
    
    Transform flyingThingTransform;

    public void FloatUpwards(Transform aTransform, float rndSpeed){
        aTransform.position = new Vector2(aTransform.position.x, aTransform.position.y + rndSpeed * Time.deltaTime);
    }

    public float Randomizer(float minSpeed, float maxSpeed){
        return Random.Range(minSpeed, maxSpeed);
    }

    
}

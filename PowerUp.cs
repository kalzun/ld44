using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : FlyingThings
{
    int giveAmtCoins = 1;
    float minSpeed = 3;
    float maxSpeed = 10;
    float rndSpeed;
    void Start()
    {
        rndSpeed = base.Randomizer(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        base.FloatUpwards(transform, rndSpeed);
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            col.gameObject.GetComponentInParent<Player>().GainCoins(giveAmtCoins);
        }
        Destroy(this.gameObject);
    }
}

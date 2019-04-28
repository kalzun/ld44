using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : FlyingThings
{   
    private float maxScale = 1.5f;
    private float minScale = 0.3f;

    private float rndSpeed;
    private float minSpeed = 3f;
    private float maxSpeed = 10f;

    private int stealAmtCoins = 5;
    public ParticleSystem ps;

    

    // Start is called before the first frame update
    void Start()
    {
        Randomizer();
        
    }

    // Update is called once per frame
    void Update()
    {
        base.FloatUpwards(transform, rndSpeed);  
    }
        
    void Randomizer(){
        rndSpeed = Random.Range(minSpeed, maxSpeed);
        float rndScale = Random.Range(minScale, maxScale);
        transform.localScale = new Vector2 (rndScale, rndScale);
        // rndSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Heart hit " + col.name);
        if (col.gameObject.tag == "Player"){
            col.gameObject.GetComponentInParent<Player>().LooseCoins(stealAmtCoins);
            ParticleSystem explosion = Instantiate(ps, col.gameObject.transform.position, transform.rotation);
            explosion.Play();
            Destroy(this.gameObject);
        }

    }
}

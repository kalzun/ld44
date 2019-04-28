using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    int cloudAmount = 0;

    void Update(){
        //Debug.Log("CloudAmount: " + cloudAmount);
    }

    public int CloudAmount(){
        return cloudAmount;
    }

    public void IncCloud(int amt){
        cloudAmount += amt;
    }
    
    public void DecCloud(int amt){
        cloudAmount -= amt;
    }
}

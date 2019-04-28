using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> visualCurrency;
    private int movementSpeed = 13;
    public int coinAmount = 20;
    public AudioSource auPlayer;
    public List<AudioClip> aClips;

    public GameObject mObj;
    MenuManager mMan;

    private Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        mMan = mObj.GetComponent<MenuManager>();
      //  mMan = GameObject.Find("MenuManager").GetComponent<MenuManager>();
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            playerPos.position = new Vector3 (transform.position.x - movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            playerPos.position = new Vector3 (transform.position.x + movementSpeed * Time.deltaTime, 0, 0);
        }
    }

    public void LooseCoins(int amount){
        coinAmount -= amount;
        UpdateCoinVisual();
        auPlayer.PlayOneShot(aClips[0]);
        
        if (coinAmount < 0){
            YouAreDead();
        }

    }

    public void GainCoins(int amount){
        coinAmount += amount;
        UpdateCoinVisual();
        auPlayer.PlayOneShot(aClips[1]);
    }

    void YouAreDead(){
        mMan.Dead();
    }

    void UpdateCoinVisual(){
        if (coinAmount < 20){
            foreach (Transform child in visualCurrency){
                if (child.name == "_10"){
                    child.gameObject.SetActive(true);
                } else {
                    child.gameObject.SetActive(false);
                }
            }
            
        }
        if (coinAmount >= 20 && coinAmount < 50){
            foreach (Transform child in visualCurrency){
                if (child.name == "_20"){
                    child.gameObject.SetActive(true);
                } else {
                    child.gameObject.SetActive(false);
                }
            }
            
        }

    }

    Transform getChild(Transform go, string name){
        foreach (Transform child in go){
            if (child.name == name){
                return child;
            }
        }
        return null;
    }


}

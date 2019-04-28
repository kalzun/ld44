using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScreen : MonoBehaviour
{

    string lvl1 = "lvl1";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadGame(){
        SceneManager.LoadScene(lvl1);
    }

    public void QuitGame() {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

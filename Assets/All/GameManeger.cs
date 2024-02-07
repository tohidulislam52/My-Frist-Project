using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    
    bool gameend = false;
    public float gamedilay = 2f;
    public GameObject levelcomUi;


    public void levelcom()
    {
        levelcomUi.SetActive(true);
    }
    public void EndGame()
    {
        if (gameend == false)
        {
            gameend = true;
            //Debug.Log("End Game");
            //Reaster();
            Invoke("Reaster", gamedilay);
            
        }
        
    }
    void Reaster()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void Update()
    {
        
    }
}

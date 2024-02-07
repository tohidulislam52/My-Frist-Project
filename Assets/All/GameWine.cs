using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManeger GameManeger;
    
    private void OnTriggerEnter(Collider other)
    {
        GameManeger.levelcom();
      
            
        
    }

}

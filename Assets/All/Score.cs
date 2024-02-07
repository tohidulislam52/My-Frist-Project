using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform player;
    public Text score;
    float f = 50.5f;
    // Update is called once per frame
    void Update()
    {
        //double pos = player.position.z+ 91.7 ;
        //score.text = pos.ToString();
        score.text = player.position.z.ToString("0");

    }
}

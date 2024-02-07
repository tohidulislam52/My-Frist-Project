using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rd;
    public float force = 1000f;
    public float xx = 400f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello game");
    }

    // Update is called once per frame
    void Update()
    {
        // add a player force
        rd.AddForce(0, 0, force * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rd.AddForce(xx * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rd.AddForce(-xx * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rd.position.y < -1f)
        {
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove : MonoBehaviour
{
    public PlayerMove movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "object")
        {
            movement.enabled = false;
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}

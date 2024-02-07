using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoloPlayer : MonoBehaviour
{
    public Transform player;
    public Transform cmara;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cmara.position  = player.position + position;
    }
}

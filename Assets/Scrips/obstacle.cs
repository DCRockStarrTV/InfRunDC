using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    PlayerMove playmove;
    void Start()
    {
        playmove = GameObject.FindObjectOfType<PlayerMove>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            playmove.Die();
        }
    }
    void Update()
    {
        
    }
}

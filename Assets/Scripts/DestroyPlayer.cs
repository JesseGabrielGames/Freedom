using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

    public GameObject Door;
    public GameObject Key;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        { 
            Destroy(Door);
            Destroy(Key);
    }
    } }

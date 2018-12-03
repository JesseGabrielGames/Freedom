using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Transform teleTarget;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.position = teleTarget.position;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleMove : MonoBehaviour {

    private bool dirRight = true;
    public float speed = 2.0f;

    // Update is called once per frame
    void Update () {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 3.4f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 0.1f)
        {
            dirRight = true;
        }
    }
}

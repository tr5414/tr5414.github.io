﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour {
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}
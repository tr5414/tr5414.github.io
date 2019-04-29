﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToandFro3 : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(4, 0, -3);
    private Vector3 pos2 = new Vector3(4, -2, -3);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
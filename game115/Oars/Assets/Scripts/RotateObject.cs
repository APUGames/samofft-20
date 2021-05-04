﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0), rotationSpeed * Time.deltaTime);
    }
}

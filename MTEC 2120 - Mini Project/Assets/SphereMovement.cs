﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(10 * Mathf.Sin(Time.time), 10 * Mathf.Cos(Time.time), 0);

        transform.localScale += new Vector3(0.1f, 0, 0.1f);
    }
}

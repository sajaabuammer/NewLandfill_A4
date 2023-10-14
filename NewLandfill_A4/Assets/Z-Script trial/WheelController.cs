﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 30;
        }

        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.16f;
    }
}

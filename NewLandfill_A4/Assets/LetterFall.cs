﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFall : MonoBehaviour
{
    //public GameObject LetterA;
   // public GameObject LetterS;
    public GameObject instructions1;
    /// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(instructions1, 5.5f);


            //LetterS.GetComponent<Rigidbody>().AddForce(transform.forward * 400f);
            //LetterA.GetComponent<Rigidbody>().AddForce(transform.forward * 400f);
            //instructions1.SetActive(false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNO : MonoBehaviour 

{
    public GameObject step2;
    // Start is called before the first frame update
    void Start()
    {
        step2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        step2.SetActive(false);

    }
}

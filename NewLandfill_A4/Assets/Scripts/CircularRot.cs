using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 
public class CircularRot : MonoBehaviour
{
public GameObject lastWheel;
public GameObject polyester; // Reference to the "Polyester" object. 
public Vector3 axis = Vector3.up;
public float rotSpeed = 5.0f;
void Update()
 {
    // Check for the 'C' key press to initiate rotation. 
    if (Input.GetKeyDown(KeyCode.C))
    {
        // Calculate the angle of rotation based on the rotation speed. 
        float angle = rotSpeed * Time.deltaTime;
        // Gets the position of 'LastWheel' and rotates the "Polyester" object around it by the 'axis' at speed 'angle' in degrees per update.
        polyester.transform.RotateAround(lastWheel.transform.position, axis, angle);
    }
} }

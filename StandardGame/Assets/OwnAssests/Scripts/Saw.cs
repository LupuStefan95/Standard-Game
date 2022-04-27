using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
   
    [SerializeField] float yAngle = 2;
   
    private void FixedUpdate()
    {
        transform.Rotate(0, yAngle, 0);
    }

}

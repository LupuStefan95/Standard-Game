using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeEvent : MonoBehaviour
{
    Rigidbody rb;
    delegate void MyDelegate();
    MyDelegate md;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            md += BumpUp;
            md += ChangeColor;
            md?.Invoke(); // instead of checking null with if statement.
        }
    }

    void BumpUp()
    {
        if(rb.transform.position.y< 3f)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }   
        
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}

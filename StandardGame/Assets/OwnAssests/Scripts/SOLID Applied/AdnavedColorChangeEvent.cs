using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdnavedColorChangeEvent : ColorChangeEvent
{
    Rigidbody rb;
    delegate void MyDelegate();
    MyDelegate md;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        md += BumpUp;
        md += ChangeColor;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            md?.Invoke(); // instead of checking null with if statement.
        }
    }

    public override void BumpUp()
    {
        if (rb.transform.position.y < 3f)
        {
            rb.AddForce(Vector3.down * 0, ForceMode.Impulse);
        }
    }

    public override void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        
    }
}

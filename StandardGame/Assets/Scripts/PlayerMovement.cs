using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    float jumpSpeed = 10f;
    float stopJumpSpeed = 30f;
    private Rigidbody rb;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        bool jump = Input.GetKeyDown(KeyCode.Space);
        bool counterJump = Input.GetKeyDown(KeyCode.LeftControl);

        transform.Translate(new Vector3(xAxis, 0, zAxis) * moveSpeed * Time.deltaTime);

        if (jump && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }

        if (counterJump)
        {
            rb.AddForce(Vector3.down * stopJumpSpeed, ForceMode.Impulse);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}

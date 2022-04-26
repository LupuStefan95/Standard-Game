using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float topSpeed = 7f;
    [SerializeField]
    float moveSpeed = 20f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float stopJumpSpeed = 30f;
    [SerializeField]
    private bool isGrounded = true;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        bool jump = Input.GetKeyDown(KeyCode.Space);
        bool counterJump = Input.GetKeyDown(KeyCode.LeftControl);
        
        if (rb.velocity.magnitude < topSpeed)
        {
            rb.AddForce(moveSpeed * Time.deltaTime * new Vector3(xAxis, 0, zAxis), ForceMode.Impulse);
        }

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

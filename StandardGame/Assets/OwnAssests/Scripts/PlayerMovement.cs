using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{   [SerializeField]
    public float topSpeed = 7f;
    [SerializeField]
    public float moveSpeed = 20f;
    [SerializeField]
    public float jumpSpeed = 10f;
    [SerializeField]
    public float stopJumpSpeed = 30f;
    [SerializeField]
    public bool isGrounded = true;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
        if(transform.position.y < 0 ){
            SceneManager.LoadScene(0);
        }
    }

    void MovePlayer()
    {
        bool exitMenu = Input.GetKeyDown(KeyCode.Escape);
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        bool jump = Input.GetKeyDown(KeyCode.Space);
        bool counterJump = Input.GetKeyDown(KeyCode.LeftControl);

        if (exitMenu)
        {
            SceneManager.LoadScene(0);
        }

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
        
        if (collision.gameObject.CompareTag("PlayerKiller"))
        {
            SceneManager.LoadScene(0);

        }

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

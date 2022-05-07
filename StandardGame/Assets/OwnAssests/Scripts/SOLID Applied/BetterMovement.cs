using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetterMovement : MonoBehaviour, ISimpleJump, ICounterJump
{
    
    public PlayerSettings playerSettings;
    private IMovementInputGetter movementInputGetter;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        movementInputGetter = GetComponent<IMovementInputGetter>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
        if (transform.position.y < 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void MovePlayer()
    {
        bool exitMenu = Input.GetKeyDown(KeyCode.Escape);
        float xAxis = movementInputGetter.Horizontal;
        float zAxis = movementInputGetter.Vertical;
        bool jump = movementInputGetter.Jump;
        bool counterJump = movementInputGetter.CounterJump;

        if (exitMenu)
        {
            SceneManager.LoadScene(0);
        }

        if (rb.velocity.magnitude < playerSettings.topSpeed)
        {
            rb.AddForce(playerSettings.moveSpeed * Time.deltaTime * new Vector3(xAxis, 0, zAxis), ForceMode.Impulse);
        }

        if (jump && playerSettings.isGrounded)
        {
            SimpleJump();
        }

        if (counterJump)
        {
            COunterJump();
        }

    }

    public void SimpleJump()
    {
        rb.AddForce(Vector3.up * playerSettings.jumpSpeed, ForceMode.Impulse);
    }

    public void COunterJump()
    {
        rb.AddForce(Vector3.down * playerSettings.stopJumpSpeed, ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerKiller"))
        {
            SceneManager.LoadScene(0);

        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            playerSettings.isGrounded = true;
        }
    }


    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            playerSettings.isGrounded = false;
        }
    }
}



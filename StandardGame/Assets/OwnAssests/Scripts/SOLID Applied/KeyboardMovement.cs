using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour, IMovementInputGetter
{
    public float Horizontal { get; private set; }

    public float Vertical { get; private set; }
    public bool Jump { get; private set; }
    public bool CounterJump { get; private set; }

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Jump = Input.GetKeyDown(KeyCode.Space);
        CounterJump = Input.GetKeyDown(KeyCode.LeftControl);
    }
}

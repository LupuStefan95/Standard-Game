using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Player Settings", menuName ="Player Settings")]
public class PlayerSettings : ScriptableObject { 
    
    public float topSpeed = 7f;  
    public float moveSpeed = 20f;
    public float jumpSpeed = 10f;
    public float stopJumpSpeed = 30f;
    public  bool isGrounded = true;
    public virtual void DoubleJump() { }
}

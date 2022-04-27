using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedRing : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        int rn = Random.Range(0, 4);
        animator = GetComponent<Animator>();
        Debug.Log(rn);
        switch (rn)
        {
            case 0: animator.SetBool("IsBlended", true);
                break;
            case 1: animator.SetBool("IsRotating", true);
                break;
            case 2:animator.SetBool("IsScaling", true);
                break;
            case 3:animator.SetBool("IsRotatingX", true);
                break;
                
        }
        
    }
    
}

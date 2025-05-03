using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator animator;

    public void ChangeParameter()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("open", false);
        
    }
}

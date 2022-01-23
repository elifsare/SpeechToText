using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobiAnimationController : MonoBehaviour
{
    Animator animator;
    private void Start() {
        animator = GetComponent<Animator>();
    }
    public void OpenAnim(){
       animator.SetBool("isOpen", true);        
    }

    public void CloseAnim(){
        animator.SetBool("isOpen", false);
    }
}

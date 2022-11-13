using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        //if jump input is pressed 
        if (Input.GetButton("Jump"))
        {
            //go to the animator and set the bool parameter called grow to true
            animator.SetBool("Growing", true);
        }
        else
        {
            animator.SetBool("Growing", false);
        }

        animator.SetInteger("AD", Mathf.RoundToInt(Input.GetAxis("Horizontal")));

        animator.SetInteger("WS", Mathf.RoundToInt(Input.GetAxis("Vertical")));
    }
}

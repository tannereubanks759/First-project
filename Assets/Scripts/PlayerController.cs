using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //reference to the character controller that handles the collisions and movement.
    public CharacterController controller;
    //speed of the player
    public float speed = 1f;
    
    

    void Update()
    {
        //step 1 get current position
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        //step 2 get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //step 3 set the new position based on input and speed
        //the new value of currentPos in x will be its current value, plus the speed
        //multiplied by the input (-1 or 1) and time.deltatime
        currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;
        currentPos.z = currentPos.z + speed * inputY * Time.deltaTime;

        //this will get us vector of our movement, instead of the new position.
        //motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;
        //motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;

        motion = (transform.forward.normalized * speed * inputY * Time.deltaTime) + (transform.right * speed * inputX * Time.deltaTime);

        //step 5 assign new position
        //transform.position = currentPos;

        //instead of moving normally, we can use the character controller
        controller.Move(motion);
        
    }
}

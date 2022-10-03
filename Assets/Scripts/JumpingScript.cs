using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    public Rigidbody reggieBody;
    public float jumpForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale >=1f)
        {
            reggieBody.AddForce(Vector3.up * jumpForce);
        }
    }
}

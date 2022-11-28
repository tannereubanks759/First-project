using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed;

    public float skinWidth = 0.1f;

    public LayerMask skinLayers;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x = x * speed * Time.deltaTime;
        y = y * speed * Time.deltaTime;

        if (CheckForWall(this.transform.right * x, skinWidth) == false)
        {
            x = 0;
        }
        if (CheckForWall(this.transform.up * y, skinWidth) == false)
        {
            y = 0;
        }

        this.transform.localPosition += new Vector3(x, y, 0);
    }

    bool CheckForWall(Vector3 direction, float range)
    {
        RaycastHit info;

        Debug.DrawRay(this.transform.position, direction * range * 2, Color.red, 1);


        if (Physics.Raycast(this.transform.position, direction, out info, range, skinLayers))
        {
            Debug.Log(info.transform.name);
            return false;
        }
        else
        {
            return true;
        }

    }
}

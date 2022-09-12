
//libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the main class of the script
public class CloudFoat : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello world");
        Debug.Log(this.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Frame");
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
        Debug.Log(speed * Time.deltaTime);
    }
}

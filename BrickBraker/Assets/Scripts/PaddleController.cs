using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float accel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(hor, 0, 0) * accel;

        if(this.transform.position.x > 7)
        {
            this.transform.position = new Vector3(7, 0, 5);
        }
        else if(this.transform.position.x < -7)
        {
            this.transform.position = new Vector3(-7, 0, 5);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 500f;
    Rigidbody rb;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = -rb.transform.forward * speed * Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

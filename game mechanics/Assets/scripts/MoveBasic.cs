using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float rotSpeed = 50f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
         transform.position = positionUpdate;
         transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0)); 
         //Vector3 positionUpdate2 = transform.position + Input.GetAxis("Horizontal") * transform.forward * speed * Time.deltaTime;
         //transform.position += positionUpdate2;

        //rb.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed);
        //rb.MovePosition(transform.position + new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
        //rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{

    public Rigidbody2D cart;
    public Rigidbody2D rearWheel;
    public Rigidbody2D frontWheel;

    public float acceleration;
    public float speed;
    private float forwardInput = 1;
    private float rotationSpeed = 1;
    private Vector2 cartRot;

    private Quaternion rotation = new Quaternion(0,0,0,1);  


    // Start is called before the first frame update
    void Start()
    {
        cartRot = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.z > 1 || transform.position.z  < -1 )
        {
            Debug.Log("Trying to adjust");
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

    private void FixedUpdate()
    {
        rearWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
        frontWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
    }
}

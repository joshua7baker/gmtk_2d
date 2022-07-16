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
    float forwardInput = 1;

    bool canMove;

    private float rotationSpeed = 1;
    private Quaternion rotation = new Quaternion(0,0,0,1);

    void Start()
    {

    }

    void Update()
    {
        BalanceRotation();
    }

    private void FixedUpdate()
    {
        CheckCanMove();
        if (canMove)
        {
            ApplySpeed();
        }
        else
        {
            Debug.Log("Cant move");
        }
    }


    void ApplySpeed()
    {
        rearWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
        frontWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
    }
    // Adjust rotation to balance cart back to 0,0,0
    void BalanceRotation()
    {
        if (transform.rotation.eulerAngles.z < -1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
        if (transform.rotation.eulerAngles.z > 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

    void CheckCanMove()
    {
        if (transform.rotation.eulerAngles.z !< 90 && transform.rotation.eulerAngles.z !> 90)
        {
            canMove = true;
            Debug.Log(canMove);
        }
        else
        {
            canMove = false;
            Debug.Log(canMove);
        }
    }
}

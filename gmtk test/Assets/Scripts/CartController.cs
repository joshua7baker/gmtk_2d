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
    private int repositionForce = 10;

    bool isGrounded;
    bool canMove;
    bool isRepositioning;

    private float rotationSpeed = 1;
    private Quaternion rotation = new Quaternion(0,0,0,1);

    public GameObject goblinPosLocation;

    //[SerializeField]
    //[HideInInspector]
    public List <Transform> goblinSeats = new();

    void Start()
    {
        foreach (Transform t in goblinPosLocation.transform)
        {
            goblinSeats.Add(t);
        }

    }

void Update()
    {
        CheckCanMove();

        if (!isRepositioning)
        {
            BalanceRotation();
        }

        if (!canMove)
        {
            if (!isRepositioning && isGrounded)
            {
                RepositionCart();
            }
        }

    }

    private void FixedUpdate()
    {

        if (canMove)
        {
            ApplySpeed();
        }
        else
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void ApplySpeed()
    {
        rearWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
        frontWheel.AddTorque(-forwardInput * speed * Time.deltaTime);
    }
    //Adjust rotation to balance cart back to 0,0,0
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

    //Update movement bool based on rotation
    void CheckCanMove()
    {
        if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 290 || transform.eulerAngles.z < -90 && transform.eulerAngles.z < -290)
        {
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }

    //Reposition cart by popping it up and rotating before allowing movement again
    void RepositionCart()
    {
        if (!canMove)
        {
            if (!isRepositioning)
            {
                Debug.Log("repo");
                isRepositioning = true;
                rearWheel.AddForce(Vector2.up * repositionForce, ForceMode2D.Impulse);
                frontWheel.AddForce(Vector2.up * repositionForce, ForceMode2D.Impulse);

                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 1000);

                StartCoroutine(checkCartPositioning());
            }
        }
        else
        {
            isRepositioning = false;
        }

    }

    IEnumerator checkCartPositioning()
    {
        yield return new WaitForSeconds(3);
        Debug.Log(canMove);
        Debug.Log(isRepositioning);
        isRepositioning = false;
        RepositionCart();
    }

}

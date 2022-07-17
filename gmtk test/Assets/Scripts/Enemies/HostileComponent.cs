using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileComponent : MonoBehaviour
{
    public Rigidbody2D rb;
    [HideInInspector] public bool hasDamaged;

    public float baseDamage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
            //gameControl.health -= 1;
            //Destroy(Circle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.collider.CompareTag("Cart"))
        //{
        //    ContactPoint2D contactPoint = collision.GetContact(0);
        //    LaunchObject(contactPoint);
        //}
    }
    
    public void OnCartCollision()
    {
        //Debug.Log("hit");

    }
    void LaunchObject(ContactPoint2D contactPoint)
    {
        rb.AddForce(Vector2.up);
    }
}

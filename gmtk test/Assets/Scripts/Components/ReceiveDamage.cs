using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveDamage : MonoBehaviour
{
    public CartController cartController;
    private bool hasDamaged;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Hostile")
        {
            HostileComponent collidedObj = collision.gameObject.GetComponent<HostileComponent>();

            if (!collidedObj.hasDamaged)
            {
                collidedObj.hasDamaged = true;

                //GameObject hostile = collision.collider.gameObject;
                //HostileComponent hostileScript = collidedObj.GetComponent<HostileComponent>();

                float damageToAppy = collidedObj.baseDamage;

                collidedObj.OnCartCollision();
                cartController.receiveDamage(damageToAppy);
            }

        }
           
    }
}

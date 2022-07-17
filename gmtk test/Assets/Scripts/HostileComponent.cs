using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileComponent : MonoBehaviour
{
    public GameObject Circle;
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
        if (!hasDamaged)
        {
            gameControl.health -= 1;
            Destroy(Circle);
        }

    }
}

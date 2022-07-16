using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtElement : MonoBehaviour
{
    public GameObject Circle;
    void OnTriggerEnter2D (Collider2D col)
    {
        gameControl.health -= 1;
        Destroy(Circle);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

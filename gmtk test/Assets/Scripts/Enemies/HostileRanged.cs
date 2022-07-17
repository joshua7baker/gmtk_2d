using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileRanged : MonoBehaviour
{
    private GameObject cart;
    private Transform cartPos;
    public GameObject cannonPivot;
    public float rotSpeed = 5f;

    Quaternion rotation;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        cart = GameObject.FindGameObjectWithTag("Cart");
    }

    // Update is called once per frame
    void Update()
    {
        //direction = cart.transform.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rotation = Quaternion.AngleAxis(angle, Vector3.left);
        //cannonPivot.transform.rotation = Quaternion.Slerp(cannonPivot.transform.rotation, rotation, rotSpeed * Time.deltaTime);
    }
}

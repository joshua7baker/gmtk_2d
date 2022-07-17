using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool followCart = false;
    public Transform target;
    public float followSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followCart)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = newPos;
        }
    }

    private void FixedUpdate()
    {
        
    }
}

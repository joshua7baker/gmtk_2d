using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float parallaxEffect;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x; //find start position
        lenght = GetComponent<SpriteRenderer>().bounds.size.x; //give us the size of the sprite
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect)); //how far we have moved relative to the camera 
        float dist = (cam.transform.position.x * parallaxEffect); //how far did we move from start point
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z); //move camera using distance

        if(temp > startpos + lenght) startpos += lenght;
        else if (temp < startpos - lenght) startpos -= lenght;  
    }
}

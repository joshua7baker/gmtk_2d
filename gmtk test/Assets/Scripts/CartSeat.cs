using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartSeat : MonoBehaviour
{
    [SerializeField]
    [HideInInspector]
    public bool occupied;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttachGoblin(GameObject goblin, GameObject seat)
    {
        goblin.transform.parent = this.transform;
        goblin.transform.position = seat.transform.position;
        occupied = true;
    }
}

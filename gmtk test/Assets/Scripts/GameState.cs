using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private CartController cartController;
    private List<GameObject> cartSeats;
    private GameObject[] goblins;
    void Start()
    {
        cartController = GameObject.Find("Cart").GetComponent<CartController>();
        goblins = GameObject.FindGameObjectsWithTag("Goblin");

        foreach (GameObject goblin in goblins)
        {
            Debug.Log(goblins);
        }



    }
    void Update()
    {
        foreach (GameObject goblin in goblins)
        {
            Transform cartSeatToUse = cartController.sea
            
        }

        
    }
}

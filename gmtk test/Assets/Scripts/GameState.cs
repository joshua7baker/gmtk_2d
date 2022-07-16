using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private CartController cartController;
    //private List<Component> cartSeats = new();
    public GameObject cart;
    public GameObject[] goblinSeats;
    private GameObject[] goblins;
    void Start()
    {
        cart = GameObject.FindGameObjectWithTag("Cart");
        cartController = GameObject.Find("Cart").GetComponent<CartController>();
        
        goblins = GameObject.FindGameObjectsWithTag("Goblin");
        goblinSeats = GameObject.FindGameObjectsWithTag("Seat");


        foreach (GameObject seat in goblinSeats)
        {
            Debug.Log(seat);
        }

        foreach (GameObject goblin in goblins)
        {
            foreach (GameObject seat in goblinSeats)
            {
                CartSeat cartScript = seat.GetComponent<CartSeat>();
                
                if (!cartScript.occupied)
                {
                    cartScript.OnAttachGoblin(goblin, seat);
                    Debug.Log("Sit Gobbo");
                    break;
                }
                else
                {   
                    Debug.Log("Seat full");
                }
            }
        }



    }
    void Update()
    {
        //foreach (GameObject goblin in goblins)
        //{
        //    //Transform cartSeatToUse = cartController.goblinSeats.
            
        //}

        
    }
}

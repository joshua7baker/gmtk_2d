using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private CartController cartController;
    public GameObject goblinPrefab;
    //private List<Component> cartSeats = new();
    private GameObject cart;
    private GameObject[] goblinWaitingArea;
    public GameObject[] goblinSeats;
    private GameObject[] goblins;

    private GameObject[] goblinsAvailable;
    private GameObject[] goblinsAssigned;
    void Start()
    {
        cart = GameObject.FindGameObjectWithTag("Cart");
        cartController = GameObject.Find("Cart").GetComponent<CartController>();
        goblinWaitingArea = GameObject.FindGameObjectsWithTag("GoblinWaitingArea");

        goblins = GameObject.FindGameObjectsWithTag("Goblin");
        goblinSeats = GameObject.FindGameObjectsWithTag("Seat");


        foreach (GameObject seat in goblinSeats)
        {
            //Debug.Log(seat);
        }

        foreach (GameObject goblin in goblins)
        {
            foreach (GameObject seat in goblinSeats)
            {
                CartSeat cartScript = seat.GetComponent<CartSeat>();
                
                if (!cartScript.occupied)
                {
                    cartScript.OnAttachGoblin(goblin, seat);
                    //Debug.Log("Sit Gobbo");
                    break;
                }
                else
                {   
                    //Debug.Log("Seat full");
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

    public void PurchaseGoblin()
    {
        Debug.Log("reachd");

        foreach (GameObject space in goblinWaitingArea)
        {
            WaitingSpace waitingScript = space.GetComponent<WaitingSpace>();
            if (!waitingScript.isOccupied)
            {
                waitingScript.isOccupied = true;
                Instantiate(goblinPrefab, space.transform);
            }
        }
    }

    public void AddGobboToCart()
    {
        s
    }
}

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

    private List<GameObject> goblinsAvailable = new();
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
        }

        foreach (GameObject goblin in goblins)
        {

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
        foreach (GameObject space in goblinWaitingArea)
        {
            bool spaceFound = false;

            if (!spaceFound)
            {
                WaitingSpace waitingScript = space.GetComponent<WaitingSpace>();
                if (!waitingScript.isOccupied)
                {
                    waitingScript.isOccupied = true;
                    GameObject goblinSpawned = Instantiate(goblinPrefab, space.transform);
                    goblinsAvailable.Add(goblinSpawned);

                    Debug.Log(goblinSpawned);
                    Debug.Log(goblinsAvailable.Count);
                    spaceFound = true;
                    break;
                }
            }
            else break;
            
        }
    }

    

    public void AddGobboToCart()
    {
        GameObject goblinToAttach = goblinsAvailable[0];
        goblinsAvailable.Remove(goblinToAttach);
        AttachToCart(goblinToAttach);
    }
    private void AttachToCart(GameObject goblin)
    {
        foreach (GameObject seat in goblinSeats)
        {
            CartSeat cartScript = seat.GetComponent<CartSeat>();
            //Debug.Log(cartScript);
            if (!cartScript.occupied)
            {
                cartScript.OnAttachGoblin(goblin, seat);
                break;
            }

        }
    }
}

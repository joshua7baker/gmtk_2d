using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGameScreen : MonoBehaviour
{
    private GameState gameStateScript;
    private GameObject gameState;
    void Start()
    {
        gameState = GameObject.Find("GameState");
        gameStateScript = gameState.GetComponent<GameState>();
    }

    void Update()
    {
        
    }

    public void AddGoblinToCart()
    {
        gameStateScript.AddGobboToCart();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{

    public GameObject Goblin, Goblin1, Goblin2, Goblin3, Goblind4, gameOver;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Goblin.gameObject.SetActive(true);
        Goblin1.gameObject.SetActive(true);
        Goblin2.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                Goblin.gameObject.SetActive(true);
                Goblin1.gameObject.SetActive(true);
                Goblin2.gameObject.SetActive(true);
                break;

            case 2:
                Goblin.gameObject.SetActive(true);
                Goblin1.gameObject.SetActive(true);
                Goblin3.gameObject.SetActive(false);
                break;

            case 1:
                Goblin.gameObject.SetActive(true);
                Goblin1.gameObject.SetActive(false);
                Goblin2.gameObject.SetActive(false);
                break;

            case 0:
                Goblin.gameObject.SetActive(false);
                Goblin1.gameObject.SetActive(false);
                Goblin2.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }

        
    }
}

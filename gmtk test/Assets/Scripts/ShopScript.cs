using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
	private GameState gameState;
	public Slider goblinSlider, armourSlider;

	public int maxGoblins, maxArmour, minGoblins, minArmour;
	int currentGoblins, currentArmour;

	int cash;

	public Text cashText;
	
	// Use this for initialization
	void Start()
	{
		gameState = Component.FindObjectOfType<GameState>();
		SetDefaults();
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			PlayerPrefs.DeleteAll();
		}

		if (Input.GetKeyDown(KeyCode.N))
		{
			SceneManager.LoadScene("Level");
		}
	}
	

	void SetDefaults()
	{
		cash = 100;
		cashText.text = cash + "g";

		currentGoblins = PlayerPrefs.GetInt("goblins", 0);
		currentArmour = PlayerPrefs.GetInt("armour", 0);

		goblinSlider.maxValue = maxGoblins;
		armourSlider.maxValue = maxArmour;

		goblinSlider.minValue = minGoblins;
		armourSlider.minValue = minArmour;

		goblinSlider.value = currentGoblins;
		armourSlider.value = currentArmour;

	}

	public void buyGoblins(int price)
	{
		gameState.PurchaseGoblin();

		//if (currentGoblins < maxGoblins)
		//{
		//	if (cash >= price)
		//	{
		//		cash -= price;
		//		cashText.text = cash + "g";
		//		currentGoblins += 1;
		//		PlayerPrefs.SetInt("goblins", currentGoblins);
		//		goblinSlider.value = currentGoblins;
		//		Debug.Log("Goblin Upgraded");

		//	}
		//	else
		//	{
		//		Debug.Log("out of cash");
		//	}
		//}
		//else
		//{
		//	Debug.Log("Goblin full");
		//}
	}

	public void sellGoblins(int price)
	{
		if (currentGoblins > minGoblins)
		{
			if (cash > price)
			{
				cash += price;
				cashText.text = cash + "g";
				currentGoblins -= 1;
				PlayerPrefs.SetInt("goblins", currentGoblins);
				goblinSlider.value = currentGoblins;
				Debug.Log("Goblin Upgraded");
			}
			else
			{
				Debug.Log("out of cash");
			}
		}
		else
		{
			Debug.Log("Goblin full");
		}
	}

	public void buyArmour(int price)
	{
		if (currentArmour < maxArmour)
		{
			if (cash > price)
			{
				cash -= price;
				cashText.text = cash + "g";
				currentArmour += 1;
				PlayerPrefs.SetInt("armour", currentArmour);
				armourSlider.value = currentArmour;
				Debug.Log("armour Upgraded");
			}
			else
			{
				Debug.Log("out of cash");
			}
		}
		else
		{
			Debug.Log("armour full");
		}
	}

	public void sellArmour(int price)
	{
		if (currentArmour > minArmour)
		{
			if (cash > price)
			{
				cash += price;
				cashText.text = cash + "g";
				currentArmour -= 1;
				PlayerPrefs.SetInt("armour", currentArmour);
				armourSlider.value = currentArmour;
				Debug.Log("armour Upgraded");
			}
			else
			{
				Debug.Log("out of cash");
			}
		}
		else
		{
			Debug.Log("Armour full");
		}
	}

}

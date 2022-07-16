using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{

	public Slider healthSlider, armourSlider;

	public int maxHealth, maxArmour;
	int currentHealth, currentArmour;

	int cash;

	public Text cashText;

	// Use this for initialization
	void Start()
	{
		SetDefs();
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


	void SetDefs()
	{
		cash = 1000;
		cashText.text = cash + "$";

		currentHealth = PlayerPrefs.GetInt("health", 0);
		currentArmour = PlayerPrefs.GetInt("armour", 0);

		healthSlider.maxValue = maxHealth;
		armourSlider.maxValue = maxArmour;

		healthSlider.value = currentHealth;
		armourSlider.value = currentArmour;

	}

	public void buyHealth(int price)
	{
		if (currentHealth < maxHealth)
		{
			if (cash > price)
			{
				cash -= price;
				cashText.text = cash + "$";
				currentHealth += 5;
				PlayerPrefs.SetInt("health", currentHealth);
				healthSlider.value = currentHealth;
				Debug.Log("Health Upgraded");
			}
			else
			{
				Debug.Log("out of cash");
			}
		}
		else
		{
			Debug.Log("Health full");
		}
	}

	public void buyArmour(int price)
	{
		if (currentArmour < maxArmour)
		{
			if (cash > price)
			{
				cash -= price;
				cashText.text = cash + "$";
				currentArmour += 10;
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

}

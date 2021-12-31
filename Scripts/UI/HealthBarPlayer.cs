using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlayer : MonoBehaviour
{
	public PlayerHealth playerHealth;
	public Slider slider;

	public void Starter()
	{
		slider.maxValue = playerHealth.health;
	}

	void Update()
    {
		slider.value = playerHealth.health;
    }
}

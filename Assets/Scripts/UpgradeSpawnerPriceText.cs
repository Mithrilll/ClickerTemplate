using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeSpawnerPriceText : MonoBehaviour
{
	private TextMeshProUGUI text = null;

	private void Awake()
	{
		text = gameObject.GetComponent<TextMeshProUGUI>();
		text.color = Color.white;
		GameManager.SpawnRatePriceChanged += OnChanged;
	}

	private void OnChanged()
	{
		text.text = GameManager.SpawnRatePrice.ToString() + " $";
	}
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeCoinPriceText : MonoBehaviour
{
	private TextMeshProUGUI text = null;

	private void Awake()
	{
		text = gameObject.GetComponent<TextMeshProUGUI>();
		text.color = Color.white;
		GameManager.MoneyRatePriceChanged += OnChanged;
	}

	private void OnChanged()
	{
		text.text = GameManager.MoneyRatePrice.ToString() + " $";
	}
}

using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	private static float coin_money_rate= 1.0f;
	private static float coin_spawn_rate = 1.0f;
	private static CoinSpawner coin_spawner;

	private static float score;
	private static float money_rate_price = 10.0f;
	private static float spawn_rate_price = 10.0f;

	public static float Score { get { return score; } }
	public static float MoneyRatePrice { get { return money_rate_price; } }
	public static float SpawnRatePrice { get { return spawn_rate_price; } }

	public static Action ScoreChanged;
	public static Action MoneyRatePriceChanged;
	public static Action SpawnRatePriceChanged;

	private void Start()
	{
		score = 0.0f;
		coin_money_rate = 1.0f;

		coin_spawner = GameObject.FindGameObjectWithTag("CoinSpawner").GetComponent<CoinSpawner>();
		coin_spawner.spawn_rate = coin_spawn_rate;

		ScoreChanged.Invoke();
		MoneyRatePriceChanged.Invoke();
		SpawnRatePriceChanged.Invoke();
	}

	public static void UpgradeCoin()
	{
		if (score >= money_rate_price)
		{
			score -= money_rate_price;
			coin_money_rate += 0.5f;
			money_rate_price *= 2.0f;
			ScoreChanged.Invoke();
			MoneyRatePriceChanged.Invoke();
		}
	}

	public static void UpgradeSpawner()
	{
		if (score >= spawn_rate_price)
		{
			score -= spawn_rate_price;
			coin_spawn_rate += 0.5f;
			coin_spawner.spawn_rate = coin_spawn_rate;
			spawn_rate_price *= 2.0f;
			ScoreChanged.Invoke();
			SpawnRatePriceChanged.Invoke();
		}
	}

	public static void OnCoinClicked(GameObject obj)
	{
		score += coin_money_rate;
		ScoreChanged.Invoke();
		Destroy(obj);
	}
}

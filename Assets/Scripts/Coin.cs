using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private void OnMouseDown()
	{
		GameManager.OnCoinClicked(gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
	private TextMeshProUGUI text = null;

	private void Awake()
	{
		text = gameObject.GetComponent<TextMeshProUGUI>();
		text.color = Color.red;
		GameManager.ScoreChanged += OnChanged;
	}

	private void OnChanged()
	{
		text.text = GameManager.Score.ToString() + " $";
	}
}

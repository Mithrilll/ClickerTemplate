using UnityEngine;
using UnityEngine.UI;

public class UpgradeSpawnerButton : MonoBehaviour
{
	private Button button = null;

	private void Start()
	{
		button = gameObject.GetComponent<Button>();
		button.onClick.AddListener(OnClick);
	}

	private void OnClick()
	{
		GameManager.UpgradeSpawner();
	}
}

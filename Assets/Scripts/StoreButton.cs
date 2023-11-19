using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour
{
	[SerializeField]
	private GameObject panel = null;

	private Button button = null;
	private bool state = false;

	private void Start()
	{
		button = gameObject.GetComponent<Button>();
		button.onClick.AddListener(OnClick);

		panel.SetActive(false);
	}

	private void OnClick()
	{
		state = !state;

		panel.SetActive(state);
		Time.timeScale = state ? 0.0f : 1.0f;
	}
}

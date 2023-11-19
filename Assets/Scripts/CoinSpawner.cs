using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	public float spawn_rate = 1.0f;

	[SerializeField]
	private float emiter_size = 5.0f;

	[SerializeField]
	private GameObject coin_prefab = null;

	private float time = 0.0f;

	private void Update()
	{
		time += Time.deltaTime;

		if(time > 1.0f / spawn_rate)
		{
			Instantiate(coin_prefab, new Vector3(Random.Range(-emiter_size/2.0f, emiter_size/2.0f), 8.0f, 200.0f), Quaternion.identity, gameObject.transform);
			time -= 1.0f / spawn_rate;
		}
	}
}

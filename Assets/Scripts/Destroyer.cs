using UnityEngine;

public class Destroyer : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		var obj = collision.gameObject;
		Destroy(obj);
	}
}

using UnityEngine;

public class Slicer : MonoBehaviour
{
	Rigidbody2D rb;

	void Start()
	{
		Application.targetFrameRate = 60;
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		worldPos.z = 0;

		rb.MovePosition(worldPos);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		var fruit = other.gameObject.GetComponent<Fruit>();
		fruit.Slice();
	}
}
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		
		Vector2 movement = new Vector2 (moveHorizontal, 0);
		rigidbody2D.AddForce (movement * speed, ForceMode2D.Impulse);

	}
}

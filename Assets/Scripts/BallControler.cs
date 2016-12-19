using UnityEngine;
using System.Collections;

public class BallControler : MonoBehaviour {

	public float speed;

	bool isRunning = false;
	public PlayerController player;

	private Vector3 distance;
	// Use this for initialization
	void Start () {
		distance = this.transform.position - player.transform.position;
		InvokeRepeating ("SpeedUp", 0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (!isRunning) {
			transform.position = player.transform.position + distance;

			if (Input.GetKeyDown (KeyCode.Space)) {
				isRunning = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, speed);
			}
		}
	}

	void SpeedUp()
	{
		float sign = Mathf.Sign (GetComponent<Rigidbody2D> ().velocity.y);
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, speed * sign);
	}
}

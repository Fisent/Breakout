using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		print ("DESTROY!!!");
		Destroy (gameObject);

	}
}

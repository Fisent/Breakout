using UnityEngine;
using System.Collections;

public class FailColliderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		print ("GAME OVER");
		Application.LoadLevel("gameOver");
	}
}

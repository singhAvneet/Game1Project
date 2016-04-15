using UnityEngine;
using System.Collections;

public class playerBullets : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	//private float _horizontalDrift;

	//public bulletFiring enemy;
	public float speedRate;



	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		//this.Reset ();
	}

	// Update is called once per frame
	void Update () {

		this._currentPosition = this._transform.position;
		this._currentPosition += new Vector2 (speedRate, 0.0f);
		this._transform.position = this._currentPosition;

	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.CompareTag ("MiniEnemy")) {
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag ("EnemyBullet")) {
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag ("EnemyBoss")) {
			Destroy (this.gameObject);
		}
	}

	//PUBLIC METHODS
	public void Reset() {
	}

	//PRIVATE METHODS
	private void _CheckBoundary(){

		if (this._currentPosition.x <= 335) {
			Destroy (this.gameObject);
		}
	}
}

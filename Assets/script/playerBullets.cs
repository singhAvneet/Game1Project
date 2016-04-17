using UnityEngine;
using System.Collections;

public class playerBullets : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform,_playerBulletTransform;
	private Vector2 _currentPosition;
	private bool check;

	//public bulletFiring enemy;
	public float speedRate;
	public GameObject _player;



	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		this.check = true;
		this._currentPosition = this._transform.position;
		this._playerBulletTransform = this.gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		if (check) {
			
			this._currentPosition += new Vector2 (speedRate, 0.0f);
			this._transform.position = this._currentPosition;
		}
	
		this._CheckBoundary ();
	}
	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.CompareTag ("IronMan")) 
		{
			Destroy (this.gameObject);
		}

		if (other.gameObject.CompareTag ("EnemyBullet")) {
			Destroy (this.gameObject);
		}
	
	}


	//PRIVATE METHODS
	private void _CheckBoundary(){

		if (this._transform.position.x > this._player.transform.position.x+500f) {
			this._playerBulletTransform.position = new Vector2 (this._player.transform.position.x + 80, this._player.transform.position.y - 10);
		//	this._transform.position = this._player.transform.position;

						//this._currentPosition = this._transform.position;
						//this._currentPosition=new Vector2 (this._player.transform.position.x, 0f);

			//this._currentPosition =	this._transform.position;
			//this.check = false;
			Destroy (this.gameObject);
		}
	} 
}

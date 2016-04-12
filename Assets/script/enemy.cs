using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed ;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Ocean Sprite to the Top
		//this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		

		if (this._currentPosition.x >= -800) {
			//this.Reset ();
			this._currentPosition = this._transform.position;
			this._currentPosition -= new Vector2(this.speed,0);
			this._transform.position = this._currentPosition;
		}
	




	}

	public void Reset() {
		this._transform.position = new Vector2 (100,this._currentPosition.y);
	}
}

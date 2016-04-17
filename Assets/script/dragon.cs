using UnityEngine;
using System.Collections;

public class dragon : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalDrift;
	private float _verticalPosition;

	//public objects
	public GameObject player;
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition.y = this._verticalPosition;
		this._currentPosition -= new Vector2(this._horizontalDrift,0f);
		this._transform.position = this._currentPosition;
		if (this._currentPosition.x < this.player.transform.position.x-100f) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._verticalPosition = Random.Range (-213f,157f);
		this._horizontalDrift = 1f;
		this._transform.position = new Vector2 (this.player.transform.position.x+600, 0);

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "upWall") {
			this._transform.position = new Vector2 (0f,this._transform.position.y+40.534f);
		
		}
		if (other.tag == "downWall") {
			this._transform.position = new Vector2 (0f,this._transform.position.y-40.534f);
		
		}
	}

}

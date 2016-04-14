using UnityEngine;
using System.Collections;

public class BossEnemyController : MonoBehaviour {
	
	//PUBLIC VARIABLE
	public float speed;

	//PRIVATE VARIABLE
	private Transform _transform;
	private Vector2 _currentPosition;
	private int _liveScore;

	// Use this for initialization
	void Start () {

		this._transform = gameObject.GetComponent<Transform> ();
		this._liveScore = 10;
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		if (this._currentPosition.x > 200) {
			this._currentPosition -= new Vector2 (this.speed, 0f);
			this._transform.position = this._currentPosition;
		}

		if (this._currentPosition.x < 80) {
		}

	}

	//PIVATE METHODS
	private void _Reset(){
		this._transform.position = new Vector2 (440f, 0f);
	}
}

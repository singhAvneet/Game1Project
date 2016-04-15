﻿using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalDrift;
	private float _verticalPosition;


	// Use this for initialization
	void Start ()
	{
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();
		// Reset the bullets` Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update ()
	{
		this._currentPosition = this._transform.position;
		this._currentPosition.y = this._verticalPosition;
		this._currentPosition -= new Vector2 (this._horizontalDrift, 0f);
		this._transform.position = this._currentPosition;
		if (this._currentPosition.x < -335) {
			this.Reset ();
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			this.Reset ();
		}
	}

	public void Reset ()
	{
		this._verticalPosition = Random.Range (-230f, 230f);
		this._horizontalDrift = 10f;
		//this._transform.position = new Vector2 (335, 0);

	}

}

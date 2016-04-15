﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Controller : MonoBehaviour {

	//PRIVATE VARIABLES
	private WarCryGameController _warCryGameController;
	private player _playerController;
	private int _bossLifeLine;

	//PUBLIC VARIABLES
	public GameObject miniEnemys;
	public BossEnemyController bossEnemy;
	public Text bossLifeLabel;


	//GETER and SETTER
	public int BossLifeLine{
		get{
			return this._bossLifeLine;
		}
		set{ 
			this._bossLifeLine = value;
			this.bossLifeLabel.text = "Boss Life: " + this._bossLifeLine;
			if (this._bossLifeLine <= 0) {
				this._EndGame ();
			}
		}
	}

	// Use this for initialization
	void Start () {
		this._initiallizeObjects ();
	}
	
	// Update is called once per frame
	void Update () {

		if (this._warCryGameController.BkgRestCount == 3) {
			this._warCryGameController.BkgRestCount += 1;
			//Instantiate Boss Enemy
			Instantiate(this.bossEnemy.gameObject);
			this.bossLifeLabel.gameObject.SetActive (true);
			//this.miniEnemys.gameObject.SetActive (false);
		}

		//Check for booEnemyLife and instant	iate miniEnemy

		
	}

	//PRIVATE METHODS
	private void _initiallizeObjects(){

		this.bossLifeLabel.gameObject.SetActive (false);
		this._bossLifeLine = 4;
		this._warCryGameController = GameObject.Find ("WarCryGameContoller").GetComponent<WarCryGameController> ();
		this._playerController = GameObject.Find ("player").GetComponent<player> ();
		for (int i = 0; i < 2; i++) {
			Instantiate (this.miniEnemys);
		}
	}

	private void _EndGame(){

		Destroy (this._playerController.gameObject);
		this._warCryGameController.gameOverLabel.text = "MISSION COMPLETED";
		this._warCryGameController._EndGame ();
	}
}

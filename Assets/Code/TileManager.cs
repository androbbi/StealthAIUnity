using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class TileManager : MonoBehaviour {
	//public GameObject _WallL;
	//public GameObject _WallPrefab;
	//public GameObject _WallU;
	//public GameObject _WallD;
	public GameObject _Floor;
	public GameObject[] _Walls;
	public bool[] _enableWalls;
	int _numOfWalls;
	public void changeColor(){
		_Floor.GetComponent<Renderer>().material.color = Color.magenta;
		for(int i = 0; i < _Walls.Length; i++){
			_Walls[i].GetComponent<Renderer>().material.color = Color.blue;
		}
	}
	public void enableWalls(){
		bool[] _enableWalls = new bool[_Walls.Length];
		for(int i = 0; i < _enableWalls.Length; i++){
			if(!_enableWalls[i]){
				_Walls[i].GetComponent<WallProps>()._isEnabled = true;
			}
			else{
				_Walls[i].GetComponent<WallProps>()._isEnabled = false;
			}
		}
	}
	public void getWalls(){
		_numOfWalls = 4;
		GameObject[] _Walls = new GameObject[_numOfWalls];
		for(int i = 0; i < _numOfWalls; i++){
			if(i == 0)
				_Walls[i] = GameObject.Find("WallL");
			if(i == 1)
				_Walls[i] = GameObject.Find("WallU");
			if(i == 2)
				_Walls[i] = GameObject.Find("WallR");
			if(i == 3)
				_Walls[i] = GameObject.Find("WallD");
		}
	}

	// Use this for initialization
	void Start () {
		getWalls();
		_Floor = GameObject.Find("Floor");
		//enableWalls();
		changeColor();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour {
	public int _gridRow;
	public int _gridCol;
	public int _gridRxC;
	// Use this for initialization

	public GameObject[,] _grid;
	//public static int numCells = 10;
	// Init 2D array for grid
	public GameObject[] _allTiles;
	public void initGrid(){
		// Find every instance of tile
		_allTiles = GameObject.FindGameObjectsWithTag("Tile");
		foreach(GameObject tile in _allTiles){
			Debug.Log(tile.name);
		}
		// an N x N grid has sqrt(number of tiles)
		_gridRxC = (int) Mathf.Sqrt(_allTiles.Length);
		GameObject[,] _grid = new GameObject[_gridRxC, _gridRxC];
	}
	public GameObject getTile(int index){

		return gameObject;
	}
	public void setGrid(){
		int count = 0;
		for(int i = 0; i < _gridRxC; i++){
			for(int j = 0; j <_gridRxC; j++){
				//getTile(count, );
				//count++;
				//_allTiles[i,j] = 
			}
		}
	}
	void Start () {
		initGrid();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

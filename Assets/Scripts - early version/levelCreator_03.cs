﻿using UnityEngine;
using System.Collections;

public class levelCreator_03 : MonoBehaviour {
	
	// Use this for initialization
	private GameObject collectedTiles;
	private const float tileWidth= 1.25f;
	private GameObject tilePos;
	private int heightLevel = 0;
	
	private GameObject gameLayer;
	private GameObject bgLayer;
	
	private GameObject tmpTile;
	
	private float startUpPosY;
	
	private float gameSpeed = 2.0f;
	private float outofbounceX;
	private int blankCounter = 0;
	private int middleCounter = 0;
	private string lastTile = "right";
	
	
	void Start () 
	{
		gameLayer = GameObject.Find("gameLayer");
		bgLayer = GameObject.Find("backgroundLayer");
		collectedTiles = GameObject.Find("tiles");
		for(int i = 0; i<20; i++){
			GameObject tmpG1 = Instantiate(Resources.Load("ground_left", typeof(GameObject))) as GameObject;
			tmpG1.transform.parent = collectedTiles.transform.FindChild("gLeft").transform;
			tmpG1.transform.position = Vector2.zero;
			GameObject tmpG2 = Instantiate(Resources.Load("ground_middle", typeof(GameObject))) as GameObject;
			tmpG2.transform.parent = collectedTiles.transform.FindChild("gMiddle").transform;
			tmpG2.transform.position = Vector2.zero;
			GameObject tmpG3 = Instantiate(Resources.Load("ground_right", typeof(GameObject))) as GameObject;
			tmpG3.transform.parent = collectedTiles.transform.FindChild("gRight").transform;
			tmpG3.transform.position = Vector2.zero;
			GameObject tmpG4 = Instantiate(Resources.Load("blank", typeof(GameObject))) as GameObject;
			tmpG4.transform.parent = collectedTiles.transform.FindChild("gBlank").transform;
			tmpG4.transform.position = Vector2.zero;
		}
		collectedTiles.transform.position = new Vector2 (-60.0f, -20.0f);
		
		tilePos = GameObject.Find("startTilePosition");
		startUpPosY = tilePos.transform.position.y;
		
		
		
		fillScene ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		
		
	}
	
	private	void fillScene()
	{
		//Fill start
		for (int i = 0; i<15; i++)
		{
			setTile("middle");
		}
		setTile("right");
	}
	
	private void setTile(string type)
	{
		switch (type){
		case "left":
			tmpTile = collectedTiles.transform.FindChild("gLeft").transform.GetChild(0).gameObject;
			break;
		case "middle":
			tmpTile = collectedTiles.transform.FindChild("gMiddle").transform.GetChild(0).gameObject;
			break;
		case "right":
			tmpTile = collectedTiles.transform.FindChild("gRight").transform.GetChild(0).gameObject;
			break;
		case "blank":
			tmpTile = collectedTiles.transform.FindChild("gBlank").transform.GetChild(0).gameObject;
			break;
		}
		tmpTile.transform.parent = gameLayer.transform;
		tmpTile.transform.position = new Vector3(tilePos.transform.position.x+(tileWidth),startUpPosY+(heightLevel * tileWidth),0);
		tilePos = tmpTile;
		
	}
	
	private void spawnTile(){
		
		
	}
	
	private void changeHeight()
	{
		int newHeightLevel = (int)Random.Range(0,4);
		if(newHeightLevel<heightLevel)
			heightLevel--;
		else if(newHeightLevel>heightLevel)
			heightLevel++;
	}
	
	
}

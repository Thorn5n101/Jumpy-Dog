﻿using UnityEngine;
using System.Collections;

public class levelCreator_02 : MonoBehaviour {
	
	// Use this for initialization
	private GameObject tilePos;
	private float startUpPosY;
	private const float tileWidth = 1.25f;
	private int heightLevel = 0;
	private GameObject tmpTile;
	
	
	private GameObject collectedTiles;
	private GameObject gameLayer;
	private GameObject bgLayer;
	
	
	
	void Start () 
	{
		gameLayer = GameObject.Find("gameLayer");
		bgLayer = GameObject.Find ("backgroundLayer");
		collectedTiles = GameObject.Find ("tiles");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
	}
	
	private void fillScene()
	{
		
		
		
	}
	
	
	public void setTile(string type){
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
}

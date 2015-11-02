using UnityEngine;
using System.Collections;

public class playerHandler_05 : MonoBehaviour {
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void jump(){
		
		this.GetComponent<Rigidbody2D>().AddForce (Vector2.up * 3000);
		
	}
	
	
}

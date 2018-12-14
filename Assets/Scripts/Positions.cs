using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour {

    Vector3 positions = new Vector3(-10.3f,-1.2f,0f);
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.transform.position = positions;
    }
}

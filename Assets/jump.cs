﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public float Jump;
    public float speed;
       

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, Jump));
            GetComponent<fsm>().Check(gameObject);

        }
        

		
	}
}

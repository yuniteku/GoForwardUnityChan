﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    //
    private float scrollpeed = -0.03f;

    //
    private float deadLine = -16;

    //
    private float startLine = 15.8f;


	// Use this for initialization
	void Start () {
       
		
	}
	
	// Update is called once per frame
	void Update () {

        //
        transform.Translate(this.scrollpeed, 0, 0);

        //画面外に出たら
        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }

    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour {

    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;

    void Awake()
    {
	    Instantiate(redObj, new Vector3(2, 1, 0), Quaternion.identity);
	    Instantiate(blueObj, new Vector3(-2, -1, 0), Quaternion.identity);
    }

    // Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

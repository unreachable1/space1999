using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : Boid {
    //inherit from boid
    public GameObject seekThis = null;
    public Vector3 seekThisTarget;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if gameobject exists, get the transform of it and pass it into boid's seek function
       
		if(seekThis != null)
        {
            seekThisTarget = seekThis.transform.position;
            boid.seekTarget(seekThisTarget);
        }
	}
}

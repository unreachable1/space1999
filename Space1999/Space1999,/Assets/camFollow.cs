using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour {
   
    public GameObject leader;

	// Use this for initialization
	void Start () {
        leader = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
       
        camBehaviour();
	}

    void camBehaviour()
    {
        //look at the transform of the assigned leader
        transform.LookAt(leader.transform);
    }
}

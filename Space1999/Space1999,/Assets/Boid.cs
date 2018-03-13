using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {

    public float mass =1f;
    public float minSpeed = 5f;
    public float maximumSpeed =10f;
    public float speed;

    public Boid boid;
    public Vector3 dist;

	// Use this for initialization
	void Start () {
        boid = GetComponent<Boid>();
	}
	
	// Update is called once per frame
	void Update () {
        
        Mathf.Clamp(speed, minSpeed, maximumSpeed);
	}

    public Vector3 seekTarget(Vector3 target)
    {
        return transform.position = (transform.position - target);
    }
}

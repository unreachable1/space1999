using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {

    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;

    public Vector3 leftOffset;
    public Vector3 rightOffset;

    // Use this for initialization
    void Awake () {

        //add gap to the x axis of each offset
        leftOffset = (prefab.transform.position) + new Vector3(gap,0,0);
        rightOffset = (prefab.transform.position) + new Vector3(gap, 0, 0);

        //instantiate 1 at spawner, 1 with the left offset and 1 with the right offset
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(prefab, leftOffset, Quaternion.identity);
        Instantiate(prefab, rightOffset, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(prefab.transform.position);
        
        

    }
}

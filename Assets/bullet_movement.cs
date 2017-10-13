//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class bullet_movement : MonoBehaviour {
    private float speed = 2f;
   // public GameObject cam;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(Time.deltaTime, 0, 0, cam.transform);
    }
}

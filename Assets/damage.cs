using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {
    public GameObject coll;


	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "energy_shield")
        {
            Destroy(Instantiate(coll, transform.position, transform.rotation), 0.98f);
            Destroy(gameObject);
        }
    }

}

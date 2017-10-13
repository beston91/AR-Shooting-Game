using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
    public GameObject coll;

    private void OnTriggerEnter(Collider shield)
    {
        if (shield.tag == "energy_shield")
        {
            Destroy(Instantiate(coll, transform.position, transform.rotation), 1f);
            Destroy(gameObject);
        }
    }
}

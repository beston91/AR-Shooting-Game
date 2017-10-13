using UnityEngine;
using System.Collections;

public class damage_receive : MonoBehaviour {
    public GameObject end;
    private int n = 0;
	// Use this for initialization

    void OnTriggerEnter(Collider collider)
    {
        n += 1;
        if (collider.tag == "bullet" && n == 20)
        {
            Destroy(Instantiate(end, transform.position, transform.rotation), 3f);
            Destroy(gameObject);
        }
    }
}

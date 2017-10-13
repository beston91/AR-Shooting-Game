
using UnityEngine;

public class Orientation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 pos = transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = rotation;
	}
	
	
}

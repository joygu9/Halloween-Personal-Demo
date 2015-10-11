using UnityEngine;
using System.Collections;

public class StackBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 1.4) {
			Vector3 player = OVRManager.instance.transform.position;
			if (player.x > 4 && player.x < 6) {
				if (player.z < 10) {
					double x = transform.position.x;
					double z = transform.position.z;
					transform.position = new Vector3((float) x, (float) 1.4, (float) z);
					GetComponent<AudioSource>().Play();
				}
			}
		} 	
	}

}

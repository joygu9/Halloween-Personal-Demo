using UnityEngine;
using System.Collections;

public class VoldyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 player = OVRManager.instance.transform.position;
		if (player.x > 4 && player.x < 6) {
			if (player.z < 8) {
				double x = transform.position.x;
				double y = transform.position.y;
				double z = transform.position.z;
					
				if (z <=8){
					transform.position = new Vector3((float) x, (float) y, (float) (7));
					GetComponent<AudioSource>().Play();
				}
			}
		} 	
	}
}

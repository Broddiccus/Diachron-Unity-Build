using UnityEngine;
using System.Collections;

public class AttackCheck : MonoBehaviour {
	public float last;
	public float timer;
	public Attack user;
	void Update(){
		timer += 1*Time.deltaTime;
		if (timer >= last) {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void OnTriggerEnter(GameObject other) {
	
	}
}

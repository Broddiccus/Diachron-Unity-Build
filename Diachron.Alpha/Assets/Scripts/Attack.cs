using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{	
	public bool ata;
	public bool lunge;
	public int[] checker;
	public bool[] checkerCheck;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Z) == true) {
			ata = true;
		} else {
			ata = false;
		}
		if (Input.GetKeyDown (KeyCode.X) == true && checkerCheck [0] == true) {
			lunge = true;
			checkerCheck [0] = false;
		}
		if (checkerCheck [0] == false) {
			checker [0]++;
		}
		if (checker [0] > 20) {
			checkerCheck [0] = true;
			checker [0] = 0;
		}
	}
}

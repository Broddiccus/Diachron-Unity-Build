using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{	
	public bool ata;
	public bool lunge;
	public float[] checker;
	public bool[] checkerCheck;
	public GameObject ataHitBox;
	public GameObject lunHitBox;
	public Movement direction;
	private GameObject hitBox;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z) == true) {
			ata = true;

			hitBox = Instantiate (ataHitBox, transform.position, transform.rotation) as GameObject;
			hitBox.transform.parent = gameObject.transform;
			switch (direction.directionx) {
			case 1: //facing left
				hitBox.transform.Translate (-1, 0, 0);
				break;
			case 2: //facing right
				hitBox.transform.Translate (1, 0, 0);
				break;
			}
			switch (direction.directionz) {
			case 1: //facing down
				hitBox.transform.Translate (0, 0, -1);

				break;
			case 2: //facing up
				hitBox.transform.Translate (0, 0, 1);
				break;
			}
		} else {
			ata = false;
		}
		if (Input.GetKeyDown (KeyCode.X) == true && checkerCheck [0] == true) {
			lunge = true;
			checkerCheck [0] = false;
		}
		if (checkerCheck [0] == false) {
			checker [0] += 1*Time.deltaTime;
		}
		if (checker [0] > 1) {
			checkerCheck [0] = true;
			checker [0] = 0;
		}
	}
}

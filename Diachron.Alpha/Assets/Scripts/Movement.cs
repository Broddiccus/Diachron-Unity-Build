using UnityEngine;

public class Movement : MonoBehaviour
{
	public Attack ata;
	public float speed;
	public int lungeCheck;
	public int directionx;
	public int directionz;
	void Update()
	{
		if (ata.ata == true) {
			speed = 1;
		} else {
			speed = 3;
		}
		if (ata.lunge == true) {
			speed = 6;
			lungeCheck++;
			if (lungeCheck > 4) {
				ata.lunge = false;
				lungeCheck = 0;
			}
		}
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		if (x < 0) { //the player is moving left
			directionx = 1;
		} else if (x > 0) { //the player is moving right
			directionx = 2;
		}
		if (z < 0) { //the player is moving down
			directionz = 1;
		} else if (z > 0) { //the player is moving up
			directionz = 2;
		}
		transform.Translate(x, 0, 0);
		transform.Translate(0, 0, z);
	}
}
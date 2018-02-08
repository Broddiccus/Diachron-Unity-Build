using UnityEngine;

public class Movement : MonoBehaviour
{
	public Attack ata;
	public float speed;
	public int lungeCheck;
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

		transform.Translate(x, 0, 0);
		transform.Translate(0, 0, z);
	}
}
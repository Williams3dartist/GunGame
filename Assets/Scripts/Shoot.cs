using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public int delayTime = 8;

	private float counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Mouse0)&& counter > delayTime) 
		{
            //not sure why bullet does not shoot the correct way.
			// BEN: Your bullet code translates in the +Y direction. Y is up. So the bullet will go up (based on the rotation)
			// Note that you are also going to create a bullet with the rotatation of 0, 0, 0, since that is the rotation of the gun.
			// This is why you see the bullet looking like it is oriented wrong too.
			// First bullet fires "automatically" because it is already in the scene. It is rotated 90 in the X. This makes Y go
			// in the right direction. 
			Instantiate (bullet, transform.position, transform.rotation);
			counter = 0;
		}
		counter += Time.deltaTime;
	}
}

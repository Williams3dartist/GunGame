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
			Instantiate (bullet, transform.position, transform.rotation);
			counter = 0;
		}
		counter += Time.deltaTime;
	}
}

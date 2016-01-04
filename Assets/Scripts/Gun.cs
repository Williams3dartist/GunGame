using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
    public GameObject bullet;
    public int delayTime = 8;

    private float counter = 0;

    // enums allow you to have a list of values associated with a data type.
    // In this case, I've created an enum called GunState, which can have the values of Idle or Firing.
    // These will translate to integer values. So in this case, Idle == 0 and Firing == 1
    enum GunState {
		Idle,
		Firing
	};



    // To maintain state, we create a variable for this
    GunState state;

	// Use this for initialization
	void Start () {
		state = GunState.Idle;
	}
	
	// Update is called once per frame
	void Update () {
		switch (state) {
		case GunState.Idle:
                // Your shoot code would go here, but you will need to make adjustments for this to work better
                if (Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
                {
                    Instantiate(bullet, transform.position, transform.rotation);
                    counter = 0;
                }
                break;
		case GunState.Firing:
			break;
		default:
			// This should never happen right now
			break;
		}
	}
}

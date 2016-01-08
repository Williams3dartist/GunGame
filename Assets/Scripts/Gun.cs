using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
    /*WILLS COMMENTS
        For public GameObject bullet is this calling the actual object in Unity by name. If this is
        the case I have to name it bulletV1 I think. 
    */
    public GameObject bullet;
    public int delayTime = 8;

    private float counter = 0;

    // enums allow you to have a list of values associated with a data type.
    // In this case, I've created an enum called GunState, which can have the values of Idle or Firing.
    // These will translate to integer values. So in this case, Idle == 0 and Firing == 1

    /*WILLS COMMENTS
    What I can see is there are two states and Firing is being left alone for now. How do I test for
    Gunstate.Idle ? Thinking I should plugin a console.log when right mouse clicks in the GunState.Idle method.
    I think that Idle is 0, and Firing is 1 like how an array works? Will keep trouble shooting.
    */
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
                    /*WILLS COMMENTS 
                    Also in the code I noticed I am calling counter = 0 after Instaniate. I don't know why. 
                    I followed this from a tutorial. I thought I called the counter in if statement with counter > 
                    delayTime operated the Instantiate code in the block. Just confused not sure if this makes sense
                    to you.
                    */
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

using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
    /*WILLS COMMENTS
        For public GameObject bullet is this calling the actual object in Unity by name. If this is
        the case I have to name it bulletV1 I think. 

	http://docs.unity3d.com/ScriptReference/GameObject.html
	Look at Find ir FindGameObjectsWithTag or FindWithTag

	In this case, when you want a bullet, you will want to generate it from a prefab
	http://docs.unity3d.com/Manual/InstantiatingPrefabs.html

	
    */
    public GameObject bullet;
	private float timeSinceFired = 0;

    // enums allow you to have a list of values associated with a data type.
    // In this case, I've created an enum called GunState, which can have the values of Idle or Firing.
    // These will translate to integer values. So in this case, Idle == 0 and Firing == 1

    /*WILLS COMMENTS
    What I can see is there are two states and Firing is being left alone for now. How do I test for
    Gunstate.Idle ? Thinking I should plugin a console.log when right mouse clicks in the GunState.Idle method.
    I think that Idle is 0, and Firing is 1 like how an array works? Will keep trouble shooting.

	The switch in update is testing for GunState.Idle. Another means is just

	if (state == GunState.Idle)
	{
	}

	Your gun is not working because of your counter/delayTime mechanism. Remove it for now. Don't worry about the delay.
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

				// First remove && counter > delayTime and run and see what happens
				// Next Try using Input.GetMouseButtonDown instead and see what happens
                if (Input.GetMouseButtonDown(KeyCode.Mouse0))
                {
                    Instantiate(bullet, transform.position, transform.rotation);
                    /*WILLS COMMENTS 
                    Also in the code I noticed I am calling counter = 0 after Instaniate. I don't know why. 
                    I followed this from a tutorial. I thought I called the counter in if statement with counter > 
                    delayTime operated the Instantiate code in the block. Just confused not sure if this makes sense
                    to you.

					You are not ever incrementing counter. You should also try and use real time, not this. For example, if you were 
					incrementing counter. When counter becomes 1, it is not 1 second, rather it will be a few milliseconds. You have to ask what the deltaTime si
					
                    WILLS COMMENT2
                    I think you are missing some notes exactly 3 lines above. Also I did what you said but error is still looking
                    for counter. I deleted both. Other error in Debug Log Severity	Code	Description	Project	File	Line
                    Error	CS1503	Argument 1: cannot convert from 'UnityEngine.KeyCode' to 'int'. Not sure.	
                    */
                    timeSinceFired = 0;

                    

					// NOte you have the change the state
					state = GunState.Firing;
                }
                break;
		case GunState.Firing:
			timeSinceFired += Time.deltaTime;

			// Now you have to decide when you want to leave the Firing state and then what is the next state.
			// What you need to do is make what they call a state diagram and make what you think the state diagram is for the gun
			// It is probably something like Idle -> Firing -> Fire -> ??? where ??? depends on the type of gun. This is a simplification
			// Another state transition to think about is Idle -> Firing -> ????? where ????? can be Jam or empty

			// I am making it go back to Idle for now, but this is wrong. This is just so you will be able fire rapidly when you remove the && counter > delayTime above
			state = GunState.Idle;
			break;
		default:
			// This should never happen right now
			break;
		}
	}
}

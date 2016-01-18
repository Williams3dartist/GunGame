using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 1f;

	// Use this for initialization
	void Start () 
	{
	
	}
    /*WILLS COMMENTS
    Why is this called once per frame. Is it because of each 1 frame the bullet moves
    in the translate z position where speed is. I think it goes(x,y,z). Dont know. I think
    im reading it right. I now have to make sure my z position is correct.

	Update is called once per frame because that is a Unity convention. See here
	http://docs.unity3d.com/Manual/ExecutionOrder.html
	https://unity3d.com/learn/tutorials/modules/beginner/scripting/update-and-fixedupdate

	Note the video is a good one. According to this, you should use FixedUpdate

	Also, it is useful to try and google the answer like: unity translate bullet. Here are some links from that search
	http://answers.unity3d.com/questions/409044/spwan-and-shoot-bullet-in-direction-of-shooter.html
	http://answers.unity3d.com/questions/19710/shooting-a-bullet-projectile-properly.html
	http://answers.unity3d.com/questions/712450/2d-bullet-script-to-shoot-in-the-direction-the-cha.html
	*/
	// Update is called once per frame.
	void Update () 
	{
		// This is technically wrong, but we won't worry about it for now. First, this should be in FixedUpdate,
		// Second, you would normally apply some math to calculate the correct distance travelled against delta time
		// Also, this only works because the barrell is going dwon the Z axis. In reality, you'd have a vectory for the speed/delta
		// that way it accounts for the actually X, Y, Z rotation if the gun was pointed in a different direction.
		
	}

	void FixedUpdate()
	{
        // Note that despite what the video says, you typically still use delta time. This is because even though FixedUpdate is supposed
        // to be a fixed amount of time, it is possible the numbers are slightly off.
        transform.Translate(0, 0, speed*Time.deltaTime);
    }
}

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
	*/
	// Update is called once per frame.
	void Update () 
	{
		transform.Translate (0,0,speed);
	}
}

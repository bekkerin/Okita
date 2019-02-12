using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour
{
	public static int numZombies;
	public bool die;
	public GameObject player;
	public float speed = 0.01f;
	//int numZombies; //no longer static
	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("Main Camera");
		numZombies++;
		Debug.Log("Number of Zombies: " + numZombies);
	}
	// Logs number of zombies to the console
	public static void CountZombies()
	{
		Debug.Log(numZombies);
	}

	void Update()
	{
		Vector3 direction = (player.transform.position - transform.position).normalized;

		float distance = (player.transform.position - transform.position).magnitude;

		Vector3 move = transform.position + (direction * speed);// direction is a vector, speed the multiplier
		transform.position = move;

		if (distance < 1f)
		{
			die = true;
		}
		if (die)
		{
			numZombies--;
			Destroy(gameObject);
            // DESTROY IS A FUNCTION BUILT INTO MONOBEHAVIOR. DEFINITION:
            //        // Summary:
            //     Removes a gameobject, component or asset.
            //
            // Parameters:
            //   obj:
            //     The object to destroy.
            //
            //   t:
            //     The optional amount of time to delay before destroying the object.
            //[ExcludeFromDocs]
            //public static void Destroy(Object obj);

}
	}
}

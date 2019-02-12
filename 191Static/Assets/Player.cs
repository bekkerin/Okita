using UnityEngine;
using System.Collections;

// THE STATIC KEYWORD TIES ALL INSTANCES OF THE CLASS - IN THIS CASE ZOMBIES - TOGETHER. THEY ALL USE THE COMMON VARIABLE NUMZOMBIES AND THEY ALL USE THE COMMON FUNCTION COUNTZOMBIES. IN THE PLAYER SCRIPT, THE STATIC ISSUE IS HIDDEN IN THE GETKEY() FUNCTION. IF YOU LOOK AT THE DEFINITION (RIGHT CLICK, GO TO DEFINITION) YOU SEE THE FUNCTION HEADER ublic static bool GetKey(KeyCode key); .
//OF COURSE, WE HAVE MANY KEYS ON THE KEYBOARD. AND OF COURSE, IT IS EASIER TO USE A COMMON FUNCTION GETKEY() FOR ALL KEYS SO YOU DON'T HAVE TO INSTANTIATE A NEW OBJECT FOR EACH KEY.
// IN THIS PROJECT, IT IS PROBABLY A LESS-GOOD EXAMPLE BECAUSE IT IS HIDDEN IN THE DEFINITION AND THE MONOBEHAVIOR CLASS. JUST LOOK AT THE STATIC VARIABLES LIKE DIE AND NUMBZOMBIES, AS WELL AS THE STATIC FUNCTION COUNTZOMBIES() , IN THE ZOMBIE SCRIPT.
// THIS PROJECT JUST DOES NOT RUN VERY WELL. IT SPAWNS THE ZOMBIES (CAPSULES) ALL AT THE SAME LOCATION, NOT SPREAD OUT, AND YOU RUN INTO THEM WHEN YOU START THE PROGRAM. JUST USE THE S KEY TO PULL BACK, AND YOU WILL SEE THEM. 

public class Player : MonoBehaviour
{
	Vector3 pos;
	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
   
		bool WKey = Input.GetKey(KeyCode.W);
		bool SKey = Input.GetKey(KeyCode.S);
		bool AKey = Input.GetKey(KeyCode.A);
		bool DKey = Input.GetKey(KeyCode.D);
		if (WKey)
		{
			pos.z += 0.1f;
		}
		if (SKey)
		{
			pos.z -= 0.1f;
		}
		if (AKey)
		{
			pos.x -= 0.1f;
		}
		if (DKey)
		{
			pos.x += 0.1f;
		}
        gameObject.transform.position = pos;
        //transform.position = pos;

		//add in a check for the A key
		//bool AKey = Input.GetKey(KeyCode.A);
		//if (AKey)
		//{
		//	Debug.Log("AKey");
		//	//calls the static function in Zombie
		//	Zombie.CountZombies();
		//}
		//Input MyInput = new Input();
		//bool AKey = MyInput.GetKey( KeyCode.A );
		//Debug.Log( AKey ); 
	}
}

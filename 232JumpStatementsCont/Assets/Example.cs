using UnityEngine;
using System.Collections;

//THIS SCRIPT SHOWS THE USE OF BREAK AND CONTINUE.
// BREAK IS USED TO 
public class Example : MonoBehaviour
{

	public GameObject[] gos;
	// Use this for initialization
	void Start()
	{
        //WITHIN EACH LOOP, IT CHECKS FOR GREATER THAN 10. 
        print("First we check the break");
        for (int i = 0; i < 20; i++)
		{
			print(i);

			if (i > 10)
			{
				print(i + " is greater than 10!");
				break;// STOPS THIS LOOP COMPLETELY AND DOES NOT GO BACK TO TOP OF FUNCTION
			}

            print("This does not print after the break");
		}

        print("Now we use the continue");
		for (int x = 0; x < 20; x++)
		{
			print(x);

			if (x > 10)
			{
                print(x + " is greater than 10!");
                continue; //RESTARTS THE LOOP FROM THE TOP AND CONTINUES THE FUNCTION AGAIN
			}

            print("this only prints if we don't have continue");
		}

		gos = new GameObject[10]; //WE'LL CREATE TEN CUBES
		for (int i = 0; i < 10; i++)
		{
			GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Vector3 v = new Vector3();
			v.x = Random.Range(-10, 10);
			v.z = Random.Range(-10, 10);
			go.transform.position = v; //PLACE THEM AT RANDOM SPOTS
			go.name = "Cube" + i.ToString();//GIVE THEM EASY NAMES
                
			if (i % 2 == 0) //ADD ZOMBIEDATA ONLY FOR EVEN NUMBERED ZOMBIES/CUBES. RUN THE PROGRAM AND CHECK THE INSPECTOR FOR EVEN AND ODD NUMBERED CUBES!
			{
				go.AddComponent(typeof(ZombieData));
			}
			gos [i] = go;
		}

	}

	// Update is called once per frame
	void Update()
	{
        //CHECK IN THE INSPECTOR IF THE EVEN NUMBERED CUBES HAVE  HITPOINTS

		foreach (GameObject go in gos) // THE GOS ARRAY WAS LOADED AT START()
		{
			ZombieData zd = (ZombieData)go.GetComponent(typeof(ZombieData));
			
			if (zd == null) // IF THE GAMEOBJECT DOES NOT HAVE ZOMBIE DATA
			{
				continue; // GO BACK TO THE TOP; IT'S NOT A ZOMBIE AND DOES NOT GET HITPOINTS
			}

            // PRETEND TO LOSE HITPOINTS
            int lost = Random.Range(1,3);
            zd.hitpoints -= lost;
            print(zd.name + " lost " + lost + " points");

			// IF THE GAMEOBJECT DOES HAVE ZOMBIEDATA
			if (zd.hitpoints > 0)
			{
				break; // DOES NOT NEED TO BE REPLENISHED YET
			}

            
			zd.hitpoints = 10; //REPLENISH HITPOINTS
			print("replenished " + go.name + " with " + zd.hitpoints + " hitpoints");
 		}
	}
}

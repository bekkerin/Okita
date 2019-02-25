using UnityEngine;
using System.Collections;

//THIS IS JUST SOME SIMPLE COVERAGE OF IF STATEMENTS, COMBINED WITH OR +/or AND
public class Example : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		if (false || false)
		{
			print("I won’t print!"); //UNREACHABLE BECAUSE IT IS NEVER TRUE
		}
		
		if (false || false || true)
		{
			print("I will print!");
		}
			      
		if (false || false || false || false || false || false || true)
		{
			print("I will print too!"); //just needs one true to work!
		}
		int enemyHealth = 10;
		int myHealth = 1;
		bool imStronger = myHealth > enemyHealth; // TRUE IF I AM STRONGER

        if (imStronger)
        {
            print("I am stronger");
        }
		
		int enemyBullets = 0;
		int myBullets = 11;
		bool imArmed = myBullets > enemyBullets; // TRUE IF I HAVE MORE BULLETS

        if (imArmed)
        {
            print("I am armed"); //DOES NOT PRINT BECAUSE HE IS NOT ARMED
        }
		
		if (imStronger || imArmed) //IF I AN STRONGER AND I HAVE MORE BULLETS
		{
			print("I am stronger and/or I am armed. I can win!");
		}
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}

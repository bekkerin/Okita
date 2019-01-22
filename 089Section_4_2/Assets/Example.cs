using UnityEngine;
using System.Collections;

/* The best games are finished games
 * 
 * what to code first is determined by what the player does. focus on the hunter movement, then the deer movement, then shooting.
 * 
 * with every step, use printing to the console to check if it works properly. always use primitive shapes (cube, sphere, capsule etc) to test basic interaction. 
 * 
 * input management is first goal. Keyboard, mouse, touch screen, game controller?*/


public class Example : MonoBehaviour {
	//Declare a nested class. this is what the book calls this. Is it not actually declaring objects of the Class type in the Start function?	

        //functions and data members can appear in any order, but it's good practice to declare variables close to where they are used. 
	class MyClass {         //the base class declaration
		public int num; //field or property in the class
        // why does num not show in the inspector??????
		public void PrintNum() {  // method or function member in the class
			Debug.Log( num );
		}
        //num and PrintNum are both public, so accessible from outside
	}

	// Use this for initialization
	void Start () {
        //declare the three objects and assign them a number
		MyClass FirstClass = new MyClass();
        //try to start typing FirstClass. to see dropdown
        //FirstCla
		FirstClass.num = 1; 
		MyClass SecondClass = new MyClass();
		SecondClass.num = 2; 
		MyClass ThirdClass = new MyClass();
		ThirdClass.num = 3;
        // show how you can use all their printnum functions
		FirstClass.PrintNum();
		SecondClass.PrintNum();
		ThirdClass.PrintNum();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

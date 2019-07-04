// this program is not closely connected to the book content. use it to review how we create classes and then multiple instances of it. for now, we'll just use numbers. later on, we can create things like sphere and enemies.
//check the output in the console

using UnityEngine;

public class Example : MonoBehaviour {
	//Declare a nested class	
	class MyClass {
		public int num;
		public void PrintNum() {
			Debug.Log( num );
		}
	}

	// Use this for initialization
	void Start () {
		MyClass FirstClass = new MyClass();
		FirstClass.num = 1;
		MyClass SecondClass = new MyClass();
		SecondClass.num = 2;
		MyClass ThirdClass = new MyClass();
		ThirdClass.num = 3;
		FirstClass.PrintNum();
		SecondClass.PrintNum();
		ThirdClass.PrintNum();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

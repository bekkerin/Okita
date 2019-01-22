using UnityEngine;
using System.Collections;
using System.IO;


public class FirstExample : MonoBehaviour
{
		class MyClass
		{
				public int num = 0;
				public void PrintNum ()
				{
						Debug.Log (num);
				}
		}
		class AnotherClass
		{
				public int anotherNum = 1;
				public void PrintNum ()
				{
						Debug.Log (anotherNum);
				}
		}
		void SimpleFunction ()
		{
				Debug.Log ("simple function is being called");
		}

		// Use this for initialization
		void Start ()
		{
				StreamWriter writer = new StreamWriter ("MyFile.txt");
				writer.WriteLine ("im a new text file.");
				writer.Flush ();
				Debug.Log ("Start");
				SimpleFunction (); // message that simplefunction is called
				Debug.Log ("int:" + 10 / 3); // as int
				Debug.Log ("float:" + 10.0f / 3.0f); // as float
				Debug.Log ("double:" + 10.0 / 3.0); // as double
                Debug.Log ("too big for float:" + 10000000.0f / 3.0f); // too big to show decimals		
                Debug.Log ("not too big for float:" + 100000.0f / 3.0f); // too big to show decimals

                Debug.Log("large double: " + 1000000000000000.0 / 3.0);
                Debug.Log("small double: " + 10000000000000.0 / 3.0);
                int a = 1 + 3 * 7 + 9; //regular calculation
				Debug.Log (a);
		}


}









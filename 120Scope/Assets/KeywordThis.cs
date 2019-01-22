using UnityEngine;
using System.Collections;

public class KeywordThis : MonoBehaviour
{
		public class MyThis
		{
				float MyFloat = 2.0f;
		
				public void AssignMyFloat (float f)
				{
                    Debug.Log("using float f");
                    MyFloat = f;
				}
		
				public void ShowMyFloat ()
				{
						Debug.Log (MyFloat);
				}
				public void AssignThisMyFloat (float MyFloat)
                // the keyword this is only necessary when you have a class variable with the same name as a parameter of a function in the class.
                {
                    this.MyFloat = MyFloat; //ambiguous MyFloat. is it the class level or the parameter?
                    Debug.Log("using float MyFloat");
                }

    }
		class MyAwkwardClass
		{
				int MyBadlyNamedInt = 0;
				void PoorlyNamedFunction ()
				{
						Debug.Log (this.MyBadlyNamedInt);//refers to class level
						int MyBadlyNamedInt = 7;
						Debug.Log (this.MyBadlyNamedInt);//also refers to class level
				}

		}

		// Use this for initialization
		void Start ()
		{
                Debug.Log("First the Keyword.this file");
                MyThis mt = new MyThis ();
				mt.AssignMyFloat (3.0f); // will it use f or MyFloat?
                mt.ShowMyFloat();
                mt.AssignThisMyFloat(4.0f);
				mt.ShowMyFloat ();	
		}
}


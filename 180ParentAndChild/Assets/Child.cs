// in this program, parent is based on MonoBehavior. The child in this script is based on/ extends the parent class. The parent can not call the child ability, but the child can call the parent ability.

using System.Collections;
using UnityEngine;

public class Child : Parent
{
	void Start()
	{
		Debug.Log(SomeInt);//someint is public int in PARENT class
		ParentAbility(); //public function in parent class
	}

	public void ChildAbility()
	{
		Debug.Log("public child function called by the parent.");
	}
}

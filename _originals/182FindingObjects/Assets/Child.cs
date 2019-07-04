using System.Collections;
using UnityEngine;

public class Child : Parent
{
    void Start()
    {
        Debug.Log(SomeInt);//someint is public int in PARENT class
                           //ParentAbility(); //public function in parent class
    }

    public void ChildAbility()
    {
        Debug.Log("public child function called by the parent.");
    }
}

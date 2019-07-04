using UnityEngine;
using System.Collections;

public class Parent : MonoBehaviour
{
    public int SomeInt = 456;
    // Use this for initialization
    void Start()
    {
        //ChildAbility();  //try uncommenting this and you see that it produces an error because parents cannot inherit from their children.    Error CS0103  The name 'ChildAbility' does not exist in the current context 


    }

    public void ParentAbility()
    {
        Debug.Log("this is a parent function. see that it is called from the child by going to the console bottom.");
    }
}

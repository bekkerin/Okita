//What happens when a class needs to refer to itself? In most cases, a class can use its own properties and fields and not get confused what variable is being referred to.
//here the class is MyThis. It has two methods to assign a number to MyFloat , and one method to show it. First it assigns it a new number as per the parameter, then it assigns it another parameter.  
// Lesson: try to avoid ambiguous names!
// in myawkwardclass, nothing is printed to the console but look at the warning message on line 41

using UnityEngine;
using System.Collections;

public class KeywordThis : MonoBehaviour
{
    public class MyThis
    {
        float MyFloat = 2.0f;

        public void AssignMyFloat(float f)
        {
            Debug.Log("using float f");
            MyFloat = f; // changes it from 2 to 3
            // now we call ShowMyFloat from Start
        }

        public void ShowMyFloat()
        {
            Debug.Log(MyFloat);
        }
        public void AssignThisMyFloat(float MyFloat)
        // the keyword this is only necessary when you have a class variable with the same name as a parameter of a function in the class.
        {
            this.MyFloat = MyFloat; //ambiguous MyFloat. is it the class level or the parameter?
            Debug.Log("using float MyFloat");
            // now we call ShowMyFloat from Start
        }

    }
    class MyAwkwardClass
    {
        int MyBadlyNamedInt = 0;
        void PoorlyNamedFunction()
        {
            Debug.Log(this.MyBadlyNamedInt);//refers to class level
            int MyBadlyNamedInt = 7;
            Debug.Log(this.MyBadlyNamedInt);//also refers to class level
            //Debug.Log(MyBadlyNamedInt);//this would refer to the int on line 41

        }

    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("First the Keyword.this file");
        MyThis mt = new MyThis();
        mt.ShowMyFloat();
        mt.AssignMyFloat(3.0f); // will it use f or MyFloat?
        mt.ShowMyFloat();
        mt.AssignThisMyFloat(4.0f);// will it use class level MyFloat or parameter MyFloat?
        mt.ShowMyFloat();
    }
}


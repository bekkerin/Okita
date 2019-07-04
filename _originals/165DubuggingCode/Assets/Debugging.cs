//this is just a project showing debugging. Usually, you'll set breakpoints by clicking in the margin and while you advance, use F8 or combinations like Ctrl-F8 to advance

using UnityEngine;
using System.Collections;

public class Debugging : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //int a = 0, b = 0; // keep statements on separate lines for easier debugging
        int a = 0;
        int b = 0;
        Debug.Log(a + b);
        int c = a;
        int d = b;
		
        ArrayList list = new ArrayList(); //lists van have anything in them!
        list.Add(1);
        list.Add("this");
        list.Add(1.0);
        list.Add(1.0f);
        // this list has a bool, a string, a double, and a float

        foreach (object i in list)
        {
            Debug.Log(i);
            int j = (int)i; // convert each data type to an integer here
            Debug.Log(j);
            string s = i as string;
            Debug.Log(s);	// convert each data type to a string here		
        }
        Monster m = new Monster(7); //using the monster class below, initialize a Monster with 7 hitpoints
        Debug.Log(m.MaxHitPoints);

    }
		
    // Update is called once per frame
    void Update()
    {
	
    }
}

public class Monster
{
    public readonly int MaxHitPoints = 10;
    public Monster(int hp)
    {
        this.MaxHitPoints = hp; // notice that there is no  checking of max hitpoints
    }
}

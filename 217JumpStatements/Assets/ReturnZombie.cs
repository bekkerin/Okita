using UnityEngine;
using System.Collections;

//  THERE ARE THREE TYPES OF JUMP STATEMENTS: RETURN, BREAK, CONTINUE. THIS EXAMPLES ONLY COVERS RETURN. BREAK AND CONTINUE COME ON PAGE 232.

// THIS SHOWS THAT FUNCTIONS ARE ABLE TO RETURN SOMETHING, LIKE A ZOMBIE
//THE CAMERA HAS THE RETURNZOMBIE SCRIPT
//THE ZOMBIE CYLINDER HAS THE ZOMBIE SCRIPT ATTACHED.
// KEEP BOTH THE SCENE AND GAME WINDOWS OPEN, SINCE THE DRAWLINE ONLY SHOWS UP IN THE SCENE WHEN WE PLAY, NOT IN THE GAME WINDOW. MOVE THE ZOMBIE WITH THE ASWD KEYS (FPS SCRIPT IMPORTED AND ATTACHED TO ZOMBIE).
// WE NEED TO PUT THE DRAWLINE UNDER BOTH START AND UPDATE, SO THE LINE IS DRAWN FROM THE VERY START(ALTHOUGH ADMITTEDLY, THE FIRST REFRESH IS PRETTY FAST - BUT THERE MAY BE OTHER REASONS WHY WE WANT TO HAVE THE ZOMBIE FOUND FROM THE START).
public class ReturnZombie : MonoBehaviour
{
    int MyAdd(int a, int b) //THIS FUNCTION RETURNS SOMETHING - IT IS NOT VOID
    {
        return a + b;
    }

    // Use this for initialization
    void Start()
	{
        int b = MyAdd(6, 7); //SEND THE FUNCTION 6 AND 7, GET 13 BACK
        print(b);//13 SHOWS IN CONSOLE
        Zombie target = GetZombie(); //LIKEWISE, GETZOMBIE RETURNS SOMETHING - A ZOMBIE GAMEOBJECT
        if (target != null) //IF THE FUNCTION REALLY RETURNED SOMETHING
        {
            //Debug.DrawLine(transform.position, target.transform.position, Color.red, 1f); // DRAW A LINE FROM MYSELF TO THE ZOMBIE CYLINDER.  HAS A START POSITION, AN END POSITION, A COLOR, AND DURATION (AND THREE OTHER OVERLOADS). Color is a property defined in the unityengine class.
        }

    }

    void Update()
    {
        Zombie target = GetZombie(); //WE NEED TO KEEP FINDING IT, BECAUSE IF THE TRANSFORM/POSITION CHANGES, OUR LINE SHOULD FOLLOW THE ZOMBIE
        if (target != null) //IF THE FUNCTION REALLY RETURNED SOMETHING
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.red, 1f); // DRAW A LINE FROM MYSELF TO THE ZOMBIE CYLINDER.  HAS A START POSITION, AN END POSITION, A COLOR, AND DURATION (AND THREE OTHER OVERLOADS). Color is a property defined in the unityengine class.


        }

    }

    // returns a zombie
    Zombie GetZombie()
	{
       return (Zombie)GameObject.FindObjectOfType(typeof(Zombie));

    }

}

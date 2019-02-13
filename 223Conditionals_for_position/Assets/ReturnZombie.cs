using UnityEngine;
using System.Collections;


public class ReturnZombie : MonoBehaviour
{
    void Start()
	{
        Zombie target = GetZombie(); 
        if (target != null) 
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.red, 1f); 
        }

    }

    void Update()
    {
        Zombie target = GetZombie(); 
        if (target != null) 
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.red, 1f);

            //  WE DEFINITELY NEED TO DEFINE THESE BOOLS HERE BECAUSE EACH FRAME THE POSITION CHANGES
            bool isAbove = target.transform.position.y > transform.position.y;
            bool isRight = target.transform.position.x > transform.position.y;
            bool isAboveAndRight = isAbove && isRight;
            bool isAboveAndLeft = isAbove && !isRight;
            bool isBelowAndRight = !isAbove && isRight;
            bool isBelowAndLeft = !isAbove && !isRight;

            if (isAboveAndLeft)
            {
                print("Zombie is above and left");
            }
            else if (isAboveAndRight)
            {
                print("Zombie is above and right");
            }
            else if (isBelowAndLeft)
            {
                print("Zombie is below and left");
            }
            else if (isBelowAndRight)
            {
                print("Zombie is below and right");
            }
            else
            {
                print("RUN FOR YOUR LIFE! THE ZOMBIE IS DIRECTLY IN FRONT OF YOU!");
            }
        }

    }

    // returns a zombie
    Zombie GetZombie()
	{
       return (Zombie)GameObject.FindObjectOfType(typeof(Zombie));

    }

}

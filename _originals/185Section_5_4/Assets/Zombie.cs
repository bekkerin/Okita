using UnityEngine;
using System.Collections;

//ALL THREE CLASSES EXTEND MONOBEHAVIOR AND DO NOT INHERIT FROM EACH OTHER

public class Zombie : MonoBehaviour
{
    public static int numZombies;//see next program for static 
    public bool die;
    public float speed = 0.01f;
    // Use this for initialization
    void Start()
    {
        numZombies++; // start with 1 zombie, update for zombiespawner creates the other three
        Debug.Log("zombie" + numZombies); // check console
    }

    void Update()
    {
        Vector3 direction = (Player.pos - transform.position).normalized; // on scale of 0 to 1
        float distance = (Player.pos - transform.position).magnitude;// on actual scale

        Vector3 move = transform.position + (direction * speed);
        transform.position = move;

        if (distance < 1f)
        {
            die = true;
        }
        if (die)
        {
            numZombies--;
            Destroy(gameObject);
        }
    }

    public static int CountZombies()
    {
        return numZombies;
    }
}

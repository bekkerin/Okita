using UnityEngine;
using System.Collections;

//ALL THREE CLASSES EXTEND MONOBEHAVIOR AND DO NOT INHERIT FROM EACH OTHER
//attach this script to camera so you create the first four zombies


public class ZombieSpawner : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Zombie.numZombies < 4)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);//make a capsule
            go.AddComponent(typeof(Zombie)); // attach the zombie script to make him a zombie
            Vector3 pos = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0); //random positioning l/r 3  and fwd/back 3
            go.transform.position = pos;

        }
    }
}

using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public GameObject ChildObject; 

    class Cat
    {
        public int Paws = 4;
        public void Meow()
        {
            print("Meow");
        }
    }

    class PianoCat : Cat // pianocat is subclass of cat
    {
        public void PlayPiano()
        {
            Debug.Log("playing piano and saying ");
            Meow();//inherited from cat
        }
    }
    //Use this for initialization
    void Start()
    {
        PianoCat famousCat = new PianoCat(); //inherits four paws, can say meow like cat, and can play piano (which regular cat can't
        famousCat.PlayPiano();
        // try typing famousCat. to see dropdown with paws (property) and playpiano / meow (functions). Monodevelop only shows these three, VS also shows all other  properties and functions like gettype().
        
        famousCat.Meow();
        Debug.Log(famousCat.Paws);
        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[]; //array of gameobjects
        foreach (GameObject go in gos) //shows all gameobjects
        {
            Debug.Log(go);
         }
    }




}

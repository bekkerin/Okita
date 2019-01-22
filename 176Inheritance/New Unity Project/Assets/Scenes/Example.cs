using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PianoCat famousCat = new PianoCat();
        famousCat.PlayPiano();
        famousCat.Meow();
        Debug.Log(famousCat.paws);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public class Cat
    {
        public int paws = 4;
        public void Meow()
        {
            Debug.Log("Meow");
        }
    }
    public class PianoCat: Cat
    {
        public void PlayPiano()
        {
            Meow(); // inherited from cat
        }
    }
}

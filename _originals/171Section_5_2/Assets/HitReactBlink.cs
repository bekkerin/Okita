// this project just shows the need for modular programming. "The general practice is for a class to be as small as possible. Once a class grows past a few hundred lines, it’s often time to consider breaking the class into several smaller classes of reusable code." ; " we need to write several short classes and add them to the same GameObject. The same goes for any other programming project. The more modular your code is, the easier it is to create complex behavior by creating different combinations of code." All the scripts here are attached to the main camera. Each represents a distinct behavior - controlling aim, reacting to hits, strength of hit reaction, controlling movement, managing physics, and managing weapons. There is nothing in the scripts themselves. Just remember that nothing happens until you connect a script to a game object. 
using UnityEngine;
using System.Collections;

public class HitReactBlink : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

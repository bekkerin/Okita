using UnityEngine;
using System.Collections;

public class AnotherExample : MonoBehaviour
{
    //OTHER FUNCTIONS BESIDE START AND UPDATE

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

    private void Awake()
    {
        //some code
    }

    private void OnEnable()
    {
        //some code
    }

    private void OnApplicationPause(bool pause)
    {
        //some code
    }

    private void FixedUpdate()
    {
        //some code
    }

    private void LateUpdate()
    {
        //some code
    }

    private void OnDestroy()
    {
        // only works with objects
    }
}

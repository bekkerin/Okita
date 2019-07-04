using UnityEngine;
using System.Collections;

// we have four gameobjects: main camera, light, capsule, and cylinder. the capsule has had the component parent added, the cylinder has had the component child added. We are going to try to find them all or selectively
public class Example : MonoBehaviour
{
    public GameObject ParentObject;
    public GameObject ChildObject;

    //Use this for initialization
    void Start()
    {
        //first all gameobjects
        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[]; //array of gameobjects
        foreach (GameObject go in gos)
        {
            Debug.Log(go);
        }

        Debug.Log("now showing only the parents. of course, the cylinder with the child component is classified as child too since it can use the public parent functions and properties");

        GameObject[] parents = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject parent in parents) // first get all gameobjects
        {
            //Debug.Log(go);//no need to show all four
            Component comp = parent.GetComponent(typeof(Parent));
            if (comp != null)
            {
                //ParentObject = parent;
                Debug.Log(parent);
            }
        }

        Debug.Log("now showing only the children");

        GameObject[] children = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject child in children) // first get all gameobjects
        {
            Component comp = child.GetComponent(typeof(Child));
            if (comp != null)
            {
                //ChildObject = child;
                Debug.Log(child);
            }
        }


    }

}

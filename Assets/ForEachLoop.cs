using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{

    public List<GameObject> obj;//this creates a list of GameObjects that fall under the name obj

    // Start is called before the first frame update
    void Start()
    {
        obj.Add(GameObject.Find("Circle"));//this adds the GameObject in quotes to the list from above
        obj.Add(GameObject.Find("Triangle"));
        obj.Add(GameObject.Find("Square"));
        obj.Add(GameObject.Find("Capsule"));

        foreach (GameObject obj in obj)
        {
            obj.SetActive(false);//this deactivates all the objects in the list without destroying them
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int[5];
    //int[] myIntArray = (12, 68. 465);
    public GameObject[] players;
    
    // Start is called before the first frame update
    void Start()
    {
        myIntArray[0] = 12; //sets the first integer to 12
        myIntArray[1] = 256;//sets the second integer to 256
        players = GameObject.FindGameObjectsWithTag("Player"); //finds all objects with the Player Tag

        foreach (GameObject obj in players)
        {
            Debug.Log("Player");
            Debug.Log(myIntArray[4]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

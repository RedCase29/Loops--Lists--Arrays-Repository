using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (hp > 0)
        {
            Debug.Log("Player has " + hp + " HP left");
            hp--;
        }
        Debug.Log(hp + " hp. Game Over.");
    }
}

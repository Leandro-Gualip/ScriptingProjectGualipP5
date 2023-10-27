using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conventions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object

        /*HELLO!
         * THIS IS TWO LINES!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.x <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

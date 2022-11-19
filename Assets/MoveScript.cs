using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // 1. Get the position
        var intposition = GetComponent<Transform>().position;
        // 2. Increase the value of x by a small amount
        intposition.x = intposition.x + 0.01f;
        // 3. Move the object in an increment defined in step 2
        GetComponent<Transform>().SetPositionAndRotation(intposition,Quaternion.identity);
        

    }
}

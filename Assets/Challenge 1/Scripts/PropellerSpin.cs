using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
     private float propellerrotationSpeed=1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      


      
        // tilt the plane up/down based on up/down arrow keys
       transform.Rotate(Vector3.forward, propellerrotationSpeed * Time.deltaTime*-1);
    }
}

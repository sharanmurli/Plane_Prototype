using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
     public float propellerrotationSpeed;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      


      
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, propellerrotationSpeed * Time.deltaTime*-1);
    }
}

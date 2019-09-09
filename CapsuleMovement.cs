using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
           transform.position = new Vector3(0, 7 * Mathf.Cos(Time.time), 20 * Mathf.Sin(Time.time));

        
    }
}

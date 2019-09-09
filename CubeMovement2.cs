using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5 * Mathf.Sin(Time.time), 5 * Mathf.Cos(Time.time), 15 * Mathf.Sin(Time.time));
    }
}

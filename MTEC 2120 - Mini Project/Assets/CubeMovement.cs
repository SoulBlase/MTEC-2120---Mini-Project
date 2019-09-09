using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 1;
    public float smooth = 5.0f;

    public float TiltAngle = 60.0f;
    public 

    int RandomXPositionForCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TiltAroundX = 20.0f * TiltAngle;
        float TiltAroundZ = 20.0f * TiltAngle;
        Quaternion target = Quaternion.Euler(TiltAroundX, 0, TiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        //RotateTheCube();
        
    }

    /*void RotateTheCube()
    {
        
    }*/
}

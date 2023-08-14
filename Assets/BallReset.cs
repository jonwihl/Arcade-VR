using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour

{
    public Vector3 origin;
    public Transform targetObject;
    public Rigidbody rb;
    public Transform backWall;
    public Transform leftWall;
    public Transform rightWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject.position.x < backWall.position.x || targetObject.position.z < leftWall.position.z || targetObject.position.z > rightWall.position.z)
        {
            targetObject.position = origin;
            rb.velocity = Vector3.zero;
        }

    }
}

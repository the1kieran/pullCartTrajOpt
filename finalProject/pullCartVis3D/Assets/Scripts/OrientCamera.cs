using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrientCamera : MonoBehaviour
{

    // Use this for initialization
    public Transform ground;

    void Start()
    {
        transform.position = new Vector3(0, 0, -3);
        Vector3 worldUP = new Vector3(0, 0, 1);
        transform.LookAt(ground, worldUP);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
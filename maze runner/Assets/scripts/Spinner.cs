using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate = 0;
    [SerializeField] float yRotate = 1;
    [SerializeField] float zRotate = 0;
        

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate,yRotate,zRotate);
    }
}

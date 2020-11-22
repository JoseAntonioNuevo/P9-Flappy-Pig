
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedScroll : MonoBehaviour
{
    public float theScrollSpeed = 0.025f;

    public Transform theCamera;

    void Start()
    {
    }

    void Update()
    {
        theCamera.position = new Vector3(theCamera.position.x- theScrollSpeed, theCamera.position.y , theCamera.position.z);
    }
}

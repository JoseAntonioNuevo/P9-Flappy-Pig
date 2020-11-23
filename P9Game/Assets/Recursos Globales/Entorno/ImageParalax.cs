using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageParalax : MonoBehaviour
{
    public float ParallaxFactor = 0f;
    public float velocity;
    public float examine;

    public Transform otraBack;

    public float lenght;
    Camera theCamera;
    Vector3 theDimension;

    Vector3 theStartPosition;

    void Start()
    {
        theCamera = Camera.main;
        theStartPosition = transform.position;

        theDimension = GetComponent<Renderer>().bounds.size;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;



        Vector3 newPos = otraBack.position;
        newPos.x += lenght;

        if(otraBack.position.x < transform.position.x)
            transform.position = newPos;
    }

    void Update()
    {
        Vector3 newPos = this.transform.position * ParallaxFactor;                   // Calculate the position of the object
       // newPos.z = 0;                       // Force Z-axis to zero, since we're in 2D

        newPos.x -=  velocity;

        transform.position = newPos;
        examine = theCamera.WorldToViewportPoint(this.transform.position).x;
        EndlessRepeater();
    }

    void EndlessRepeater()
    {
        Vector3 posRieght = this.transform.position;
        posRieght.x += lenght / 2;
        examine = theCamera.WorldToScreenPoint(posRieght).x;
        if (theCamera.WorldToScreenPoint(posRieght).x < 0 )
        {
            Vector3 newPos = otraBack.position;
            newPos.x +=  otraBack.GetComponent<SpriteRenderer>().bounds.size.x ;

            transform.position = newPos;
        }
    }
}
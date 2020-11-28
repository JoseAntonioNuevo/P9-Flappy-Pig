using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IAEnemy : MonoBehaviour
{
    [SerializeField]
    float health = 100f;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    bool isFloating = false;
    [SerializeField]
    float floatingsSpeed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Floating();
    }

    void Floating()
    {
        
        if (isFloating)
        {
            transform.position = new Vector3(0, Mathf.Sin(Time.time)* floatingsSpeed);
        }

    }
}

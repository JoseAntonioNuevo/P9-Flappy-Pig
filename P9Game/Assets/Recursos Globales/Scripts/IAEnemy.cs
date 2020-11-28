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

    [SerializeField]
    GameObject weapon = null;
    [SerializeField]
    GameObject projectile = null; 
    [SerializeField]
    float projectileSpeed = 1f;

    [SerializeField]
    float maxDelay = 10f;
    [SerializeField]
    float minDelay = 5f;

    [SerializeField]
    float fireDelay = 1f;

    public float time = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Floating();

        time += Time.deltaTime;

        if (time > fireDelay)
        {
            Fire();
            time = 0;
           // fireDelay = Random.Range(minDelay, maxDelay);
        }


    }

    void Floating()
    {
        
        if (isFloating)
        {

            
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time)* floatingsSpeed,-1);
        }

    }

    void Fire()
    {
       GameObject projectileInstance = Instantiate(projectile, weapon.transform.position, Quaternion.identity);

        projectileInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(-projectileSpeed, 0);
        
    }
}

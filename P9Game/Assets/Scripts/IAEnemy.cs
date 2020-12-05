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
    float minDelay = 1f;
    [SerializeField]
    float maxDelay = 3f;

    [SerializeField]
    GameObject[] weapon = null;
    [SerializeField]
    ProjectileData[] projectiles = null;

    float fireDelay= 0;

    public float time = 0;
    public int random = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Floating();
        FireController();
    }

    void Floating()
    {
        
        if (isFloating)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time)* floatingsSpeed);
        }

    }

    void Fire(int idx, int wpn)
    {
        ProjectileData projectileInstance = Instantiate(projectiles[idx], weapon[wpn].transform.position, Quaternion.identity);

        projectileInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(-projectiles[idx].Speed, 0);
        
    }

    void FireController()
    {


        time += Time.deltaTime;

        if (time > fireDelay)
        {
            random = Random.Range(1, 10);
            Debug.Log("entra en +2 y el random es " + random);
            for (int i = 0; i < projectiles.Length; i++)
            {
                if (random >= projectiles[i].MinProbability && random < projectiles[i].MaxProbability)
                {
                    Debug.Log("disparo " +i +" porque el random es " + random);
                    Fire(i, i);
                        
                }
            }

            time = 0;
            fireDelay = Random.Range(minDelay, maxDelay);
        }



      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IARoca : MonoBehaviour
{


    [SerializeField]  
    GameObject explosionVFX = null;

    [SerializeField]
    float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Destroy(gameObject);
            PlayExplosion();
        }
    }

    private void PlayExplosion()
    {
        GameObject explosion = Instantiate(explosionVFX, transform.position, transform.rotation);
        Destroy(explosion, 1f);
    }
}

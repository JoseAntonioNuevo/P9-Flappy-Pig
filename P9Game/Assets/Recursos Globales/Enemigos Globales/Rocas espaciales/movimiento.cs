using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public GameObject meteor;
    public float speed = 1f;
    Transform punteroizq;
    Vector3 localScale;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        meteor = GameObject.Find("Meteorito(Clone)");
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        punteroizq = GameObject.Find("Punteroizq").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > punteroizq.position.x)
        {
            localScale.x = -1;
            transform.localScale = localScale;
            rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);

        }
        else
        {
            Destroy(meteor);
            Destroy(this.gameObject);
        }
    }


}

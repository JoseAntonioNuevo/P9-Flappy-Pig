﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 2f;

    public float hp, maxHP = 120f;
    public Image vida;

    public GameObject disparo;
    Vector2 dispos;
    public float firerate = 0.5f;
    public float nextfire = 0.0f;

    public string nombre = "ricc";
    public int score = 2300;
    public int nivel = 1;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHP;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) transform.Translate(0, -speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) transform.Translate(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.Space) && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            fire();
        }

    }

    public void recibirdano(float amount)
    {
        hp = Mathf.Clamp(hp - amount, 0f, maxHP);
        vida.transform.localScale = new Vector2(hp / maxHP, 1);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Meteorito")
        {
            recibirdano(40);
            Destroy(collision.gameObject);
        }

    }

    void fire()
    {
        dispos = transform.position;
        dispos += new Vector2(2f, 0f);
        Instantiate(disparo, dispos, Quaternion.identity);
    }

    public void SavePlayer()
    {
        SaveLoad.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveLoad.Load();

        nombre = data.nombreprota;
        score = data.scoretotal;
        nivel = data.nivelcarga;

    }

}

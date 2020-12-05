using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileData : MonoBehaviour
{
    [SerializeField]
    string name;
    [SerializeField]
    float damage;
    [SerializeField]
    float speed;

    [SerializeField]
    int minProbability = 1;
    [SerializeField]
    int maxProbability = 10;


    public string Name { get => name; set => name = value; }
    public float Damage { get => damage; set => damage = value; }
    public float Speed { get => speed; set => speed = value; }

    public int MinProbability { get => minProbability; set => minProbability = value; }
    public int MaxProbability { get => maxProbability; set => maxProbability = value; }
}

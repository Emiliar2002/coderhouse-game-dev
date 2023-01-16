using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{

    [SerializeField] private Vector3 size;
    [SerializeField] private float speed = 1;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float health = 5;


    float HealSelf(float healing)
    {
        health += healing;
        return health;
    }

    float DamageSelf(float damage)
    {
        health -= damage;
        return health;
    }

    Vector3 Move(Vector3 newDirection)
    {
        direction = newDirection;
        return direction;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = size;
        Debug.Log(HealSelf(30));
        Debug.Log(DamageSelf(30));
        Debug.Log(Move(new Vector3(1, 1, 1)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed;
    }
}

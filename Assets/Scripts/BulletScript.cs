using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed;
    public int damage;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        //shoot.sfx
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed;
    }
}

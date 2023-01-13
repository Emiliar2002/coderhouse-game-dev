using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 2f;
    public float timeAlive = 0f;
    public float maxTime = 2f;
    public int damage;
    public Vector3 direction = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        //shoot.sfx
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += direction * speed * Time.deltaTime;
        timeAlive += Time.deltaTime;
        if(timeAlive >= maxTime)
        {
            Destroy(gameObject);
        }
    }
}

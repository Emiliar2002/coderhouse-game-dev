using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Mode
{
    Chase,
    LookAt
}

public class ChaseOrLook : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Mode mode = Mode.Chase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case Mode.Chase:
                Vector3 vectorToAya = player.transform.position - transform.position;
                float distanceToPlayer = (vectorToAya).magnitude;
                if (distanceToPlayer > 2f)
                {
                    transform.position += vectorToAya.normalized * 5f * Time.deltaTime;
                }
                break;
            case Mode.LookAt:
                Vector3 vectorToPlayer = player.transform.position - transform.position;
                Quaternion newRotation = Quaternion.LookRotation(vectorToPlayer);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * 10);
                break;
        }
    }
}

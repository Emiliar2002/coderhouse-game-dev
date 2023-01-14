using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    [SerializeField] private KeyCode shootKeyCode = KeyCode.J;
    [SerializeField] private KeyCode shootKeyCode2 = KeyCode.K;
    [SerializeField] private KeyCode shootKeyCode3 = KeyCode.L;
    [SerializeField] private GameObject bulletPrefab;
    private bool shooting = false;



    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode) & Input.GetKeyDown(shootKeyCode2) & Input.GetKeyDown(shootKeyCode3) & !shooting)
        {
            Shoot();
            shooting = true;
        }
        else
        {
            shooting = false;
        }
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
        for (int i = 0; i < 3; i++)
        {
            Instantiate(bulletPrefab, transform, false);
        }
        shooting = true;
    }



}

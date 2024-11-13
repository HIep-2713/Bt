using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Keyboard.current.jKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab,FirePoint.position , transform.rotation);
        }

    }
    
}

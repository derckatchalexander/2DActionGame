using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float dethTime;
    void Start()
    {
        Destroy(gameObject, dethTime);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
   
    public float rotationSpeed = 25.0f;  // Döndürme hýzýný ayarlayýn

    void Update()
    {
        // Öðeyi döndür
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}



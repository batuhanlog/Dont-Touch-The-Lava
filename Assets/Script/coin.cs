using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
   
    public float rotationSpeed = 25.0f;  // D�nd�rme h�z�n� ayarlay�n

    void Update()
    {
        // ��eyi d�nd�r
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}



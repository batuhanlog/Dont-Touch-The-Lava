using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class camera : MonoBehaviour
    {
        public Transform target;  // Bu de�i�ken, takip edilecek ��eyi �Sphere� ��esi i�in bir de�i�ken tan�mlay�n. Bu de�i�ken, camera'n�n hangi ��eyi takip edece�ini belirtmek i�in kullan�lacakt�r.

        void Update()
        {
            // Camera'y� "Sphere" ��esinin pozisyonuna e�itleyin
            transform.position = target.position;
        }
    }


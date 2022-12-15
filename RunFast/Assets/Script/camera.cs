using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class camera : MonoBehaviour
    {
        public Transform target;  // Bu deðiþken, takip edilecek öðeyi “Sphere” öðesi için bir deðiþken tanýmlayýn. Bu deðiþken, camera'nýn hangi öðeyi takip edeceðini belirtmek için kullanýlacaktýr.

        void Update()
        {
            // Camera'yý "Sphere" öðesinin pozisyonuna eþitleyin
            transform.position = target.position;
        }
    }


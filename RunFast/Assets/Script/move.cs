using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class move : MonoBehaviour
{
   
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
        transform.position += movement;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }





void OnCollisionEnter(Collision collision)
    {
        // Zemine deðdiðinde sahneyi baþa sar
        if (collision.gameObject.name == "Plane")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

   

    public int score = 0;  // Puan deðiþkenini tanýmlayýn
    public Text scoreText;  // "Text" öðesi için bir deðiþken tanýmlayýn
    private Vector3 velocity;
    private bool isGrounded;

    void OnTriggerEnter(Collider other)
    {
        // Eðer "Sphere" bir puan nesnesiyle çarpýþýrsa
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // Puaný 1 artýrýn
            score++;

            // Ekrana puaný yazdýrýn
            scoreText.text = "Coin : " + score;

            Destroy(other.gameObject);

        }
    }
}



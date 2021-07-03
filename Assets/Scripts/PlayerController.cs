using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public Transform target;
    private Vector3 initialPosition;

    public string textValue;
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2> ();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementY, 0.0f, 0.0f);
        rb.AddForce(movement * speed);

        if (target.transform.position.x - transform.position.x <= 8)
        {
            textElement.text = textValue;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            transform.position = initialPosition;
            GetComponent<AudioSource>().Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRed : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = Input.GetAxis("Horizontal2");
        float yVelocity = Input.GetAxis("Vertical2");

        rigidbody2D.velocity = new Vector2(xVelocity, yVelocity) * speed;
    }
}

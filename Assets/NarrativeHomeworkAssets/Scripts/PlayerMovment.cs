using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D _rigRigidbody2D;
    private PlayerDialogue _playerDialogue;
    private float _xVelocity = 0f;
    private float _yVelocity = 0f;
    public float speed = 3;
    public float walkTime;
    private float walkTimer;

    // Start is called before the first frame update
    void Start()
    {
        walkTimer = 0;
        _rigRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;
            //_rigRigidbody2D.velocity = new Vector2(_xVelocity, _yVelocity) * speed; 
        }
    }
}

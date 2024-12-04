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

        _xVelocity = Input.GetAxis("Horizontal");
        _yVelocity = Input.GetAxis("Vertical");


        if(_xVelocity == -1)
        {

            if(walkTimer <= 0)
            {
                transform.position += (Vector3) Vector2.left * 1.2f;
                walkTimer = walkTime;
            }

           walkTimer -= Time.deltaTime;
        }
        
        //_rigRigidbody2D.velocity = new Vector2(_xVelocity, _yVelocity) * speed; 
    }
}

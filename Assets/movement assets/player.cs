using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movementSpeed = 8f;
    public float jumpSpeed = 12f;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //help from codemahal
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }
    // Update is called once per frame
    void FixedUpdate() //updates w the jump mechanics. because fixed update is with physics, i do it here rather than in an update
    {
        Vector3 walkingMovement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //horizontal movement vector
        transform.position += walkingMovement * Time.deltaTime * movementSpeed; //estabilishes the movement
    }
}


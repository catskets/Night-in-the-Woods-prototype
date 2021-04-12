using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement_2 : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(new Vector2(speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(new Vector2(-1 * speed * Time.deltaTime, 0));
        }
        else
        {
            //rb.velocity = Vector2.zero;
        }
    }
}

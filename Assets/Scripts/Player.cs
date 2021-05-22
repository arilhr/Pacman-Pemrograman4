using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D playerRb;
    private Vector2 dest = Vector2.zero;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        dest = transform.position;
    }

    private void Update()
    {
        PlayerControl();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, moveSpeed);
        playerRb.MovePosition(p);
    }

    private void PlayerControl()
    {
        // Check for Input if not moving
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
            if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
            if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;
        }
    }

    bool valid(Vector2 dir)
    {
        // Cast Line from 'next to Pac-Man' to 'Pac-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>() || hit.collider.tag != "Wall");
    }
}

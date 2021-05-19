using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    private int direction = 0; // 1: up, 2: down, 3: right, 4: left
    private Rigidbody2D playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
        Move();
    }

    void Move()
    {
        switch (direction)
        {
            case 1:
                playerRb.velocity = new Vector2(0, moveSpeed * Time.deltaTime * 10);
                break;
            case 2:
                playerRb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime * 10);
                break;
            case 3:
                playerRb.velocity = new Vector2(moveSpeed * Time.deltaTime * 10, 0);
                break;
            case 4:
                playerRb.velocity = new Vector2(-moveSpeed * Time.deltaTime * 10, 0);
                break;
            default:
                break;
        }
            
                
    }

    void PlayerControl()
    {
        if (Input.GetKeyDown(KeyCode.W))
            direction = 1;
        else if (Input.GetKeyDown(KeyCode.S))
            direction = 2;
        else if (Input.GetKeyDown(KeyCode.D))
            direction = 3;
        else if (Input.GetKeyDown(KeyCode.A))
            direction = 4;
    }
}

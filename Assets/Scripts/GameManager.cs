using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int currentFood;
    public Player player;

    private void Start()
    {
        currentFood = GameObject.FindGameObjectsWithTag("Food").Length;
    }

    private void Update()
    {
        CheckWin();
        player.PlayerControl();
    }

    private void FixedUpdate()
    {
        player.Move();
    }

    private void CheckWin()
    {
        if (currentFood <= 0)
        {
            Debug.Log("Win");
        }
    }

    private void GameLose()
    {

    }

    public static void DecreaseFood()
    {
        currentFood--;
        Debug.Log($"Food Remaining: {currentFood}");
    }
}

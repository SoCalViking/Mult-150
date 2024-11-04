using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript purple, pink, orange, green;
    private bool isGameOver = true;
    // Update is called once per frame
    void Update()
    {
        //if all four goals are solved then the game is over
        isGameOver = purple.isSolved && pink.isSolved && orange.isSolved && green.isSolved;
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameM : MonoBehaviour
{
    public int health = 10;
    public int score = 0;
    public Text scoreText;
    public Text healthText;
    public void Score()
    {
        score += 1;
    }
    public void damage()
    {
        health = health - 1;
    }
    void Update()
    {
        if(health <= 0)
        {
            endGame();
        }
        FindObjectOfType<Points>().display(score);
        FindObjectOfType<Health>().display(health);
    }
    public void endGame()
    {
        SceneManager.LoadScene(2);
    }
}

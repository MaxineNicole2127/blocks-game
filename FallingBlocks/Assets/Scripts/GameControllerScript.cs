using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private int score = 0;
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

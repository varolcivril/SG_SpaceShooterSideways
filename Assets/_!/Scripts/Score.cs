using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text txt;
    public int score = 0;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    public void AddToScoreVoid()
    {
        score++;
        PrintScore();
    }

    public void PrintScore()
    {
        txt.text = $"Score: {score}";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;

    public void Setup(int Score)
    {
        gameObject.SetActive(true);
        pointsText.text = Score.ToString() + "POINTS";
    }
}

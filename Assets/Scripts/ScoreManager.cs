using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI txt;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckScore (int pickupvalue)
    {
        score += pickupvalue;
        txt.text="Score: "+score.ToString();
        if (score >= 14)
        {
            txt.text = "You Won";
        }
    }
}

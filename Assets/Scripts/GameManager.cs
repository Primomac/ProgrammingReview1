using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Variables

    public int lives = 3; public TextMeshProUGUI lifeDisplay;
    public float score = 0; public TextMeshProUGUI scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeDisplay.text = "Lives: " + lives;
        scoreDisplay.text = "Score: " + score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour

{
    public Text scoreText;
    public Text waveText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void UpdateWaveText(int wave)
    {
        waveText.text = "Wave " + wave.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    // public TextMeshProUGUI scoreText;
    int score = 0;

    ///To implement singleton behaviour of Score Manager Class
    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        // scoreText.text = score.ToString()+" Kills";    
    }
    ///ShootScript will call this method for each shooted zombie for incrementing score.
    public void addScore(){
        score+=1;
        ///The score will re-render in Unity Game Scene
        scoreText.text = score.ToString()+" Kills";    
    }
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}

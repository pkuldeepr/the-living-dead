using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject shoot;
    public GameObject score;
    public int cs=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUpdate(){
        cs++;
        score.GetComponent<TextMeshProUGUI>().text = cs.ToString() + " Kills";
    }
    public void exit(){
        SceneManager.LoadScene("MainMenu");
    }
}

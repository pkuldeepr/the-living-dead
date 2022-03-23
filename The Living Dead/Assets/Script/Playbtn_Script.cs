using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playbtn_Script : MonoBehaviour
{
    //variable for anchors
    public Sprite musicon;
    public Sprite musicoff;
    public GameObject music; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void playBtn()
    {
        SceneManager.LoadScene("PlayGame");    
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");    
    }
    public void Guns()
    {
        SceneManager.LoadScene("Guns");    
    }
    public void togglemusic()
    {
        if(music.GetComponent<Toggle>().isOn==false)
        {
            music.GetComponent<Image>().sprite=musicoff;
        }
        else{
            music.GetComponent<Image>().sprite=musicon;
        }
    }
}

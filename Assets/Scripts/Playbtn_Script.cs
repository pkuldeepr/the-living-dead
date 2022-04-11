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
    ///After tapping play, Zombie instantiation will start
    public void playBtn()
    {
        SceneManager.LoadScene("PlayGame");    
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");    
    }
    ///To Navigate to Gun Shop screen
    public void Guns()
    {
        SceneManager.LoadScene("Guns");    
    }

    ///To turn on off background music
    public void togglemusic()
    {
        if(music.GetComponent<Toggle>().isOn==false)
        {
            music.GetComponent<Image>().sprite=musicoff;
        }
        else{
            music.GetComponent<Image>().sprite=musicon;
        }
        ///TODO: based on user preferences start stop music 
    }
}

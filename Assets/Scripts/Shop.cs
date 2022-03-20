using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    //variable for anchors
    public Sprite locked;
    public Sprite unlocked;
    public GameObject buy;
    // public GameObject previous;
    // public GameObject Next;
    // private int currentID;
    // private int totalitems;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void back()
    {
        SceneManager.LoadScene("MainMenu");    
    }
    public void bought()
    {
        if(buy.GetComponent<Toggle>().isOn==true)
        {
            buy.GetComponent<Image>().sprite=unlocked;
        }
        else{
            buy.GetComponent<Image>().sprite=locked;
        }
    }
    // public void prev()
    // {
    //     if(currentID > 1)
    //     {
    //         currentID--;
    //     }
    // }
    // public void next()
    // {
    //     if(totalitems > currentID)
    //     {
    //         currentID++;
    //     }
    // }
}

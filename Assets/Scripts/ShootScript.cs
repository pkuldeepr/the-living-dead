using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    ///for smoke animations after destroying a zombie
    public GameObject smoke;
    public GameObject score;
    // public GameObject bullet;

    public int cs=0;
    // public int bullets = 15;
    
    public void Shoot(){
        // BulletUpdate();
        RaycastHit hit;
        ///Physics Raycast Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if(hit.transform.name == "Zombie1(Clone)" || hit.transform.name == "Zombie2(Clone)" || hit.transform.name == "Zombie3(Clone)"){
                Destroy(hit.transform.gameObject);  
                ///To increment score 
                ScoreUpdate();             
                Instantiate(smoke,hit.point,Quaternion.LookRotation(hit.normal));
            }
        }
    }

    public void ScoreUpdate(){
        cs++;
        score.GetComponent<TextMeshProUGUI>().text = cs.ToString() + " Kills";
    }

    // public void BulletUpdate(){
    //     bullets--;
    //     if(bullets==0){
    //         SceneManager.LoadScene("GameOver");
    //     }
    //     else{
    //         bullet.GetComponent<TextMeshProUGUI>().text = bullets.ToString() + " Bullets Left";
    //     }
    // }

    public void exit(){
        SceneManager.LoadScene("MainMenu");
    }
    // Start is called before the first frame update
    // void Start()
    // {
    // }
    
    // Update is called once per frame
    // void Update()
    // {
    // }
}

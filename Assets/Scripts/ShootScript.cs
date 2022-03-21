using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    ///for smoke animations after destroying a zombie
    public GameObject smoke;
    
    public void Shoot(){
        RaycastHit hit;
        ///Physics Raycast Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if(hit.transform.name == "Zombie1(Clone)" || hit.transform.name == "Zombie2(Clone)" || hit.transform.name == "Zombie3(Clone)"){
                Destroy(hit.transform.gameObject);  
                ///To increment score 
                ScoreManager.instance.addScore();             
                Instantiate(smoke,hit.point,Quaternion.LookRotation(hit.normal));
            }
        }
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

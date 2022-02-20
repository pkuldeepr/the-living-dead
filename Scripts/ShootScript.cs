using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    
    public void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if(hit.transform.name == "Zombie1(Clone)" || hit.transform.name == "Zombie2(Clone)" || hit.transform.name == "Zombie3(Clone)"){
                Destroy(hit.transform.gameObject);
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

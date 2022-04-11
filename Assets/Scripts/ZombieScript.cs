using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        ///Moves the transform(Zombie) in the direction and distance of translation.
        transform.Translate(Vector3.forward*Time.deltaTime*0.4f);
    }
}

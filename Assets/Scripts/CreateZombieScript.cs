using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateZombieScript : MonoBehaviour
{
    public GameObject[] zombies;
    ///Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCreating());        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    IEnumerator StartCreating(){
        yield return new WaitForSeconds(4);
        for(int i=0;i<3;i++){
            ///This method will start Instantiating zombies as Gameobject at Random position ranging from -1 to 1 on X-axis        
            var position = new Vector3(Random.Range(-1f, 1f), -0.7f, 5);
            // var position = new Vector3(0f, -0.5f, 5);
            ///Quaternion Euler Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis; applied in that order.
            Instantiate(zombies[i],position, Quaternion.Euler(180,0,180));
        }
        StartCoroutine(StartCreating());
    }
}

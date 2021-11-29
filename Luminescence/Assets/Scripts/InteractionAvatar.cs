using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InteractionAvatar : MonoBehaviour
{

    public GameObject Cube;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision InteractionCollision)
    {
        if(InteractionCollision.gameObject.name == "collision")
        {
            Cube.SetActive(true);
            Debug.Log("Hello: " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

}

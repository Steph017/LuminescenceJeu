using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InteractionAvatar : MonoBehaviour
{

    public GameObject lumiereCadeaux;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision InteractionCollision)
    {
        if(InteractionCollision.gameObject.name == "ZoneCadeau")
        {
            lumiereCadeaux.SetActive(true);
            Debug.Log("Hello: " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPersonnage : MonoBehaviour

{

    public GameObject objetExplosion;

    void OnCollisionEnter(Collision infoCollision) // le type de la variable est Collision
    {
       

        if (infoCollision.gameObject.name == "Avatar3")
        {
            objetExplosion.SetActive(true);
            
        }
    }

}

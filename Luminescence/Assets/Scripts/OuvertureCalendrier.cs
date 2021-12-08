using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCalendrier : MonoBehaviour

{

    

    void OnCollisionEnter(Collision infoCollision) // le type de la variable est Collision
    {
        

        if (infoCollision.gameObject.name == "ZONE1")
        {
            Debug.Log(infoCollision.gameObject.name);

        }
    }

}
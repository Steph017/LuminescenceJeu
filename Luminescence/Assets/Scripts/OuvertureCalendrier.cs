using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCalendrier : MonoBehaviour

{

    public GameObject objetExplosion;

    void OnCollisionEnter(Collision infoCollision) // le type de la variable est Collision
    {
        Debug.Log(infoCollision.gameObject.name);

        if (infoCollision.gameObject.name == "RightHand Controller")
        {
            objetExplosion.SetActive(true);

        }
    }

}
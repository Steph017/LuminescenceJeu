using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureCalendrier : MonoBehaviour
{
    [SerializeField] private Animator MyAnimation;
    public AudioClip Bell;
    

    void OnTriggerEnter(Collider OuverturePorte) // le type de la variable est Collider
    {
        if (OuverturePorte.CompareTag("Player"))
        {
            MyAnimation.SetBool("Ouverture", true);
            AudioSource.PlayClipAtPoint(Bell, transform.position, 1);
            
        }
        
      
    }


}
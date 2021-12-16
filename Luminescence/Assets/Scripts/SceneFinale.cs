using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFinale : MonoBehaviour
{

    public bool Mitaine = false;
    public GameObject MitaineObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "mitaine")
        {
            Mitaine = true;
            Destroy(MitaineObject);
            Debug.Log("mitaine");
        }

        if (other.CompareTag("25") && Mitaine == true)
        {
            Debug.Log("Trajet fini");
            Invoke("ChangementScene", 2f);

        }

    }

    public void ChangementScene()
    {
        SceneManager.LoadScene("FIN");
    }
}


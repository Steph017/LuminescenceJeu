using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementSceneDebut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangementScene", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangementScene()
    {
        SceneManager.LoadScene("KEVIN");
    }
}

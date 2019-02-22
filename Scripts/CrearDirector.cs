using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrearDirector : MonoBehaviour
{
    
    // Use this for initialization
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Clear Screen");
        }
    }
}
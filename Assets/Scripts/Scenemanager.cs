using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scenemanager : MonoBehaviour {

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
	
}

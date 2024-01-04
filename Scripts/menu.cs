using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    
    public void loadScene(int indexScene)
    {
        
        SceneManager.LoadScene(indexScene);
        
    }

    public void game()
    {
        

        SceneManager.LoadScene(1);
        

    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("sair");
    }

    

    public void closeaGameOve()
    {
        SceneManager.LoadScene("Start");
    }
}

using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class SceneLoader : MonoBehaviour
{
    
    public void LoadLandmarkScene()
    {
        UnityEngine.Debug.Log("LoadLandmarkScene button clicked!");
        SceneManager.LoadScene("LandmarkScene"); // Load the scene by its name
    }

    // Might add more scene loading methods here as needed
    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}
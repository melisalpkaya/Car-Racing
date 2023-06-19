using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrackController : MonoBehaviour
{
     public void Scene1() {  
        SceneManager.LoadScene("Night");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene("Day");  
    }  
    
}

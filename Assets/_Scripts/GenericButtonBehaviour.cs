﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
GAME2014-Assign1-CG    GenericButtonBehaviour.cs
Author: Cameron Geraats
StudID: 100806837
Last Modified: 04/10/2020
Description: Button Changes Scene
 
 */

public class GenericButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    string DestinationSceneName;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    public void OnButtonPressed()
    {
        //SoundManager.PlaySound("menu_1");

        //StartCoroutine("LoadScene");
        SceneManager.LoadScene(DestinationSceneName);
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(DestinationSceneName);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMethod : MonoBehaviour
{
    [SerializeField] GameObject Asobikata;
    public void PlayMethodButton()
    {
        Asobikata.SetActive(true);
    }
    public void ExitButton()
    {
        Asobikata.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

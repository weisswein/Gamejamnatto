using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Asobikataapear : MonoBehaviour
{
    [SerializeField] GameObject Asb;
   public void AsobikataOpen()
    {
        Asb.SetActive(true);
    }
   public void AsobikataClose()
    {
        Asb.SetActive(false);
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

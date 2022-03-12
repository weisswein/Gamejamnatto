using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NattoGohanChanger : MonoBehaviour
{
    public Sprite[] ToppingGohan;
    private Image nattoImage;

    
    // Start is called before the first frame update
    void Start()
    {
        nattoImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NattoGohanChange(int i)
    {
        nattoImage.sprite = ToppingGohan[i];
    }
}

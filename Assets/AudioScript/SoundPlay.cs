using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundPlay : MonoBehaviour
{
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    [SerializeField] AudioSource source3;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip clip3;
    public UseRotateAround Countobj;
    void Update()
    {
     if(Countobj.Cou == 10)
        {
            source1.PlayOneShot(clip2);
        }
     else if(Countobj.Cou == 30)
        {
            source2.PlayOneShot(clip3);
        }
     else if(Countobj.Cou == 1)
        {
            source3.PlayOneShot(clip1);
        }
    }
}

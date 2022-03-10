using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//このスクリプトは、効果音を動かします。
public class SoundPlay : MonoBehaviour
{
    // 音を調整するコンポーネントを取得
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    
    //音源素材を取得
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
  
    public UseRotateAround Countobj;
    void Update()
    {
     if(Countobj.Cou == 10)//10回混ぜたときに、効果音
        {
            source1.PlayOneShot(clip1);
        }
     else if(Countobj.Cou == 30)//30回混ぜたときに、効果音
        {
            source2.PlayOneShot(clip2);
        }
   
    }
}

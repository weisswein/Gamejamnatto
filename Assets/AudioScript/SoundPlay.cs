using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//このスクリプトは、効果音を動かします。
public class SoundPlay : MonoBehaviour
{
    //音が重ならないようにするためフラグ
    private bool clip1flag = false;
    private bool clip2flag = false;

    // 音を調整するコンポーネントを取得
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    
    //音源素材を取得
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
  
    public UseRotateAround Countobj;
    void Update()
    {
     if(Countobj.Cou == 10 && !clip1flag)//10回混ぜたときに、効果音
        {
            source1.PlayOneShot(clip1);
            clip1flag = true;
        }
     else if(Countobj.Cou == 30 && !clip2flag)//30回混ぜたときに、効果音
        {
            source2.PlayOneShot(clip2);
            clip2flag = true;
        }
     else if(Countobj.Cou == 0)//初期状態(混ぜ無し状態)で効果音のフラグを戻す
        {
            clip1flag = false;
            clip2flag = false;
        }
   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;
 
public class SpriteChange : MonoBehaviour
{
   
    int Countnb = 0;
  
    // Image コンポーネントを格納する変数
    private Image m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    public UseRotateAround Countingnt;
 

    // ゲーム開始時に実行する処理
    void Start()
    {
      
     
        // Image コンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();
    }
    

    // ゲーム実行中に毎フレーム実行する処理
    void Update()
    {
        Countnb = Countingnt.Cou;
     
       if (Countnb >= 30)//もし30回以上かき混ぜたら、納豆のイラストが極ネバになる
        {
            m_Image.sprite = m_Sprite[2]; 
           
        }
           else if ((10 <= Countnb) && (Countnb < 30))//10回以上30回未満混ぜたときは、納豆のイラストがちょいネバになる
            { 
              Debug.Log(Countingnt.Cou);
               m_Image.sprite = m_Sprite[1];
            }
       
           
       
        /*if (Input.GetKeyDown(KeyCode.A))//もし30回以上かき混ぜたら、納豆のイラストが極ネバになる
        {
            m_Image.sprite = m_Sprite[2];
        }
        else if (Input.GetKeyDown(KeyCode.Space))//10回以上30回未満混ぜたときは、納豆のイラストがちょいネバになる
        {
            m_Image.sprite = m_Sprite[1];
        }
        */

        


    }
}
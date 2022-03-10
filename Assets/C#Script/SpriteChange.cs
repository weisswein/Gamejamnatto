using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;
 
public class SpriteChange : nattoList
{
   
    int Countnb = 0;
  
    // Image コンポーネントを格納する変数
    private SpriteRenderer m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    public UseRotateAround Countingnt;

    public GameManager gamemanager;
 

    // ゲーム開始時に実行する処理
    void Start()
    {
      
     
        // Sprite Renderコンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<SpriteRenderer>();
    }
    

    // ゲーム実行中に毎フレーム実行する処理
    void Update()
    {
        Countnb = Countingnt.Cou;
     
       if (Countnb >= 30)//もし30回以上かき混ぜたら、納豆のイラストが極ネバになる
        {
            gamemanager.ChooseMaze(Maze.Yokumaze);
            m_Image.sprite = m_Sprite[2]; 
           
        }
           else if ((10 <= Countnb) && (Countnb < 30))//10回以上30回未満混ぜたときは、納豆のイラストがちょいネバになる
            {
            gamemanager.ChooseMaze(Maze.Tyoimaze);
            m_Image.sprite = m_Sprite[1];
            }
        else//10以下は納豆のイラストは混ぜてない状態に
        {
            gamemanager.ChooseMaze(Maze.Mazenasi);
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
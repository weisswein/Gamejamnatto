/*
 バグ内容
画面の端まで箸を持っていけるので、回数が早くなる。

解決策
Mathf.Clamp(value, min, max);でマウスの位置を限定したい
 
 */
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class UseRotateAround : MonoBehaviour //納豆を混ぜるときのプログラム
{
   
     public int Cou = 0;
    float total = 0;
    

   void Start()
    {

    }


   void OnMouseDrag()
    {

        //Spriteの位置をワールド座標からスクリーン座標に変換して、objectPointに格納
        Vector3 objectPoint
            = Camera.main.WorldToScreenPoint(transform.position);
      
        //spriteの基準となる点
        Vector3 AxisPoint
            = Vector3.zero;
        
        //spriteの現在位置(マウス位置)を、pointScreenに格納
        Vector3 pointScreen
            = new Vector3(Input.mousePosition.x,
                          Input.mousePosition.y,
                           objectPoint.z);
       
      

        //spriteの現在位置を、スクリーン座標からワールド座標に変換して、pointWorldに格納
        Vector3 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
         pointWorld.z = AxisPoint.z;


       //動かせる位置を制限
        pointWorld.x = Mathf.Clamp(Camera.main.ScreenToWorldPoint(pointScreen).x, -3, 3);
        pointWorld.y = Mathf.Clamp(Camera.main.ScreenToWorldPoint(pointScreen).y, 0, 4);

             //spriteの位置を、pointWorldにする
             transform.position = pointWorld;
        
        
        //spriteの最初の位置からの距離
        Vector3 Distance = AxisPoint - transform.position;
       
        float length = Mathf.Clamp(Distance.magnitude, 0, 5);
        
            total += length;
       
         if (total >= 500)
          {
             Cou += 1;    //混ぜる回数をカウント
            Debug.Log(Cou);
            total = 0;//合計の値を0に戻す
          }

        
       
    }

    //納豆を混ぜるシーンの終了後に呼ばれる関数
    public void EndMazeScene()
    {
        //カーソルを見えるように
        Cursor.visible = true;

        //混ぜた回数を0に初期化
        Cou = 0;
    }
   
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.visible = false;
        }
        else { Cursor.visible = true; }

    }
}
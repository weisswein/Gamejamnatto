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
        Cursor.lockState = CursorLockMode.Confined;
    }


    /*  Vector3 mazeru(Vector3 a, Vector3 b) 
      { // 混ぜるときの位置制限→円の式　a^2 + b^2 = 25
         c = Math.Pow(a,2);
         b = Math.Pow(b,2);
         c + d == 25 ;
      } */

    // 中心点
    //  [SerializeField] private Vector3 _center = Vector3.zero;

    // 回転軸
    //[SerializeField] private Vector3 _axis = Vector3.up;

    // 円運動周期
    // [SerializeField] private float _period = 2;
   // [SerializeField]
    //private Image imgBase;

  

   void OnMouseDrag()
    {
       
        //Spriteの位置をワールド座標からスクリーン座標に変換して、objectPointに格納
        Vector3 objectPoint
            = Camera.main.WorldToScreenPoint(transform.position);
        //spriteの回転軸となる点
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

             //spriteの位置を、pointWorldにする
             transform.position = pointWorld;

        //spriteの最初の位置からの距離
        Vector3 Distance = AxisPoint - transform.position;
        //Debug.Log(Distance.magnitude);//表示
        float length = Mathf.Clamp(Distance.magnitude, 0, 5);
        
            total += length;
       
         if (total >= 500)
          {
             Cou += 1;    //混ぜる回数をカウント
             
            total = 0;//合計の値を0に戻す
          }


      

        //画面外に混ぜる箸が行ってしまったら、ゲームオーバー
       // if (Distance.magnitude >= 10) SceneManager.LoadScene("GameOverScene") ; 
    }

    private void Update()
    {

      
        // 中心点centerの周りを、軸axisで、period周期で円運動
      /*  transform.RotateAround(
            _center,
            _axis,
            360 / _period * Time.deltaTime
        );*/
    }
}
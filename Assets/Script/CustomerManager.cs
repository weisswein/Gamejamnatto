using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 お客に付けるスクリプト
 乗せて欲しいトッピングやかき混ぜて欲しい回数の情報をここにいれる
 */


public class CustomerManager : nattoList
{
    //求めている納豆の種類を格納
    public Natto likenatto;
    //載せて欲しいトッピングを格納
    public Topping liketopping;

    //求めている混ぜ度合いを格納
    public Maze likemaze;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //完成した納豆が客の求めている納豆と合っているかを判定

    //選択された納豆やトッピング、混ぜ度合いを引数として受ける取る
    public void NattoChecker(Natto natto,Topping topping,Maze maze)
    {
        //求めている種類の納豆か？
        if (natto == likenatto)
        {
            Debug.Log("好きな納豆");
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }

        //求めているトッピングか？
        if (topping == liketopping)
        {
            Debug.Log("好きなトッピング");
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }


        //求めている混ぜ度合か？
        if (maze == likemaze)
        {
            Debug.Log("好きな混ぜ具合");
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }



    }


}

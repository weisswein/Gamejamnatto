using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    public Maze likemaze=Maze.Yokumaze;

    //整合度によってポイントを加算
    private int point = 0;

    private GameManager gamemanager;

    public Text ordertext;

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
    public int NattoChecker(Natto natto,Topping topping,Maze maze)
    {
        point = 0;

        //求めている種類の納豆か？
        if (natto == likenatto)
        {
            point += 100;
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }

        //求めているトッピングか？
        if (topping == liketopping)
        {
            point += 100;
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }


        //求めている混ぜ度合か？
        if (maze == likemaze)
        {
            point += 100;
        }
        else
        {
            Debug.Log("違うそうじゃない");
        }

        return point;
    }

    //GameManagerから求めている納豆やトッピングの情報を受け取る関数
    public void SetStatus(Natto natto, Topping topping, Maze maze)
    {
        likenatto = natto;
        liketopping = topping;
        likemaze = maze;
    }

    //GameManagerの情報を受け取る関数
    public void SetGameManager(GameManager game)
    {
        gamemanager = game;
    }

    //求めている納豆の種類やトッピングから注文のテキストを生成する関数
    public void GenerateText(Natto natto, Topping topping, Maze maze)
    {
        string spell ="";

        //トッピングによるテキストの生成
        foreach (Topping top in Nattotext.Keys)
        {
            if (top == topping)
            {
                spell += Toppingtext[top];
            }
        }

        //混ぜ度合いによるテキストの生成
        foreach (Maze ma in Mazetext.Keys)
        {
            if (ma == maze)
            {
                spell += Mazetext[ma];
            }
        }

        //納豆の種類によるテキスト
        foreach (Natto nat in Nattotext.Keys)
        {
            if (nat == natto)
            {
                spell += Nattotext[nat];
            }
        }

        ordertext.text = spell+"納豆";
    }

}

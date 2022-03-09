using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingButton : nattoList
{
    //このスクリプトが付いているオブジェクトのトッピングの名前
    public Topping topping;

    public GameManager gamemanager;

    //クリックされたボタンのトッピングの名前を取得する関数 (ボタンにアタッチ)
    public void ToppingSelectButton()
    {
        Debug.Log(topping);
        gamemanager.ChooseTopping(topping);
    }
}

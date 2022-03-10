using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NattoButton : nattoList
{
    //このスクリプトが付いているオブジェクトの納豆の種類
    public Natto natto;

    public GameManager gamemanager;



    //クリックされたボタンの納豆の名前を取得する関数 (ボタンにアタッチ)
    public void NattoSelectButton()
    {
        gamemanager.ChooseNatto(natto);

    }

}

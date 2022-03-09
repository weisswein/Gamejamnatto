using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NattoButton : MonoBehaviour
{

    //納豆の種類
    public enum Natto { Kotubu, Ootubu, Hikiwari };

    //このスクリプトが付いているオブジェクトの納豆の種類
    public Natto natto;


    //クリックされたボタンの納豆の名前を取得する関数 (ボタンにアタッチ)
    public void NattoSelectButton()
    {
        Debug.Log(natto);
    }

}

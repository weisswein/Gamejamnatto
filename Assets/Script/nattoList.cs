using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nattoList : MonoBehaviour
{
    //納豆の種類やトッピングの種類を格納するスクリプト

    //納豆の種類
    public enum Natto { None,Kotubu, Ootubu, Hikiwari };

    //トッピングの種類
    public enum Topping { None,Negi, Nori, Cheese };

    //混ぜられた度合い
    public enum Maze { None,Mazenasi,Tyoimaze,Yokumaze};

}

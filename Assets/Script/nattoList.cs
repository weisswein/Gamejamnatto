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

    //納豆の種類とテキストの組み合わせ
    protected Dictionary<Natto, string> Nattotext = new Dictionary<Natto, string>()
    {
        { Natto.Kotubu,"小粒"},
        { Natto.Ootubu,"大粒"},
        { Natto.Hikiwari,"ひきわり"}
    };

    //トッピングとテキストの組み合わせ
    protected Dictionary<Topping, string> Toppingtext = new Dictionary<Topping, string>()
    {
        { Topping.Negi,"ねぎ"},
        { Topping.Nori,"のり"},
        { Topping.Cheese,"チーズ"}
    };

    //トッピングとテキストの組み合わせ
    protected Dictionary<Maze, string> Mazetext = new Dictionary<Maze, string>()
    {
        { Maze.Mazenasi,"混ぜない"},
        { Maze.Tyoimaze,"ちょい混ぜ"},
        { Maze.Yokumaze,"よく混ぜ"}
    };

}

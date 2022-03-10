using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : nattoList
{
    //選択された納豆の種類を格納する変数
    private Natto selectnatto;
    //選択されたトッピングを格納する変数
    private Topping selecttopping;
    //混ぜられた度合いを格納する変数
    private Maze selectmaze;

    //ポイントを溜めていく変数
    [SerializeField] private int score = 0;

    //操作画面を入れる
    //(0:納豆選択画面,1:納豆かき混ぜ画面,2:トッピング選択画面)
    public GameObject[] scenePanel;

    //納豆のボウルを格納する配列
    public GameObject[] nattoBowlList;

    //表示される納豆のボウルの変数
    private GameObject nattobowl;

    private GameManager gamemanager;

    //生成したオブジェクトの親子関係を設定するのに必要
    public GameObject canvas;
    public GameObject MazeScene;

    //かき混ぜるための箸の情報
    public UseRotateAround chopstick;
    //スコアテキストの情報
    public ScoreText scoremanager;

    //生成されたお客のオブジェクトを格納する変数
    private GameObject customer=null;
    //生成するお客さんの情報を格納する変数
    public List<GameObject> customerPrefab;
    private void Awake()
    {
        gamemanager = GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //最初に客を出現
        GenerateCostumer();
    }

    // Update is called once per frame
    void Update()
    {

    }

   //ボタンによって選ばれた納豆を格納する関数
    public void ChooseNatto(Natto natto)
    {
        selectnatto = natto;
        Debug.Log(selectnatto);
    }

    //ボタンによって選ばれたトッピングを格納する関数
    public void ChooseTopping(Topping topping)
    {
        selecttopping = topping;
   
    }

    //かき混ぜた回数によって変わる混ぜ度合いを格納する関数
    public void ChooseMaze(Maze maze)
    {
        selectmaze = maze;
    }

    //お客を生成する関数
    private void GenerateCostumer()
    {
        if (customer == null)
        {
            //客のオブジェクトを生成
            customer = Instantiate(customerPrefab[0]);

            //オブジェクトをcanvas内に移動(これをしないと画像が表示されない)
            customer.transform.SetParent(canvas.transform, false);

            //お客にゲームマネージャーの情報を渡す
            customer.GetComponent<CustomerManager>().SetGameManager(gamemanager);


            //ランダムにトッピングや納豆を決定
            int randomnatto = Random.Range(1, 4);
            int randomtopping = Random.Range(1, 4);//種類を増やしたら数を変更する
            int randomnmaze = Random.Range(1, 4);

            //お客にトッピングや納豆の情報を渡す
            customer.GetComponent<CustomerManager>().SetStatus((Natto)randomnatto, (Topping)randomtopping, (Maze)randomnmaze);
            customer.GetComponent<CustomerManager>().GenerateText((Natto)randomnatto, (Topping)randomtopping, (Maze)randomnmaze);
        }

    }

    //画面遷移を行うボタン(納豆の選択→かき混ぜ→トッピング)
    //(0:納豆の選択,1:かき混ぜ,2:トッピングの選択)
    public void SceneChangeButton(int flag)
    {
        switch (flag)
        {
            case 0:

                //納豆をかき混ぜるボウルの生成
                GenerateNattoBowl();

                //納豆をかき混ぜる画面の表示
                scenePanel[0].SetActive(false);
                scenePanel[1].SetActive(true);
                break;
            case 1:

                //納豆をかき混ぜた後の終了処理を呼ぶ
                chopstick.EndMazeScene();
                //納豆ボウルを破棄
                Destroy(nattobowl);

                //トッピングを選択する画面の表示
                scenePanel[1].SetActive(false);
                scenePanel[2].SetActive(true);
                break;
            case 2:
                //次の客を生成するまでの処理を行う
                EndProcess();
                break;
        }
    }

    //納豆の種類によって納豆をかき混ぜるボウルを生成する
    public void GenerateNattoBowl()
    {
        switch (selectnatto)
        {
            case Natto.Kotubu:
                nattobowl = Instantiate(nattoBowlList[0]);
                break;
            case Natto.Ootubu:
                nattobowl = Instantiate(nattoBowlList[1]);
                break;
            case Natto.Hikiwari:
                nattobowl = Instantiate(nattoBowlList[2]);
                break;

        }

        //nattobowl.transform.position = new Vector3(-960.0f, -540.0f, 0f);
        nattobowl.transform.SetParent(MazeScene.transform);
        nattobowl.GetComponent<SpriteChange>().Countingnt = chopstick;
        nattobowl.GetComponent<SpriteChange>().gamemanager = this.gamemanager;

    }

    private void EndProcess()
    {
        //「求めている納豆を提供できたか？」でスコアを加算する
        score += customer.GetComponent<CustomerManager>().NattoChecker(selectnatto, selecttopping, selectmaze);

        //スコアテキストに反映
        scoremanager.AddScore(score);

        //客を削除
        DeleteCustomer();

        //選択していた納豆、トッピング、混ぜ度合いの情報を初期化
        selectnatto = Natto.None;
        selecttopping = Topping.None;
        selectmaze = Maze.None;

        //次の客を生成する
        GenerateCostumer();

        //納豆を選択する画面の表示
        scenePanel[2].SetActive(false);
        scenePanel[0].SetActive(true);
    }
    //使い終わった客を破棄する関数
    private void DeleteCustomer()
    {
        Destroy(customer);
        customer = null;
    }

}

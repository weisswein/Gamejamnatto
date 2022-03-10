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

    private GameManager gamemanager;
    public GameObject canvas;

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

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateCostumer();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            score+=customer.GetComponent<CustomerManager>().NattoChecker(selectnatto,selecttopping,selectmaze);
            DeleteCustomer();
        }
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
        Debug.Log(selectmaze);
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
        }

    }

    //使い終わった客を破棄する関数
    private void DeleteCustomer()
    {
        Destroy(customer);
        customer = null;
    }

    




}

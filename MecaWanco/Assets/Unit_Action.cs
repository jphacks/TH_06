using UnityEngine;
using System.Collections;

public class Unit_Action : MonoBehaviour {

    //--------------------------------
    public float speed;
    public float jump;

    public LayerMask layer;
    public GameObject bulletP;
    //--------------------------------
    bool isGroundFit = false;
    bool isWallFit = false;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        move();
        Attack();
	}

    //----------------------------------
    //機能：ユニットの移動
    //引数：なし
    //戻値：なし
    //----------------------------------
    void move()
    {
      
        Vector2 move = new Vector2(speed, 0);
        move.x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime * 150;
        move.y = GetComponent<Rigidbody2D>().velocity.y;
        //move *= speed;
        if(isWallFit)
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, move.y);
        else
        GetComponent<Rigidbody2D>().velocity = move;

        ////振り返り
        //if (move.x > 0)
        //{
        //    isRightWallFit = Physics2D.Linecast(
        //     transform.position,
        //     transform.position + new Vector3(0.18f * 2, 0, 0),
        //     wall);
        //}
        //else if (move.x < 0)
        //{
        //    isLeftWallFit = Physics2D.Linecast(
        //      transform.position,
        //      transform.position + new Vector3(-0.18f * 2, 0, 0),
        //      wall);
        //}
       

        //ジャンプ
        isGroundFit = Physics2D.Linecast(
            transform.position,
            transform.position + new Vector3(-0.18f * 2, -0.18f * 2, 0),
            layer);

  
        if (Input.GetButtonDown("Jump") && isGroundFit)
        {
            print("jump!");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(move.x, jump));
        }

    }
    //----------------------------------
    //機能：ユニットの攻撃
    //引数：なし
    //戻値：なし
    //----------------------------------
    void Attack()
    {
        if(Input.GetButtonDown("Fire1"))
        {

        }
    }

    //----------------------------------
    //機能：何かに当たったら呼ばれる関数
    //引数：なし
    //戻値：なし
    //----------------------------------
    void OnCollisionEnter(Collision2D target)
    {
    }
}

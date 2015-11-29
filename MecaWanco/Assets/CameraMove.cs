using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public GameObject Player;
    float spase = 3.0f;

    public GameObject prefab; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //キャラを中心にカメラを移動
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 2, -10);
        
        //画面端まで行ったらストップ
        if (transform.position.x < -28)
        {
            transform.position = new Vector3(-28,Player.transform.position.y+2, -10);
        }
        if (transform.position.x >= 36)
        {
            transform.position = new Vector3(36, Player.transform.position.y+2, -10);
        }

	}

    //----------------------------------
    //機能：ユニットの移動
    //引数：なし
    //戻値：なし
    //----------------------------------
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Wall")
        {

        }
    }

}

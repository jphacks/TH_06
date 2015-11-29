using UnityEngine;
using System.Collections;

public class Nacou : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody2D>().AddForce(this.transform.forward);
	}
	
	// Update is called once per frame
    void Update()
    {

        Destroy(this.gameObject, 1.0f);

    }

    void OncollisionEnter(Collision2D target)
    {

        if (target.gameObject.tag == "Target")
        {
            Destroy(target.gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pos : MonoBehaviour {
    public GameObject com,tup;
	// Use this for initialization
    void Start()
    {

	}
	
	// Update is called once per frame
    void Update()
    {
        com.transform.position = new Vector3(tup.transform.position.x, tup.transform.position.y , -10f);
	}
}

using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour
{

    public AudioSource s;
    public AudioSource sJ;
    // Use this for initialization
    void Start()
    {
        sJ.volume = 0.5f;
        s.Play();
        sJ.Stop();

    }
    public void jump_sound()
    {
        sJ.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
}

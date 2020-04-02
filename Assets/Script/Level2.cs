using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            print("FINISH");
            Destroy(gameObject);
            Application.LoadLevel(5);
            FindObjectOfType<AudioManager>().Play("Finish");
        }
    }
}

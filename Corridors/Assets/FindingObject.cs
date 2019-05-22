using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class FindingObject : MonoBehaviour
{
    public Text myText;
    private int score;

    AudioSource pickUpSound;


    void Start()
    {
        Cursor.visible = false;
        Screen.lockCursor = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "axet")
        {
            pickUpSound = col.GetComponent<AudioSource>();
            pickUpSound.Play();
            Debug.Log("Collision");
            score++;
            Destroy(col.gameObject, 0.4f);
            myText.text = "Axes collected: " + score + "/4";
        }

        if (score == 4 & (SceneManager.GetActiveScene().name == "FinalScene"))
        {
            System.Threading.Thread.Sleep(1000);
            SceneManager.LoadScene("Scene2");
            score = 0;
        }
        else if (score == 4 & (SceneManager.GetActiveScene().name == "Scene2"))
        {
            myText.text = "Game completed!";
        }
    }
}
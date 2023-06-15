using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public int mov;
    public int rot;
    Rigidbody rb;
    private int score=0;
    public Text scoretxt;
    private int counter=0;
    public Text wintxt;
    public Toggle toggle;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * mov);
        rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * rot);
        
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("enemy"))
        {
           other.gameObject.SetActive(false);
            score++;
            counter++;
            scoretxt.text = "Score: " + score;
            if (counter == 19)
            {
                wintxt.enabled = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            print("crash with the wall");
            score--;
            scoretxt.text = "Score: " + score;
        }
    }

    public void ResetScore()
    {
        score = 0;
        scoretxt.text = "Score: " + score;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void SetBallActive()
    {
        gameObject.SetActive(toggle.isOn);
    }
}

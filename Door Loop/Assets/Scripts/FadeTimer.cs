using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTimer : MonoBehaviour
{
    private float countdown = 2f;

    void Update()
    {

        if (countdown > 0)
        {
            countdown -= Time.deltaTime;

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}

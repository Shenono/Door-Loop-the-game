using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;
    public GameObject Golden;
    public GameObject Golden2;
    private bool Active1 = true;
    private bool Active2 = false;
    private bool Active3 = false;
    private bool Active4 = false;
    private bool Gold = false;
    private bool Gold1 = true;
    private bool Box = false;
    private bool Box1 = false;
    private bool Box2 = false;
    private bool Box3 = false;
    private bool Box4 = false;
    private bool Box5 = false;
    private bool Box6 = false;
    private bool Box7 = false;
    private bool Box8 = false;
    private bool Box9 = false;
    private bool Box10 = false;
    private bool Box11 = false;
    private bool Box12 = false;
    private bool Box13 = false;
    private bool Box14 = false;
    private bool Box15 = false;

    void Start()
    {
        Canvas.SetActive(false);
        Canvas1.SetActive(true);
        Canvas2.SetActive(false);
        Canvas3.SetActive(false);
        Canvas4.SetActive(false);
        Golden.SetActive(true);
        Golden2.SetActive(false);
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Canvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Rigidbody rb;
                if (rb = hit.transform.GetComponent<Rigidbody>())
                {
                    Action(hit.transform.gameObject);
                }
            }
        }
    }
    private void Action(GameObject go)
    {
        if (go.CompareTag("Door"))
        {
            if (Active4 == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (Golden2 == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if (go.CompareTag("Nota"))
        {
            Destroy(go);
            Canvas.SetActive(true);
            Time.timeScale = 0f;
        }


        if (go.CompareTag("Box"))
        {
            if (Box == true)
            { 
                go.transform.position -= new Vector3(0, 0, 1);
                Box = false;
            }
            else if (Box == false)
            {
                go.transform.position += new Vector3(0, 0, 1);
                Box = true;
            }
        }
        if (go.CompareTag("Box1"))
        {

            if (Box1 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box1 = false;
            }
            else if (Box1 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box1 = true;
            }
        }
        if (go.CompareTag("Box2"))
        {

            if (Box2 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box2 = false;
            }
            else if (Box2 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box2 = true;
            }
        }
        if (go.CompareTag("Box3"))
        {

            if (Box3 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box3 = false;
            }
            else if (Box3 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box3 = true;
            }
        }
        if (go.CompareTag("Box4"))
        {

            if (Box4 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box4 = false;
            }
            else if (Box4 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box4 = true;
            }
        }
        if (go.CompareTag("Box5"))
        {

            if (Box5 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box5 = false;
            }
            else if (Box5 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box5 = true;
            }
        }
        if (go.CompareTag("Box6"))
        {

            if (Box6 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box6 = false;
            }
            else if (Box6 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box6 = true;
            }
        }
        if (go.CompareTag("Box7"))
        {

            if (Box7 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box7 = false;
            }
            else if (Box7 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box7 = true;
            }
        }
        if (go.CompareTag("Box8"))
        {

            if (Box8 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box8 = false;
            }
            else if (Box8 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box8 = true;
            }
        }
        if (go.CompareTag("Box9"))
        {

            if (Box9 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box9 = false;
            }
            else if (Box9 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box9 = true;
            }
        }
        if (go.CompareTag("Box10"))
        {
            if (Box10 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box10 = false;
            }
            else if (Box10 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box10 = true;
            }
        }
        if (go.CompareTag("Box11"))
        {
            if (Box11 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box11 = false;
            }
            else if (Box11 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box11 = true;
            }
        }
        if (go.CompareTag("Box12"))
        {

            if (Box12 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box12 = false;
            }
            else if (Box12 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box12 = true;
            }
        }
        if (go.CompareTag("Box13"))
        {

            if (Box13 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box13 = false;
            }
            else if (Box13 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box13 = true;
            }
        }
        if (go.CompareTag("Box14"))
        {

            if (Box14 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box14 = false;
            }
            else if (Box14 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box14 = true;
            }
        }
        if (go.CompareTag("Box15"))
        {

            if (Box15 == true)
            {

                go.transform.position -= new Vector3(0, 0, 1);
                Box15 = false;
            }
            else if (Box15 == false)
            {

                go.transform.position += new Vector3(0, 0, 1);
                Box = true;
            }
        }
        if (go.CompareTag("Key"))
        {
            Destroy(go);
            if (Active3 == true)
            {
                Active3 = false;
                Active4 = true;
                Canvas3.SetActive(false);
                Canvas4.SetActive(true);
            }
            if (Active2 == true)
            {
                Active2 = false;
                Active3 = true;
                Canvas2.SetActive(false);
                Canvas3.SetActive(true);
            }
            if (Active1 == true)
            {
                Active1 = false;
                Active2 = true;
                Canvas1.SetActive(false);
                Canvas2.SetActive(true);
            }
        }
        if (go.CompareTag("GoldenKey"))
        {
            Destroy(go);
            if (Gold1 == true)
            {
                Gold1 = false;
                Gold = true;
                Golden.SetActive(false);
                Golden2.SetActive(true);
            }
        }
    }
}

    

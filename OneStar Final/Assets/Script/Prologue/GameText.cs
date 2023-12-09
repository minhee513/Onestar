using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class GameText : MonoBehaviour
{
    public GameObject button;

    public GameObject loguePanel;

    public GameObject gPanel1;
    // public GameObject gPanel2;

    public GameObject cPanel1;
    public GameObject pChat1;

    private void Start()
    {
        button.SetActive(false);

        cPanel1.SetActive(false);
        pChat1.SetActive(false);

        gPanel1.SetActive(false);
        // gPanel2.SetActive(false);
    }

    private void Update()
    {
       StartCoroutine(PanelAppear());
    }

    /*
    public void openProloguePanel()
    {
        button.SetActive(false);
        gPanel1.SetActive(false);
        loguePanel.SetActive(true);
    }
    */

    IEnumerator PanelAppear()
    {
        if (gPanel1 == true)
        {
            yield return new WaitForSeconds(3f);
            cPanel1.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(ChatAppear());
                // StartCoroutine(ButtonAppear());
                // gPanel1.SetActive(false);
                // gPanel2.SetActive(true);
            }
        }
    }

    IEnumerator ChatAppear()
    {
        yield return new WaitForSeconds(2f);
        loguePanel.SetActive(false);
        pChat1.SetActive(true);
    }

    IEnumerator ButtonAppear()
    {
        yield return new WaitForSeconds(3f);
        button.SetActive(true);
    }
}
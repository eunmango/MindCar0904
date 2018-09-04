using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainingController_auto : MonoBehaviour
{
    public GameObject upperText;
    public GameObject CountDown;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    void TurnOff()
    {
        upperText.SetActive(false);
    }

    IEnumerator CountStart()
    {
        Invoke("TurnOff", 4);
        yield return new WaitForSeconds(4);

        yield return new WaitForSeconds(0.5f);
        CountDown.SetActive(true);

        for (int i = 30; i > 0; i--)
        {
            yield return new WaitForSeconds(1);
            CountDown.GetComponent<Text>().text = i.ToString();
        }
        SceneManager.LoadScene("default");

    }
}
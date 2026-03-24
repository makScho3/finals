using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishScript : MonoBehaviour
{
    public GameObject finishText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Finish");

            finishText.SetActive(true);

            Invoke("ResetLevel", 2f);
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

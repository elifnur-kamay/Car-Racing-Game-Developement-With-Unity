using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject finishText;

    void Start()
    {
        if (finishText != null)
        {
            finishText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has crossed the finish line");
            if (finishText != null)
            {
                finishText.SetActive(true);
            }
        }
    }



}

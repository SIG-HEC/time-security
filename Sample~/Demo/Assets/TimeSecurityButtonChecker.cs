using UnityEngine;

public class TimeSecurityButtonChecker : MonoBehaviour
{
    [SerializeField] private DateSO threshold;

    public void OnPressed()
    {
        if (TimeSecurityChecker.IsOutOfTime(threshold))
        {
            Debug.Log("Time is over");
        }
        else
        {
            Debug.Log("Time is not over yet");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherMentor : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject positiveFeedbackPopup;
    public GameObject negativeFeedbackPopup;

    public float popupLifetime;
    public void ShowFeedback(string feedback)
    {
        Debug.Log("ShowPositiveFeedback");
        var popup = Instantiate(positiveFeedbackPopup, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
        Destroy(popup, popupLifetime);
    }

    //public void ShowNegativeFeedback() {
    //    Debug.Log("ShowNegativeFeedback");
    //    var popup = Instantiate(negativeFeedbackPopup, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
    //    Destroy(popup, popupLifetime);
    //}
}

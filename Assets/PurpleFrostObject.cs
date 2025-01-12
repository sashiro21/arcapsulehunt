using UnityEngine;

public class PurpleFrostObject : MonoBehaviour
{
    public int points = 1;
    private timer_script _timerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timerScript = Object.FindFirstObjectByType<timer_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch detected");
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        HandleDestroy(gameObject); // Pop the balloon
                    }
                }
            }
        }
    }

    void OnMouseDown()
    {
        {
            HandleDestroy(gameObject); // Pop the balloon
        }
    }

    private void HandleDestroy(Object gameObject)
    {
        if (gameObject is null)
        {
            throw new System.ArgumentNullException(nameof(gameObject));
        }

        if (_timerScript is not null)
        {
            _timerScript.IncrementScore();
        }

        Destroy(gameObject);
    }
}

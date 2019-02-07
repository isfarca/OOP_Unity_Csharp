using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{
    #region Main function "Start()"

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Start");
	}

    #endregion

    #region Main function "Update()"

    // Update is called once per frame
    void Update ()
    {
        Debug.Log("Update");

        if (Input.GetKeyDown(KeyCode.Space))
            this.enabled = !this.enabled; // disable this Component / MonoBehaviour
	}

    #endregion

    #region System functions

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    #endregion
}
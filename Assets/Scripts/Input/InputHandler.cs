using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public static event Action OnTap;
    private UserInput _userInput;

    private void Awake()
    {
        _userInput = new();
        _userInput.Enable();
    }

    #region Start

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _userInput.MobileTouch.TapTapTap.performed += OnTapPerformed;
    }

    private void OnTapPerformed(InputAction.CallbackContext context)
    {
        OnTap?.Invoke();
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        _userInput.MobileTouch.TapTapTap.performed -= OnTapPerformed;
    }
}

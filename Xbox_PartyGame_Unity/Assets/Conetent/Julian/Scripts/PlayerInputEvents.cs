﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Julian.InputSystem
{
    public class PlayerInputEvents : MonoBehaviour
    {

        public void FireMove(InputAction.CallbackContext context)
        {
            OnMove?.Invoke(context);
        }
        public delegate void MoveAction(InputAction.CallbackContext context);
        public event MoveAction OnMove;

        public void FireButtonSouth(InputAction.CallbackContext context)
        {
            OnButtonSouth?.Invoke(context);
        }
        public delegate void ButtonSouthAction(InputAction.CallbackContext context);
        public event ButtonSouthAction OnButtonSouth;


        public void OnDeviceLost()
        {
            PlayerInputCenter.Instance.FireOnDeviceLost();
        }

        public void OnDeviceRegained()
        {
            PlayerInputCenter.Instance.FireOnDeviceRegained();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
   InputManager inputManager;
   private Player_Locomotion playerLocomotion;

   private void Awake()
   {
      inputManager = GetComponent<InputManager>();
      playerLocomotion = GetComponent<Player_Locomotion>();
   }

   private void Update()
   {
      inputManager.HandleAllInputs();
   }

   private void FixedUpdate()
   {
      playerLocomotion.HandleAllMovement();
   }
}

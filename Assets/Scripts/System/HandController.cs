using Oculus.Interaction;
using Oculus.Interaction.HandPosing.Visuals;
using UnityEngine;

namespace System
{
    public class HandController:MonoBehaviour
    {
        public HandGrabInteractorVisual LeftVisual;
        public HandGrabInteractorVisual RightVisual;

        private void Start()
        {
            LeftVisual.enabled = true;
            RightVisual.enabled = false;
        }

    }
}
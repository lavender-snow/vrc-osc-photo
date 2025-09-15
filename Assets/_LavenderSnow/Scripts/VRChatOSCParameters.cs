using UnityEngine;

namespace OSCPhoto
{
    public enum VRChatOSCParameter
    {
        inputMoveForward,
        inputMoveBackward,
        inputMoveLeft,
        inputMoveRight,
        inputJump,
        userCameraPose
    }

    [System.Serializable]
    public class VRChatOSCParameters
    {
        public bool inputMoveForward = false;
        public bool inputMoveBackward = false;
        public bool inputMoveLeft = false;
        public bool inputMoveRight = false;
        public bool inputJump = false;
        public float[] userCameraPose = new float[6];
    }
}
using extOSC;
using UnityEngine;

namespace OSCPhoto
{
    public class OSCManager : MonoBehaviour
    {
        private OSCTransmitter transmitter;
        private OSCReceiver receiver;

        private VRChatOSCParameters vrcOSCParameters = new VRChatOSCParameters();
        private VRChatOSCParameters previousVrcOSCParameters = new VRChatOSCParameters();

        void Start()
        {
            transmitter = gameObject.GetComponent<OSCTransmitter>();
            receiver = gameObject.AddComponent<OSCReceiver>();
        }

        void Update()
        {
            if (vrcOSCParameters.inputJump != previousVrcOSCParameters.inputJump)
            {
                sendInputJump();
                previousVrcOSCParameters.inputJump = vrcOSCParameters.inputJump;
            }

            if (vrcOSCParameters.inputMoveForward != previousVrcOSCParameters.inputMoveForward)
            {
                sendInputForward();
                previousVrcOSCParameters.inputMoveForward = vrcOSCParameters.inputMoveForward;
            }

            if (vrcOSCParameters.inputMoveBackward != previousVrcOSCParameters.inputMoveBackward)
            {
                sendInputBackward();
                previousVrcOSCParameters.inputMoveBackward = vrcOSCParameters.inputMoveBackward;
            }

            if (vrcOSCParameters.inputMoveLeft != previousVrcOSCParameters.inputMoveLeft)
            {
                sendInputLeft();
                previousVrcOSCParameters.inputMoveLeft = vrcOSCParameters.inputMoveLeft;
            }

            if (vrcOSCParameters.inputMoveRight != previousVrcOSCParameters.inputMoveRight)
            {
                sendInputRight();
                previousVrcOSCParameters.inputMoveRight = vrcOSCParameters.inputMoveRight;
            }
        }

        private void sendInputJump()
        {
            var message = new OSCMessage("/input/Jump");
            message.AddValue(OSCValue.Int(vrcOSCParameters.inputJump ? 1 : 0));
            transmitter.Send(message);
        }

        private void sendInputForward()
        {
            var message = new OSCMessage("/input/MoveForward");
            message.AddValue(OSCValue.Int(vrcOSCParameters.inputMoveForward ? 1 : 0));
            transmitter.Send(message);
        }

        private void sendInputBackward()
        {
            var message = new OSCMessage("/input/MoveBackward");
            message.AddValue(OSCValue.Int(vrcOSCParameters.inputMoveBackward ? 1 : 0));
            transmitter.Send(message);
        }

        private void sendInputLeft()
        {
            var message = new OSCMessage("/input/MoveLeft");
            message.AddValue(OSCValue.Int(vrcOSCParameters.inputMoveLeft ? 1 : 0));
            transmitter.Send(message);
        }

        private void sendInputRight()
        {
            var message = new OSCMessage("/input/MoveRight");
            message.AddValue(OSCValue.Int(vrcOSCParameters.inputMoveRight ? 1 : 0));
            transmitter.Send(message);
        }

        public void SetInputMoveForwardParameter(bool value)
        {
            vrcOSCParameters.inputMoveForward = value;
        }

        public void SetInputMoveBackwardParameter(bool value)
        {
            vrcOSCParameters.inputMoveBackward = value;
        }

        public void SetInputMoveLeftParameter(bool value)
        {
            vrcOSCParameters.inputMoveLeft = value;
        }

        public void SetInputMoveRightParameter(bool value)
        {
            vrcOSCParameters.inputMoveRight = value;
        }

        public void SetInputJumpParameter(bool value)
        {
            vrcOSCParameters.inputJump = value;
        }
    }

}

using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;    

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            
        }
    }
}
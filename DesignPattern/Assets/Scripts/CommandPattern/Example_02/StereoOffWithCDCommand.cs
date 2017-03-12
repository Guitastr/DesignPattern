namespace Assets.Scripts.CommandPattern.Example_02
{
    public class StereoOffWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}
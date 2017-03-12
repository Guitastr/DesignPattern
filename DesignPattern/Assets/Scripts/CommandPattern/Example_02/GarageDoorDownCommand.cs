namespace Assets.Scripts.CommandPattern.Example_02
{
    public class GarageDoorDownCommand : Command
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Off();
        }

        public void Undo()
        {
        }
    }
}
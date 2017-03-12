namespace Assets.Scripts.CommandPattern.Example_02
{
    public class GarageDoorUpCommand : Command
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.On();
        }

        public void Undo()
        {
            
        }
    }
}
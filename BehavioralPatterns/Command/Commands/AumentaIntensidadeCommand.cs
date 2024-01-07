using Commands.Interfaces;
using Commands.Receivers;

namespace Commands.Commands
{
    public class AumentaIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public AumentaIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.AumentarIntensidade();
        }
    }
}

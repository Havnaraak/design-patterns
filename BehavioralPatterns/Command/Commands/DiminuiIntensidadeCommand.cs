

using Commands.Interfaces;
using Commands.Receivers;

namespace Commands.Commands
{
    public class DiminuiIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DiminuiIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DiminuirIntensidade();
        }
    }
}

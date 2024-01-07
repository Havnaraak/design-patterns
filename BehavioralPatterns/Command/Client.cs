using Commands.Commands;
using Commands.Receivers;

namespace Commands
{
    public class Client
    {
        public void FalarComandos()
        {
            var luminaria = new LuzLuminariaReceiver();

            ControleInvoker controle = new ControleInvoker();

            controle.AddCommand("LigaLuz", new LigaLuminariaCommand(luminaria));
            controle.AddCommand("DesligaLuz", new DesligaLuminariaCommand(luminaria));
            controle.AddCommand("AumentaIntensidade", new AumentaIntensidadeCommand(luminaria));
            controle.AddCommand("DiminuiIntensidade", new DiminuiIntensidadeCommand(luminaria));

            controle.ExecuteCommand("LigaLuz");

            //teste
            controle.ExecuteCommand("AumentaIntensidade");
            
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");
            controle.ExecuteCommand("DiminuiIntensidade");

            //teste
            controle.ExecuteCommand("DiminuiIntensidade");

            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");
            controle.ExecuteCommand("AumentaIntensidade");


            controle.ExecuteCommand("DesligaLuz");
        }
    }
}

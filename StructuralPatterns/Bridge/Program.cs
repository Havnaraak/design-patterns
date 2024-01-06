using Bridge;
using Bridge.Abstracao;
using Bridge.Implementacao;

var client = new Client();

client.Material = new CanetaEsferografica();
client.Material.CorImplementacao = new Azul();
client.ConsultarCanetasPinceisNoEstoque();

client.Material = new PincelMarcador();
client.Material.CorImplementacao = new Preto();
client.ConsultarCanetasPinceisNoEstoque();
<h1>Creation Patterns</h1>

## Factory Method
<br/> Pattern utilizada com o objetivo de criar objetos, desacoplando o consumidor do criador do objeto.

Estruturação
<ul>
    <li>Objetos que serão criados herdando da mesma interface | EX : Interface Iservice e objetos MasterService/PremiumService/TraditionalService</li>
    <li>Classe abstrata contendo o método criador do objeto | EX: ServiceFactory</li>
    <li>Classe concreta herdando da classe abstrata e seu(s) método(s) criador(es)| EX: SelectService </li>
    <li>Client que consumirá o(s) método(s) de criação | EX: Client </li>
</ul>


## Abstract Method
<br/>Pattern "baseada" na FactoryMethod, com a grande diferença sendo a criação de uma interface factory abstrata, sendo usada de base para instanciar outras factories.

Ex: 3 factories herdando na mesma interface IFactory, fazendo com que o cliente utilize de base essa interface IFactory para criar os produtos desejados.

-> Var factory do client recebendo instâncias de factorys diferentes.

## Singleton
<br/>Pattern que pode ser usada quando há a necessidade e manter apenas um instância de uma determinada classe para utilização.

Estruturação
<ul>
    <li>É necessário que a classe possua o contrutor privado, não permitido criação de instâncias externamente/li>
    <li>Uma propriedade statica privada e uma publica com get publico e set privado</li>
    <li>Alterar o modificador de acesso Get para que ele valide se a propriedade privada (responsável por manter a instância) já foi instanciada, caso sim, apenas retorna a instancia, caso não, cria uma nova instância e retorna</li>
</ul>

Também pode ser obtido esse resultado através da injeção de dependência, utilizando o método AddSingleton() da propriedade service.

## Builder
<br/>Pattern utilizado para construção de produtos geralmente complexos, utiliza de base um produto para ser construido, um Builder responsável por alimentar os dados do produto e um Director para gerenciar a criação.

Estruturação

<ul>
    <li>Utilizamos de base um produto | EX: Studio24M e Studio26M </li>
    <li>É criado um builder para esse produto, no qual fica responsável por alimentar os dados | EX: Studio24mBuilder e Studio26MBuilder </li>
    <li>O Director irá gerenciar esse(s) builder(s), fazendo com que o client, para criar o produto desejado, realize o mesmo pelo Director.</li>
</ul>
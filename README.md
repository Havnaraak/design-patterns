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
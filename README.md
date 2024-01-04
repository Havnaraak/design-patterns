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
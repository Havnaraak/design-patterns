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

## Prototype
<br/>Pattern também de criação, porém utiliza como base um método de clonagem de um prototipo pré definido.

Estruturação

<ul>
    <li>Utiliza de base uma classe abstrata para que seja usada de base na implementação, com os métodos necessário para a classe + o método clone. | EX: StudioModel </li>
    <li>A classe que heradará a abstração, terá a implementação do método clone, que será responsável por retornar um objeto com a tipagem abstrata | EX Studio</li>
    <li>Terá uma classe manager, responável por armazendar os prototypes (utilizado dictionary no caso) e disponibilizar um clone delas quando necessário | EX: SalesManagerStudio </li>
</ul>


<h1>Structural Patterns</h1>

## Adapter
<br/>Pattern utilizado para desvincular um código legado/biblioteca/dll diretamente do código do sistema, criando um adapter que fará referencia com esse código legado, ficando responsável por interpretar a regra de neǵocio do legado e disponibilizar para o código do sistema. Fazendo com que em caso de alterações no código legado, será necessário alterar apenas o adapter.


## Flyweight
<br/>Pattern utilizado para reduzir consumo de memória em situações que há a necessidade de criar diversos objetos e essa criação ocasione esse alto consumo. É necessário dividir o objeto em 2 partes:
<ul>
    <li>Extrínseca: Parte do objeto que varia de instancia pra instancia, necessário receber por parâmetro | EX: props cor e tamanho</li>
    <li>Intríseco: Parte do objeto que não muda, será compartilhada com todas instancias | EX: props condicao e acao</li>
</ul>

Após separação dos objetos, teremos uma Factory para gerenciar a criação/disponibilização desses objetos, fazendo com que seja criado uma instância quando não existir. 

## Bridge
<br/>Pattern semelhante ao Adapter, será dividido pela abstraçao e implementação, no qual a abstração será responsável por chamar as implementações, disponibilizando para o cliente todas as ações necessárias através da abstração.

## Composite
<br/>Pattern com estrutura hierárquica, dividido em composites e leafs, no composite atua como um delegador.
<ul>
    <li>Composite: O composite é um delegador composto de outro(s) composite(s) e leaf(s)</li>
    <li>Leaf : Elemento base, responsável por executar a operação que foi delegata pelo composite. Não possui sub-elementos</li>
</ul>
<br/>O composite delegará a ação até chegar em um Leaf para executá-la.

## Decorator
<br/>Semelhante ao Composite, porém ao invés de aninhar objetos, o decorator aninha comportamentos.
<br/>Necessário possuir um objeto base, que possui a necessidade de ter seus serviços alterados de acordo com condições.
<br/>EX: Objeto BanhoTosa(base) -> incrementa as alterações de comportamento acessórios e luxospa, fazendo com que os mesmos métodos se comportem diferente.
<br/>Resumo: Decora um objeto e altera apenas o comportamento do objeto.


## Facade
<br/>Pattern utilizado para simplificar um código muito complexo, podendo ser dividido em sub-facades gerenciados por um facadeManager.

## Proxy
<br/>Pattern utilizado para realizar o controle de acesso a objetos. Permitindo fornecer um objeto substituto ao original e exetuar ações antes ou depois da requisição chegar no objeto original. Algumas variações:
<ul>
    <li>Virtual: Controla dados valiosos e sensíveis para utilização ou criação</li>
    <li>Remoto: Controla acesso a servidores remotos</li>
    <li>Proteção: Acessa recursos que necessitam de autenticação/permissão</li>
</ul>

Estruturação:
<ul>
    <li>Interface base</li>
    <li>Objeto concreto implementando interface</li>
    <li>Proxy também implementando a interface</li>
</ul>

<h1>Behavioral Patterns</h1>

## Template Method
<br/>Pattern utilizado para fornecer uma classe abstrata com partes de código fixo, que será compartilhado e utilizado da mesma forma para as classes que herdarem.
Classe ProcessaDados abstrata, com o método ApresentarValores fixo, suas heranças não fazem override no método ApresentarValores, apenas nos outros. 

## Interpreter
<br/>Pattern utilizado para fornecer uma maneira de avaliar a gramática ou a expressão da linguagem, tendo um interpretador de base que recebe um contexto de execução das expressões.

## Observer
<br/>Pattern com escopo em objeto, definindo dependência de um para muitos, com o principal objetivo de notificar e atualizar todas heranças quando o objeto for atualizado.

Estruturação
<ul>
    <li>Interface Subject com lista de observers e métodos de adicionar, remover e notificar</li>
    <li>Interface Observer com o método de update</li>
    <li>Classe implementando as interfaces</li>
</ul>

## Visitor
<br/>Pattern utilizado para criar operações sem a necessidade de alterar o código alvo da operação, permitindo adicionar novas funcionalidades a um objeto pré-existente sem alterá-lo.

Estruturação
<ul>
    <li>Abstração para o Visitor (interface ou classe abstrata)</li>
    <li>Classes implementando a abstração</li>
    <li>Abstração para o Elemento alvo do visitor</li>
    <li>Classes implementando a abstração</li>
</ul>

## Command
<br/>Patter utilizado para encapsular uma solicitação ou comando em um objeto autônomo, podendo ser passado como argumento de método, permitindo parametrizar objetos com diferentes solicitações, enfileirar ou registrar solicitações e implementar recursos de cancelamento.

Estruturação
<ul>
    <li>Interface Command com método de execução do comando</li>
    <li>Classe Invoker, responsável por iniciar a solicitação</li>
    <li>ConcreteCommand implementa as solicitações e passa para o receiver</li>
    <li>Classe Receiver, contém a lógica de negócio que executa a solicitação do command</li>
</ul>

## Strategy
<br/>Pattern utilizado para definir um grupo de algoritmos e colocá-los em classe individuais, separando as responsabilidades. O objeto strategy altera o algoritmo conforme o contexto requisita, em tempo de execução.

Estruturação
<ul>
    <li>Context: insere e executa os strategies</li>
    <li>IStrategy: Interface com o método de execução</li>
    <li>Strategies: Implementam IStrategy e possuem os algoritmos para executar</li>
</ul>


## Chain of Responsibility
<br/>Pattern utilizado para evitar a dependência entre um objeto receptor e um objeto solicitante, fazendo com que seja possível mais de um objeto realizar o tratamento da solicitação.

Estruturação
<ul>
    <li>Abstraçao com método para executar um processamento e um ponteiro para o próximo receiver</li>
    <li>Receivers que implementam a abstração</li>
</ul>

## Iterator
<br/>Pattern utilizado para percorrer elementos de uma coleção, sem expor a estrutura.

Estruturação:
<ul>
    <li>Interface IIterator, com métodos para percorrer</li>
    <li>Interface IAggregate que possui o método para obter o IIterator</li>
    <li>classes implementando as interfaces</li>
</ul>

## Mediator
<br/>Pattern utilizado para encapsular a comunicação entre objetos, fazendo a intermediaçao entre um objeto e outro.

Estruturação
<ul>
    <li>Interface IMediator</li>
    <li>Interface IColleague</li>
    <li>Implementação das interfaces</li>
</ul>

## Memento
<br/>Pattern utilizado para capturar e armazenar o estado de um objeto em um determinado momento, permitindo com que seja restaurado posteriormente sem violar o encapsulamento.

Estruturação:
<ul>
    <li>Originator: Objeto que irá se capturar</li>
    <li>Memento: Armazena o estado do objeto originator (somente setters e readonly)</li>
    <li>Caretaker: Acessa o originator e pode desfazer qualquer mudança efetuada se necessário. Responsável por armazenar todos os Mementos, recuperados de maneira LIFO (Last In First Out)</li>
</ul>

## State
<br/>Pattern utilizado quando o comportamento do objeto muda dependendo do seu estado, permitindo com que esse comportamento seja alterado de acordo com o estado.

Estruturação
<ul>
    <li>Context: Armazendo uma referencia a um dos objetos de estado e delega o trabalho para ele</li>
    <li>IState: Contem os métodos do estado</li>
    <li>ConcreteStates: Fornece as implementações referente ao seu estado.</li>
</ul>
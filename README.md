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

# Boas-vindas ao repositório do Exercício `Contador de Caracteres` 

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project/exercise-character-counter`.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project/exercise-character-counter`

  2. Instale as dependências

  - `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project/exercise-character-counter`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto character counter'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa:  _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project/exercise-character-counter`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project/exercise-character-counter`/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project/exercise-character-counter`/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre, após um (ou alguns) `commits` de atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `main.yml`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Olá, Tryber! Uma fábrica de software está com um projeto em mente para facilitar a vida de pessoas desenvolvedoras e até mesmo de pessoas que não são da área. 

Se trata de um sistema que calcula quantos caracteres têm em determinado texto. 

Por exemplo no texto `O Rato Roeu a Roupa do Rei de Roma` há 34 caracteres. Ou seja, caso seja passado esse valor por input, o valor 34 tem que ser retornado. 

Essa abordagem pode ser muito útil no nosso dia a dia como pessoa desenvolvedora, principalmente quando estamos lidando com base de dados e queremos verificar quantos caracteres determinado texto possui para definir o tamanho de um campo ou até mesmo para realizar validações em um front-end. 

Dessa forma, esse cliente teve a ideia desse sistema e para isso precisamos de sua ajuda!
 
## 1 - Criar a função `Action()` da classe `CharacterCounter`

<details>
  <summary>Essa função vai ser a base do sistema!</summary><br />

Essa função vai ser o *core* do sistema, ou seja, a regra de negócio vai estar armazenada nela. 

A ideia é caso seja passado como parâmetro uma string, como por exemplo: `Isso é um texto`, tem que ser retornado o valor inteiro `15`. Dessa forma, correspondendo ao tamanho do texto mencionado no exemplo.

</details>

<details>
  <summary>Crie o teste unitário para a função <code>Action()</code></summary><br />

Utilizando xUnit + FluentAssertions, realize testes unitários para se certificar que a função está retornando o número correto referente à quantidade de caracteres passada nos casos de teste.

Por exemplo, se o texto passado em input for `Eu sou uma pessoa desenvolvedora formada na Trybe`, o retorno tem que ser: `49`.

</details>

## 2 - Lidar com exceções 

<details>
  <summary>Vamos pensar nas possibilidades excepcionais?!</summary><br />

Estava aqui pensando, se na função `Action()` da classe `CharacterCounter`, o parâmetro `text` chegar `null`? Segue os requisitos e ações a realizar:

- Lance e capture uma exceção do tipo `NullReferenceException` com a mensagem `Valor de texto inválido`.

- Manipule a exceção dando um console na mensagem da exceção capturada e relance a exceção para o fluxo de controle de chamada da função.

</details>

<details>
  <summary>Crie o teste unitário para verficar o lançamento de exeções</summary><br />

Para testar o funcionamento do lançamento de exceção, utilize os testes unitários. Caso o valor passado em `text` for nulo, a exceção do tipo `NullReferenceException` tem que ser lançada. 

</details>

## 3 - Analisar performance da função (Extra não avaliativo)

<details>
  <summary>Vamos mensurar quanto tempo a função Action() da classe CharacterCounter está demorando para ser executada até o seu final</summary><br />

Para análise de performance da função utilize um watch no início da função, seguindo o código:

`var watch = Stopwatch.StartNew();`

Adicione a referência na classe: 

`using System.Diagnostics;`

Dessa forma é possível mensurar seu tempo.

Para obter o resultado da métrica do tempo em Milissegundo utilize:

`watch.ElapsedMilliseconds`

Não esqueça de escrever esse valor no console. E independentemente de ser causada exceção ou não, essa informação tem que ser impressa no console no fim da função. Além disso, não esqueça de parar o watch, utilizando o código seguinte:

`watch.Stop();`

Dessa forma é possível mensurar o tempo da função e garantir uma análise da performance de quanto tempo a mesma está demorando para ser executada. 

</details>



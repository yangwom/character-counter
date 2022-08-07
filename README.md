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



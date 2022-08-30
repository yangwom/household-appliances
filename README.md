
 
## 1 - Crie uma classe abstrata `Appliance`

<details>
  <summary>
    A classe `Appliance` deve ser **abstrata**
  </summary>
  <br />
  Utilize o modificador correto para criar uma classe abstrata
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Appliance</code> deve ser possuir as propriedades <code>string Brand</code>, <code>string Model</code> e <code>bool IsOn</code>
  </summary>
  <br />
  As propriedades devem ter getters e setters padrão, e não precisam ser abstratas, pois não iremos alterá-las nas classes herdeiras
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Appliance</code> deve ser possuir um construtor que receba e atribua os valores das propriedades <code>Brand</code> e <code>Model</code> e que receba o valor inicial da propriedade <code>IsOn</code>.
  </summary>
  <br />
  O recebimento inicial do <code>IsOn</code> pode não fazer muito sentido numa situação real, pois nenhum eletrodoméstico vem ligado de fábrica, mas é importante para que consigamos testar o funcionamento correto dessa classe mais pra frente.
  <br /><br />
</details>

---

## 2 - Crie uma interface `ICooker`

Diferentemente da classe `Appliance`, que só pode ser herdada por eletrodomésticos, a interface `ICooker` poderá ser implementada por objetos que não tenham relação entre si, como por exemplo um fogão, uma fogueira e um forno a lenha.

<details>
  <summary>
    A interface <code>ICooker</code> deve designar uma propriedade <code>BoilingTime</code> e uma propriedade <code>MaximumTemperature</code>, a serem utilizadas por classes que a implementarem.
  </summary>
  <br />
  A interface deve ser pública, mas não há necessidade de definir níveis de acesso aos membros definidos na interface, já que eles serão implementados em classes que poderão definir individualmente esse nível de acesso.
  <br /><br />
</details>

<details>
  <summary>
    A interface <code>ICooker</code> deve designar um método <code>void Cook</code> que receba como parâmetro uma <code>string food</code>, a ser implementado por classes que a utilizem.
  </summary>
  <br />
  O método deve receber uma string com o nome da comida a ser cozinhada, o que será repassado às classes que implementarem <code>ICooker</code>, já que os parâmetros fazem parte da assinatura do método.
  <br /><br />
</details>

---

## 3 - Crie uma classe `ElectricStove`

Essa classe representará um fogão cujo funcionamento dependa de energia elétrica.

<details>
  <summary>
    A classe <code>ElectricStove</code> deve ser herdeira de <code>Appliance</code>
  </summary>
  <br />
  Como não definimos nenhum método abstrato, não é necessário fazer nenhum override. Nesse caso, a definição da classe como abstrata foi baseada no fato de que todo elétrodoméstico tem um subtipo, não podendo ser instanciado diretamente.
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>ElectricStove</code> deve ser implementar <code>ICooker</code>
  </summary>
  <br />
  As propriedades e o método de <code>ICooker</code> devem ser implementados diretamente na classe <code>ElectricStove</code>.
  <br /><br />
</details>

<details>
  <summary>
    O construtor de <code>ElectricStove</code> deve receber os valores de <code>Brand</code>, <code>Model</code>, <code>BoilingTime</code>, <code>MaximumTemperature</code> e <code>IsOn</code> e deve repassar os valores relevantes para o construtor da classe base.
  </summary>
  <br />
  As propriedades que são utilizadas no construtor de <code>Appliance</code> devem ser repassadas para serem corretamente atribuídas.
  <br /><br />
  <blockquote>
    <strong>Se liga na dica ✏️:</strong> O valor de <code>IsOn</code> pode ser um parâmetro default com o valor <code>false</code>, já que esse é o comportamento inicial padrão de um fogão.
  </blockquote>
  <br /><br />
</details>

<details>
  <summary>
    O método <code>Cook</code> deve ter uma validação condicional que lançará uma exceção caso o valor de IsOn esteja como falso, e imprima uma mensagem relevante no console caso seja verdadeiro.
  </summary>
  <br />
  Isso irá impedir que o método funcione quando o fogão estiver desligado. Insira também uma mensagem na exceção detalhando o que aconteceu de errado, isso irá ajudar a debugar o código no futuro caso seja necesssário!
  <br /><br />
</details>

<details>
  <summary>
    Implemente um método <code>Bake</code>, que deve funcionar de maneira parecida com o <code>Cook</code>, só que com mensagens diferentes ao executar com sucesso ou ao lançar a exceção.
  </summary>
  <br />
  Esse método será o único membro nativo da classe <code>ElectricStove</code>, já que os demais são definidos inicialmente ou em <code>Appliance</code> ou em <code>ICook</code>.
  <br /><br />
</details>

---

## 4 - Crie uma classe `Microwave`

Essa classe representará um aparelho de microondas.

<details>
  <summary>
    A classe <code>Microwave</code> deve ser herdeira de <code>Appliance</code>
  </summary>
  <br />
  Como não definimos nenhum método abstrato, não é necessário fazer nenhum override. Nesse caso, a definição da classe como abstrata foi baseada no fato de que todo elétrodoméstico tem um subtipo, não podendo ser instanciado diretamente.
  <br /><br />
</details>

<details>
  <summary>
    A classe <code>Microwave</code> deve ser implementar <code>ICooker</code>
  </summary>
  <br />
  As propriedades e o método de <code>ICooker</code> devem ser implementados diretamente na classe <code>Microwave</code>.
  <br /><br />
</details>

<details>
  <summary>
    O construtor de <code>Microwave</code> deve receber os valores de <code>Brand</code>, <code>Model</code>, <code>BoilingTime</code>, <code>MaximumTemperature</code> e <code>IsOn</code> e deve repassar os valores relevantes para o construtor da classe base.
  </summary>
  <br />
  As propriedades que são utilizadas no construtor de <code>Appliance</code> devem ser repassadas para serem corretamente atribuídas.
  <br /><br />
  <blockquote>
    <strong>Se liga na dica ✏️:</strong> O valor de <code>IsOn</code> pode ser um parâmetro default com o valor <code>false</code>, já que esse é o comportamento inicial padrão de um microondas.
  </blockquote>
  <br /><br />
</details>

<details>
  <summary>
    O método <code>Cook</code> deve ter uma validação condicional que lançará uma exceção caso o valor de IsOn esteja como falso, e imprima uma mensagem relevante no console caso seja verdadeiro.
  </summary>
  <br />
  Isso irá impedir que o método funcione quando o microondas estiver desligado. Insira também uma mensagem na exceção detalhando o que aconteceu de errado, isso irá ajudar a debugar o código no futuro caso seja necesssário!

   <blockquote>
    <strong>Se liga na dica ✏️:</strong> Não se esqueça que a mensagem será diferente da mensagem do fogão, já que ambos eletrodomésticos funcionam de forms diferentes. Com isso, teremos duas implementações diferentes da mesma mensagem!
  </blockquote>

  <br /><br />
</details>

<details>
  <summary>
    Implemente um método <code>Heat</code>, que deve funcionar de maneira parecida com o <code>Cook</code>, só que com mensagens diferentes ao executar com sucesso ou ao lançar a exceção.
  </summary>
  <br />
  Esse método será o único membro nativo da classe <code>Microwave</code>, já que os demais são definidos inicialmente ou em <code>Appliance</code> ou em <code>ICook</code>.
  <br /><br />
</details>

---

## 5 - Crie testes para as classes concretas criadas nos requisitos anteriores

Em geral, como interfaces e classes abstratas não são entidades instanciáveis e, inclusive, podem não possuir implementação, não há a necessídade de testá-las diretamente, já que as classes que as implementem/herdem serão sempre testadas individualmente.

<details>
  <summary>
    Implemente o teste <code>TestMicrowave</code> presente na classe de teste <code>ApplianceTests</code> para testar a classe do microondas.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>O microondas deve ter o valor inicial de <code>IsOn</code> como falso</li>
    <li>O microondas deve ser da marca passada no <code>InlineData</code></li>
    <li>O microondas deve ser do modelo passado no </code>InlineData</code></li>
    <li>O microondas deve ter o tempo de cocção passado no <code>InlineData</code></li>
    <li>O microondas deve ter a temperatura máxima passada no </code>InlineData</code></li>
    <li>O método <code>SwitchPower()</code> deve inverter corretamente o valor de <code>IsOn</code></li>
    <li>O método <code>cook</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
    <li>O método <code>heat</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
  </ol>
  <br /><br />
</details>

<details>
  <summary>
    Implemente o teste <code>TestElectricStove</code> presente na classe de teste <code>ApplianceTests</code> para testar a classe do fogão.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>O fogão deve ter o valor inicial de <code>IsOn</code> como falso</li>
    <li>O fogão deve ser da marca passada no <code>InlineData</code></li>
    <li>O fogão deve ser do modelo passado no </code>InlineData</code></li>
    <li>O fogão deve ter o tempo de cocção passado no <code>InlineData</code></li>
    <li>O fogão deve ter a temperatura máxima passada no </code>InlineData</code></li>
    <li>O método <code>SwitchPower()</code> deve inverter corretamente o valor de <code>IsOn</code></li>
    <li>O método <code>cook</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
    <li>O método <code>bake</code> deve lançar uma exceção quando <code>IsOn</code> for falso e não lançar quando for verdadeiro</li>
  </ol>
  <br /><br />
</details>

<details>
  <summary>
    Implemente o teste <code>TestPolymorphism</code> presente na classe de teste <code>ApplianceTests</code> para testar a relação de polimorfismo entre as entidades criadas anteriormente.
  </summary>
  <br />
  Esse método deverá testar o seguinte:
  <ol>
    <li>Tanto um fogão quanto um microondas devem ser atribuíveis à classe `Appliance`</li>
    <li>Tanto um fogão quanto um microondas devem ser atribuíveis à interface `ICooker`</li>
  </ol>

  <blockquote>
    <strong>Se liga na dica ✏️:</strong> Sempre que uma classe A é atribuível como uma classe ou interface B, significa que todas as mensagens que B recebe podem ser interpretadas por A, comprovando assim a existência de uma relação polimórfica.
  </blockquote>

  <br /><br />
</details>

---

Agora você já está apto utilizar o polimorfismo no seu dia a dia e a utilizar corretamente as classes abstratas e interfaces, escolhendo sempre a melhor opção de acordo com o contexto no qual estiver trabalhando! #VQV

# Tipos de Dados em C#

Em C#, os tipos de dados são utilizados para declarar variáveis e definir o tipo de valores que essas variáveis podem armazenar. Eles são divididos em duas categorias principais: tipos de valor e tipos de referência.

## 1. Tipos de Valor

Os tipos de valor armazenam dados diretamente e são alocados na pilha de memória. Quando uma variável de tipo de valor é atribuída a outra, uma cópia do valor é feita.

## Tipos Numéricos Inteiros:

- int: Inteiro de 32 bits. Intervalo: -2,147,483,648 a 2,147,483,647.
- long: Inteiro de 64 bits. Intervalo: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
- short: Inteiro de 16 bits. Intervalo: -32,768 a 32,767.
- byte: Inteiro de 8 bits sem sinal. Intervalo: 0 a 255.

## Tipos Numéricos de Ponto Flutuante:

- float: Ponto flutuante de precisão simples de 32 bits.
- double: Ponto flutuante de precisão dupla de 64 bits.
- decimal: Ponto flutuante de alta precisão de 128 bits, geralmente usado para valores monetários.

## Outros Tipos de Valor:

- bool: Representa um valor booleano (true ou false).
- char: Armazena um único caractere Unicode de 16 bits.
- struct: Tipo de dado definido pelo usuário, que pode conter múltiplos tipos de valor.
- enum: Define um conjunto de constantes nomeadas, facilitando a legibilidade do código.

## 2. Tipos de Referência

Os tipos de referência armazenam uma referência para os dados, e não os dados em si. Eles são alocados no heap de memória, e várias variáveis podem apontar para o mesmo objeto.

- string: Tipo de dado imutável que representa uma sequência de caracteres Unicode.
- object: Tipo base para todos os tipos em C#. Pode armazenar qualquer tipo de dado.
- class: Tipo definido pelo usuário que pode conter dados e métodos. Instâncias de classes são alocadas no heap e acessadas por referência.
- interface: Define um contrato que as classes ou structs podem implementar.
- delegate: Representa uma referência a um método. É usado para implementar eventos e métodos de retorno (callbacks).

## 3. Tipos Nulos

- Nullable<T>: Permite que tipos de valor aceitem null. Usado quando você precisa representar a ausência de valor para tipos de valor.

```csharp
int? idade = null
```

## 4. Palavras-chave de Tipos Predefinidos

Em C#, você pode usar palavras-chave predefinidas ou os nomes de tipos da biblioteca base (como System.Int32 em vez de int). Ambas têm o mesmo significado e podem ser usadas de forma intercambiável

```csharp
int idade = 30;
float altura = 1.75f;
bool isAdulto = true;
string nome = "Maria";
```

Esses tipos de dados são fundamentais para a programação em C#, permitindo que você declare e manipule variáveis de forma eficiente.

O **DateTime** em C# é uma estrutura que representa datas e horários. É amplamente utilizado para trabalhar com informações temporais, como armazenar, comparar e calcular datas e horas.

Aqui estão algumas das principais funcionalidades e métodos do DateTime em C#:

## 1. Criação de Instâncias DateTime

Você pode criar uma instância DateTime de várias maneiras:

```csharp
DateTime dataEspecifica = new DateTime(2024, 8, 25, 14, 30, 0);
```

Isso cria um DateTime para 25 de agosto de 2024, às 14:30:00.

Data Atual:

```csharp
DateTime hoje = DateTime.Today;
```

DateTime.Today retorna a data atual com a hora definida como 00:00:00.

Hora Atual:

```csharp
DateTime horaAtual = DateTime.Now.TimeOfDay;
```

TimeOfDay retorna apenas a parte de hora do DateTime.

Data UTC (Tempo Universal Coordenado):

```csharp
DateTime utcNow = DateTime.UtcNow;

```

DateTime.UtcNow retorna a data e hora atuais em UTC.

## 2. Propriedades Comuns

- Year, Month, Day: Acessam o ano, mês e dia da instância.

```csharp
int ano = agora.Year;
int mes = agora.Month;
int dia = agora.Day;
```

- Hour, Minute, Second: Acessam a hora, minuto e segundo

```csharp
int hora = agora.Hour;
int minuto = agora.Minute;
int segundo = agora.Second;
```

- DayOfWeek: Retorna o dia da semana (como um enum).

```csharp
DayOfWeek diaDaSemana = agora.DayOfWeek;
```

DayOfYear: Retorna o dia do ano (de 1 a 365/366).

```csharp
int diaDoAno = agora.DayOfYear;
```

##3. Métodos de Manipulação de DateTime
Adição de Tempo:

AddDays, AddMonths, AddYears: Adicionam dias, meses ou anos a um DateTime.

```csharp
DateTime novaData = agora.AddDays(5);
```

AddHours, AddMinutes, AddSeconds: Adicionam horas, minutos ou segundos.

```csharp
DateTime novaHora = agora.AddHours(2);
```

Subtração de Tempo:

Subtract: Subtrai um intervalo de tempo ou outro DateTime.

```csharp
TimeSpan diferenca = dataEspecifica.Subtract(agora);
```

## 4. Comparação de DateTime

CompareTo: Compara dois DateTime e retorna um valor que indica a relação entre os dois.

```csharp
int resultado = agora.CompareTo(dataEspecifica);
// -1 se 'agora' for anterior a 'dataEspecifica'
// 0 se forem iguais
// 1 se 'agora' for posterior a 'dataEspecifica'
```

Operadores de Comparação: Você pode usar operadores como <, >, <=, >=, ==, e !=.

```csharp
bool isAnterior = agora < dataEspecifica;
```

## 5. Formatação de DateTime

Formatação para String:

```csharp
string formatoCustomizado = agora.ToString("dd/MM/yyyy HH:mm:ss");
```

Conversão Padrão:

```csharp
string formatoPadrao = agora.ToString();
```

Formatação com CultureInfo:

```csharp
string formatoCultural = agora.ToString("d", new CultureInfo("pt-BR"));
```

## 6. Parsing de Strings para DateTime

Parse e TryParse:

```csharp
DateTime dataConvertida = DateTime.Parse("25/08/2024 14:30:00");
bool sucesso = DateTime.TryParse("25/08/2024 14:30:00", out DateTime data);
```

## 7. Intervalos de Tempo com TimeSpan

TimeSpan: Usado para representar um intervalo de tempo.

```csharp
TimeSpan duracao = novaData - agora;
```

## 8. Trabalhando com Zonas Horárias

DateTimeOffset: Uma estrutura que inclui o DateTime e o deslocamento em relação ao UTC.

```csharp
DateTimeOffset zonalDate = DateTimeOffset.Now;
```

Conversão entre fuso horários:

```csharp
TimeZoneInfo fusoHorario = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
DateTime dataConvertida = TimeZoneInfo.ConvertTime(agora, fusoHorario);
```

Com DateTime, você tem controle total sobre a manipulação de datas e horas em C#, facilitando o desenvolvimento de aplicações que lidam com informações temporais.

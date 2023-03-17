// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nomeDoUser = "Welerson"; //Forma preguiçosa de declarar uma variavel (Sem declarar o type)
Console.Write("Olá"); 
Console.Write(nomeDoUser);

//Maneira fora do padrão de declarar uma variavel com Tipagem Dinamica, não muito recomendado...

dynamic cor_favorira = "verde";

Console.WriteLine(cor_favorira);    

cor_favorira = 1231.23f;

Console.WriteLine(cor_favorira); 


//Declarações de variaveis com CONST, Variaveis de CONST não podem ser modificadas, por questões de segurança e garantia de que o código não venha a ser modificado, prejudicando assim o funcionamento do programa/software.


const float PI = 2323.234f;//Impossivel mudar o valor.

Console.WriteLine(PI);










Console.ReadLine(); //mantem o código/programa aberto mesmo depois de finalizar o processo.







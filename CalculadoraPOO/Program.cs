using System;
// definição da classe calculadora
public class Calculadora
{
    //Método para adição
    public double adicao(double num1, double num2)
    { 
        return num1 + num2; 
    }

    public double subtracao (double num1, double num2)
    {
        return num1 - num2;
    }

    public double multipicacao (double num1, double num2)
    {
        return (num1 * num2);
    }

    public double divisao (double num1, double num2)
    {
        if(num2 != 0)
        {
            return num1 / num2; 
        }
        else
        {
            Console.WriteLine("Não pode dividir por zero");
                return double.NaN;
        }
    }

}
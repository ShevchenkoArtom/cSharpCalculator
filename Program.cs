using System;
namespace esli {
    class Program {
        static void Main() {
            float num_1, num_2, result;
            string move;

            Console.Write("Введите первое число: ");
            num_1 = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            num_2 = float.Parse(Console.ReadLine());
            Console.Write("Что нужно сделать? +, -, *, /: ");
            move = Console.ReadLine();
            if(move == "+"){
                result = num_1 + num_2;
                Console.WriteLine(result);
            } else if(move == "-"){
                result = num_1 - num_2;
                Console.WriteLine(result);
            } else if(move == "*") {
                result = num_1 * num_2;
                Console.WriteLine(result);
            } else if(move == "/" && num_2 != 0){
                result = num_1 / num_2;
                Console.WriteLine(result);
            } else if(move == "/" && num_2 == 0){
                Console.WriteLine("На ноль делить нельзя, попробуйте снова");
            } else {
                Console.WriteLine("Вы сделали что-то неправильно, попробуйте снова.");
            }
            

        }
    }
}
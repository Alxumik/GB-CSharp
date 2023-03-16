Console.Write("Представьтесь, пожалуйста: ");
string username = Console.ReadLine();
if(username.ToLower() == "маня"){
    Console.WriteLine("Я Вас категорически приветствую!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

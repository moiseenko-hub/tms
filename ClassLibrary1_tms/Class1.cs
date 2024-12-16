namespace ClassLibrary1_tms;

public class Class1
{
    /*
     * Задание 1: Вывод ФИО и даты рождения  - базовое задание, без использовния библиотек
       Описание:
       Напишите программу, которая запрашивает у пользователя его ФИО и дату рождения, а затем выводит их на экран.
     */
    public void Foo()
    {
        Console.WriteLine("Введите ваше ФИО : ");
        var fio = Console.ReadLine();
        Console.WriteLine("Введите дату рождения(дд.мм.гггг)");
        var date = Console.ReadLine();
        Console.WriteLine($"Ваши данные : {fio}, дата рождения : {date}");
    }
    
    /*
     * Задание 2: Генератор стихов
       
       Описание:
       Напишите программу, которая берет случайные слова из заранее заданного набора и составляет "стих" из нескольких строк.
     */
    public string GetRandomVerses(List<string> words)
    {
        List<string> Verses = new List<string>();
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
            {
                Verses.Add(words[new Random().Next(0,words.Count)]);
            }
            Verses.Add("\n");
        }

        return String.Join(" ", Verses);
    }
    
    /*
     * Задание 3: Текстовый квест
       Описание:
       
       Напишите текстовую игру, где пользователь принимает решения, от которых зависит сюжет.
     */

    public void TestQuest()
    {
        Console.WriteLine("Вы находитесь в лесу. Перед вами два пути: налево и направо.  Введите ваш выбор\n (налево/направо):");
        var answer = Console.ReadLine();
        if(answer.Equals("направо"))
            Console.WriteLine("Вас сьел медведь");
        else if(answer.Equals("налево"))
            Console.WriteLine("Все в порядке");
        else
            Console.WriteLine("Такого выбора не было. Вас сьели два медведя");
    }
    
    /*
     * Задание 4: Симулятор магазина Покупатель-продавец (для любителей финтеха =D)
       
       Описание:
       Создайте программу, где пользователь играет роль покупателя, а программа выступает в роли продавца.
        В начале у пользователя есть определённая сумма денег. Программа предлагает товары на продажу с случайно сгенерированными ценами.
         Пользователь может покупать товары, пока у него есть деньги, или выйти из магазина.
     */
    
    public void StoreSimulator()
    {
        List<string> productList = new List<string>() { "Яблоко", "Хлеб", "Кукуруза", "Мясо", "Вода" };
        Dictionary<string, int> store = new Dictionary<string, int>();
        Random rand = new Random();
        int balance = 500;
        Console.WriteLine($"Добро пожаловать в магазин. У вас на счету {balance} монет\nТовары в наличии : ");
        
        for (var i = 0; i < 3; i++)
        {
            var randProduct = productList[rand.Next(productList.Count)];
            var randPrice = new Random().Next(15, 60);
            store[randProduct] = randPrice;
            Console.WriteLine($"{i+1}. {randProduct} - {randPrice} монет");
        }

        while (store.Count > 0)
        {
            Console.WriteLine("Введите название товара для покупки или \"0\" для выхода : ");
            var choice = Console.ReadLine();
            if (choice.Equals("0"))
                break;
            Console.WriteLine($"Вы купили {choice} за {store[choice]} монет. Ваш остаток {balance - store[choice]} монет");
            balance -= store[choice];
            store.Remove(choice);

            Console.WriteLine("Товары в наличии : ");
            foreach (var item in store)
            {
                Console.WriteLine($"{item.Key} - {item.Value} монет");
            }
            
        }
    }
    
    
}
#region task1

//int[] numbers = { 12, 24, 13, 11 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i]; 
//}

//Console.WriteLine(sum);

#endregion

#region task2

//int[] numbers = { 4, 12, 23, 45 ,6,19};
//int count = 0;

//foreach (var number in numbers)
//    if (number > 10) 
//    {
//    count++;
//}
//Console.WriteLine(count);
#endregion

#region task3

// int[] numbers = { 4, 12, 23, 45 ,6,19};
//int sum = 0;
//int count=0;

//foreach(int number in numbers)
//{
//    sum += number;
//    count++;
//        }


//Console.WriteLine(sum/count);


#endregion

#region task4

 string[] months = { "yanvar", "fevral", "mart", "aprel", "may", "iyun", "iyul", "avqust", "sentyabr","oktyabr","noyabr","dekabr" };
string item = Console.ReadLine();
for (int i = 0; i < months.Length; i++)

{
    if (item == "aprel" || item == "may" || item == "mart")
    {
        Console.WriteLine("yaz ayidir");
        break;
    }
    else if (item == "yanvar" || item == "fevral" || item == "dekabr")
    {
        Console.WriteLine("qis ayidir");
        break;
    }

    else if (item == "iyun" || item == "iyul" || item == "avqust")
    {
        Console.WriteLine("yay ayidir");
        break;
    }
    else if (item == "sentyabr" || item == "oktyabr" || item == "noyabr")
    {
        Console.WriteLine("payiz ayidir");
        break;
    }
    else Console.WriteLine("sehf daxil etdiniz");
    break;
}


#endregion
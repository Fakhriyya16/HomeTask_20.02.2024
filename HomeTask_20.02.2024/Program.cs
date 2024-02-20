//Method yazirsiz, Method stringden ibaret array ve char qebul edir.
//Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.

int CountOfChars(string str, char s)
{
    int count = 0;
    char[] strArray = str.ToCharArray();
    foreach(char c in strArray)
    {
        if (c == s)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(CountOfChars("Hello", 'l'));





//Repetition from class

//string data = Console.ReadLine();

//int result = int.Parse(data);

//Console.WriteLine(result);



//Data: string data = Console.ReadLine();

//int responce;

//bool isConvert = int.TryParse(data, out responce);

//if (isConvert)
//{
//    Console.WriteLine("response is --" + responce);
//}
//else
//{
//    Console.WriteLine("Format is wrong");
//    goto Data;
//}






//string[] names = { "Holland", "Donovan", "Brayan", "Gibbs", "Carter", "Olsen" };

////string[] arr = new string[5];

////string[] arr1 = new string[2] {"Qwed", "QWedqs"};








//string[] names = { "Holland", "Donovan", "Brayan", "Gibbs", "Carter", "Olsen" };

//Console.WriteLine(names[names.Length-1]);

//Console.WriteLine(names[3]);

//for(int i  = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}




//int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9 } };

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[1,2]);


//int[,,] nums = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7,8 } } };

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[1,1,0]);






//string[] names = { "Holland", "Donovan", "Brayan", "Gibbs", "Carter", "Olsen" };

//Console.WriteLine(names.Contains("Holland"));

//var datas = names.Reverse().ToArray();

//Console.WriteLine(datas[datas.Length-1]);

//Array.Sort(names);

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}



//int[] nums = { 3, 5, 6, 7 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (int item in datas)
//{
//    Console.WriteLine(item);
//}






//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 5, 6 };

//Array.Resize(ref arr2, 5);

//arr1.CopyTo(arr2, 2);

//foreach (int i in arr2)
//{
//    Console.WriteLine(i);
//}






string[] names = { "Holland", "Donovan", "Brayan", "Donovan", "Carter", "Olsen" };

//var data = Array.Find(names, x => x == "Donovan");

//var data = Array.FindAll(names, x => x == "Donovan");

//var data = Array.FindIndex(names, x => x == "Brayan");

//var data = Array.FindLastIndex(names, x => x == "Donovan");

//var data = names.FirstOrDefault();

//var data = names.LastOrDefault(m=> m == "Donovan");

//var data = names.All(m => m == "Donovan");

//var data = names.Any(m => m == "Donovan");

//var data = Array.Exists(names, m => m == "Donovan");

//var data = names.Where(m => m == "Donovan").ToArray();

//foreach(var d in data)
//{
//    Console.WriteLine(d);
//}

//var datas = names.OrderByDescending(x => x);

//foreach (var data in datas)
//{
//    Console.WriteLine(data);
//}


//var datas = names.Any(m => m == "Donovan");

//foreach (var name in names)
//{
//    if(name == "Donovan")
//    {
//        Console.WriteLine(true);
//        break;
//    }
//}


//var datas = names.All(m => m == "Donovan");

//void CheckDatas(string[] names, string str)
//{
//    int count = 0;

//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == "Donovan")
//        {
//            count++;
//        }
//    }
//    if (names.Length == count)
//    {
//        Console.WriteLine(true);
//    }
//    else
//    {
//        Console.WriteLine(false);
//    }
//}
//CheckDatas(names, "Donovan");








//DateTime date = DateTime.Now;

//DateTime date = DateTime.Now.AddYears(5);

//Console.WriteLine(date);



//DateTime birthday = new DateTime(2002, 12, 16);

//Console.WriteLine(birthday);


//DateOnly date = new DateOnly(2002,12,16);

//Console.WriteLine(date);



//var date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

//Console.WriteLine(date);


//var date = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

//Console.WriteLine(date);


//var currentYear =  DateTime.Now.Year;

//DateTime birthday = new DateTime(2002, 12, 16);

//var birthdayYear = birthday.Year;

//Console.WriteLine(currentYear - birthdayYear);
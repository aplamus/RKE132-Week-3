Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kAsutaja arv on paaris või paaritu

int result = userNum % 2;
if (result != 0) //!= tähendab et ei ole 
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}

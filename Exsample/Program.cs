int countEven = 0;
int countOdd = 0;
Console.WriteLine( "Введите число" );
char[] nums = Console.ReadLine().ToCharArray();
for ( int i = 0; i < nums.Length; i++ )
{
    if ( int.Parse( nums[i].ToString() ) % 2 == 0 )
    {
        countEven++;
    }
    else
    {
        countOdd++;
    }
}

Console.WriteLine($"{countEven} четных  \n{countOdd} нечетных");
Console.ReadKey();
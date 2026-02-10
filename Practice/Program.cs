
// Console.WriteLine("Hello, World!");
// Console.ReadKey();

//  변수 선언
/*string message = "안녕하세요.";

Console.WriteLine(message);
Console.ReadKey();*/


// 정수형 타입
/* byte
 * □□□□□□□□ 2^8 = 256 
 * 
 * sbyte
 * ■□□□□□□□ 2^7 = 128
 */
/*byte age = 25;
sbyte temperature = -128;

Console.WriteLine("age : " + age);
Console.WriteLine("temperature : " + temperature);
Console.ReadKey();*/

// 부동소수점 타입 (2진수로 연산)
/*float f = 1.1f;
float f2 = 1.2f;

Console.WriteLine(f + f2);  // 예상값 = 2.3, 실제값 = ?

double d = 1.11;
double d2 = 1.21;
Console.WriteLine(d + d2);  // 예상값 = 2.32, 실제값 = ?*/

/*// 고정소수점 타입
decimal m = 1.11m;
decimal m2 = 1.21m;
Console.WriteLine(m + m2);
// 10000.12345

//Console.WriteLine(f);*/

/*// bool
bool isTrue = false;
//Console.WriteLine("isTrue: " + isTrue);

// char
char character = 'A';
char[] chars = { 'i', 's', 'T', 'r', 'u', 'e' };
string str = new string(chars);

Console.WriteLine(str + " : " + isTrue);

char upperA = '\u0041';  // 'A'
int upperAInt = (int)upperA;  // 65

Console.WriteLine(upperA);
Console.WriteLine(upperAInt);

int upperBInt = upperAInt + 1;
char upperB = (char)upperBInt;

Console.WriteLine(upperB);  // B
Console.WriteLine(upperBInt);  // 66*/

/*// 시작점
class Program
{
    static void Main()
    {
        Days days = Days.Sunday;
        Console.WriteLine(days);
        Console.ReadKey();
    }
}

*//*// 상수
const int SUNDAY = 0;
const int MONDAY = 1;
const int TUESDAY = 2;
const int WEDNESDAY = 3;
const int THURSDAY = 4;
const int FRIDAY = 5;
const int SATURDAY = 6;*//*

// 상수 -> Enum
enum Days
{
    Sunday = 13,
    Monday = 3,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
};

//Days days = Days.Sunday;

//Console.ReadKey();*/

// 명시적 선언 (Explicit Declaration)
/*
 * 장점: 변수의 타입이 명확하게 드러나므로 코드의 가독성이 높아짐
 * 단점: 모든 변수에 대해 타입을 명시해야 하므로 코드가 길어질 수 있음
 */
int number;
string text = "hi";
double pi = 3.14;

// 암시적 선언 (Implicit Declaration)
/*
 * 장점: 변수의 타입을 명시하지 않아도 되므로 코드가 간결해집니다.
 * 단점: 타입을 명확히 알기 어려워져 타입 관련 오류를 발견하기 어려울 수 있습니다.
 */
var number2 = 10;
var text2 ="hi";
var pi2 = 3.14;


Console.ReadKey();